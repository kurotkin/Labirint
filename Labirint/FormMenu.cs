using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Sound.play_start();
            start_L1();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Sound.soundOn();
                checkBox1.Text = "Звук включен";
                Sound.play_fail();
            }
            else
            {
                Sound.soundOf();
                checkBox1.Text = "Звук выключен";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void start_L1()
        {
            L1 lavel1 = new L1();
            lavel1.ShowDialog();
        }
    }
}
