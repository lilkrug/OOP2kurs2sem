using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_1_laba
{
    public partial class Form1 : Form, ICalc
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Калькулятор размеров";

            this.Size = new Size(800, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            this.BackgroundImage = Image.FromFile("C:\\Users\\lilkr\\Downloads\\1616525300_1-p-krutoi-fon-1.jpg");
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void button1_Click(object sender, EventArgs e)
        {
            double a;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                switch (comboBox1.Text)
                {
                    case "Европейские":
                        if (a == 0)
                        {
                            throw new Exception("Program krash!!!!!!!!!!!");
                        }
                        textBox2.Text = Convert.ToString(a * 2);
                        break;
                    case "Русские":
                        if (a == 0)
                        {
                            throw new Exception("Program krash!!!!!!!!!!!");
                        }
                        textBox2.Text = Convert.ToString(a * 3);
                        break;
                    case "Американские":
                        if (a == 0)
                        {
                            throw new Exception("Program krash!!!!!!!!!!!");
                        }
                        textBox2.Text = Convert.ToString(a * 4);
                        break;
                    case "Британские":
                        if (a == 0)
                        {
                            throw new Exception("Program krash!!!!!!!!!!!");
                        }
                        textBox2.Text = Convert.ToString(a * 5);
                        break;
                }
            }
            catch (Exception)
            {
                    throw new Exception("Program krash!!!!!!!!!!!");
            }
            
            
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

       
    }
}
