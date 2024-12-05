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
            ChangeNoText();
        }

        public StreamReader rQuestions = new StreamReader("questions.txt");
        public char[] answers = new char[5];
        public char[] rAnswers = new char[5];
        public int questionCount = 1,count=0, countRightAnswers = 0;
        public int remaining = 5;

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


        public void WriteResults()
        {
            StreamReader r = new StreamReader("answers.txt");
            string line;
            int counter = 0;
            while ((line = r.ReadLine()) != null)
            {
                rAnswers[counter] = char.Parse(line);
                counter++;
            }

            StreamWriter w = new StreamWriter("results.txt", false);
            for(int i=0;i<answers.Length; i++)
            {
                if(answers[i] == rAnswers[i])
                {
                    w.WriteLine($"✔{answers[i]})");
                    countRightAnswers++;
                }
                else w.WriteLine($"✘{answers[i]}) --> {rAnswers[i]})");
            }
            w.Write($"{countRightAnswers}/5");
            w.Close();
        }

        public void ChangeNoText()
        {
            remainingQuestionsText.Text = $"Оставащи въпроси: {remaining}";
            questionNoText.Text = $"Въпрос {questionCount++}";
        }
        private void nextQuestion_Click(object sender, EventArgs e)
        {

            if (count != 4)
            {
                if (!a.Checked && !b.Checked && !v.Checked && !g.Checked) MessageBox.Show("Маркирай отговор!");
                else
                {
                    NextQuestion();
                    AddAnswer(count);
                    remaining--;
                    count++;
                    ChangeNoText();
                }
            }
            else
            {
                WriteResults();
                this.Close();
            }
        }
    }
}
