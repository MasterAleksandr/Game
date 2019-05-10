using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl = new System.Windows.Forms.PictureBox();
            this.fireball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireball)).BeginInit();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.BackColor = System.Drawing.Color.Transparent;
            this.pl.Image = global::WindowsFormsApp3.Properties.Resources.down_stend;
            this.pl.Location = new System.Drawing.Point(139, 179);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(40, 77);
            this.pl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pl.TabIndex = 0;
            this.pl.TabStop = false;
            this.pl.Click += new System.EventHandler(this.pl_Click);
            // 
            // fireball
            // 
            this.fireball.BackColor = System.Drawing.Color.Transparent;
            this.fireball.Image = global::WindowsFormsApp3.Properties.Resources.a0cd84b264f852e4c7af031efb08af91_1_1_;
            this.fireball.Location = new System.Drawing.Point(220, 179);
            this.fireball.Name = "fireball";
            this.fireball.Size = new System.Drawing.Size(42, 43);
            this.fireball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fireball.TabIndex = 1;
            this.fireball.TabStop = false;
            this.fireball.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.map;
            this.ClientSize = new System.Drawing.Size(1344, 690);
            this.Controls.Add(this.fireball);
            this.Controls.Add(this.pl);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pl)).EndI  nit();
            ((System.ComponentModel.ISupportInitialize)(this.fireball)).EndInit();
            this.ResumeLayout(false);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.PictureBox pl;
        private PictureBox fireball;
    }
}

