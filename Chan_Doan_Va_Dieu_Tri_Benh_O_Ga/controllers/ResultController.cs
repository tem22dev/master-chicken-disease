using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.utils.Constants;

namespace Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.controllers
{
    public partial class ResultController : UserControl
    {
        frMain main;
        public ResultController(frMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        public void setDisease(string disease)
        {
            labelDiseaseName.Text = DiseaseList.getQuestion(disease);
            richTextDT.Text = Rresult.getRresult(disease);
        }
            
            
        private void buttonBack_Click(object sender, EventArgs e)
        {
            main.BackToStart();
        }
    }
}
