﻿
namespace SiteEmlakProgrami
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(461, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(282, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(282, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(305, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(692, 425);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Site Giriş Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

