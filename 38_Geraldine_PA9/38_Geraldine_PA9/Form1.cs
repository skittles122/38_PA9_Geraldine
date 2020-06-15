using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38_Geraldine_PA9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double UserInput;
        public double ConvertedAmt;
        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {

                if (UserInput < 0)
                {
                    txt_Amount.Text = "Please enter a valid amount!";
                }
                else
                {
                    UserInput = double.Parse(txt_Amount.Text);
                    if (rb_US.Checked)
                    {
                        ConvertedAmt = (UserInput * 0.74);
                        txt_Converted.Text = ConvertedAmt.ToString();
                    }
                    else if (rb_Yen.Checked)
                    {
                        ConvertedAmt = (UserInput * 81.97);
                        txt_Converted.Text = ConvertedAmt.ToString();
                    }
                    //else if (rb_Ringgit.Checked)
                    //{
                    //    ConvertedAmt = (UserInput * 3.01);
                    //    txt_Converted.Text = ConvertedAmt.ToString();

                    //}
                    else
                    {
                        txt_Converted.Text = "Please Select Currency!";
                    }
                }
            }
            catch (FormatException)
            {
                txt_Amount.Text = "Please enter a valid amount!";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
            rb_US.Checked = false;
            rb_Yen.Checked = false;
        }
    }
}
