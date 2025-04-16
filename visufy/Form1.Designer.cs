using System.Drawing;
using System.Windows.Forms;

namespace LecteurMP3_UI_Stylé
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnChoisirDossier;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox listMusiques;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pictureCover;
        private System.Windows.Forms.ProgressBar progressBar; // Déclaration de la ProgressBar
        private System.Windows.Forms.Label lblTempsEcoule; // Label pour afficher le temps écoulé
        private System.Windows.Forms.Label lblTempsTotal; // Label pour afficher le temps total de la musique
        private System.Windows.Forms.Button btnFullscreen;
        

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnChoisirDossier = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.listMusiques = new System.Windows.Forms.ListBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pictureCover = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblTempsEcoule = new System.Windows.Forms.Label();
            this.lblTempsTotal = new System.Windows.Forms.Label();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.lblTempsRestant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisirDossier
            // 
            this.btnChoisirDossier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnChoisirDossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoisirDossier.ForeColor = System.Drawing.Color.White;
            this.btnChoisirDossier.Location = new System.Drawing.Point(30, 55);
            this.btnChoisirDossier.Name = "btnChoisirDossier";
            this.btnChoisirDossier.Size = new System.Drawing.Size(150, 35);
            this.btnChoisirDossier.TabIndex = 1;
            this.btnChoisirDossier.Text = "📁 Choisir dossier";
            this.btnChoisirDossier.UseVisualStyleBackColor = false;
            this.btnChoisirDossier.Click += new System.EventHandler(this.btnChoisirDossier_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(30, 340);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 35);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "▶️ Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(140, 340);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 35);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "⏸ Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(250, 340);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 35);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "⏹ Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // listMusiques
            // 
            this.listMusiques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listMusiques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMusiques.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listMusiques.ItemHeight = 17;
            this.listMusiques.Location = new System.Drawing.Point(30, 100);
            this.listMusiques.Name = "listMusiques";
            this.listMusiques.Size = new System.Drawing.Size(352, 206);
            this.listMusiques.TabIndex = 2;
            this.listMusiques.DoubleClick += new System.EventHandler(this.listMusiques_DoubleClick);
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitre.Location = new System.Drawing.Point(30, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(440, 25);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "🎵 En lecture : (aucune)";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // pictureCover
            // 
            this.pictureCover.BackColor = System.Drawing.Color.Black;
            this.pictureCover.Location = new System.Drawing.Point(482, 98);
            this.pictureCover.Name = "pictureCover";
            this.pictureCover.Size = new System.Drawing.Size(293, 277);
            this.pictureCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCover.TabIndex = 6;
            this.pictureCover.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Gray;
            this.progressBar.ForeColor = System.Drawing.Color.Green;
            this.progressBar.Location = new System.Drawing.Point(30, 392);
            this.progressBar.MarqueeAnimationSpeed = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(440, 10);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // lblTempsEcoule
            // 
            this.lblTempsEcoule.Location = new System.Drawing.Point(30, 405);
            this.lblTempsEcoule.Name = "lblTempsEcoule";
            this.lblTempsEcoule.Size = new System.Drawing.Size(100, 15);
            this.lblTempsEcoule.TabIndex = 8;
            // 
            // lblTempsTotal
            // 
            this.lblTempsTotal.Location = new System.Drawing.Point(397, 369);
            this.lblTempsTotal.Name = "lblTempsTotal";
            this.lblTempsTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTempsTotal.TabIndex = 10;
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Location = new System.Drawing.Point(700, 20);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(75, 30);
            this.btnFullscreen.TabIndex = 0;
            this.btnFullscreen.Text = "Fullscreen";
            this.btnFullscreen.UseVisualStyleBackColor = true;
            this.btnFullscreen.Click += new System.EventHandler(this.btnFullscreen_Click);
            // 
            // lblTempsRestant
            // 
            this.lblTempsRestant.Location = new System.Drawing.Point(397, 405);
            this.lblTempsRestant.Name = "lblTempsRestant";
            this.lblTempsRestant.Size = new System.Drawing.Size(100, 15);
            this.lblTempsRestant.TabIndex = 9;
            this.lblTempsRestant.Click += new System.EventHandler(this.lblTempsRestant_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnChoisirDossier);
            this.Controls.Add(this.listMusiques);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.pictureCover);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblTempsEcoule);
            this.Controls.Add(this.lblTempsRestant);
            this.Controls.Add(this.lblTempsTotal);
            this.Controls.Add(this.btnFullscreen);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "Form1";
            this.Text = "Lecteur MP3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).EndInit();
            this.ResumeLayout(false);

        }

        private Label lblTempsRestant;
    }
}
