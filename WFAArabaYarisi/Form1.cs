using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAArabaYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();


        private void Form1_Load(object sender, EventArgs e)
        {
            switch (rnd.Next(1, 4))
            {
                case 1:
                    this.BackColor = Color.LightGreen;

                    break;
                case 2:
                    this.BackColor = Color.LightBlue;
                    break;
                case 3:
                    this.BackColor = Color.LightYellow;
                    break;

            }



            btnStart.Enabled = false;
            cmbSecim.Items.Add("Ferrari");
            cmbSecim.Items.Add("Ford Mavi");
            cmbSecim.Items.Add("Taksi");


            MessageBox.Show("Lutfen Bahis giriniz ve paranızı yatırınız. Minimum 100 tl olmalı.");



        }
        private void txtPara_TextChanged(object sender, EventArgs e)
        {
            int miktar = 0;

            try
            {
                miktar = Convert.ToInt32(txtPara.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen düzgün formatta deger girin.");
                return;
            }


            if (miktar >= 100)
            {


                MessageBox.Show("Para girişi başarılı");
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }

        }
       
       
        private void btnStart_Click(object sender, EventArgs e)
        {

            timer1.Start();
            switch (rnd.Next(1, 4))
            {
                case 1:
                    this.BackColor = Color.LightGreen;

                    break;
                case 2:
                    this.BackColor = Color.LightBlue;
                    break;
                case 3:
                    this.BackColor = Color.LightYellow;
                    break;

            }
            
          
        }
        private void btnPara_Click(object sender, EventArgs e)
        {
            try
            {
                int topPara = 0;
                do
                {
                    topPara += Convert.ToInt32(txtPara);
                }
                while (topPara < 1000);


                MessageBox.Show($"Toplam para:{topPara} ");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbFerrari.Left += rnd.Next(3, 7);
            pbFord.Left += rnd.Next(3, 7);
            pbTaksi.Left += rnd.Next(3, 7);


            int para = Convert.ToInt32(txtPara.Text);

            
                   

                if (this.BackColor == Color.LightGreen)
                {
                    pbTaksi.Left += 9;
                    lblSpiker.Text = "Çim alandaki bu yarışta Taksi yarışı önde görünüyor..";

                }
                else if (this.BackColor == Color.LightBlue)
                {
                    pbFord.Left += 9;
                    lblSpiker.Text = "Karlı-Buzlu bu alanda Ford Mavi yarışı önde götürüyor";
                }
                else if (this.BackColor == Color.LightYellow)
                {
                    pbFerrari.Left += 9;
                    lblSpiker.Text = "Çöldeki Bu yarışta Ferrari yarışı önde götürüyor";
                }
                if (pbTaksi.Right >= lblFinish.Left)
                {
                    timer1.Stop();
                    MessageBox.Show("Taksi bu turu kazandı");
                   if (cmbSecim.ToString() == "Taksi")
                   {
                    lblKazanılan.Text = $"{para}";                  
                   }
                    
                    pbTaksi.Left = pbFord.Left = pbFerrari.Left = 5;
                }
                else if (pbFerrari.Right >= lblFinish.Left)
                {
                    timer1.Stop();
                    MessageBox.Show("Ferrari bu turu kazandı");
                    if (cmbSecim.ToString() == "Ferrari")
                    {
                    lblKazanılan.Text = $"{para}";
                }

                    pbTaksi.Left = pbFord.Left = pbFerrari.Left = 5;
                }
                else if (pbFord.Right >= lblFinish.Left)
                {
                    timer1.Stop();
                    MessageBox.Show("Ford Mavi bu turu kazandı");
                    if (cmbSecim.ToString() == "Ford Mavi")
                    {
                    lblKazanılan.Text = $"{para}";

                }

                    pbTaksi.Left = pbFord.Left = pbFerrari.Left = 5;

                }
               

           
        }

        

            



         

        
    }
}
