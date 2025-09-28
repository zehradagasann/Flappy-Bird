namespace FluppyBird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skorLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.boruAlt = new System.Windows.Forms.PictureBox();
            this.boruUst = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // skorLabel
            // 
            this.skorLabel.AutoSize = true;
            this.skorLabel.BackColor = System.Drawing.Color.Transparent;
            this.skorLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorLabel.Location = new System.Drawing.Point(10, 10);
            this.skorLabel.Name = "skorLabel";
            this.skorLabel.Size = new System.Drawing.Size(125, 37);
            this.skorLabel.TabIndex = 4;
            this.skorLabel.Text = "Skor: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // boruAlt
            // 
            this.boruAlt.BackColor = System.Drawing.Color.Green;
            this.boruAlt.Location = new System.Drawing.Point(450, 450);
            this.boruAlt.Name = "boruAlt";
            this.boruAlt.Size = new System.Drawing.Size(80, 250);
            this.boruAlt.TabIndex = 3;
            this.boruAlt.TabStop = false;
            // 
            // boruUst
            // 
            this.boruUst.BackColor = System.Drawing.Color.Green;
            this.boruUst.Location = new System.Drawing.Point(450, 0);
            this.boruUst.Name = "boruUst";
            this.boruUst.Size = new System.Drawing.Size(80, 250);
            this.boruUst.TabIndex = 2;
            this.boruUst.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.BackColor = System.Drawing.Color.SandyBrown;
            this.zemin.Location = new System.Drawing.Point(0, 600);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(600, 100);
            this.zemin.TabIndex = 1;
            this.zemin.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Cursor = System.Windows.Forms.Cursors.No;
            this.flappyBird.Image = global::FluppyBird.Properties.Resources.png_transparent_flappy_bird_flappy_color_fly_bird_game_bantar_adventure_flies_game_animals_head1;
            this.flappyBird.Location = new System.Drawing.Point(90, 250);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(50, 40);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(578, 644);
            this.Controls.Add(this.skorLabel);
            this.Controls.Add(this.boruAlt);
            this.Controls.Add(this.boruUst);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.flappyBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Flappy Bird Oyunu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.PictureBox boruUst;
        private System.Windows.Forms.PictureBox boruAlt;
        private System.Windows.Forms.Label skorLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

