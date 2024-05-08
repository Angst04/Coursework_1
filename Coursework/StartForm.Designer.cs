namespace Coursework
{
    partial class StartForm
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
            monthCalendar = new MonthCalendar();
            startButton = new Button();
            closeButton = new Button();
            groupBox1 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 0;
            label1.Text = "Выберите дату начала смены";
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(24, 49);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 2;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // startButton
            // 
            startButton.Location = new Point(24, 233);
            startButton.Name = "startButton";
            startButton.Size = new Size(454, 49);
            startButton.TabIndex = 32;
            startButton.Text = "Готово";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.Location = new Point(471, -1);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(33, 31);
            closeButton.TabIndex = 33;
            closeButton.Text = "x";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Location = new Point(247, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 100);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите количество остановок";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(157, 50);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(31, 19);
            radioButton6.TabIndex = 32;
            radioButton6.TabStop = true;
            radioButton6.Text = "6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(91, 50);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(31, 19);
            radioButton5.TabIndex = 31;
            radioButton5.TabStop = true;
            radioButton5.Text = "5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(25, 50);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(31, 19);
            radioButton4.TabIndex = 30;
            radioButton4.TabStop = true;
            radioButton4.Text = "4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 296);
            Controls.Add(groupBox1);
            Controls.Add(closeButton);
            Controls.Add(startButton);
            Controls.Add(monthCalendar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MonthCalendar monthCalendar;
        private Button startButton;
        private Button closeButton;
        private GroupBox groupBox1;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
    }
}