﻿namespace AgendaSolution.Win.Cadastros
{
    partial class ContatoCadastroForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 0;
            label1.Text = " Nome Completo : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 126);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 1;
            label2.Text = " Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 80);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 26);
            textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 26);
            textBox3.TabIndex = 5;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(143, 77);
            maskedTextBox2.Mask = "(99) 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(177, 26);
            maskedTextBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(272, 178);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(373, 178);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ContatoCadastroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(554, 252);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ContatoCadastroForm";
            Text = "ContatoCadastroForm";
            Load += ContatoCadastroForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox2;
        private Button button1;
        private Button button2;
    }
}