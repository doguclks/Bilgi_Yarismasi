namespace Bigli_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnA.Enabled= false;
            BtnB.Enabled= false;
            BtnC.Enabled= false;
            BtnD.Enabled= false;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnBasla.Enabled = true;

            
            label4.Text = BtnB.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnBasla.Enabled = true;

            
            label4.Text = BtnC.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnBasla.Enabled = true;
            

            
            label4.Text = BtnD.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;  
            BtnD.Enabled = false;
            BtnBasla.Enabled = true;

            
            label4.Text = BtnA.Text;
            if(label2.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnBasla.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            BtnBasla.Text = "SONRAKI";
            soruno++;
            LblSoru.Text = soruno.ToString();


            if(soruno == 1)
            {
                richTextBox1.Text = "Turkiye'nin baskenti neresidir? ";

                BtnA.Text = "Ankara";
                BtnB.Text = "Bursa";
                BtnC.Text = "Istanbul";
                BtnD.Text = "Izmir";

                label2.Text = "Ankara";
            }
            if(soruno == 2)
            {
                richTextBox1.Text = "'Calikusu' hangi yazara aittir ?";

                BtnA.Text = "Orhan Veli";
                BtnB.Text = "Sait Faik Abasiyanik";
                BtnC.Text = "Resat Nuri Guntekin";
                BtnD.Text = "Rifat Ilgaz";

                label2.Text = "Resat Nuri Guntekin";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Cumhuriyet kac yilinda ilan edilmistir? ";

                BtnA.Text = "1920";
                BtnB.Text = "1938";
                BtnC.Text = "1921";
                BtnD.Text = "1923";

                label2.Text = "1923";
                BtnBasla.Text = "SONUCLAR";
            }
            if (soruno == 4)
            {
                BtnA.Enabled= false;
                BtnB.Enabled= false;
                BtnC.Enabled= false;
                BtnD.Enabled= false;
                BtnBasla.Enabled = false;

                MessageBox.Show("Dogru = " + dogru + "\n" + "Yanlis " + yanlis);

            }
        }
    }
}