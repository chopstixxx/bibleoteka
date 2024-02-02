namespace bibleoteka
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            dateTimePicker3 = new DateTimePicker();
            label3 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            label4 = new Label();
            button4 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(31, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(31, 80);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 14);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Дата 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 62);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Дата 2";
            // 
            // button1
            // 
            button1.Location = new Point(31, 119);
            button1.Name = "button1";
            button1.Size = new Size(200, 23);
            button1.TabIndex = 4;
            button1.Text = "Найти разницу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(294, 32);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 5;
            dateTimePicker3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 14);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Время";
            // 
            // button2
            // 
            button2.Location = new Point(294, 80);
            button2.Name = "button2";
            button2.Size = new Size(200, 23);
            button2.TabIndex = 7;
            button2.Text = "Узнать время суток";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 240);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button3
            // 
            button3.Location = new Point(294, 288);
            button3.Name = "button3";
            button3.Size = new Size(200, 23);
            button3.TabIndex = 9;
            button3.Text = "Определение года";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 222);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 10;
            label4.Text = "Год";
            // 
            // button4
            // 
            button4.Location = new Point(30, 288);
            button4.Name = "button4";
            button4.Size = new Size(200, 23);
            button4.TabIndex = 11;
            button4.Text = "Получить результат";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(30, 175);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(146, 19);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Полный формат даты";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(31, 200);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(145, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Краткий формат даты";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(31, 225);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(207, 19);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "Полный формат даты и времени";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(31, 250);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(206, 19);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "Краткий формат даты и времени";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(527, 351);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Дата и время";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Button button1;
        private DateTimePicker dateTimePicker3;
        private Label label3;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Label label4;
        private Button button4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}