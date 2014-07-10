using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using Ionic.Zip;

namespace Launcher
{
    public partial class Launcher : Form
    {
        WebClient CLIENT; // Класс для загрузки файлов
        const string SERVER_VERSION_INTERNET_URL = "http://9groupmod.100ms.ru/updates/ServerVersion.txt"; 
        
        const string USER_VERSION_FILE = @"mods\Group9\Data\Version.txt";
        const string SERVER_VERSION_FILE = @"mods\Group9\Updates\ServerVersion.txt";
        const string EXTRACTING_PATH = @"mods\Group9\Data";

        string USER_VERSION; // Версия пользователя
        string SERVER_VERSION;  // Версия сервера

        string UPDATE_FILE_PATH=""; // Куда качается обновление

        int LAST_SIZE = 0;  // размер файла при предыдущем замере
        int CUR_SIZE = 0;   // размер файла при текущем замере

        bool Cancel = false;    // отмена загрузки

        public Launcher()
        {
            InitializeComponent();
            CLIENT = new WebClient();
            CLIENT.DownloadProgressChanged +=
            new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);    // Меняем событие загрузки для отображения прогресса
            if (!System.IO.Directory.Exists(@"mods\Group9\Updates"))
                System.IO.Directory.CreateDirectory(@"mods\Group9\Updates");
            if (!System.IO.Directory.Exists(@"mods\Group9\Data"))
                System.IO.Directory.CreateDirectory(@"mods\Group9\Data");

        }
        public void SwitchText(bool value) // Видим - не видим)
        {
            TIMER.Enabled = value;
            //
            L_DOWNLOADED.Visible = value;
            T_DOWNLOADED.Visible = value;
            //
            L_FULL.Visible = value;
            T_FULL.Visible = value;
            //
            L_PROGRESS.Visible = value;
            P_PROGRESS.Visible = value;
            //
            T_SPEED.Visible = value;
            B_CANCEL.Visible = value;
            B_UPDATE.Visible = !value;
            B_START.Visible = !value;
            Application.DoEvents();
            //
        }

