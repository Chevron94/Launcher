namespace Launcher
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.P_PROGRESS = new System.Windows.Forms.ProgressBar();
            this.B_START = new System.Windows.Forms.Button();
            this.B_UPDATE = new System.Windows.Forms.Button();
            this.B_CANCEL = new System.Windows.Forms.Button();
            this.L_PROGRESS = new System.Windows.Forms.Label();
            this.L_USERVERSION = new System.Windows.Forms.Label();
            this.L_SERVERVERSION = new System.Windows.Forms.Label();
            this.L_DOWNLOADED = new System.Windows.Forms.Label();
            this.L_FULL = new System.Windows.Forms.Label();
            this.T_USERVERSION = new System.Windows.Forms.TextBox();
            this.T_SERVERVERSION = new System.Windows.Forms.TextBox();
            this.T_DOWNLOADED = new System.Windows.Forms.TextBox();
            this.T_FULL = new System.Windows.Forms.TextBox();
            this.T_SPEED = new System.Windows.Forms.TextBox();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // P_PROGRESS
            // 
            this.P_PROGRESS.Location = new System.Drawing.Point(154, 357);
            this.P_PROGRESS.Name = "P_PROGRESS";
            this.P_PROGRESS.Size = new System.Drawing.Size(327, 23);
            this.P_PROGRESS.Step = 1;
            this.P_PROGRESS.TabIndex = 0;
            this.P_PROGRESS.Visible = false;
            // 
            // B_START
            // 
            this.B_START.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_START.BackgroundImage")));
            this.B_START.Location = new System.Drawing.Point(563, 82);
            this.B_START.Name = "B_START";
            this.B_START.Size = new System.Drawing.Size(112, 37);
            this.B_START.TabIndex = 1;
            this.B_START.UseVisualStyleBackColor = true;
            this.B_START.Click += new System.EventHandler(this.Start_Click);
            // 
            // B_UPDATE
            // 
            this.B_UPDATE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_UPDATE.BackgroundImage")));
            this.B_UPDATE.Location = new System.Drawing.Point(563, 29);
            this.B_UPDATE.Name = "B_UPDATE";
            this.B_UPDATE.Size = new System.Drawing.Size(112, 38);
            this.B_UPDATE.TabIndex = 2;
            this.B_UPDATE.UseVisualStyleBackColor = true;
            this.B_UPDATE.Click += new System.EventHandler(this.Update_Click);
            // 
            // B_CANCEL
            // 
            this.B_CANCEL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_CANCEL.BackgroundImage")));
            this.B_CANCEL.Location = new System.Drawing.Point(563, 29);
            this.B_CANCEL.Name = "B_CANCEL";
            this.B_CANCEL.Size = new System.Drawing.Size(112, 38);
            this.B_CANCEL.TabIndex = 3;
            this.B_CANCEL.UseVisualStyleBackColor = true;
            this.B_CANCEL.Visible = false;
            this.B_CANCEL.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // L_PROGRESS
            // 
            this.L_PROGRESS.AutoSize = true;
            this.L_PROGRESS.BackColor = System.Drawing.Color.Transparent;
            this.L_PROGRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_PROGRESS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.L_PROGRESS.Location = new System.Drawing.Point(23, 357);
            this.L_PROGRESS.Name = "L_PROGRESS";
            this.L_PROGRESS.Size = new System.Drawing.Size(88, 20);
            this.L_PROGRESS.TabIndex = 4;
            this.L_PROGRESS.Text = "Прогресс";
            this.L_PROGRESS.Visible = false;
            // 
            // L_USERVERSION
            // 
            this.L_USERVERSION.AutoSize = true;
            this.L_USERVERSION.BackColor = System.Drawing.Color.Transparent;
            this.L_USERVERSION.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_USERVERSION.ForeColor = System.Drawing.SystemColors.Highlight;
            this.L_USERVERSION.Location = new System.Drawing.Point(23, 283);
            this.L_USERVERSION.Name = "L_USERVERSION";
            this.L_USERVERSION.Size = new System.Drawing.Size(125, 20);
            this.L_USERVERSION.TabIndex = 5;
            this.L_USERVERSION.Text = "Установлено:";
            // 
            // L_SERVERVERSION
            // 
            this.L_SERVERVERSION.AutoSize = true;
            this.L_SERVERVERSION.BackColor = System.Drawing.Color.Transparent;
            this.L_SERVERVERSION.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_SERVERVERSION.ForeColor = System.Drawing.SystemColors.Highlight;
            this.L_SERVERVERSION.Location = new System.Drawing.Point(23, 316);
            this.L_SERVERVERSION.Name = "L_SERVERVERSION";
            this.L_SERVERVERSION.Size = new System.Drawing.Size(94, 20);
            this.L_SERVERVERSION.TabIndex = 6;
            this.L_SERVERVERSION.Text = "Доступно:";
            // 
            // L_DOWNLOADED
            // 
            this.L_DOWNLOADED.AutoSize = true;
            this.L_DOWNLOADED.BackColor = System.Drawing.Color.Transparent;
            this.L_DOWNLOADED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_DOWNLOADED.ForeColor = System.Drawing.SystemColors.Highlight;
            this.L_DOWNLOADED.Location = new System.Drawing.Point(271, 283);
            this.L_DOWNLOADED.Name = "L_DOWNLOADED";
            this.L_DOWNLOADED.Size = new System.Drawing.Size(104, 20);
            this.L_DOWNLOADED.TabIndex = 7;
            this.L_DOWNLOADED.Text = "Загружено:";
            this.L_DOWNLOADED.Visible = false;
            // 
            // L_FULL
            // 
            this.L_FULL.AutoSize = true;
            this.L_FULL.BackColor = System.Drawing.Color.Transparent;
            this.L_FULL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_FULL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.L_FULL.Location = new System.Drawing.Point(271, 316);
            this.L_FULL.Name = "L_FULL";
            this.L_FULL.Size = new System.Drawing.Size(63, 20);
            this.L_FULL.TabIndex = 8;
            this.L_FULL.Text = "Всего:";
            this.L_FULL.Visible = false;
            // 
            // T_USERVERSION
            // 
            this.T_USERVERSION.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_USERVERSION.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.T_USERVERSION.Location = new System.Drawing.Point(154, 285);
            this.T_USERVERSION.Name = "T_USERVERSION";
            this.T_USERVERSION.ReadOnly = true;
            this.T_USERVERSION.Size = new System.Drawing.Size(100, 22);
            this.T_USERVERSION.TabIndex = 9;
            this.T_USERVERSION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_SERVERVERSION
            // 
            this.T_SERVERVERSION.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_SERVERVERSION.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.T_SERVERVERSION.Location = new System.Drawing.Point(154, 318);
            this.T_SERVERVERSION.Name = "T_SERVERVERSION";
            this.T_SERVERVERSION.ReadOnly = true;
            this.T_SERVERVERSION.Size = new System.Drawing.Size(100, 22);
            this.T_SERVERVERSION.TabIndex = 10;
            this.T_SERVERVERSION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_DOWNLOADED
            // 
            this.T_DOWNLOADED.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_DOWNLOADED.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.T_DOWNLOADED.Location = new System.Drawing.Point(381, 285);
            this.T_DOWNLOADED.Name = "T_DOWNLOADED";
            this.T_DOWNLOADED.ReadOnly = true;
            this.T_DOWNLOADED.Size = new System.Drawing.Size(100, 22);
            this.T_DOWNLOADED.TabIndex = 11;
            this.T_DOWNLOADED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_DOWNLOADED.Visible = false;
            // 
            // T_FULL
            // 
            this.T_FULL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_FULL.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.T_FULL.Location = new System.Drawing.Point(381, 316);
            this.T_FULL.Name = "T_FULL";
            this.T_FULL.ReadOnly = true;
            this.T_FULL.Size = new System.Drawing.Size(100, 22);
            this.T_FULL.TabIndex = 12;
            this.T_FULL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_FULL.Visible = false;
            // 
            // T_SPEED
            // 
            this.T_SPEED.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_SPEED.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.T_SPEED.Location = new System.Drawing.Point(575, 360);
            this.T_SPEED.Name = "T_SPEED";
            this.T_SPEED.ReadOnly = true;
            this.T_SPEED.Size = new System.Drawing.Size(100, 22);
            this.T_SPEED.TabIndex = 13;
            this.T_SPEED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_SPEED.Visible = false;
            // 
            // TIMER
            // 
            this.TIMER.Interval = 1000;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(687, 392);
            this.Controls.Add(this.T_SPEED);
            this.Controls.Add(this.T_FULL);
            this.Controls.Add(this.T_DOWNLOADED);
            this.Controls.Add(this.T_SERVERVERSION);
            this.Controls.Add(this.T_USERVERSION);
            this.Controls.Add(this.L_FULL);
            this.Controls.Add(this.L_DOWNLOADED);
            this.Controls.Add(this.L_SERVERVERSION);
            this.Controls.Add(this.L_USERVERSION);
            this.Controls.Add(this.L_PROGRESS);
            this.Controls.Add(this.B_CANCEL);
            this.Controls.Add(this.B_UPDATE);
            this.Controls.Add(this.B_START);
            this.Controls.Add(this.P_PROGRESS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar P_PROGRESS;
        private System.Windows.Forms.Button B_START;
        private System.Windows.Forms.Button B_UPDATE;
        private System.Windows.Forms.Button B_CANCEL;
        private System.Windows.Forms.Label L_PROGRESS;
        private System.Windows.Forms.Label L_USERVERSION;
        private System.Windows.Forms.Label L_SERVERVERSION;
        private System.Windows.Forms.Label L_DOWNLOADED;
        private System.Windows.Forms.Label L_FULL;
        private System.Windows.Forms.TextBox T_USERVERSION;
        private System.Windows.Forms.TextBox T_SERVERVERSION;
        private System.Windows.Forms.TextBox T_DOWNLOADED;
        private System.Windows.Forms.TextBox T_FULL;
        private System.Windows.Forms.TextBox T_SPEED;
        private System.Windows.Forms.Timer TIMER;
    }
}

