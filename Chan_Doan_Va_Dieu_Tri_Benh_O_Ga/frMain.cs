using System;
using SbsSW.SwiPlCs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.controllers;

namespace Chan_Doan_Va_Dieu_Tri_Benh_O_Ga
{
    public partial class frMain : Form
    {
        

        private Start start;
        private Question question;
        public frMain()
        {
            InitializeComponent();

            start = new Start(this);
            question = new Question(this);

            panelMain.Controls.Add(start);
        }

        

        public void Start()
        {
            Controls.Clear();
            Controls.Add(question);
        }
    }
}
