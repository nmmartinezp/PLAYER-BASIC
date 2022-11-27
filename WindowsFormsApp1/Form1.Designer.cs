
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.NameMusic = new System.Windows.Forms.ListBox();
            this.ListMusic = new System.Windows.Forms.ListBox();
            this.btnAddDic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(12, 12);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(394, 266);
            this.Player.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(169, 298);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnpause
            // 
            this.btnpause.Location = new System.Drawing.Point(250, 298);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(75, 23);
            this.btnpause.TabIndex = 2;
            this.btnpause.Text = "Pause";
            this.btnpause.UseVisualStyleBackColor = true;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(331, 298);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // NameMusic
            // 
            this.NameMusic.FormattingEnabled = true;
            this.NameMusic.Location = new System.Drawing.Point(12, 328);
            this.NameMusic.Name = "NameMusic";
            this.NameMusic.Size = new System.Drawing.Size(394, 17);
            this.NameMusic.TabIndex = 5;
            // 
            // ListMusic
            // 
            this.ListMusic.FormattingEnabled = true;
            this.ListMusic.Location = new System.Drawing.Point(413, 13);
            this.ListMusic.Name = "ListMusic";
            this.ListMusic.Size = new System.Drawing.Size(272, 329);
            this.ListMusic.TabIndex = 6;
            // 
            // btnAddDic
            // 
            this.btnAddDic.Location = new System.Drawing.Point(413, 348);
            this.btnAddDic.Name = "btnAddDic";
            this.btnAddDic.Size = new System.Drawing.Size(95, 23);
            this.btnAddDic.TabIndex = 7;
            this.btnAddDic.Text = "Agregar carpeta";
            this.btnAddDic.UseVisualStyleBackColor = true;
            this.btnAddDic.Click += new System.EventHandler(this.btnAddDic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.btnAddDic);
            this.Controls.Add(this.ListMusic);
            this.Controls.Add(this.NameMusic);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox NameMusic;
        private System.Windows.Forms.ListBox ListMusic;
        private System.Windows.Forms.Button btnAddDic;
    }
}

