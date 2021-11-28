using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akenator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            answer.Visible = false;
            label1.Visible = false;
        }
        int step = 0;
        void game() 
        {
            if (step == 0)
            {
                answer.Visible = true;
                label1.Visible = true;
                pictureBox1.Visible = false;
                Question.Text = "Это птсау?";
                button1.Text = "Следующий вопрос";
                step += 1;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            game();
        }
    }
}
