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

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("..\\..\\input.txt");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string fileText = richTextBox2.Text;
            File.WriteAllText("..\\..\\output.txt", fileText);

            File.Copy("..\\..\\input.txt", "..\\..\\output.txt", true);
            File.WriteAllText("..\\..\\output.txt", File.ReadAllText("..\\..\\output.txt", Encoding.Default).Replace(". ", "\n"));
            richTextBox2.Text = File.ReadAllText("..\\..\\output.txt");

            MessageBox.Show("Данные успешно записаны в файл");
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
