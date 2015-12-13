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
    public partial class L1 : Form
    {
        public L1()
        {
            InitializeComponent();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void L1_Load(object sender, EventArgs e)
        {

        }

        private void st()
        {
            Point p;
            p = label1.Location;
            p.Offset(label1.Width / 2, label1.Height / 2);
            Cursor.Position =PointToScreen(p);
        }

        private void L1_Shown(object sender, EventArgs e)
        {
            st();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
