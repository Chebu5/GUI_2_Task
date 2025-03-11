namespace WinFormsApp1
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
            Word1 = new TextBox();
            Word2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Word1
            // 
            Word1.Location = new Point(33, 56);
            Word1.Name = "Word1";
            Word1.Size = new Size(139, 27);
            Word1.TabIndex = 0;
            // 
            // Word2
            // 
            Word2.Location = new Point(33, 115);
            Word2.Name = "Word2";
            Word2.Size = new Size(139, 27);
            Word2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(33, 195);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Ответ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(151, 195);
            button2.Name = "button2";
            button2.Size = new Size(144, 29);
            button2.TabIndex = 3;
            button2.Text = "Очистить ввод";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 59);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 4;
            label1.Text = "Введите первое слово";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 118);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 5;
            label2.Text = "Введите второе слово";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 258);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.Location = new Point(443, 56);
            label4.Name = "label4";
            label4.Size = new Size(200, 168);
            label4.TabIndex = 7;
            label4.Text = "Даны два слова одинаковой длины. Поменять местами буквы на четных позициях, то есть например было a1a2a3a4 и b1b2b3b4, а вывести слова a1b2a3b4 и b1a2b3a4";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 373);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Word2);
            Controls.Add(Word1);
            Name = "Form1";
            Text = "Замена четных символов слов";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Word1;
        private TextBox Word2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
