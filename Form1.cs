using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeinCalc
{
    public partial class Form1 : Form
    {
        List<string> primeiroValor = new List<string> { }; //primeiro valor antes da expressão +
        string t1 = "";
        string t2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            if (tb_subResult.Text == "0")
            {
                string ValorFinal = tb_result.Text;
                string ValorNotAdc = ValorFinal.Remove(0, ValorFinal.Length - 1);

                if (ValorNotAdc != "+")
                {
                    foreach (var item in primeiroValor)
                    {
                        string ValorInicial = item;
                        ValorInicial = ValorInicial.Remove(item.Length - 1, 1); //Valor Inicial 
                        ValorFinal = ValorFinal.Remove(0, item.Length); //Valor final 

                        tb_subResult.Text = (int.Parse(ValorInicial) + int.Parse(ValorFinal)).ToString();
                    }
                }
            }
            else
            {
                string ValorFinal = tb_result.Text;
                foreach (var item in primeiroValor)
                {
                   
                    ValorFinal = ValorFinal.Remove(0, item.Length); //Valor final 
                    MessageBox.Show(ValorFinal);
                }

                MessageBox.Show(tb_subResult.Text);
            }
        }

        private void btn_one_Click(object sender, EventArgs e)   
        {
            btn_one.Text = "1";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "1";
            }
            else
            {
                tb_result.Text += btn_one.Text;
            }
          
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            tb_result.Text = "0";
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            btn_two.Text = "2";
            if (tb_result.Text == "0")
            {
                tb_result.Text = "2";
            }
            else
            {
                tb_result.Text += btn_two.Text;
            }
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            btn_three.Text = "3";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "3";
            }
            else
            {
                tb_result.Text += btn_three.Text;
            }
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            btn_four.Text = "4";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "4";
            }
            else
            {
                tb_result.Text += btn_four.Text;
            }
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            btn_five.Text = "5";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "5";
            }
            else
            {
                tb_result.Text += btn_five.Text;
            }
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            btn_six.Text = "6";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "6";
            }
            else
            {
                tb_result.Text += btn_six.Text;
            }
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            btn_seven.Text = "7";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "7";
            }
            else
            {
                tb_result.Text += btn_seven.Text;
            }
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            btn_eight.Text = "8";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "8";
            }
            else
            {
                tb_result.Text += btn_eight.Text;
            }
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            btn_zero.Text = "0";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "0";
            }
            else
            {
                tb_result.Text += btn_zero.Text;
            }
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            btn_nine.Text = "9";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "9";
            }
            else
            {
                tb_result.Text += btn_nine.Text;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            string MyResult = tb_result.Text;

            if (MyResult.Length > 0)
            {
                tb_result.Text = MyResult.Remove(MyResult.Length - 1, 1);
                string ValorNotAdc = MyResult.Remove(0, MyResult.Length - 1);

                if (ValorNotAdc == "+")
                {
                    primeiroValor.Clear();
                }
            }
            else
            {
                tb_result.Text = "0";
            }
           
        }

        private void btn_multp_Click(object sender, EventArgs e)
        {
            btn_nine.Text = "*";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "0";
            }
            else
            {
                tb_result.Text += btn_multp.Text;
            }
        }

        private void btn_substract_Click(object sender, EventArgs e)
        {
            btn_substract.Text = "-";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "0";
            }
            else
            {
                tb_result.Text += btn_substract.Text;
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            btn_division.Text = "÷";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "0";
            }
            else
            {
                tb_result.Text += btn_division.Text;
            }
        }

        private void btn_addition_Click(object sender, EventArgs e)
        {
            
            btn_addition.Text = "+";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "0";
            }
            else
            {  
                if (t1 == "")
                {
                    t1 = tb_result.Text;
                    lb_n1.Text = t1;
                }
                else
                {
                    t2 = tb_result.Text;
                    lb_n2.Text = t2;
                }
                tb_result.Text += btn_addition.Text;
                //if(primeiroValor.Count < 1)
                //{
                //    primeiroValor.Add(tb_result.Text);

                //}
                //else
                //{
                //    primeiroValor.Clear();
                //    primeiroValor.Add(tb_subResult.Text);
                //}
            }
        }
        private void btn_negat_Click(object sender, EventArgs e)
        {
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            btn_percent.Text = "%";

            if (tb_result.Text == "0")
            {
                tb_result.Text = "0";
            }
            else
            {
                tb_result.Text += btn_percent.Text;
            }
        }

        private void tb_result_TextChanged(object sender, EventArgs e)
        {
       
            if (tb_result.Text == "")
            {
                tb_result.Text = "0";
            }else 
            {
                if (tb_result.Text.Contains("+"))
                {
                    string str = tb_result.Text;
                    char[] arr;

                    arr = str.ToCharArray(0, str.Length);

                    foreach (char c in arr) {
                        if (c.ToString() == "+")
                        {
                            return;
                        }
                        t2 = tb_result.Text;
                        lb_n2.Text = tb_result.Text;
                    }
                     
                }
                
            }
           
        }
        private void Somar(string n1, string n2)
        {
            MessageBox.Show((int.Parse(n1) + int.Parse(n2)).ToString());
        }
    }
}
