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
            mainTimer = new System.Windows.Forms.Timer(components);
            passengerTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            monthCalendar = new MonthCalendar();
            label2 = new Label();
            nowTime = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            labelNum1 = new Label();
            passCount1 = new Label();
            passCount2 = new Label();
            labelNum2 = new Label();
            pictureBox2 = new PictureBox();
            passCount3 = new Label();
            labelNum3 = new Label();
            pictureBox3 = new PictureBox();
            passCount4 = new Label();
            labelNum4 = new Label();
            pictureBox4 = new PictureBox();
            passCount5 = new Label();
            labelNum5 = new Label();
            pictureBox5 = new PictureBox();
            passCount6 = new Label();
            labelNum6 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            startButton = new Button();
            label7 = new Label();
            nowDate = new Label();
            nowDateType = new Label();
            label9 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mainTimer
            // 
            mainTimer.Tick += timer1_Tick;
            // 
            // passengerTimer
            // 
            passengerTimer.Interval = 3000;
            passengerTimer.Tick += passengerTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 42);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Текущее время";
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(267, 64);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 1;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 90);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Выбранная дата";
            // 
            // nowTime
            // 
            nowTime.AutoSize = true;
            nowTime.Location = new Point(153, 64);
            nowTime.Name = "nowTime";
            nowTime.Size = new Size(34, 15);
            nowTime.TabIndex = 3;
            nowTime.Text = "00:00";
            // 
            // button1
            // 
            button1.Location = new Point(833, 208);
            button1.Name = "button1";
            button1.Size = new Size(325, 42);
            button1.TabIndex = 4;
            button1.Text = "Выслать ";
            button1.UseVisualStyleBackColor = true;
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
            // labelNum1
            // 
            labelNum1.AutoSize = true;
            labelNum1.Location = new Point(277, 376);
            labelNum1.Name = "labelNum1";
            labelNum1.Size = new Size(26, 15);
            labelNum1.TabIndex = 8;
            labelNum1.Text = "№1";
            // 
            // passCount1
            // 
            passCount1.AutoSize = true;
            passCount1.Location = new Point(284, 278);
            passCount1.Name = "passCount1";
            passCount1.Size = new Size(13, 15);
            passCount1.TabIndex = 9;
            passCount1.Text = "0";
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
            // labelNum2
            // 
            labelNum2.AutoSize = true;
            labelNum2.Location = new Point(420, 376);
            labelNum2.Name = "labelNum2";
            labelNum2.Size = new Size(26, 15);
            labelNum2.TabIndex = 11;
            labelNum2.Text = "№2";
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
            // labelNum3
            // 
            labelNum3.AutoSize = true;
            labelNum3.Location = new Point(574, 376);
            labelNum3.Name = "labelNum3";
            labelNum3.Size = new Size(26, 15);
            labelNum3.TabIndex = 14;
            labelNum3.Text = "№3";
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
            // labelNum4
            // 
            labelNum4.AutoSize = true;
            labelNum4.Location = new Point(728, 376);
            labelNum4.Name = "labelNum4";
            labelNum4.Size = new Size(26, 15);
            labelNum4.TabIndex = 17;
            labelNum4.Text = "№4";
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
            // labelNum5
            // 
            labelNum5.AutoSize = true;
            labelNum5.Location = new Point(878, 376);
            labelNum5.Name = "labelNum5";
            labelNum5.Size = new Size(26, 15);
            labelNum5.TabIndex = 20;
            labelNum5.Text = "№5";
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
            // labelNum6
            // 
            labelNum6.AutoSize = true;
            labelNum6.Location = new Point(1033, 376);
            labelNum6.Name = "labelNum6";
            labelNum6.Size = new Size(26, 15);
            labelNum6.TabIndex = 23;
            labelNum6.Text = "№6";
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
            label6.Location = new Point(833, 44);
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
            groupBox1.Location = new Point(833, 82);
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
            // startButton
            // 
            startButton.Location = new Point(124, 171);
            startButton.Name = "startButton";
            startButton.Size = new Size(91, 55);
            startButton.TabIndex = 28;
            startButton.Text = "Начать смену";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(304, 42);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 29;
            label7.Text = "Выберите дату";
            // 
            // nowDate
            // 
            nowDate.AutoSize = true;
            nowDate.Location = new Point(124, 113);
            nowDate.Name = "nowDate";
            nowDate.Size = new Size(73, 15);
            nowDate.TabIndex = 30;
            nowDate.Text = "                      ";
            // 
            // nowDateType
            // 
            nowDateType.AutoSize = true;
            nowDateType.Location = new Point(124, 132);
            nowDateType.Name = "nowDateType";
            nowDateType.Size = new Size(85, 15);
            nowDateType.TabIndex = 31;
            nowDateType.Text = "                          ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(456, 42);
            label9.Name = "label9";
            label9.Size = new Size(158, 15);
            label9.TabIndex = 32;
            label9.Text = "Отслеживаемые остановки";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(456, 64);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(45, 19);
            checkBox1.TabIndex = 34;
            checkBox1.Text = "№1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(456, 90);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(45, 19);
            checkBox2.TabIndex = 35;
            checkBox2.Text = "№2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(456, 115);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(45, 19);
            checkBox3.TabIndex = 36;
            checkBox3.Text = "№3";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.Location = new Point(456, 140);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(45, 19);
            checkBox4.TabIndex = 37;
            checkBox4.Text = "№4";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.Location = new Point(456, 165);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(45, 19);
            checkBox5.TabIndex = 38;
            checkBox5.Text = "№5";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Checked = true;
            checkBox6.CheckState = CheckState.Checked;
            checkBox6.Location = new Point(456, 190);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(45, 19);
            checkBox6.TabIndex = 39;
            checkBox6.Text = "№6";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 651);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label9);
            Controls.Add(nowDateType);
            Controls.Add(nowDate);
            Controls.Add(label7);
            Controls.Add(startButton);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(passCount6);
            Controls.Add(labelNum6);
            Controls.Add(pictureBox6);
            Controls.Add(passCount5);
            Controls.Add(labelNum5);
            Controls.Add(pictureBox5);
            Controls.Add(passCount4);
            Controls.Add(labelNum4);
            Controls.Add(pictureBox4);
            Controls.Add(passCount3);
            Controls.Add(labelNum3);
            Controls.Add(pictureBox3);
            Controls.Add(passCount2);
            Controls.Add(labelNum2);
            Controls.Add(pictureBox2);
            Controls.Add(passCount1);
            Controls.Add(labelNum1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(nowTime);
            Controls.Add(label2);
            Controls.Add(monthCalendar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
        private MonthCalendar monthCalendar;
        private Label label2;
        private Label nowTime;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label labelNum1;
        private Label passCount1;
        private Label passCount2;
        private Label labelNum2;
        private PictureBox pictureBox2;
        private Label passCount3;
        private Label labelNum3;
        private PictureBox pictureBox3;
        private Label passCount4;
        private Label labelNum4;
        private PictureBox pictureBox4;
        private Label passCount5;
        private Label labelNum5;
        private PictureBox pictureBox5;
        private Label passCount6;
        private Label labelNum6;
        private PictureBox pictureBox6;
        private Label label6;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Timer passengerTimer;
        private Button startButton;
        private Label label7;
        private Label nowDate;
        private Label nowDateType;
        private Label label9;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
    }
}