namespace _3x_1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            run = new Button();
            label1 = new Label();
            myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            listView = new ListView();
            inputBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)myChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // run
            // 
            run.BackColor = Color.FromArgb(30, 95, 116);
            run.FlatAppearance.BorderSize = 0;
            run.FlatStyle = FlatStyle.Flat;
            run.Location = new Point(88, 129);
            run.Name = "run";
            run.Size = new Size(142, 36);
            run.TabIndex = 0;
            run.Text = "Run";
            run.UseVisualStyleBackColor = false;
            run.Click += run_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(37, 26);
            label1.Name = "label1";
            label1.Size = new Size(262, 19);
            label1.TabIndex = 3;
            label1.Text = "Collatz conjecture for positive integer";
            label1.Click += label1_Click;
            // 
            // myChart
            // 
            myChart.BackColor = Color.FromArgb(29, 45, 80);
            myChart.BorderlineColor = Color.Transparent;
            chartArea2.BackColor = Color.FromArgb(29, 45, 80);
            chartArea2.BackSecondaryColor = Color.White;
            chartArea2.BorderColor = Color.White;
            chartArea2.Name = "ChartArea1";
            myChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = Color.Transparent;
            legend2.ForeColor = Color.White;
            legend2.Name = "Legend1";
            myChart.Legends.Add(legend2);
            myChart.Location = new Point(336, 26);
            myChart.Name = "myChart";
            myChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelBackColor = Color.Transparent;
            series2.LabelBorderColor = Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            myChart.Series.Add(series2);
            myChart.Size = new Size(1094, 811);
            myChart.TabIndex = 9;
            myChart.Text = "chart1";
            myChart.Click += chart1_Click;
            // 
            // listView
            // 
            listView.BackColor = Color.FromArgb(19, 59, 92);
            listView.BorderStyle = BorderStyle.None;
            listView.ForeColor = Color.White;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.Location = new Point(12, 188);
            listView.Name = "listView";
            listView.Size = new Size(318, 649);
            listView.TabIndex = 10;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // inputBox
            // 
            inputBox.BackColor = Color.FromArgb(19, 59, 92);
            inputBox.BorderStyle = BorderStyle.None;
            inputBox.ForeColor = Color.White;
            inputBox.Location = new Point(12, 55);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(318, 16);
            inputBox.TabIndex = 11;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(12, 81);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(315, 15);
            errorLabel.TabIndex = 12;
            errorLabel.Text = "Put one or multiple positive integers separated by comma.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(29, 45, 80);
            ClientSize = new Size(1442, 855);
            Controls.Add(errorLabel);
            Controls.Add(inputBox);
            Controls.Add(listView);
            Controls.Add(myChart);
            Controls.Add(label1);
            Controls.Add(run);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Collatz Conjecture";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)myChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button run;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private ListView listView;
        private TextBox inputBox;
        private ErrorProvider errorProvider1;
        private Label errorLabel;
    }
}
