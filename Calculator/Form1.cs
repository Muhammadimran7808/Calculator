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
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public partial class mainForm : Form
    {    
        Double firstNum, secondNum, result;
        char oper;
        string path = @"C:\Users\Public\myFile.txt";


        public mainForm()
        {
            InitializeComponent();
        }   

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                
                txtbox.Text = "1";
            }
            else
            {
                txtbox.Text = txtbox.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "2";
            }
            else
            {
                txtbox.Text = txtbox.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "3";
            }
            else
            {
                txtbox.Text = txtbox.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "4";
            }
            else
            {
                txtbox.Text = txtbox.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "5";
            }
            else
            {
                txtbox.Text = txtbox.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "6";
            }
            else
            {
                txtbox.Text = txtbox.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "7";
            }
            else
            {
                txtbox.Text = txtbox.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "8";
            }
            else
            {
             
                txtbox.Text = txtbox.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "9";
            }
            else
            {
                txtbox.Text = txtbox.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "0";
            }
            else
            {
                txtbox.Text = txtbox.Text + "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbox.Text = "0";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtbox.Text);
            txtbox.Text = "0";
            oper = '+';
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtbox.Text);
            txtbox.Text = "0";
            oper = '-';
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtbox.Text);
            txtbox.Text = "0";
            oper = '*';
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtbox.Text);
            txtbox.Text = "0";
            oper = '/';
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            firstNum= Convert.ToDouble(txtbox.Text);
            txtbox.Text = "0";
            oper = '%';
        }

        private void btnRslt_Click(object sender, EventArgs e)
        {   
                secondNum = Convert.ToDouble(txtbox.Text);
                if (oper == '+')
                {
                    result = firstNum + secondNum;
                    txtbox.Text =Convert.ToString(result);
                }
                else if (oper == '-')
                {
                    result = firstNum - secondNum;
                    txtbox.Text = Convert.ToString(result);
                }
                else if (oper == '*')
                {
                    result = firstNum * secondNum;
                    txtbox.Text = Convert.ToString(result);
                }
                else if(oper == '/')
                {
                    result = firstNum / secondNum;
                    txtbox.Text = result.ToString("N3");
                }
                else
                {
                    result = firstNum % secondNum;
                    txtbox.Text = result.ToString("N3");
                }
                
        
            // creating file to store all the calculation in file
            FileInfo file = new FileInfo(path);
            StreamWriter writer = file.AppendText();
            writer.WriteLine(string.Concat(firstNum , oper , secondNum," = ",result));
            writer.Close();
            // showing calculation records in text box
            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str;
                str= reader.ReadToEnd();
                txtHistory.Text = str;
                reader.Close();
            }
           
        }

        private void btnSq_Click(object sender, EventArgs e)
        {
            double num, squar;
            num = Convert.ToDouble(txtbox.Text);
            squar = num * num;
            txtbox.Text =Convert.ToString(squar);
            
            FileInfo file = new FileInfo(path);
            StreamWriter writer = file.AppendText();
            writer.WriteLine(string.Concat(num," * ", num, " = ", squar));
            writer.Close();

            // showing calculation records in text box
            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str = reader.ReadToEnd();
                txtHistory.Text = str;
                reader.Close();
            }
        }

        private void btnSqR_Click(object sender, EventArgs e)
        {
            double num, sqRt;
            num = Convert.ToDouble(txtbox.Text);
            sqRt = Math.Sqrt(num);
            txtbox.Text = Convert.ToString(sqRt);

            FileInfo file = new FileInfo(path);
            StreamWriter writer = file.AppendText();
            writer.WriteLine(string.Concat("√",num, " = ", sqRt));
            writer.Close();

            // showing calculation records in text box
            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str = reader.ReadToEnd();
                txtHistory.Text = str;
                reader.Close();
            }
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            if(txtbox.Text.Contains("."))
            {
            
            }
            else
            {
                txtbox.Text = txtbox.Text + ".";
            }
            
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            double num, cube;
            num = Convert.ToDouble(txtbox.Text);
            cube = Math.Pow(num,3);
            txtbox.Text = Convert.ToString(cube);

            FileInfo file = new FileInfo(path);
            StreamWriter writer = file.AppendText();
            writer.WriteLine(string.Concat(num,"^3 = ", cube));
            writer.Close();

            // showing calculation records in text box
            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str = reader.ReadToEnd();
                txtHistory.Text = str;
                reader.Close();
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtbox.Text = "0";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            int num;
            num = txtbox.Text.Length;
            if (num > 1)
            {
                txtbox.Text = txtbox.Text.Remove(num - 1, 1);
            }
            else
            {
                txtbox.Text = "0";
            }
        }

        private void clearHis_Click(object sender, EventArgs e)
        {
            txtHistory.Text = null;
        }

        private void delHistoryPer_Click(object sender, EventArgs e)
        {
            using (FileStream file = new FileStream(path, FileMode.Truncate))
            {
                txtHistory.Text = null;
            }
        }

        private void delHistoryPer_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Delete Permanent History", delHistoryPer);
            toolTip1.InitialDelay = 80;
        }


        private void mainForm_Load(object sender, EventArgs e) { this.Width = 507; txtbox.Width = 410; }

        private void standerdToolStripMenuItem_Click(object sender, EventArgs e) { this.Width = 507; txtbox.Width = 410; }
        

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e) { this.Width = 655; txtbox.Width = 550; }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCalc;
            exitCalc=MessageBox.Show("Confirm if you want to exit","Scientific Calculator",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(exitCalc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double angleInDegree = Convert.ToDouble(txtbox.Text);
            double angleInRadian = angleInDegree * (Math.PI / 180);
            result = Math.Sin(angleInRadian);
            txtbox.Text = Convert.ToString(result.ToString("N2"));

            // Creating file
            FileInfo file = new FileInfo(path);
            StreamWriter writer = file.AppendText();
            writer.WriteLine(string.Concat("sin(", angleInDegree, "°) = ", result.ToString("N2")));
            writer.Close();

            // showing calculation records in text box
            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str = reader.ReadToEnd();
                txtHistory.Text = str;
                reader.Close();
            }
        }
        private void btnCos_Click(object sender, EventArgs e)
        {
            double angleInDegree = Convert.ToDouble(txtbox.Text);
            double angleInRadian = angleInDegree * (Math.PI / 180);
            result = Math.Cos(angleInRadian);
            txtbox.Text = Convert.ToString(result.ToString("N2"));

            // Creating file
            FileInfo file = new FileInfo(path);
            StreamWriter writer = file.AppendText();
            writer.WriteLine(string.Concat("cos(", angleInDegree, "°) = ", result.ToString("N2")));
            writer.Close();

            // showing calculation records in text box
            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str = reader.ReadToEnd();
                txtHistory.Text = str;
                reader.Close();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double angleInDegree = Convert.ToDouble(txtbox.Text);
            if (angleInDegree == 90 || angleInDegree == 270)
            {
                double r = double.PositiveInfinity;
                result = Math.Tan(r);
                txtbox.Text = Convert.ToString(result.ToString("N4"));
            }
            else
            {
            double angleInRadian = angleInDegree * (Math.PI / 180);
            result = Math.Tan(angleInRadian);
            txtbox.Text = Convert.ToString(result.ToString("N4"));
            }

            // Creating file
            FileInfo file = new FileInfo(path);
            StreamWriter writer = file.AppendText();
            writer.WriteLine(string.Concat("tan(", angleInDegree, "°) = ", result.ToString("N2")));
            writer.Close();

            // showing calculation records in text box
            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str = reader.ReadToEnd();
                txtHistory.Text = str;
                reader.Close();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(txtbox.Text);
            result = Math.Log10(angle);
            txtbox.Text = Convert.ToString(result.ToString("N4"));

            // Creating file
            FileInfo file = new FileInfo(path);
            StreamWriter writer = file.AppendText();
            writer.WriteLine(string.Concat("log(", angle, ") = ", result.ToString("N2")));
            writer.Close();

            // showing calculation records in text box
            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str = reader.ReadToEnd();
                txtHistory.Text = str;
                reader.Close();
            }
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(txtbox.Text);
            result = Math.Log(angle);
            txtbox.Text = Convert.ToString(result.ToString("N4"));

            // Creating file
            FileInfo file = new FileInfo(path);
            StreamWriter writer = file.AppendText();
            writer.WriteLine(string.Concat("ln(", angle, ") = ", result.ToString("N2")));
            writer.Close();

            // showing calculation records in text box
            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str = reader.ReadToEnd();
                txtHistory.Text = str;
                reader.Close();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(txtbox.Text);
            result = angle * (Math.PI);
            txtbox.Text = Convert.ToString(result.ToString("N5"));

            // Creating file 
            FileInfo file = new FileInfo(path);
            StreamWriter writer = file.AppendText();
            writer.WriteLine(string.Concat(angle, "π = ", result.ToString("N4")));
            writer.Close();

            // showing calculation records in text box
            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str = reader.ReadToEnd();
                txtHistory.Text = str;
                reader.Close();
            }
        }

        private void btnOneBYx_Click(object sender, EventArgs e)
        {
             double num;
            num = Convert.ToDouble(txtbox.Text);
            txtbox.Text = Convert.ToString(1/num);

            FileInfo file = new FileInfo(path);
            StreamWriter writer = file.AppendText();
            writer.WriteLine(string.Concat("1/", num, " = ", 1/num));
            writer.Close();

            // showing calculation records in text box
            if (file.Exists){
                StreamReader reader = file.OpenText();
                string str = reader.ReadToEnd();
                txtHistory.Text = str;
                reader.Close();
            }
        }

    }

}
