namespace Coursework
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            nowTime = new Label();
            sendButton = new Button();
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
            groupBox1 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            startButton = new Button();
            nowDate = new Label();
            nowDateType = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            transportPanel = new Panel();
            transportProgressBar = new ProgressBar();
            transportCurrentStop = new Label();
            transportChangeButton = new Button();
            transportAmount = new Label();
            transportDeparture = new Label();
            transportType = new Label();
            closeButton = new Button();
            groupBox2 = new GroupBox();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            testLabel = new Label();
            passengerTimer = new System.Windows.Forms.Timer(components);
            groupBox3 = new GroupBox();
            minibusRemainsLabel = new Label();
            busRemainsLabel = new Label();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            transportPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // mainTimer
            // 
            mainTimer.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 43);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Текущее время";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 83);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Текущая дата";
            // 
            // nowTime
            // 
            nowTime.AutoSize = true;
            nowTime.Location = new Point(96, 65);
            nowTime.Name = "nowTime";
            nowTime.Size = new Size(34, 15);
            nowTime.TabIndex = 3;
            nowTime.Text = "00:00";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(951, 512);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(122, 42);
            sendButton.TabIndex = 4;
            sendButton.Text = "Выслать ";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 403);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 352);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 6;
            label3.Text = "Количество пассажиров:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 421);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "Остановка:";
            // 
            // labelNum1
            // 
            labelNum1.AutoSize = true;
            labelNum1.Location = new Point(220, 450);
            labelNum1.Name = "labelNum1";
            labelNum1.Size = new Size(26, 15);
            labelNum1.TabIndex = 8;
            labelNum1.Text = "№1";
            // 
            // passCount1
            // 
            passCount1.AutoSize = true;
            passCount1.Location = new Point(227, 352);
            passCount1.Name = "passCount1";
            passCount1.Size = new Size(13, 15);
            passCount1.TabIndex = 9;
            passCount1.Text = "0";
            // 
            // passCount2
            // 
            passCount2.AutoSize = true;
            passCount2.Location = new Point(370, 352);
            passCount2.Name = "passCount2";
            passCount2.Size = new Size(13, 15);
            passCount2.TabIndex = 12;
            passCount2.Text = "0";
            // 
            // labelNum2
            // 
            labelNum2.AutoSize = true;
            labelNum2.Location = new Point(363, 450);
            labelNum2.Name = "labelNum2";
            labelNum2.Size = new Size(26, 15);
            labelNum2.TabIndex = 11;
            labelNum2.Text = "№2";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(353, 403);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // passCount3
            // 
            passCount3.AutoSize = true;
            passCount3.Location = new Point(524, 352);
            passCount3.Name = "passCount3";
            passCount3.Size = new Size(13, 15);
            passCount3.TabIndex = 15;
            passCount3.Text = "0";
            // 
            // labelNum3
            // 
            labelNum3.AutoSize = true;
            labelNum3.Location = new Point(517, 450);
            labelNum3.Name = "labelNum3";
            labelNum3.Size = new Size(26, 15);
            labelNum3.TabIndex = 14;
            labelNum3.Text = "№3";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(507, 403);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // passCount4
            // 
            passCount4.AutoSize = true;
            passCount4.Location = new Point(678, 352);
            passCount4.Name = "passCount4";
            passCount4.Size = new Size(13, 15);
            passCount4.TabIndex = 18;
            passCount4.Text = "0";
            // 
            // labelNum4
            // 
            labelNum4.AutoSize = true;
            labelNum4.Location = new Point(671, 450);
            labelNum4.Name = "labelNum4";
            labelNum4.Size = new Size(26, 15);
            labelNum4.TabIndex = 17;
            labelNum4.Text = "№4";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(661, 403);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // passCount5
            // 
            passCount5.AutoSize = true;
            passCount5.Location = new Point(828, 352);
            passCount5.Name = "passCount5";
            passCount5.Size = new Size(13, 15);
            passCount5.TabIndex = 21;
            passCount5.Text = "0";
            // 
            // labelNum5
            // 
            labelNum5.AutoSize = true;
            labelNum5.Location = new Point(821, 450);
            labelNum5.Name = "labelNum5";
            labelNum5.Size = new Size(26, 15);
            labelNum5.TabIndex = 20;
            labelNum5.Text = "№5";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(811, 403);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // passCount6
            // 
            passCount6.AutoSize = true;
            passCount6.Location = new Point(983, 352);
            passCount6.Name = "passCount6";
            passCount6.Size = new Size(13, 15);
            passCount6.TabIndex = 24;
            passCount6.Text = "0";
            // 
            // labelNum6
            // 
            labelNum6.AutoSize = true;
            labelNum6.Location = new Point(976, 450);
            labelNum6.Name = "labelNum6";
            labelNum6.Size = new Size(26, 15);
            labelNum6.TabIndex = 23;
            labelNum6.Text = "№6";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(966, 403);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(36, 487);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 80);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите остановку, куда хотите отправить дополнительный транспорт:";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(267, 50);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(44, 19);
            radioButton6.TabIndex = 32;
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
            radioButton2.Text = "№2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
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
            startButton.Location = new Point(72, 163);
            startButton.Name = "startButton";
            startButton.Size = new Size(91, 49);
            startButton.TabIndex = 28;
            startButton.Text = "Начать смену";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // nowDate
            // 
            nowDate.AutoSize = true;
            nowDate.Location = new Point(80, 106);
            nowDate.Name = "nowDate";
            nowDate.Size = new Size(73, 15);
            nowDate.TabIndex = 30;
            nowDate.Text = "                      ";
            // 
            // nowDateType
            // 
            nowDateType.AutoSize = true;
            nowDateType.Location = new Point(80, 126);
            nowDateType.Name = "nowDateType";
            nowDateType.Size = new Size(85, 15);
            nowDateType.TabIndex = 31;
            nowDateType.Text = "                          ";
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(192, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 263);
            panel1.TabIndex = 42;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(transportPanel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(866, 263);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // transportPanel
            // 
            transportPanel.BackColor = Color.FromArgb(255, 224, 192);
            transportPanel.Controls.Add(transportProgressBar);
            transportPanel.Controls.Add(transportCurrentStop);
            transportPanel.Controls.Add(transportChangeButton);
            transportPanel.Controls.Add(transportAmount);
            transportPanel.Controls.Add(transportDeparture);
            transportPanel.Controls.Add(transportType);
            transportPanel.Location = new Point(3, 3);
            transportPanel.Name = "transportPanel";
            transportPanel.Size = new Size(839, 44);
            transportPanel.TabIndex = 3;
            // 
            // transportProgressBar
            // 
            transportProgressBar.Location = new Point(401, 10);
            transportProgressBar.Name = "transportProgressBar";
            transportProgressBar.Size = new Size(262, 23);
            transportProgressBar.TabIndex = 5;
            // 
            // transportCurrentStop
            // 
            transportCurrentStop.AutoSize = true;
            transportCurrentStop.Location = new Point(287, 14);
            transportCurrentStop.Name = "transportCurrentStop";
            transportCurrentStop.Size = new Size(13, 15);
            transportCurrentStop.TabIndex = 4;
            transportCurrentStop.Text = "1";
            // 
            // transportChangeButton
            // 
            transportChangeButton.Location = new Point(743, 10);
            transportChangeButton.Name = "transportChangeButton";
            transportChangeButton.Size = new Size(75, 23);
            transportChangeButton.TabIndex = 3;
            transportChangeButton.Text = "Изменить";
            transportChangeButton.UseVisualStyleBackColor = true;
            // 
            // transportAmount
            // 
            transportAmount.AutoSize = true;
            transportAmount.Location = new Point(188, 14);
            transportAmount.Name = "transportAmount";
            transportAmount.Size = new Size(30, 15);
            transportAmount.TabIndex = 2;
            transportAmount.Text = "0/50";
            // 
            // transportDeparture
            // 
            transportDeparture.AutoSize = true;
            transportDeparture.Location = new Point(97, 14);
            transportDeparture.Name = "transportDeparture";
            transportDeparture.Size = new Size(34, 15);
            transportDeparture.TabIndex = 1;
            transportDeparture.Text = "00:30";
            // 
            // transportType
            // 
            transportType.AutoSize = true;
            transportType.Location = new Point(11, 14);
            transportType.Name = "transportType";
            transportType.Size = new Size(52, 15);
            transportType.TabIndex = 0;
            transportType.Text = "Автобус";
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.Location = new Point(1069, -1);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(33, 31);
            closeButton.TabIndex = 43;
            closeButton.Text = "x";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton11);
            groupBox2.Controls.Add(radioButton12);
            groupBox2.Location = new Point(383, 487);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 80);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выберите тип транспорта";
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(171, 50);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(136, 19);
            radioButton11.TabIndex = 28;
            radioButton11.Text = "Маршрутка (25 чел)";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Checked = true;
            radioButton12.Location = new Point(17, 50);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(116, 19);
            radioButton12.TabIndex = 0;
            radioButton12.TabStop = true;
            radioButton12.Text = "Автобус (50 чел)";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Location = new Point(192, 9);
            label9.Name = "label9";
            label9.Size = new Size(79, 31);
            label9.TabIndex = 45;
            label9.Text = "Тип транспорта";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Location = new Point(268, 9);
            label10.Name = "label10";
            label10.Size = new Size(79, 31);
            label10.TabIndex = 46;
            label10.Text = "Время отправления";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(353, 15);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 47;
            label11.Text = "Заполненность";
            // 
            // label12
            // 
            label12.Location = new Point(451, 7);
            label12.Name = "label12";
            label12.Size = new Size(76, 35);
            label12.TabIndex = 48;
            label12.Text = "№ текущей остановки";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(596, 17);
            label13.Name = "label13";
            label13.Size = new Size(262, 15);
            label13.TabIndex = 49;
            label13.Text = "Время до прибытия на следующую остановку";
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.Location = new Point(88, 281);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(52, 15);
            testLabel.TabIndex = 50;
            testLabel.Text = "Отладка";
            // 
            // passengerTimer
            // 
            passengerTimer.Interval = 3000;
            passengerTimer.Tick += passengerTimer_Tick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(minibusRemainsLabel);
            groupBox3.Controls.Add(busRemainsLabel);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(729, 487);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(202, 80);
            groupBox3.TabIndex = 51;
            groupBox3.TabStop = false;
            groupBox3.Text = "Доступный транспорт";
            // 
            // minibusRemainsLabel
            // 
            minibusRemainsLabel.AutoSize = true;
            minibusRemainsLabel.Location = new Point(158, 52);
            minibusRemainsLabel.Name = "minibusRemainsLabel";
            minibusRemainsLabel.Size = new Size(13, 15);
            minibusRemainsLabel.TabIndex = 3;
            minibusRemainsLabel.Text = "0";
            // 
            // busRemainsLabel
            // 
            busRemainsLabel.AutoSize = true;
            busRemainsLabel.Location = new Point(158, 27);
            busRemainsLabel.Name = "busRemainsLabel";
            busRemainsLabel.Size = new Size(13, 15);
            busRemainsLabel.TabIndex = 2;
            busRemainsLabel.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 54);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 1;
            label6.Text = "Маршрутки:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 27);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 0;
            label5.Text = "Автобусы:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 584);
            Controls.Add(groupBox3);
            Controls.Add(testLabel);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            Controls.Add(nowDateType);
            Controls.Add(nowDate);
            Controls.Add(startButton);
            Controls.Add(groupBox1);
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
            Controls.Add(sendButton);
            Controls.Add(nowTime);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            transportPanel.ResumeLayout(false);
            transportPanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label nowTime;
        private Button sendButton;
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
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private System.Windows.Forms.Timer mainTimer;
        private Button startButton;
        private Label nowDate;
        private Label nowDateType;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button closeButton;
        private GroupBox groupBox2;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label testLabel;
        private Panel transportPanel;
        private ProgressBar transportProgressBar;
        private Label transportCurrentStop;
        private Button transportChangeButton;
        private Label transportAmount;
        private Label transportDeparture;
        private Label transportType;
        private System.Windows.Forms.Timer passengerTimer;
        private GroupBox groupBox3;
        private Label minibusRemainsLabel;
        private Label busRemainsLabel;
        private Label label6;
        private Label label5;
    }
}