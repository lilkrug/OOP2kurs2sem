
namespace ООП_2_laba
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {

            InitializeComponent();
            this.BackgroundImage = Image.FromFile("C:\\Users\\lilkr\\Downloads\\depositphotos_46935505-stock-photo-passenger-plane-take-off-from (1).jpg");
            this.Width = 1024;
            this.Height = 600;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
          
          



        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {
           
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://metanit.com");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            using (var fs = new StreamReader($"E:\\Education\\2 курс 2 сем\\ООП 2 сем\\ООП 2 laba\\Path.json"))
            {
                MessageBox.Show(fs.ReadToEnd());
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var fs = new StreamWriter($"E:\\Education\\2 курс 2 сем\\ООП 2 сем\\ООП 2 laba\\Path.json"))
            {
                if (radioButton1.Checked)
                {
                    radioButton1.Text = "250";
                }
                if (radioButton2.Checked)
                {
                    radioButton2.Text = "300";
                }
                if (radioButton3.Checked)
                {
                    radioButton3.Text = "200";
                }

               
                switch (comboBox1.Text)
                {
                    case "Boing 520":

                        break;
                    case "Boing 246":

                        break;
                    case "Boing 777 Long":

                        break;
                    case "AirPlane zxc":

                        break;
                }

                switch (comboBox2.Text)
                {
                    case "Пассажирский":

                        break;
                    case "Военный":

                        break;
                    case "Грузовой":

                        break;

                }

                switch (comboBox3.Text)
                {
                    case "2018":

                        break;
                    case "2019":

                        break;
                    case "2020":

                        break;
                    case "2021":

                        break;
                    case "2022":

                        break;
                }

                fs.WriteLine("Название самолёта: " + comboBox1.Text + "Тип самолёта: " + comboBox2.Text + "Год выпуска: " + comboBox3.Text + "Кол-во пассажирских мест: " + radioButton1);
                MessageBox.Show("Ввод сохранён");
            }
           
          
        }
    

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("Ваша дата: " + monthCalendar1.Name); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }
    }
}