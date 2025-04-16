using System;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using TagLib;
using System.Drawing;
using System.Collections.Generic;

namespace LecteurMP3_UI_Stylé
{
    public partial class Form1 : Form
    {
        private WaveOutEvent waveOut;
        private AudioFileReader audioFile;
        private List<string> fichiersMp3 = new List<string>();
        private Timer timer; // Déclaration de la minuterie pour la ProgressBar

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoisirDossier_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    fichiersMp3.Clear();
                    listMusiques.Items.Clear();
                    var fichiers = Directory.GetFiles(fbd.SelectedPath, "*.mp3");
                    foreach (var fichier in fichiers)
                    {
                        fichiersMp3.Add(fichier);
                        listMusiques.Items.Add(Path.GetFileNameWithoutExtension(fichier));
                    }
                }
            }
        }

        private void listMusiques_DoubleClick(object sender, EventArgs e)
        {
            if (listMusiques.SelectedIndex >= 0)
            {
                string fichier = fichiersMp3[listMusiques.SelectedIndex];
                lblTitre.Text = "🎵 En lecture : " + Path.GetFileNameWithoutExtension(fichier);
                JouerMusique(fichier);
            }
        }

        private void JouerMusique(string fichier)
        {
            waveOut?.Stop();
            waveOut?.Dispose();
            audioFile?.Dispose();

            audioFile = new AudioFileReader(fichier);
            waveOut = new WaveOutEvent();
            waveOut.Init(audioFile);
            waveOut.Play();

            // Mise en place du timer pour mettre à jour la ProgressBar
            timer = new Timer();
            timer.Interval = 1000; // Mise à jour toutes les secondes
            timer.Tick += Timer_Tick;
            timer.Start();

            AfficherCover(fichier);

            // Affichage du temps total de la musique
            lblTempsTotal.Text = audioFile.TotalTime.ToString(@"mm\:ss");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && waveOut != null)
            {
                // Calcul du temps écoulé
                double progression = audioFile.CurrentTime.TotalSeconds / audioFile.TotalTime.TotalSeconds * 100;
                progressBar.Value = (int)progression;

                // Mise à jour du temps écoulé
                lblTempsEcoule.Text = audioFile.CurrentTime.ToString(@"mm\:ss");

                // Mise à jour du temps restant
                TimeSpan tempsRestant = audioFile.TotalTime - audioFile.CurrentTime;
                lblTempsRestant.Text = tempsRestant.ToString(@"mm\:ss");

                // Si la musique est terminée, arrêter le timer
                if (audioFile.CurrentTime >= audioFile.TotalTime)
                {
                    timer.Stop();
                }
            }
        }

        private void AfficherCover(string fichier)
        {
            try
            {
                var tfile = TagLib.File.Create(fichier);
                if (tfile.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(tfile.Tag.Pictures[0].Data.Data);
                    using (MemoryStream ms = new MemoryStream(bin))
                    {
                        pictureCover.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureCover.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement de la couverture : {ex.Message}");
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            waveOut?.Play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            waveOut?.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            waveOut?.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            waveOut?.Dispose();
            audioFile?.Dispose();
        }
        private bool isFullscreen = false; // Déclaration de la variable isFullscreen
        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            if (isFullscreen)
            {
                // Revenir en mode fenêtre
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;  // Désactiver le "toujours au-dessus"
                this.Size = new Size(800, 556); // Taille d'origine de la fenêtre
                this.CenterToScreen();  // Centrer la fenêtre à l'écran
            }
            else
            {
                // Passer en mode plein écran
                this.FormBorderStyle = FormBorderStyle.None;  // Supprimer les bordures de la fenêtre
                this.WindowState = FormWindowState.Maximized;  // Maximiser la fenêtre
                this.TopMost = true;  // Rendre la fenêtre toujours au-dessus des autres fenêtres
            }
            isFullscreen = !isFullscreen;  // Alterner l'état de l'écran
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void lblTempsRestant_Click(object sender, EventArgs e)
        {

        }
    }

}
