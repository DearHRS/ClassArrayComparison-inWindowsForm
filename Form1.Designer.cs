namespace Lab6
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
            this.label_family_name = new System.Windows.Forms.Label();
            this.textBox_family_name = new System.Windows.Forms.TextBox();
            this.label_count = new System.Windows.Forms.Label();
            this.label_dash = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_from_where = new System.Windows.Forms.Label();
            this.textBox_from_where = new System.Windows.Forms.TextBox();
            this.label_cost_stay_per_day = new System.Windows.Forms.Label();
            this.textBox_cost_stay_per_day = new System.Windows.Forms.TextBox();
            this.label_day_month_settlement = new System.Windows.Forms.Label();
            this.textBox_day_month_settlement = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox_saver = new System.Windows.Forms.GroupBox();
            this.label_error = new System.Windows.Forms.Label();
            this.groupBox_compare = new System.Windows.Forms.GroupBox();
            this.textBox_all_data = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.groupBox_mode = new System.Windows.Forms.GroupBox();
            this.radioButton_compare = new System.Windows.Forms.RadioButton();
            this.radioButton_save = new System.Windows.Forms.RadioButton();
            this.groupBox_saver.SuspendLayout();
            this.groupBox_compare.SuspendLayout();
            this.groupBox_mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_family_name
            // 
            this.label_family_name.AutoSize = true;
            this.label_family_name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_family_name.Location = new System.Drawing.Point(107, 19);
            this.label_family_name.Name = "label_family_name";
            this.label_family_name.Size = new System.Drawing.Size(153, 32);
            this.label_family_name.TabIndex = 0;
            this.label_family_name.Text = "Family Name";
            // 
            // textBox_family_name
            // 
            this.textBox_family_name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_family_name.Location = new System.Drawing.Point(267, 19);
            this.textBox_family_name.Name = "textBox_family_name";
            this.textBox_family_name.Size = new System.Drawing.Size(202, 39);
            this.textBox_family_name.TabIndex = 1;
            this.textBox_family_name.TextChanged += new System.EventHandler(this.textBox_family_name_TextChanged);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_count.Location = new System.Drawing.Point(94, 225);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(27, 32);
            this.label_count.TabIndex = 0;
            this.label_count.Text = "0";
            // 
            // label_dash
            // 
            this.label_dash.AutoSize = true;
            this.label_dash.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_dash.Location = new System.Drawing.Point(120, 224);
            this.label_dash.Name = "label_dash";
            this.label_dash.Size = new System.Drawing.Size(23, 32);
            this.label_dash.TabIndex = 0;
            this.label_dash.Text = "/";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_total.Location = new System.Drawing.Point(142, 224);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(27, 32);
            this.label_total.TabIndex = 0;
            this.label_total.Text = "3";
            // 
            // label_from_where
            // 
            this.label_from_where.AutoSize = true;
            this.label_from_where.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_from_where.Location = new System.Drawing.Point(119, 64);
            this.label_from_where.Name = "label_from_where";
            this.label_from_where.Size = new System.Drawing.Size(141, 32);
            this.label_from_where.TabIndex = 0;
            this.label_from_where.Text = "From where";
            // 
            // textBox_from_where
            // 
            this.textBox_from_where.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_from_where.Location = new System.Drawing.Point(266, 64);
            this.textBox_from_where.Name = "textBox_from_where";
            this.textBox_from_where.Size = new System.Drawing.Size(202, 39);
            this.textBox_from_where.TabIndex = 1;
            this.textBox_from_where.TextChanged += new System.EventHandler(this.textBox_from_where_TextChanged);
            // 
            // label_cost_stay_per_day
            // 
            this.label_cost_stay_per_day.AutoSize = true;
            this.label_cost_stay_per_day.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_cost_stay_per_day.Location = new System.Drawing.Point(103, 108);
            this.label_cost_stay_per_day.Name = "label_cost_stay_per_day";
            this.label_cost_stay_per_day.Size = new System.Drawing.Size(157, 32);
            this.label_cost_stay_per_day.TabIndex = 0;
            this.label_cost_stay_per_day.Text = "Cost stay/day";
            // 
            // textBox_cost_stay_per_day
            // 
            this.textBox_cost_stay_per_day.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_cost_stay_per_day.Location = new System.Drawing.Point(266, 108);
            this.textBox_cost_stay_per_day.Name = "textBox_cost_stay_per_day";
            this.textBox_cost_stay_per_day.Size = new System.Drawing.Size(202, 39);
            this.textBox_cost_stay_per_day.TabIndex = 1;
            this.textBox_cost_stay_per_day.TextChanged += new System.EventHandler(this.textBox_cost_stay_per_day_TextChanged);
            // 
            // label_day_month_settlement
            // 
            this.label_day_month_settlement.AutoSize = true;
            this.label_day_month_settlement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_day_month_settlement.Location = new System.Drawing.Point(6, 154);
            this.label_day_month_settlement.Name = "label_day_month_settlement";
            this.label_day_month_settlement.Size = new System.Drawing.Size(255, 32);
            this.label_day_month_settlement.TabIndex = 0;
            this.label_day_month_settlement.Text = "Day Month settlement";
            // 
            // textBox_day_month_settlement
            // 
            this.textBox_day_month_settlement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_day_month_settlement.Location = new System.Drawing.Point(267, 154);
            this.textBox_day_month_settlement.Name = "textBox_day_month_settlement";
            this.textBox_day_month_settlement.Size = new System.Drawing.Size(202, 39);
            this.textBox_day_month_settlement.TabIndex = 1;
            this.textBox_day_month_settlement.TextChanged += new System.EventHandler(this.textBox_day_month_settlement_TextChanged);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_save.Location = new System.Drawing.Point(257, 216);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(211, 47);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // groupBox_saver
            // 
            this.groupBox_saver.Controls.Add(this.label_error);
            this.groupBox_saver.Controls.Add(this.textBox_family_name);
            this.groupBox_saver.Controls.Add(this.label_total);
            this.groupBox_saver.Controls.Add(this.button_save);
            this.groupBox_saver.Controls.Add(this.label_dash);
            this.groupBox_saver.Controls.Add(this.label_family_name);
            this.groupBox_saver.Controls.Add(this.label_count);
            this.groupBox_saver.Controls.Add(this.textBox_day_month_settlement);
            this.groupBox_saver.Controls.Add(this.label_from_where);
            this.groupBox_saver.Controls.Add(this.label_day_month_settlement);
            this.groupBox_saver.Controls.Add(this.textBox_from_where);
            this.groupBox_saver.Controls.Add(this.textBox_cost_stay_per_day);
            this.groupBox_saver.Controls.Add(this.label_cost_stay_per_day);
            this.groupBox_saver.Location = new System.Drawing.Point(32, 89);
            this.groupBox_saver.Name = "groupBox_saver";
            this.groupBox_saver.Size = new System.Drawing.Size(786, 288);
            this.groupBox_saver.TabIndex = 3;
            this.groupBox_saver.TabStop = false;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_error.Location = new System.Drawing.Point(475, 157);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(78, 32);
            this.label_error.TabIndex = 6;
            this.label_error.Text = "label1";
            // 
            // groupBox_compare
            // 
            this.groupBox_compare.Controls.Add(this.textBox_all_data);
            this.groupBox_compare.Controls.Add(this.textBox_output);
            this.groupBox_compare.Location = new System.Drawing.Point(3, 89);
            this.groupBox_compare.Name = "groupBox_compare";
            this.groupBox_compare.Size = new System.Drawing.Size(780, 406);
            this.groupBox_compare.TabIndex = 4;
            this.groupBox_compare.TabStop = false;
            // 
            // textBox_all_data
            // 
            this.textBox_all_data.Location = new System.Drawing.Point(573, 22);
            this.textBox_all_data.Multiline = true;
            this.textBox_all_data.Name = "textBox_all_data";
            this.textBox_all_data.Size = new System.Drawing.Size(194, 359);
            this.textBox_all_data.TabIndex = 1;
            // 
            // textBox_output
            // 
            this.textBox_output.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_output.Location = new System.Drawing.Point(34, 22);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(532, 359);
            this.textBox_output.TabIndex = 0;
            // 
            // groupBox_mode
            // 
            this.groupBox_mode.Controls.Add(this.radioButton_compare);
            this.groupBox_mode.Controls.Add(this.radioButton_save);
            this.groupBox_mode.Location = new System.Drawing.Point(32, 13);
            this.groupBox_mode.Name = "groupBox_mode";
            this.groupBox_mode.Size = new System.Drawing.Size(751, 70);
            this.groupBox_mode.TabIndex = 5;
            this.groupBox_mode.TabStop = false;
            // 
            // radioButton_compare
            // 
            this.radioButton_compare.AutoSize = true;
            this.radioButton_compare.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_compare.Location = new System.Drawing.Point(494, 22);
            this.radioButton_compare.Name = "radioButton_compare";
            this.radioButton_compare.Size = new System.Drawing.Size(129, 36);
            this.radioButton_compare.TabIndex = 0;
            this.radioButton_compare.TabStop = true;
            this.radioButton_compare.Text = "Compare";
            this.radioButton_compare.UseVisualStyleBackColor = true;
            this.radioButton_compare.CheckedChanged += new System.EventHandler(this.radioButton_compare_CheckedChanged);
            // 
            // radioButton_save
            // 
            this.radioButton_save.AutoSize = true;
            this.radioButton_save.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_save.Location = new System.Drawing.Point(83, 22);
            this.radioButton_save.Name = "radioButton_save";
            this.radioButton_save.Size = new System.Drawing.Size(82, 36);
            this.radioButton_save.TabIndex = 0;
            this.radioButton_save.TabStop = true;
            this.radioButton_save.Text = "Save";
            this.radioButton_save.UseVisualStyleBackColor = true;
            this.radioButton_save.CheckedChanged += new System.EventHandler(this.radioButton_save_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 541);
            this.Controls.Add(this.groupBox_saver);
            this.Controls.Add(this.groupBox_mode);
            this.Controls.Add(this.groupBox_compare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_saver.ResumeLayout(false);
            this.groupBox_saver.PerformLayout();
            this.groupBox_compare.ResumeLayout(false);
            this.groupBox_compare.PerformLayout();
            this.groupBox_mode.ResumeLayout(false);
            this.groupBox_mode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_family_name;
        private System.Windows.Forms.TextBox textBox_family_name;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_dash;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox textBox_from_where;
        private System.Windows.Forms.Label label_from_where;
        private System.Windows.Forms.Label label_cost_stay_per_day;
        private System.Windows.Forms.TextBox textBox_cost_stay_per_day;
        private System.Windows.Forms.Label label_day_month_settlement;
        private System.Windows.Forms.TextBox textBox_day_month_settlement;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.GroupBox groupBox_saver;
        private System.Windows.Forms.GroupBox groupBox_compare;
        private System.Windows.Forms.TextBox textBox_all_data;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.GroupBox groupBox_mode;
        private System.Windows.Forms.RadioButton radioButton_compare;
        private System.Windows.Forms.RadioButton radioButton_save;
        private System.Windows.Forms.Label label_error;
    }
}

