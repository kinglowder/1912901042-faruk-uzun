
namespace vizeodevi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_derece = new System.Windows.Forms.Label();
            this.label_durum = new System.Windows.Forms.Label();
            this.label_yer = new System.Windows.Forms.Label();
            this.picture_bulutlu = new System.Windows.Forms.PictureBox();
            this.picture_gunesli = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_bulutlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gunesli)).BeginInit();
            this.SuspendLayout();
            // 
            // label_derece
            // 
            this.label_derece.AutoSize = true;
            this.label_derece.Location = new System.Drawing.Point(182, 234);
            this.label_derece.Name = "label_derece";
            this.label_derece.Size = new System.Drawing.Size(38, 15);
            this.label_derece.TabIndex = 0;
            this.label_derece.Text = "label1";
            // 
            // label_durum
            // 
            this.label_durum.AutoSize = true;
            this.label_durum.Location = new System.Drawing.Point(182, 290);
            this.label_durum.Name = "label_durum";
            this.label_durum.Size = new System.Drawing.Size(38, 15);
            this.label_durum.TabIndex = 1;
            this.label_durum.Text = "label2";
            this.label_durum.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_yer
            // 
            this.label_yer.AutoSize = true;
            this.label_yer.Location = new System.Drawing.Point(182, 347);
            this.label_yer.Name = "label_yer";
            this.label_yer.Size = new System.Drawing.Size(38, 15);
            this.label_yer.TabIndex = 2;
            this.label_yer.Text = "label3";
            // 
            // picture_bulutlu
            // 
            this.picture_bulutlu.BackColor = System.Drawing.Color.Transparent;
            this.picture_bulutlu.Image = global::vizeodevi.Properties.Resources._700422_icon_1_cloud_512;
            this.picture_bulutlu.Location = new System.Drawing.Point(513, 24);
            this.picture_bulutlu.Name = "picture_bulutlu";
            this.picture_bulutlu.Size = new System.Drawing.Size(94, 68);
            this.picture_bulutlu.TabIndex = 3;
            this.picture_bulutlu.TabStop = false;
            // 
            // picture_gunesli
            // 
            this.picture_gunesli.BackColor = System.Drawing.Color.Transparent;
            this.picture_gunesli.Image = global::vizeodevi.Properties.Resources.Sunny_icon;
            this.picture_gunesli.Location = new System.Drawing.Point(647, 24);
            this.picture_gunesli.Name = "picture_gunesli";
            this.picture_gunesli.Size = new System.Drawing.Size(88, 89);
            this.picture_gunesli.TabIndex = 4;
            this.picture_gunesli.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Şehir";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Sıcaklık";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 282);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Hava durumu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vizeodevi.Properties.Resources.aydinda_sokaga_cikma_yasa_626_2_41;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picture_gunesli);
            this.Controls.Add(this.picture_bulutlu);
            this.Controls.Add(this.label_yer);
            this.Controls.Add(this.label_durum);
            this.Controls.Add(this.label_derece);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_bulutlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gunesli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_derece;
        private System.Windows.Forms.Label label_durum;
        private System.Windows.Forms.Label label_yer;
        private System.Windows.Forms.PictureBox picture_bulutlu;
        private System.Windows.Forms.PictureBox picture_gunesli;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

