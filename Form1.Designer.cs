﻿namespace TesteProgramacao
{
    partial class Form1
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
            this.Exercicio1 = new System.Windows.Forms.Button();
            this.Exercicio2 = new System.Windows.Forms.Button();
            this.Exercicio3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Exercicio1
            // 
            this.Exercicio1.Location = new System.Drawing.Point(75, 40);
            this.Exercicio1.Name = "Exercicio1";
            this.Exercicio1.Size = new System.Drawing.Size(118, 42);
            this.Exercicio1.TabIndex = 0;
            this.Exercicio1.Text = "Exercicio1";
            this.Exercicio1.UseVisualStyleBackColor = true;
            this.Exercicio1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exercicio2
            // 
            this.Exercicio2.Location = new System.Drawing.Point(75, 274);
            this.Exercicio2.Name = "Exercicio2";
            this.Exercicio2.Size = new System.Drawing.Size(110, 45);
            this.Exercicio2.TabIndex = 1;
            this.Exercicio2.Text = "Exercicio2";
            this.Exercicio2.UseVisualStyleBackColor = true;
            this.Exercicio2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exercicio3
            // 
            this.Exercicio3.Location = new System.Drawing.Point(75, 508);
            this.Exercicio3.Name = "Exercicio3";
            this.Exercicio3.Size = new System.Drawing.Size(118, 43);
            this.Exercicio3.TabIndex = 2;
            this.Exercicio3.Text = "Exercicio3";
            this.Exercicio3.UseVisualStyleBackColor = true;
            this.Exercicio3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Já no Texto B, quantos são os verbos?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "E quantos verbos do Texto B estão em primeira pessoa?";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Como seria a lista de vocabulário do Texto B?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "E no Texto B, quantos números bonitos distintos existem?";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(314, 642);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(245, 342);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(502, 119);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 698);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exercicio3);
            this.Controls.Add(this.Exercicio2);
            this.Controls.Add(this.Exercicio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exercicio1;
        private System.Windows.Forms.Button Exercicio2;
        private System.Windows.Forms.Button Exercicio3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

