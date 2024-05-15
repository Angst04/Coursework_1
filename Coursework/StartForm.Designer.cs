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
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(285, 25);
            label1.TabIndex = 0;
            label1.Text = "Выберите дату начала смены";
            // 
            // monthCalendar
            // 
            monthCalendar.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar.Location = new Point(84, 49);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 2;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(24, 235);
            startButton.Name = "startButton";
            startButton.Size = new Size(529, 49);
            startButton.TabIndex = 32;
            startButton.Text = "Готово";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(364, 15);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 33;
            label2.Text = "Информация";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(348, 59);
            label3.Name = "label3";
            label3.Size = new Size(186, 129);
            label3.TabIndex = 34;
            label3.Text = "Ваша смена продлится с 06:00 до 20:00. Вам нужно следить за количеством пассажиров на каждой остановке и в случае необходимости высылать дополнительный транспорт";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 296);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(startButton);
            Controls.Add(monthCalendar);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Начало смены";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MonthCalendar monthCalendar;
        private Button startButton;
        private Label label2;
        private Label label3;
    }
}