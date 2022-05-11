using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        Guest[] guests = new Guest[3]; 

        public Form1()
        {
            InitializeComponent();
            radioButton_save.Checked = true;
            label_count.Text = "0";
            label_total.Text = "3";
            groupBox_saver.Visible = true;
            groupBox_compare.Visible = false;
            label_error.Visible = false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            
            double dummy_double;
            int[] dummy_intarr = new int[2];
            string[] dummy_string = textBox_day_month_settlement.Text.Split();

            if (textBox_family_name.Text == "")
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 22);
                label_error.Text = "Error 1: Family Name can \r\nnot be empty";
            }
            else if (textBox_from_where.Text == "")
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 67);
                label_error.Text = "Error 2: From Where can \r\nnot be empty";
            }
            else if(textBox_cost_stay_per_day.Text == "")
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 111);
                label_error.Text = "Error 3: Cost per stay can \r\nnot be empty";
            }
            else if (!double.TryParse(textBox_cost_stay_per_day.Text, out dummy_double))
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 111);
                label_error.Text = "Error 4: Cost per stay must \r\nbe a double";
            }
            else if (dummy_string.Length < 2)
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 157);
                label_error.Text = "Error 5: Day Month requires \r\n2 inputs";
            }
            else if (!int.TryParse(dummy_string[0], out dummy_intarr[0]))
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 157);
                label_error.Text = "Error 6: Day must be \r\nan integer";
            }
            else if (!int.TryParse(dummy_string[1], out dummy_intarr[1]))
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 157);
                label_error.Text = "Error 7: Month must be \r\nan integer";
            }
            else if (Convert.ToInt32(dummy_string[0]) < 0)
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 157);
                label_error.Text = "Error 8: Day can not be \r\na negative number";
            }
            else if (Convert.ToInt32(dummy_string[1]) < 0)
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 157);
                label_error.Text = "Error 9: Month can not be \r\na negative number";
            }            
            else if (Convert.ToInt32(dummy_string[1]) > 12)
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 157);
                label_error.Text = "Error 10: Month can not be \r\ngreater than 12";
            }
            else if(Convert.ToInt32(dummy_string[1]) == 2 && Convert.ToInt32(dummy_string[0]) > 29)
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 157);
                label_error.Text = "Error 11: Day can not be \r\ngreater than 29";
            }
            else if ((Convert.ToInt32(dummy_string[1]) == 1 || Convert.ToInt32(dummy_string[1]) == 3 || Convert.ToInt32(dummy_string[1]) == 5 || Convert.ToInt32(dummy_string[1]) == 7 || Convert.ToInt32(dummy_string[1]) == 8 || Convert.ToInt32(dummy_string[1]) == 10 || Convert.ToInt32(dummy_string[1]) == 12) && (Convert.ToInt32(dummy_string[0]) > 31))
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 157);
                label_error.Text = "Error 12: Day can not be \r\ngreater than 31";
            }
            else if ((Convert.ToInt32(dummy_string[1]) == 4 || Convert.ToInt32(dummy_string[1]) == 6 || Convert.ToInt32(dummy_string[1]) == 9 || Convert.ToInt32(dummy_string[1]) == 11) && (Convert.ToInt32(dummy_string[0]) > 30))
            {
                label_error.Visible = true;
                label_error.Location = new Point(475, 157);
                label_error.Text = "Error 13: Day can not be \r\ngreater than 30";
            }
            else
            {
                guests[Convert.ToInt32(label_count.Text)] = new Guest(textBox_family_name.Text, textBox_from_where.Text, dummy_double, dummy_intarr);
                label_count.Text = Convert.ToString(Convert.ToInt32(label_count.Text) + 1);
                    
                textBox_family_name.Text = "";
                textBox_from_where.Text = "";
                textBox_cost_stay_per_day.Text = "";
                textBox_day_month_settlement.Text = "";

                if(label_count.Text == "3")
                {
                    radioButton_compare.Checked = true;
                }
            }
        }

        private void radioButton_save_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_saver.Visible = true;
            groupBox_compare.Visible = false;
            label_count.Text = "0";
        }

        private void radioButton_compare_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_compare.Visible = true;
            groupBox_saver.Visible = false;

            if(guests[2] == null)
            {
                radioButton_save.Checked = true;
            }
            else
            {               
                guests[0].Name_Outputter(guests, textBox_all_data);

                guests[0].Tester(guests, textBox_output);
            }
        }

        private void textBox_family_name_TextChanged(object sender, EventArgs e)
        {
            label_error.Visible = false;
        }

        private void textBox_from_where_TextChanged(object sender, EventArgs e)
        {
            label_error.Visible = false;
        }

        private void textBox_cost_stay_per_day_TextChanged(object sender, EventArgs e)
        {
            label_error.Visible = false;
        }

        private void textBox_day_month_settlement_TextChanged(object sender, EventArgs e)
        {
            label_error.Visible = false;
        }
    }
}
