namespace Coursework
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            label2 = new Label();
            nowTime = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            passCount1 = new Label();
            passCount2 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            passCount3 = new Label();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            passCount4 = new Label();
            label12 = new Label();
            pictureBox4 = new PictureBox();
            passCount5 = new Label();
            label14 = new Label();
            pictureBox5 = new PictureBox();
            passCount6 = new Label();
            label16 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            passengerTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 42);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Текущее время";
            label1.Click += label1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(267, 64);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 40);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Текущая дата";
            // 
            // nowTime
            // 
            nowTime.AutoSize = true;
            nowTime.Location = new Point(145, 64);
            nowTime.Name = "nowTime";
            nowTime.Size = new Size(49, 15);
            nowTime.TabIndex = 3;
            nowTime.Text = "00:00:00";
            nowTime.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(553, 204);
            button1.Name = "button1";
            button1.Size = new Size(325, 42);
            button1.TabIndex = 4;
            button1.Text = "Выслать ";
            button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(267, 329);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 278);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 6;
            label3.Text = "Количество пассажиров:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 347);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "Остановка:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 376);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 8;
            label5.Text = "№1";
            // 
            // passCount1
            // 
            passCount1.AutoSize = true;
            passCount1.Location = new Point(284, 278);
            passCount1.Name = "passCount1";
            passCount1.Size = new Size(13, 15);
            passCount1.TabIndex = 9;
            passCount1.Text = "0";
            passCount1.Click += passCount1_Click;
            // 
            // passCount2
            // 
            passCount2.AutoSize = true;
            passCount2.Location = new Point(427, 278);
            passCount2.Name = "passCount2";
            passCount2.Size = new Size(13, 15);
            passCount2.TabIndex = 12;
            passCount2.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(420, 376);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 11;
            label8.Text = "№2";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(410, 329);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // passCount3
            // 
            passCount3.AutoSize = true;
            passCount3.Location = new Point(581, 278);
            passCount3.Name = "passCount3";
            passCount3.Size = new Size(13, 15);
            passCount3.TabIndex = 15;
            passCount3.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(574, 376);
            label10.Name = "label10";
            label10.Size = new Size(26, 15);
            label10.TabIndex = 14;
            label10.Text = "№3";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(564, 329);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // passCount4
            // 
            passCount4.AutoSize = true;
            passCount4.Location = new Point(735, 278);
            passCount4.Name = "passCount4";
            passCount4.Size = new Size(13, 15);
            passCount4.TabIndex = 18;
            passCount4.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(728, 376);
            label12.Name = "label12";
            label12.Size = new Size(26, 15);
            label12.TabIndex = 17;
            label12.Text = "№4";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(718, 329);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // passCount5
            // 
            passCount5.AutoSize = true;
            passCount5.Location = new Point(885, 278);
            passCount5.Name = "passCount5";
            passCount5.Size = new Size(13, 15);
            passCount5.TabIndex = 21;
            passCount5.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(878, 376);
            label14.Name = "label14";
            label14.Size = new Size(26, 15);
            label14.TabIndex = 20;
            label14.Text = "№5";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(868, 329);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // passCount6
            // 
            passCount6.AutoSize = true;
            passCount6.Location = new Point(1040, 278);
            passCount6.Name = "passCount6";
            passCount6.Size = new Size(13, 15);
            passCount6.TabIndex = 24;
            passCount6.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1033, 376);
            label16.Name = "label16";
            label16.Size = new Size(26, 15);
            label16.TabIndex = 23;
            label16.Text = "№6";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1023, 329);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 40);
            label6.Name = "label6";
            label6.Size = new Size(211, 15);
            label6.TabIndex = 25;
            label6.Text = "Выслать дополнительный транспорт";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(553, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 100);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите остановку, куда хотите отправить транспорт:";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(267, 50);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(44, 19);
            radioButton6.TabIndex = 32;
            radioButton6.TabStop = true;
            radioButton6.Text = "№6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(217, 50);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(44, 19);
            radioButton5.TabIndex = 31;
            radioButton5.TabStop = true;
            radioButton5.Text = "№5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(167, 50);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(44, 19);
            radioButton4.TabIndex = 30;
            radioButton4.TabStop = true;
            radioButton4.Text = "№4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(117, 50);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(44, 19);
            radioButton3.TabIndex = 29;
            radioButton3.TabStop = true;
            radioButton3.Text = "№3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(67, 50);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(44, 19);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "№2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(44, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "№1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 651);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(passCount6);
            Controls.Add(label16);
            Controls.Add(pictureBox6);
            Controls.Add(passCount5);
            Controls.Add(label14);
            Controls.Add(pictureBox5);
            Controls.Add(passCount4);
            Controls.Add(label12);
            Controls.Add(pictureBox4);
            Controls.Add(passCount3);
            Controls.Add(label10);
            Controls.Add(pictureBox3);
            Controls.Add(passCount2);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Controls.Add(passCount1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(nowTime);
            Controls.Add(label2);
            Controls.Add(monthCalendar1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MonthCalendar monthCalendar1;
        private Label label2;
        private Label nowTime;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label passCount1;
        private Label passCount2;
        private Label label8;
        private PictureBox pictureBox2;
        private Label passCount3;
        private Label label10;
        private PictureBox pictureBox3;
        private Label passCount4;
        private Label label12;
        private PictureBox pictureBox4;
        private Label passCount5;
        private Label label14;
        private PictureBox pictureBox5;
        private Label passCount6;
        private Label label16;
        private PictureBox pictureBox6;
        private Label label6;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private System.Windows.Forms.Timer passengerTimer;
    }
}