using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.utils;
using static Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.utils.Constants;

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

        // -1 chua hoi 0 sai 1 dung
        private int[] selectedsAnswer = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1};

        public Question(frMain main)
        {
            InitializeComponent();
            this.main = main;

            init();

            renderQuestion();

        }

        private void nextQuestion(bool answer)
        {
            selectedsAnswer[currentIndexQuestion] = answer ? 1 : 0;
            string yesAnswer = getYesAnswer();
            string noAnswer = getNoAnswer();

            string[] query = Query("disease(_, " + yesAnswer + ", " + noAnswer + ", X).");

            bool[] tempArr = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

            int count = 0;

            foreach (string item in query)
            {
                
                int[] intArr = HelpMethods.NumberStringToArr(item);
                foreach(int i in intArr)
                {
                    tempArr[i] = true;
                }
                count++;
            }

            if(count == 1)
            {
                string disease = myProlog.Query("disease(X,"+ yesAnswer + " ).");

                if (disease != "")
                {
                    main.setResult(disease);
                    return;
                }
                
            }

            for(int i = 1; i < tempArr.Length; i++)
            {
                if (tempArr[i] == false)
                {
                    selectedsAnswer[i] = 0;
                }
            }

            for(int i = 1; i < selectedsAnswer.Length; i++)
            {
                if (selectedsAnswer[i] == -1)
                {
                    currentIndexQuestion = i;
                    currentQuestion++;
                    return;
                }
            }
            main.setResult("null");
            return;
        }

        

        private void renderQuestion()
        {
            labelNumberQuestion.Text = "Câu "+ currentQuestion + ":";
            richTextBoxQuestion.Text = QuestionList.getQuestion(currentIndexQuestion);
        } 

        public void reset()
        {
            currentQuestion = 1;
            currentIndexQuestion = 1;

            // -1 chua hoi 0 sai 1 dung
            int[] arr = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1};
            selectedsAnswer = arr;
        }

        private void init()
        {
            myProlog = new MyProlog(prologFilePath);
        }

        private string getYesAnswer()
        {
            string str = "";

            int count = 0;

            foreach (int item in selectedsAnswer)
            {       
                if(item == 1)
                {
                    str += " " + count.ToString();
                }
                count++;
            }
            return "[" + str.Trim().Replace(" ", ",") + "]";
        }

        private string getNoAnswer()
        {
            string str = "";
            int count = 0;
            foreach (int item in selectedsAnswer)
            {
                if (item == 0)
                {
                    str += " " + count.ToString();
                }
                count++;
            }
            return "[" + str.Trim().Replace(" ", ",") + "]";
        }

        private string[] Query(string queryString)
        {
            return myProlog.Query(queryString).Trim().Split(' ');
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            nextQuestion(false);
            renderQuestion();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            nextQuestion(true);
            renderQuestion();
        }
    }
}
