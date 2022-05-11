using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lab6
{
    interface Iboi
    {
        int[] CompareTO(Guest guest1, Guest guest2); 
    }

    interface Iboii
    {
        int[] CompareTO(Guest guest1, Guest guest2);
    }

    class Guest:Iboi, Iboii
    {
        protected string Last_name;
        protected string From_where;
        protected double Cost_stay_per_day;
        protected int[] Day_month_settlement = new int[2];

        public Guest(string Last_name, string From_where, double Cost_stay_per_day, int[] Day_month_settlement)
        {
            this.Last_name = Last_name;
            this.From_where = From_where;
            this.Cost_stay_per_day = Cost_stay_per_day;
            this.Day_month_settlement[0] = Day_month_settlement[0];
            this.Day_month_settlement[1] = Day_month_settlement[1];
        }

        int[] Iboi.CompareTO(Guest guest1, Guest guest2)
        {
            int[] array = new int[5];

            array[0] = guest1.Last_name.CompareTo(guest2.Last_name);
            array[1] = guest1.From_where.CompareTo(guest2.From_where);
            array[2] = guest1.Cost_stay_per_day.CompareTo(guest2.Cost_stay_per_day);
            array[3] = guest1.Day_month_settlement[0].CompareTo(guest2.Day_month_settlement[0]);
            array[4] = guest1.Day_month_settlement[1].CompareTo(guest2.Day_month_settlement[1]);

            return array;
        }

        int[] Iboii.CompareTO(Guest guest1, Guest guest2)
        {
            int[] array = new int[5];

            array[0] = guest1.Last_name.CompareTo(guest2.Last_name);
            array[1] = guest1.From_where.CompareTo(guest2.From_where);
            array[2] = guest1.Cost_stay_per_day.CompareTo(guest2.Cost_stay_per_day);
            array[3] = guest1.Day_month_settlement[0].CompareTo(guest2.Day_month_settlement[0]);
            array[4] = guest1.Day_month_settlement[1].CompareTo(guest2.Day_month_settlement[1]);

            return array;
        }

        public int[] ClassCompareTO1(Guest guest1, Guest guest2)
        {
            return ((Iboi)this).CompareTO(guest1, guest2);
        }

        public int[] ClassCompareTO2(Guest guest1, Guest guest2)
        {
            return ((Iboii)this).CompareTO(guest1, guest2);
        }

        public void Name_Outputter(Guest[] guest, TextBox textbox)
        {
            for(int i = 0; i < guest.Length; i++)
            {
                if (textbox.Text == "")
                {
                    textbox.Text = "Record " + (i + 1) + ": \r\n" +
                                   "  Last name = " + guest[i].Last_name + "\r\n" +
                                   "  From Where = " + guest[i].From_where + "\r\n" +
                                   "  Cost = " + guest[i].Cost_stay_per_day + "\r\n" +
                                   "  Day and Month = " + guest[i].Day_month_settlement[0] + " " + guest[0].monthfinda(Convert.ToInt32(guest[i].Day_month_settlement[1])) +
                                   "\r\n";
                }
                else
                {
                    textbox.Text = textbox.Text + "------------------------------------\r\n" +
                                   "Record " + (i + 1) + ": \r\n" +
                                   "  Last name = " + guest[i].Last_name + "\r\n" +
                                   "  From Where = " + guest[i].From_where + "\r\n" +
                                   "  Cost = " + guest[i].Cost_stay_per_day + "\r\n" +
                                   "  Day and Month = " + guest[i].Day_month_settlement[0] + " " + guest[0].monthfinda(Convert.ToInt32(guest[i].Day_month_settlement[1])) +
                                   "\r\n";
                }
            }
        }

        public void Tester(Guest[] guest, TextBox textbox)
        {
            textbox.Text = "";
            textbox.Text = textbox.Text + guest[0].Iterator(guest, 0, 1);
            textbox.Text = textbox.Text + guest[0].Iterator(guest, 0, 2);
            textbox.Text = textbox.Text + guest[0].Iterator(guest, 1, 2);
        }

        public string Iterator(Guest[] guest, int a, int b)
        {
            int[] dummy = guest[0].ClassCompareTO1(guest[a], guest[b]);
            string[] result = new string[6];

            for (int i = 0; i < dummy.Length; i++)
            {
                if (dummy[i] == 0)
                {
                    result[i] = "same";
                }
                else
                {
                    result[i] = "different";
                }
            }

            result[5] = "Comparing " + guest[a].Last_name + " to " + guest[b].Last_name + " using first compare method\r\n" +
                        "   Names are " + result[0] + ".\r\n" +
                        "   From Where is " + result[1] + ".\r\n" +
                        "   Cost stay per day is " + result[2] + ".\r\n" +
                        "   Day of settlement is " + result[3] + ".\r\n" +
                        "   Month of settlement is " + result[4] + ".\r\n";


            dummy = guest[0].ClassCompareTO1(guest[a], guest[b]);
            for (int i = 0; i < dummy.Length; i++)
            {
                if (dummy[i] == 0)
                {
                    result[i] = "same";
                }
                else
                {
                    result[i] = "different";
                }
            }

            result[5] = result[5] + "\r\nComparing " + guest[a].Last_name + " to " + guest[b].Last_name + " using second compare method\r\n" +
                        "   Names are " + result[0] + ".\r\n" +
                        "   From Where is " + result[1] + ".\r\n" +
                        "   Cost stay per day is " + result[2] + ".\r\n" +
                        "   Day of settlement is " + result[3] + ".\r\n" +
                        "   Month of settlement is " + result[4] + ".\r\n\r\n" +
                        "----------------------------------------------------\r\n\r\n";


            return result[5];
        }

        public string monthfinda(int i) 
        {
            string result = "";
            switch (i)
            {
                case (1):
                    result = "Januvary";
                    break;
                case (2):
                    result = "Febuary";
                    break;
                case (3):
                    result = "March";
                    break;
                case (4):
                    result = "April";
                    break;
                case (5):
                    result = "May";
                    break;
                case (6):
                    result = "June";
                    break;
                case (7):
                    result = "July";
                    break;
                case (8):
                    result = "August";
                    break;
                case (9):
                    result = "September";
                    break;
                case (10):
                    result = "October";
                    break;
                case (11):
                    result = "November";
                    break;
                case (12):
                    result = "December";
                    break;
            }
            return result;
        }
    }
}
