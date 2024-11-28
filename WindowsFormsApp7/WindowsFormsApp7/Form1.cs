using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NextQuestion();
        }

        public StreamReader rQuestions = new StreamReader("questions.txt");
        public StreamReader rAnswers = new StreamReader("answers.txt");
        public char[] answers = new char[5];
        public char[] realAnswers = new char[5];
        public int count = 0;

        public void NextQuestion()
        {
            questionText.Clear();
            questionText.AppendText($@"{rQuestions.ReadLine()}
а) {rQuestions.ReadLine()}
б) {rQuestions.ReadLine()}
в) {rQuestions.ReadLine()}
г) {rQuestions.ReadLine()}");     
        }

        public void AddAnswer(int num)
        {
            if (a.Checked)
            {
                answers[num] = 'а';
                a.Checked = false;
            }
            else if (b.Checked)
            {
                answers[num] = 'б';
                b.Checked = false;
            }
            else if (v.Checked)
            {
                answers[num] = 'в';
                v.Checked = false;
            }
            else
            {
                answers[num] = 'г';
                g.Checked = false;
            }
        }

        private void nextQuestion_Click(object sender, EventArgs e)
        {

            if (count == 4)
            {
                if (!a.Checked && !b.Checked && !v.Checked && !g.Checked) MessageBox.Show("Маркирай отговор!");
                else
                {
                    NextQuestion();
                    AddAnswer(count);
                    count++;
                }
            }
            else
            {
                string line = "";
                int right = 0;
                for (int i=0; line != null;i++)
                {
                    line = rAnswers.ReadLine();
                    realAnswers[i] = char.Parse(line);
                    if (realAnswers[i] == answers[i]) right++;
                }

                questionText.AppendText($"{right}/5");

            }
        }
    }
}
