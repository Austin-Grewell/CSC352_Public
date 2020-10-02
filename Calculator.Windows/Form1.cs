using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "0";
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += ".";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "+";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            this.inputBox.Text += "/";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            //for now
            this.inputBox.Text += "=";
            //complete all operations
        }

        private void buttonReciprocal_Click(object sender, EventArgs e)
        {
            // 1/x reciprocation
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            // take things as a percent
        }

        private void buttonSqRoot_Click(object sender, EventArgs e)
        {
            // take the sqr root
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // clear one at a time
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // delete the window
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"Received {e.KeyCode}");

            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    {
                        button0_Click(sender, e);
                        break;
                    }
                case Keys.D1:
                case Keys.NumPad1:
                    {
                        button1_Click(sender, e);
                        break;
                    }
                case Keys.D2:
                case Keys.NumPad2:
                    {
                        button2_Click(sender, e);
                        break;
                    }
                case Keys.D3:
                case Keys.NumPad3:
                    {
                        button3_Click(sender, e);
                        break;
                    }
                case Keys.D4:
                case Keys.NumPad4:
                    {
                        button4_Click(sender, e);
                        break;
                    }
                case Keys.D5:
                case Keys.NumPad5:
                    {
                        button5_Click(sender, e);
                        break;
                    }
                case Keys.D6:
                case Keys.NumPad6:
                    {
                        button6_Click(sender, e);
                        break;
                    }
                case Keys.D7:
                case Keys.NumPad7:
                    {
                        button7_Click(sender, e);
                        break;
                    }
                case Keys.D8:
                    {
                        if (e.Shift)
                        {
                            buttonMultiply_Click(sender, e);
                        }
                        else
                        {
                            button8_Click(sender, e);
                        }

                        break;
                    }
                case Keys.NumPad8:
                    {
                        button8_Click(sender, e);
                        break;
                    }
                case Keys.D9:
                case Keys.NumPad9:
                    {
                        button9_Click(sender, e);
                        break;
                    }
                case Keys.Oemplus:
                    {
                        if(e.Shift)
                        {
                            buttonAdd_Click(sender, e);
                        }
                        else
                        {
                            buttonEquals_Click(sender, e);
                        }

                        break;
                    }
            }
        }
    }
}
