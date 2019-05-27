namespace Lab14_Tim
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.EncryptTextBox = new System.Windows.Forms.TextBox();
            this.DecryptTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.GistogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShowSwapBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProbabilityShiftsBox = new System.Windows.Forms.TextBox();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GistogramChart)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptTextBox
            // 
            this.EncryptTextBox.Location = new System.Drawing.Point(12, 39);
            this.EncryptTextBox.Multiline = true;
            this.EncryptTextBox.Name = "EncryptTextBox";
            this.EncryptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EncryptTextBox.Size = new System.Drawing.Size(442, 300);
            this.EncryptTextBox.TabIndex = 1;
            // 
            // DecryptTextBox
            // 
            this.DecryptTextBox.Location = new System.Drawing.Point(522, 39);
            this.DecryptTextBox.Multiline = true;
            this.DecryptTextBox.Name = "DecryptTextBox";
            this.DecryptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DecryptTextBox.Size = new System.Drawing.Size(441, 300);
            this.DecryptTextBox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Произвести анализ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Загрузить текст из файла";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1187, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Очистить всё";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GistogramChart
            // 
            chartArea1.Name = "ChartArea1";
            this.GistogramChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GistogramChart.Legends.Add(legend1);
            this.GistogramChart.Location = new System.Drawing.Point(12, 411);
            this.GistogramChart.Name = "GistogramChart";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Загруженный текст";
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Исходный алфавит";
            series2.MarkerSize = 1;
            series2.Name = "Series2";
            this.GistogramChart.Series.Add(series1);
            this.GistogramChart.Series.Add(series2);
            this.GistogramChart.Size = new System.Drawing.Size(951, 320);
            this.GistogramChart.TabIndex = 7;
            this.GistogramChart.Text = "chart1";
            title1.Name = "TItle0";
            title1.Text = "Гистограмма встречаемости букв";
            this.GistogramChart.Titles.Add(title1);
            // 
            // ShowSwapBox
            // 
            this.ShowSwapBox.Location = new System.Drawing.Point(1002, 39);
            this.ShowSwapBox.Multiline = true;
            this.ShowSwapBox.Name = "ShowSwapBox";
            this.ShowSwapBox.ReadOnly = true;
            this.ShowSwapBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowSwapBox.Size = new System.Drawing.Size(310, 300);
            this.ShowSwapBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(999, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Шифрованный    Ассоциация";
            // 
            // ProbabilityShiftsBox
            // 
            this.ProbabilityShiftsBox.Location = new System.Drawing.Point(1002, 411);
            this.ProbabilityShiftsBox.Multiline = true;
            this.ProbabilityShiftsBox.Name = "ProbabilityShiftsBox";
            this.ProbabilityShiftsBox.ReadOnly = true;
            this.ProbabilityShiftsBox.Size = new System.Drawing.Size(310, 320);
            this.ProbabilityShiftsBox.TabIndex = 10;
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(522, 353);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(100, 22);
            this.KeyBox.TabIndex = 11;
            this.KeyBox.Text = "0";
            this.KeyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Произвести смещение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.ProbabilityShiftsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowSwapBox);
            this.Controls.Add(this.GistogramChart);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DecryptTextBox);
            this.Controls.Add(this.EncryptTextBox);
            this.Name = "MainForm";
            this.Text = "Frequency analysis";
            ((System.ComponentModel.ISupportInitialize)(this.GistogramChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EncryptTextBox;
        private System.Windows.Forms.TextBox DecryptTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart GistogramChart;
        private System.Windows.Forms.TextBox ShowSwapBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProbabilityShiftsBox;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Button button1;
    }
}

