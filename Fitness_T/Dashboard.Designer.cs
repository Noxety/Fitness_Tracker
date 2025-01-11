namespace Fitness_T
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_goal = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.recordChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbdata = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.Cmb_1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_goal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_3 = new System.Windows.Forms.RadioButton();
            this.radio_2 = new System.Windows.Forms.RadioButton();
            this.radio_1 = new System.Windows.Forms.RadioButton();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ComboBox();
            this.btn_change_data = new System.Windows.Forms.Button();
            this.lbl_alert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recordChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbdata.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(1019, 455);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(83, 29);
            this.btn_log_out.TabIndex = 15;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(12, 9);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(236, 20);
            this.lbl_welcome.TabIndex = 12;
            this.lbl_welcome.Text = "Welcome To Fitness Tracker";
            // 
            // lbl_goal
            // 
            this.lbl_goal.AutoSize = true;
            this.lbl_goal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_goal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_goal.Location = new System.Drawing.Point(666, 40);
            this.lbl_goal.Name = "lbl_goal";
            this.lbl_goal.Size = new System.Drawing.Size(53, 19);
            this.lbl_goal.TabIndex = 11;
            this.lbl_goal.Text = "Goal - ";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weight.Location = new System.Drawing.Point(495, 40);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(67, 19);
            this.lbl_weight.TabIndex = 10;
            this.lbl_weight.Text = "Weight - ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(13, 52);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(88, 18);
            this.lbl_name.TabIndex = 17;
            this.lbl_name.Text = "User Name - ";
            // 
            // recordChart
            // 
            this.recordChart.BorderlineColor = System.Drawing.Color.Black;
            this.recordChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.recordChart.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.recordChart.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.recordChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.recordChart.Legends.Add(legend3);
            this.recordChart.Location = new System.Drawing.Point(632, 125);
            this.recordChart.Name = "recordChart";
            this.recordChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
            series3.BorderColor = System.Drawing.Color.Black;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Records";
            this.recordChart.Series.Add(series3);
            this.recordChart.Size = new System.Drawing.Size(470, 252);
            this.recordChart.TabIndex = 18;
            this.recordChart.Text = "chart1";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(629, 383);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(158, 17);
            this.lbl_total.TabIndex = 19;
            this.lbl_total.Text = "Total Calories Burned - ";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_text.Location = new System.Drawing.Point(628, 98);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(263, 24);
            this.label_text.TabIndex = 20;
            this.label_text.Text = "Your Goal Have Achieved !";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbdata);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.list);
            this.groupBox1.Location = new System.Drawing.Point(16, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 323);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activities to Choose Based on Exercies";
            // 
            // gbdata
            // 
            this.gbdata.Controls.Add(this.lbl_alert);
            this.gbdata.Controls.Add(this.label4);
            this.gbdata.Controls.Add(this.btn_confirm);
            this.gbdata.Controls.Add(this.txt_weight);
            this.gbdata.Controls.Add(this.Cmb_1);
            this.gbdata.Controls.Add(this.label6);
            this.gbdata.Controls.Add(this.label5);
            this.gbdata.Controls.Add(this.txt_goal);
            this.gbdata.Location = new System.Drawing.Point(0, 0);
            this.gbdata.Name = "gbdata";
            this.gbdata.Size = new System.Drawing.Size(417, 323);
            this.gbdata.TabIndex = 23;
            this.gbdata.TabStop = false;
            this.gbdata.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Calories";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(87, 244);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(248, 35);
            this.btn_confirm.TabIndex = 23;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // txt_weight
            // 
            this.txt_weight.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_weight.Location = new System.Drawing.Point(87, 113);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(183, 20);
            this.txt_weight.TabIndex = 18;
            // 
            // Cmb_1
            // 
            this.Cmb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_1.FormattingEnabled = true;
            this.Cmb_1.Items.AddRange(new object[] {
            "lb",
            "kg"});
            this.Cmb_1.Location = new System.Drawing.Point(276, 111);
            this.Cmb_1.Name = "Cmb_1";
            this.Cmb_1.Size = new System.Drawing.Size(45, 24);
            this.Cmb_1.TabIndex = 22;
            this.Cmb_1.Text = "lb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Body Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total Goal to Burn";
            // 
            // txt_goal
            // 
            this.txt_goal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_goal.Location = new System.Drawing.Point(87, 186);
            this.txt_goal.Name = "txt_goal";
            this.txt_goal.Size = new System.Drawing.Size(183, 20);
            this.txt_goal.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_3);
            this.groupBox2.Controls.Add(this.radio_2);
            this.groupBox2.Controls.Add(this.radio_1);
            this.groupBox2.Location = new System.Drawing.Point(56, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.groupBox2.Size = new System.Drawing.Size(295, 127);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // radio_3
            // 
            this.radio_3.AutoSize = true;
            this.radio_3.Location = new System.Drawing.Point(20, 90);
            this.radio_3.Name = "radio_3";
            this.radio_3.Size = new System.Drawing.Size(186, 17);
            this.radio_3.TabIndex = 5;
            this.radio_3.TabStop = true;
            this.radio_3.Text = "vigorous effort , fast (14-15.9,mph)";
            this.radio_3.UseVisualStyleBackColor = true;
            // 
            // radio_2
            // 
            this.radio_2.AutoSize = true;
            this.radio_2.Location = new System.Drawing.Point(20, 56);
            this.radio_2.Name = "radio_2";
            this.radio_2.Size = new System.Drawing.Size(201, 17);
            this.radio_2.TabIndex = 4;
            this.radio_2.TabStop = true;
            this.radio_2.Text = "moderate effort , normal (12-13.9mph)";
            this.radio_2.UseVisualStyleBackColor = true;
            // 
            // radio_1
            // 
            this.radio_1.AutoSize = true;
            this.radio_1.Location = new System.Drawing.Point(20, 20);
            this.radio_1.Name = "radio_1";
            this.radio_1.Size = new System.Drawing.Size(166, 17);
            this.radio_1.TabIndex = 3;
            this.radio_1.TabStop = true;
            this.radio_1.Text = "light effort , slow (10-11.9mph)";
            this.radio_1.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_submit.Location = new System.Drawing.Point(56, 271);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(295, 31);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metrics of each Exercise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Activity  :  ";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Items.AddRange(new object[] {
            "Bicycling",
            "Running",
            "Swimming",
            "Walking",
            "Aerobic",
            "Rope Jumping"});
            this.list.Location = new System.Drawing.Point(85, 57);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(121, 21);
            this.list.TabIndex = 0;
            this.list.Text = "Bicycling";
            this.list.SelectedIndexChanged += new System.EventHandler(this.selected_changed);
            // 
            // btn_change_data
            // 
            this.btn_change_data.Location = new System.Drawing.Point(16, 452);
            this.btn_change_data.Name = "btn_change_data";
            this.btn_change_data.Size = new System.Drawing.Size(174, 32);
            this.btn_change_data.TabIndex = 22;
            this.btn_change_data.Text = "Change Body Weight And Goal";
            this.btn_change_data.UseVisualStyleBackColor = true;
            this.btn_change_data.Click += new System.EventHandler(this.btn_change_data_Click);
            // 
            // lbl_alert
            // 
            this.lbl_alert.AutoSize = true;
            this.lbl_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert.Location = new System.Drawing.Point(117, 27);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(173, 16);
            this.lbl_alert.TabIndex = 25;
            this.lbl_alert.Text = "Please Fill Weight and Goal";
            this.lbl_alert.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1114, 496);
            this.Controls.Add(this.btn_change_data);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.recordChart);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_goal);
            this.Controls.Add(this.lbl_weight);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.recordChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbdata.ResumeLayout(false);
            this.gbdata.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_goal;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DataVisualization.Charting.Chart recordChart;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.RadioButton radio_3;
        private System.Windows.Forms.RadioButton radio_2;
        private System.Windows.Forms.RadioButton radio_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox list;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_change_data;
        private System.Windows.Forms.GroupBox gbdata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.ComboBox Cmb_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_goal;
        private System.Windows.Forms.Label lbl_alert;
    }
}