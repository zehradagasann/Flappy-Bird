using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluppyBird
{
    public partial class Form1 : Form
    {
        
        int boruHizi = 8;
        int skor = 0;
        int yercekimi = 1;
        int kusHizi = 0;
        Random rastgele = new Random();
        int boruBoslugu = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            kusHizi += yercekimi;
            flappyBird.Top += kusHizi;

            boruAlt.Left -= boruHizi;
            boruUst.Left -= boruHizi;

            skorLabel.Text = "Skor: " + skor;

            if (boruAlt.Left < -150)
            {
                boruAlt.Left = 700;
                boruUst.Left = 700;
                skor++;

                boruUst.Height = rastgele.Next(50, 300);
                boruUst.Top = 0;
                boruAlt.Top = boruUst.Height + boruBoslugu;
                boruAlt.Height = zemin.Top - boruAlt.Top;
            }

            if (flappyBird.Bounds.IntersectsWith(boruAlt.Bounds) ||
                flappyBird.Bounds.IntersectsWith(boruUst.Bounds) ||
                flappyBird.Bounds.IntersectsWith(zemin.Bounds) ||
                flappyBird.Top < -10) 
            {
                oyunuBitir();
            }

            if (skor > 5)
            {
                boruHizi = 12;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                kusHizi = -12;
            }
            else if (e.KeyCode == Keys.R && !gameTimer.Enabled)
            {
                oyunuYenidenBaslat();
            }
        }
        private void oyunuBitir()
        {
            gameTimer.Stop();
            skorLabel.Text += " - Oyun Bitti! Yeniden başlamak için 'R' tuşuna basın.";
        }
        private void oyunuYenidenBaslat()
        {
            flappyBird.Location = new Point(90, 250);
            skor = 0;
            boruHizi = 8;
            kusHizi = 0;
            skorLabel.Text = "Skor: 0";

            boruAlt.Left = 600;
            boruUst.Left = 600;

            boruUst.Height = rastgele.Next(50, 300);
            boruUst.Top = 0;

            boruAlt.Top = boruUst.Height + boruBoslugu;
            boruAlt.Height = zemin.Top - boruAlt.Top;

            gameTimer.Start();
        }
    }
}
