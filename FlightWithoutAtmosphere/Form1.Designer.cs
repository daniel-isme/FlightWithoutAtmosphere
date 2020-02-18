namespace FlightWithoutAtmosphere
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_height = new System.Windows.Forms.NumericUpDown();
            this.edit_angle = new System.Windows.Forms.NumericUpDown();
            this.edit_speed = new System.Windows.Forms.NumericUpDown();
            this.button_launch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.text_time = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.edit_weight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_weight)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea6.AxisX.Maximum = 100D;
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.AxisY.Maximum = 50D;
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(12, 159);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(776, 377);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Speed";
            // 
            // edit_height
            // 
            this.edit_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_height.Location = new System.Drawing.Point(135, 15);
            this.edit_height.Name = "edit_height";
            this.edit_height.Size = new System.Drawing.Size(120, 41);
            this.edit_height.TabIndex = 7;
            // 
            // edit_angle
            // 
            this.edit_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_angle.Location = new System.Drawing.Point(135, 62);
            this.edit_angle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.edit_angle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edit_angle.Name = "edit_angle";
            this.edit_angle.Size = new System.Drawing.Size(120, 41);
            this.edit_angle.TabIndex = 8;
            this.edit_angle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // edit_speed
            // 
            this.edit_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_speed.Location = new System.Drawing.Point(135, 106);
            this.edit_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edit_speed.Name = "edit_speed";
            this.edit_speed.Size = new System.Drawing.Size(120, 41);
            this.edit_speed.TabIndex = 9;
            this.edit_speed.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // button_launch
            // 
            this.button_launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_launch.Location = new System.Drawing.Point(583, 72);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(171, 55);
            this.button_launch.TabIndex = 10;
            this.button_launch.Text = "Launch";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // text_time
            // 
            this.text_time.AutoSize = true;
            this.text_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_time.Location = new System.Drawing.Point(577, 14);
            this.text_time.Name = "text_time";
            this.text_time.Size = new System.Drawing.Size(135, 36);
            this.text_time.TabIndex = 11;
            this.text_time.Text = "Time: 0 s";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(411, 62);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 41);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Size";
            // 
            // edit_weight
            // 
            this.edit_weight.DecimalPlaces = 1;
            this.edit_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_weight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edit_weight.Location = new System.Drawing.Point(411, 18);
            this.edit_weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edit_weight.Name = "edit_weight";
            this.edit_weight.Size = new System.Drawing.Size(120, 41);
            this.edit_weight.TabIndex = 14;
            this.edit_weight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "Weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edit_weight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.text_time);
            this.Controls.Add(this.button_launch);
            this.Controls.Add(this.edit_speed);
            this.Controls.Add(this.edit_angle);
            this.Controls.Add(this.edit_height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edit_height;
        private System.Windows.Forms.NumericUpDown edit_angle;
        private System.Windows.Forms.NumericUpDown edit_speed;
        private System.Windows.Forms.Button button_launch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label text_time;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edit_weight;
        private System.Windows.Forms.Label label5;
    }
}

