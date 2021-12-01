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
            else if (step == 1)
            {

                if (answer.Text.ToLower() == "да")
                {
                    Question.Text = "Это танк выше пятого уровня?";
                    step = 2;
                }
                else if (answer.Text.ToLower() == "нет")
                {
                    Question.Text = "Это тяжёлый танк?";
                    step = 4;
                }


            }
            else if (step == 2)
            {
                if (answer.Text.ToLower() == "да")
                {
                    Question.Text = "Это танк выше седьмого уровня?";
                    step = 3;
                }
                else if (answer.Text.ToLower() == "нет")
                {
                    Question.Text = "Это су78и";
                    pictureBox1.Visible = true;
                    answer.Visible = false;
                    label1.Visible = false;
                    pictureBox1.Image = Properties.Resources.Su76_nn;
                    step = 7;
                    button1.Text = "Сыграть еще раз";

                }
            }
            else if (step == 3)
            {
                if (answer.Text.ToLower() == "да")
                {
                    Question.Text = "Это ису 152";
                    pictureBox1.Visible = true;
                    answer.Visible = false;
                    label1.Visible = false;
                    pictureBox1.Image = Properties.Resources.Su76_nn;
                    step = 7;
                    button1.Text = "Сыграть еще раз";
                }
                else if(answer.Text.ToLower() == "нет")
                {
                    Question.Text = "Это су 100";
                    pictureBox1.Visible = true;
                    answer.Visible = false;
                    label1.Visible = false;
                    pictureBox1.Image = Properties.Resources.Su76_nn;
                    step = 7;
                    button1.Text = "Сыграть еще раз";
                }
            }
            if (step == 7)
            {
                step = 0;
                
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
