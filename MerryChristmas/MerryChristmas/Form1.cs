using System.IO;
using System.Globalization;

namespace MerryChristmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public StreamReader r;
        public string style;
        public string[] names;
        string dateTime = DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss");

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked)
                MessageBox.Show("Моля изберете тип!");

            else if (!radioButton6.Checked && !radioButton7.Checked)
                MessageBox.Show("Моля изберете имената!");

            else if (richTextBox2.Text == string.Empty)
                MessageBox.Show("Моля въведете имената!");
            
            else if (radioButton6.Checked)
            {
                Directory.CreateDirectory($"messages\\{dateTime}");
                names = richTextBox2.Lines;
                foreach(string name in names)
                {
                    StreamWriter w = new StreamWriter($"messages\\{dateTime}\\{name}.txt");
                    w.Write($"{style.Replace("{name}",name)}");
                    w.Close();
                }
                MessageBox.Show($"Съобщенията са генерирани и са запазени на: C:\\Users\\КрумМанолов\\source\\repos\\MerryChristmas\\MerryChristmas\\bin\\Debug\\net8.0-windows\\messages\\{dateTime}");

            }
            else if (radioButton7.Checked)
            {
                
            }
        }

        public void previewChange(int num)
        {
            r = new StreamReader($"types\\{num}.txt");
            style = r.ReadToEnd();
            richTextBox1.Text = style;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            previewChange(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            previewChange(2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            previewChange(3);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            previewChange(4);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            previewChange(5);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Моля въведете имената:";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Моля, въведете пътят до текстоия файл";
        }
    }
}
