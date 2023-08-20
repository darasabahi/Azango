using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Azango
{
    public partial class Form3 : Form
    {
        int i = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                Class1.indahan = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (!checkBox2.Checked)
            {
                Class1.rabana = false;

            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                Class1.azan = false;

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            indahan_stop.Hide();
            rabana_stop.Hide();
            azan_stop.Hide();
            int a = SystemInformation.PrimaryMonitorSize.Height;
            int b = SystemInformation.PrimaryMonitorSize.Width;
            this.Location = (new Point(b - 420, a - 413));
            trackBar1.Value = Class1.takhir;
         textBox1.Text = Convert.ToString(Class1.takhir);
         int shahr = Class1.shahr;
         switch (shahr)
         {
             case 1:
                 comboBox1.Text = "اهواز";
                 
                 break;
             case 2:
                 comboBox1.Text = "تهران";
                
                 break;
             case 3:
                 comboBox1.Text = "شیراز";
               
                 break;
             case 4:
                 comboBox1.Text = "اصفهان";
                
                 break;
             case 5:
                 comboBox1.Text = "قم";
               
                 break;
             case 6:
                 comboBox1.Text = "مشهد";
                
                 break;
             case 7:
                 comboBox1.Text = "کرج";
                 break;
             case 8:
                 comboBox1.Text = "همدان";
                 break;
             case 9:
                 comboBox1.Text = "اراک";
                 break;
             case 10:
                 comboBox1.Text = "اردبیل";
                 break;
             case 11:
                 comboBox1.Text = "بندر عباس";
                 break;
             case 12:
                 comboBox1.Text = "بیرجند";
                 break;
             case 13:
                 comboBox1.Text = "بجنورد";
                 break;
             case 14:
                 comboBox1.Text = "بوشهر";
                 break;
             case 15:
                 comboBox1.Text = "گرگان";
                 break;
             case 16:
                 comboBox1.Text = "ایلام";
                 break;
             case 17:
                 comboBox1.Text = "کرمان";
                 break;
             case 18:
                 comboBox1.Text = "کرمانشاه";

                 break;
             case 19:
                 comboBox1.Text = "خرم آباد";

                 break;
             case 20:
                 comboBox1.Text = "قزوین";

                 break;
             case 21:
                 comboBox1.Text = "رشت";

                 break;
             case 22:
                 comboBox1.Text = "سنندج";

                 break;
             case 23:
                 comboBox1.Text = "ساری";

                 break;
             case 24:
                 comboBox1.Text = "سمنان";
                 break;
             case 25:
                 comboBox1.Text = "شهرکرد";
                 break;
             case 26:
                 comboBox1.Text = "تبریز";
                 break;
             case 27:
                 comboBox1.Text = "ارومیه";
                 break;
             case 28:
                 comboBox1.Text = "یاسوج";
                 break;
             case 29:
                 comboBox1.Text = "یزد";
                 break;
             case 30:
                 comboBox1.Text = "زاهدان";
                 break;
             case 31:
                 comboBox1.Text = "زنجان";
                 break;
             case 32:
                 comboBox1.Text = "دزفول";
                 break;
             default:

                 break;

         }


        }

        

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            i = Convert.ToInt16(trackBar1.Value);
            textBox1.Text = Convert.ToString(i);
            Class1.takhir = i;
            using (StreamWriter sa = File.CreateText(Application.StartupPath + "\\takhir.txt"))
            {
                sa.Write(i);

            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           string s= textBox1.Text;
            if (s == "1" | s == "2" | s == "3" | s == "4" | s == "5" | s =="6" | s == "7" | s == "8" | s == "9" | s == "10" | s == "-1" | s == "-2" | s == "-3" | s == "-4" | s == "-5" | s == "-6" | s == "-7" | s == "-8" | s == "-9" | s == "-10" | s=="0")
    
            {trackBar1.Value = Convert.ToInt32(textBox1.Text);
                i = Convert.ToInt16(trackBar1.Value);

                Class1.takhir = i;
                using (StreamWriter sa = File.CreateText(Application.StartupPath + "\\takhir.txt"))
                {
                    sa.Write(i);
            }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                switch (comboBox1.Text)
                {
                    case "اهواز":
                        Class1.shahr =1;
                        break;
                    case "تهران":
                        Class1.shahr = 2;
                        break;
                    case "شیراز":
                        Class1.shahr =3;
                        break;
                    case "اصفهان":
                        Class1.shahr =4;
                        break;
                    case "قم":
                        Class1.shahr = 5;
                        break;
                    case "مشهد":
                        Class1.shahr = 6;
                        break;
                    case "کرج":
                        Class1.shahr =7;
                        break;
                    case "همدان":
                        Class1.shahr =8;
                        break;
                    case "اراک":
                        Class1.shahr =9;
                        break;
                    case "اردبیل":
                        Class1.shahr = 10;
                        break;
                    case "بندرعباس":
                        Class1.shahr = 11;
                        break;
                    case "بیرجند":
                        Class1.shahr = 12;
                        break;
                    case "بجنورد":
                        Class1.shahr = 13;
                        break;
                    case "بوشهر":
                        Class1.shahr = 14;
                        break;
                    case "گرگان":
                        Class1.shahr = 15;
                        break;
                    case "ایلام":
                        Class1.shahr = 16;
                        break;
                    case "کرمان":
                        Class1.shahr = 17;
                        break;
                     case "کرمانشاه":
                        Class1.shahr =18;
                        break;
                     case "خرم آباد":
                        Class1.shahr =19;
                        break;
                    case "قزوین":
                        Class1.shahr = 20;
                        break;
                    case "رشت":
                        Class1.shahr = 21;
                        break;
                    case "سنندج":
                        Class1.shahr = 22;
                        break;
                    case "ساری":
                        Class1.shahr = 23;
                        break;
                    case "سمنان":
                        Class1.shahr = 24;
                        break;
                    case "شهرکرد":
                        Class1.shahr = 25;
                        break;
                    case "تبریز":
                        Class1.shahr = 26;
                        break;
                    case "ارومیه":
                        Class1.shahr = 27;
                        break;
                    case "یاسوج":
                        Class1.shahr = 28;
                        break;
                    case "یزد":
                        Class1.shahr = 29;
                        break;
                    case "زاهدان":
                        Class1.shahr = 30;
                        break;
                    case "زنجان":
                        Class1.shahr = 31;
                        break;
                    case "دزفول":
                        Class1.shahr = 32;
                        break;
                    default:

                        break;

                }
                using (StreamWriter sa = File.CreateText(Application.StartupPath + "\\shahr.txt"))
                {
                    sa.Write(Class1.shahr);

                }
            }
        }

        private void indahan_stop_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.Stop();
            indahan_stop.Hide();
            indahan_paly.Show();

        }

        private void rabana_stop_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.Stop();
            rabana_stop.Hide();
            rabana_play.Show();
        }

        private void azan_stop_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.Stop();
            azan_play.Show();
            azan_stop.Hide();
        }

        private void indahan_paly_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\indahan.wav");
            s.Play();
            indahan_paly.Hide();
            indahan_stop.Show();
            rabana_stop.Hide();
            azan_stop.Hide();
            rabana_play.Show();
            azan_play.Show();
        }

        private void rabana_play_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\rabana.wav");
            s.Play();
            rabana_play.Hide();
            rabana_stop.Show();
            indahan_stop.Hide();
            azan_stop.Hide();
            indahan_paly.Show();
            azan_play.Show();
        }

        private void azan_play_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\azan.wav");
            s.Play();
            azan_play.Hide();
            azan_stop.Show();
            rabana_stop.Hide();
            indahan_stop.Hide();
            rabana_play.Show();
            indahan_paly.Show();
        }
    }
}
