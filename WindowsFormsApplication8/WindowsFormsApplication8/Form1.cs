using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string digit, Binary = "", Octa = "";
                int n, number;
                digit = textBox1.Text;
                n = digit.Length;
                for (int i = n - 1; i >= 0; i--)
                {
                    Binary = toBinary(digit[i]) + Binary;
                }

                while (Binary.Length % 3 != 0)
                {
                    Binary = "0" + Binary;
                }

                int L = Binary.Length;

                for (int i = 0; i < L; i = i + 3)
                {
                    Octa += toOcta(Binary.Substring(i, 3));

                }
                number = Convert.ToInt32(Octa);
                textBox2.Text = number.ToString();
            }
            catch(Exception){
                MessageBox.Show("onaltılı bir sayı giriniz");
            }
        }

        string toBinary(char x)
        {

            switch (x)
            {
                case '0':
                    return "0000";
                    break;
                case '1':
                    return "0001";
                    break;
                case '2':
                    return "0010";
                    break;
                case '3':
                    return "0011";
                    break;
                case '4':
                    return "0100";
                    break;
                case '5':
                    return "0101";
                    break;
                case '6':
                    return "0110";
                    break;
                case '7':
                    return "0111";
                    break;
                case '8':
                    return "1000";
                    break;
                case '9':
                    return "1001";
                    break;
                case 'A':
                    return "1010";
                    break;
                case 'B':
                    return "1011";
                    break;
                case 'C':
                    return "1100";
                    break;
                case 'D':
                    return "1101";
                    break;
                case 'E':
                    return "1110";
                    break;
                case 'F':
                    return "1111";
                    break;
                case 'a':
                    return "1010";
                    break;
                case 'b':
                    return "1011";
                    break;
                case 'c':
                    return "1100";
                    break;
                case 'd':
                    return "1101";
                    break;
                case 'e':
                    return "1110";
                    break;
                case 'f':
                    return "1111";
                    break;
                default:
               
                return "";
                    break;

            }

        }
        string toOcta(string bin)
        {
            switch (bin)
            {
                case "000":
                    return "0";
                    break;
                case "001":
                    return "1";
                    break;
                case "010":
                    return "2";
                    break;
                case "011":
                    return "3";
                    break;
                case "100":
                    return "4";
                    break;
                case "101":
                    return "5";
                    break;
                case "110":
                    return "6";
                    break;
                case "111":
                    return "7";
                    break;
                default:
                    
                  return "";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}