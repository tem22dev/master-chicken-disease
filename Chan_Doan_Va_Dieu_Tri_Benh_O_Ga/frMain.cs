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
        

        private Start startController;
        private Question questionController;
        private ResultController resultController;
        public frMain()
        {
            InitializeComponent();

            startController = new Start(this);
            questionController = new Question(this);
            resultController = new ResultController(this);

            panelMain.Controls.Add(startController);
        }

        public void BackToStart()
        {
            Controls.Clear();

            Controls.Add(startController);
        }

        public void setResult(string disease)
        {
            Controls.Clear();

            resultController.setDisease(disease);

            Controls.Add(resultController);
        }

        public void Start()
        {
            Controls.Clear();

            questionController.reset();

            Controls.Add(questionController);
        }
    }
}
