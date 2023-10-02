using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.controllers
{
    public partial class Question : UserControl
    {
        private MyProlog myProlog;
        private const String prologFilePath = @"..\..\benh_o_ga.pl";

        private frMain main;

        //main
        private int currentQuestion = 1;
        private int currentIndexQuestion = 1;
        private int[] selectesAnswer = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

        public Question(frMain main)
        {
            InitializeComponent();
            this.main = main;

            init();
        }

        private void nextQuestion()
        {

        }

        private void init()
        {
            myProlog = new MyProlog(prologFilePath);



            foreach (string item in Query("benh(_, X)."))
            {
                string str = Regex.Replace(item, @"[,\[\]]" , " ");
                string[] arr = str.Trim().Split(' ');
                
                foreach (string n in arr)
                {
                    MessageBox.Show(n);
                }
            }
        }

        private string[] Query(string queryString)
        {
            return myProlog.Query(queryString).Trim().Split(' ');
        }
    }
}
