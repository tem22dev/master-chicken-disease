using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.controllers
{
    public partial class Start : UserControl
    {
        private frMain main;
        public Start(frMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void batdau_Click(object sender, EventArgs e)
        {
            main.Start();
        }
    }
}
