using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_lotto
{
    public partial class Form1 : Form
    {
        //setup Variables
        int[] lucky_nums = new int[6];
        Label[] labels= new Label[6];

        //setup Randomiser
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void b_roll_Click(object sender, EventArgs e)
        {
            labels[0] = l_luckynum1;
            labels[1] = l_luckynum2;
            labels[2] = l_luckynum3;
            labels[3] = l_luckynum4;
            labels[4] = l_luckynum5;
            labels[5] = l_luckynum6;

            for (int i = 0; i < 6; i++)
            {
                lucky_nums[i] = rnd.Next(1,100);
                labels[i].Text = lucky_nums[i].ToString();
            }
        }
    }
}