        private void Start_Click(object sender, EventArgs e) // Запуск игры
        {
            if (System.IO.File.Exists("swfoc.exe"))
            {
                System.Diagnostics.Process GAME = new System.Diagnostics.Process();
                GAME.StartInfo.FileName = "swfoc.exe";
                GAME.StartInfo.Arguments = "MODPATH=" + @"Mods\Group9";
                GAME.Start();
            }
            else MessageBox.Show("Файл swfoc.exe не найден", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void get_user_version()  // получить версию юзера
        {
            if (!System.IO.File.Exists(USER_VERSION_FILE))
            {
                T_USERVERSION.Text = "0.0.0";
                USER_VERSION = "0.0.0";
            }
            else
            {
                System.IO.StreamReader UserVersionReader = new System.IO.StreamReader(USER_VERSION_FILE);
                USER_VERSION = (UserVersionReader.ReadLine()).Trim();
                T_USERVERSION.Text = USER_VERSION;
                UserVersionReader.Close();
            }
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            get_user_version();
        }

        private void Extracting_Process(object sender, ExtractProgressEventArgs e) // отображение прогресса распаковки
        {
            if (e.EntriesExtracted > 0)     // Костыль №1
            {
                P_PROGRESS.Value = e.EntriesExtracted;
            }
            Application.DoEvents();
        }

        private void Extract(string Path_To_Archive, string Extract_Path)   // Сама функция извлечения
        {
            ZipFile zf = new ZipFile(UPDATE_FILE_PATH);
            zf.ExtractProgress += Extracting_Process;
            P_PROGRESS.Maximum = zf.Count;
            zf.ExtractAll(EXTRACTING_PATH,ExtractExistingFileAction.OverwriteSilently);
        }

        public void client_DownloadProgressChanged(object sender,
       DownloadProgressChangedEventArgs e) // отображение загрузки
        {
            P_PROGRESS.Value = e.ProgressPercentage;
            T_DOWNLOADED.Text = (new System.IO.FileInfo(UPDATE_FILE_PATH).Length/1024/1024).ToString()+","+(new System.IO.FileInfo(UPDATE_FILE_PATH).Length/1024%1024).ToString()+ " МБ";
            Application.DoEvents();
        }

        public bool GetDownloadInfo(ref string DownloadUrl, ref int UnpackSize) // получаем инфу из скачанного файла серверной версии
        {
            System.IO.StreamReader ServerReader = new System.IO.StreamReader(SERVER_VERSION_FILE);
            SERVER_VERSION = (ServerReader.ReadLine()).Trim(); // Версия
            T_SERVERVERSION.Text = SERVER_VERSION;
            if (SERVER_VERSION.Equals(USER_VERSION))    // проверка версии
            {
                ServerReader.Close();
                return false;
            }
            // Пропуск пустой строки
            ServerReader.ReadLine();
            // Пропуск версии (необходима в будущем)
            ServerReader.ReadLine();
            //
            DownloadUrl = (ServerReader.ReadLine()).Trim(); // ссылка на обновление
            UnpackSize = Convert.ToInt32((ServerReader.ReadLine()).Trim()); // размер в распакованном виде
            ServerReader.Close();
            return true;
        }

        private void DownLoadFile(string url, string path)  // загрузка файла с интернета
        {
            CLIENT.DownloadFileAsync(new Uri(url), path);
        }

        private void Cancel_Click(object sender, EventArgs e)   // отмена
        {
            CLIENT.CancelAsync();
            Cancel = true;
        }
        private int GetFileSize(string URL) // запрос размера файла
        {
            WebRequest rq = WebRequest.Create(URL);
            rq.Method = "HEAD";
            HttpWebResponse resp = (HttpWebResponse)rq.GetResponse();
            return Convert.ToInt32(resp.ContentLength);
        }
        private void Update_Click(object sender, EventArgs e)   // обновление
        {
            string DOWNLOAD_URL=""; // ссылка для скачивания
            int Unpack_Size = 0;    // распакованный размер 
            CUR_SIZE = 0;   // обнулить замеры размера файла
            LAST_SIZE = 0;
            Cancel = false; // загрузка не отменена
            UPDATE_FILE_PATH = SERVER_VERSION_FILE; // Куда и как сохранить файл

            DownLoadFile(SERVER_VERSION_INTERNET_URL, SERVER_VERSION_FILE); // скачивание файла серверной версии
            
            while (CLIENT.IsBusy) // Ждем пока скачается)
            { Application.DoEvents(); };

            P_PROGRESS.Value = 0; // сбрасываем прогресс бар
            if(GetDownloadInfo(ref DOWNLOAD_URL, ref Unpack_Size))  // если нужно что-то качать
            {
            SwitchText(true);   // отображаем доп. окошки
            //
            int length = GetFileSize(DOWNLOAD_URL); // размер скачиваемого файла
             //
            T_FULL.Text = (length / 1024 / 1024).ToString() + "," + (length / 1024 % 1024).ToString()+" МБ";
            T_DOWNLOADED.Text = "0";
            UPDATE_FILE_PATH = @"mods\Group9\Updates\0.0.1.zip"; // Куда и как сохранить файл

            DownLoadFile(DOWNLOAD_URL, UPDATE_FILE_PATH); // скачиваем архив

            while (CLIENT.IsBusy)   // см. выше
            { Application.DoEvents(); }

            if (Cancel) // Если отмена
            {
                TIMER.Enabled = false; // выключить таймер
                System.IO.File.Delete(UPDATE_FILE_PATH);    // удалить недокачанный файл
                MessageBox.Show("Обновление прервано!", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SwitchText(false); // скрыть окошки
                return;
            }
            TIMER.Enabled = false;  // выкл. таймер
            P_PROGRESS.Value = 0; // сброс прогресса
            Extract(UPDATE_FILE_PATH, EXTRACTING_PATH); // распаковка
            get_user_version(); // обновление версии пользователя
            MessageBox.Show("Обновление завершено!", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SwitchText(false); // спрятать окошки
            }
            else MessageBox.Show("Обновление не требуется!", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Profit=)
        }

        private void TIMER_Tick(object sender, EventArgs e) // определение скорости загрузки
        {
            CUR_SIZE = Convert.ToInt32(new System.IO.FileInfo(UPDATE_FILE_PATH).Length);
            T_SPEED.Text = ((CUR_SIZE - LAST_SIZE)/ 1024).ToString() + " КБ/С";
            LAST_SIZE = CUR_SIZE;
            Application.DoEvents();
        }
    }
}
