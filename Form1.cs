using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace Azango
{
    public partial class Form1 : Form
    {
        string roz;
        int min, sec;
        Boolean azan = Class1.azan;
        Boolean rabana = Class1.rabana;
        Boolean indahan = Class1.indahan;
        private bool dragging;
        private Point pointClicked;
        int takhir, shahr;
     

        public Form1()
        {
            InitializeComponent();
        }
        public void change_backgrounImage()
        {
            DateTimePicker dt = new DateTimePicker();
            roz = dt.Value.Day.ToString();
            int year = Convert.ToInt32(dt.Value.Year.ToString());
            int month = Convert.ToInt32(dt.Value.Month.ToString());
           
                if (month == 7)
                {
                    switch (roz)
                    {
                        case "21":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\1.jpg");
                            break;

                        case "22":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\2.jpg");
                            break;

                        case "23":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\3.jpg");
                            break;

                        case "24":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\4.jpg");
                            break;

                        case "25":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\5.jpg");
                            break;

                        case "26":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\6.jpg");
                            break;

                        case "27":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\7.jpg");
                            break;

                        case "28":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\8.jpg");
                            break;

                        case "29":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\9.jpg");
                            break;

                        case "30":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\10.jpg");
                            break;

                        case "31":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\11.jpg");
                            break;

                        case "1":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\12.jpg");
                            break;

                        case "2":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\13.jpg");
                            break;

                        case "3":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\14.jpg");
                            break;

                        case "4":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\15.jpg");
                            break;

                        case "5":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\16.jpg");
                            break;

                        case "6":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\17.jpg");
                            break;

                        case "7":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\18.jpg");
                            break;

                        case "8":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\19.jpg");
                            break;

                        case "9":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\20.jpg");
                            break;

                        case "10":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\21.jpg");
                            break;

                        case "11":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\22.jpg");
                            break;

                        case "12":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\23.jpg");
                            break;

                        case "13":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\24.jpg");
                            break;

                        case "14":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\25.jpg");
                            break;

                        case "15":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\26.jpg");
                            break;

                        case "16":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\27.jpg");
                            break;

                        case "17":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\28.jpg");
                            break;

                        case "18":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\29.jpg");
                            break;

                        case "19":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\30.jpg");
                            break;

                        case "20":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\31.jpg");
                            break;
                    }
                }
                else if (month == 5)
                {
                    switch (roz)
                    {
                        case "1":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\2.jpg");
                            break;

                        case "2":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\3.jpg");
                            break;

                        case "3":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\4.jpg");
                            break;

                        case "4":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\5.jpg");
                            break;

                        case "5":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\6.jpg");
                            break;

                        case "6":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\7.jpg");
                            break;

                        case "7":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\8.jpg");
                            break;

                        case "8":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\9.jpg");
                            break;

                        case "9":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\10.jpg");
                            break;

                        case "10":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\11.jpg");
                            break;

                        case "11":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\12.jpg");
                            break;

                        case "12":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\13.jpg");
                            break;

                        case "13":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\14.jpg");
                            break;

                        case "14":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\15.jpg");
                            break;

                        case "15":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\16.jpg");
                            break;

                        case "16":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\17.jpg");
                            break;

                        case "17":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\18.jpg");
                            break;

                        case "18":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\19.jpg");
                            break;

                        case "19":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\20.jpg");
                            break;

                        case "20":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\21.jpg");
                            break;

                        case "21":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\22.jpg");
                            break;

                        case "22":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\23.jpg");
                            break;

                        case "23":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\24.jpg");
                            break;

                        case "24":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\25.jpg");
                            break;

                        case "25":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\26.jpg");
                            break;

                        case "26":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\27.jpg");
                            break;

                        case "27":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\28.jpg");
                            break;

                        case "28":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\29.jpg");
                            break;

                        case "29":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\30.jpg");
                            break;

                        case "30":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\31.jpg");
                            break;

                        case "31":
                            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\pic\\31.jpg");
                            break;
                    }
                }


            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            DateTimePicker dt = new DateTimePicker();
            int hb = Convert.ToInt32(dt.Value.Second.ToString());
            if (hb == 00)
            {
                button1.Hide();
                button2.Hide();
                button3.Hide();
                label9.Hide();
            }
            else if (hb == 30)
            {
                button1.Hide();
                button2.Hide();
                button3.Hide();
                label9.Hide();
            }
            int year = Convert.ToInt32(dt.Value.Year.ToString());
            int month = Convert.ToInt32(dt.Value.Month.ToString());
            int day = Convert.ToInt32(dt.Value.Day.ToString());
            if(month==5)
            {
                if (day <= 10) {
                    day = day + 21;
                }
                else if(day>10){
                    day=day-10;
                }
                roz = Convert.ToString(day);
                OleDbConnection c = new OleDbConnection(@"provider=Microsoft.jet.OLEDB.4.0;Data source=" + Application.StartupPath + "\\rooz.mdb");
                OleDbCommand cmd = new OleDbCommand("select * from tabel where rooz=" + roz, c);
                c.Open();
                OleDbDataReader datareader = cmd.ExecuteReader();
                datareader.Read();
                int str0 = datareader.GetInt32(Class1.shahr);
                label4.Text = Convert.ToString(str0);
                c.Close();


                OleDbConnection c1 = new OleDbConnection(@"provider=Microsoft.jet.OLEDB.4.0;Data source=" + Application.StartupPath + "\\rooz.mdb");
                OleDbCommand cmd1 = new OleDbCommand("select * from hours where rooz=" + roz, c1);

                c1.Open();
                OleDbDataReader datareader1 = cmd1.ExecuteReader();
                datareader1.Read();
                int str2 = datareader1.GetInt32(Class1.shahr);
                label8.Text = Convert.ToString(":" + str2);
            

                c1.Close();
                min = Convert.ToInt32(dt.Value.Minute.ToString());
                sec = Convert.ToInt32(dt.Value.Second.ToString());






                int hour = Convert.ToInt32(dt.Value.Hour.ToString());

                if (hour == str2)
                {
                   
                    //شمارش معکوس
                    int d = str0 - (min-Class1.takhir);
                    if (d == 1)
                    {

                        // int b = Convert.ToInt32(str0);
                        int a = 60 - sec;
                        if (a > 0)
                        {
                            this.Show();
                            this.WindowState = FormWindowState.Normal;
                            label3.Text = Convert.ToString(a);
                        }
                    }
                    //**********************
                    if (Class1.rabana == true)
                    {
                        int indahan = str0 - (10 - Class1.takhir);
                        if (min == indahan)
                        {

                            if (sec == 30 & Class1.indahan == true)
                            {

                                System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\indahan.wav");
                                s.Play();
                                button4.Show();



                            }
                        }
                    }
                    else if (Class1.rabana == false)
                    {
                        int indahan = str0 - (5 - Class1.takhir); ;
                        if (min == indahan)
                        {

                            if (sec == 11 & Class1.indahan == true)
                            {

                                System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\indahan.wav");
                                s.Play();
                                button4.Show();



                            }
                        }
                    }
                    int rabana = str0 - (5 - Class1.takhir); ;
                    if (min == rabana)
                    {

                        if (sec == 31 & Class1.rabana == true)
                        {

                            System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\Rabana.wav");
                            s.Play();
                            button4.Show();



                        }
                    }
                    else if (min == ((str0 -1)+ Class1.takhir ) & Class1.azan == true)
                    {
                        if (sec == 48)
                        {


                           // System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\radio.wav");
                          // s.Play();
                           // button4.Show();


                        }
                        else if (sec == 57)
                        {
                            System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\azan.wav");
                            s.Play();
                            button4.Show();
                        }
                        else if (sec == 59)
                        {


                            label3.Text = "قبول باشد";
                            notifyIcon1.BalloonTipTitle = ":برنامه اذان گو";
                            notifyIcon1.BalloonTipText = "قبول باشد";
                            notifyIcon1.ShowBalloonTip(500);
                          
                        }
                    }
                    else if (sec == 10)
                    {
                        label3.Text = "";

                    }
                    else if (min == ((str0 + 4) + Class1.takhir))
                    {
                        if (sec == 54)
                        {
                            button4.Hide();
                        }
                    }

                }
               
                if (hour == 00)
                {
                    if (min == 00)
                    {
                        if (sec == 00)
                        {
                            
                                change_backgrounImage();
                                this.Refresh();


                          


                        }
                    }
                }

            





            }
            if (month == 7)
            {
                roz = Convert.ToString(day);
                OleDbConnection c = new OleDbConnection(@"provider=Microsoft.jet.OLEDB.4.0;Data source=" + Application.StartupPath + "\\rooz.mdb");
                OleDbCommand cmd = new OleDbCommand("select * from tabel where rooz=" + roz, c);
                c.Open();
                OleDbDataReader datareader = cmd.ExecuteReader();
                datareader.Read();
                int str0 = datareader.GetInt32(Class1.shahr);
                label4.Text = Convert.ToString(str0);
                c.Close();


                OleDbConnection c1= new OleDbConnection(@"provider=Microsoft.jet.OLEDB.4.0;Data source=" + Application.StartupPath + "\\rooz.mdb");
                OleDbCommand cmd1 = new OleDbCommand("select * from hours where rooz=" + roz, c1);

                c1.Open();
                OleDbDataReader datareader1= cmd1.ExecuteReader();
                datareader1.Read();
                int str2 = datareader1.GetInt32(Class1.shahr);
                label8.Text = Convert.ToString(":" + str2);


             c1.Close();
                min = Convert.ToInt32(dt.Value.Minute.ToString());
                sec = Convert.ToInt32(dt.Value.Second.ToString());






                int hour = Convert.ToInt32(dt.Value.Hour.ToString());

                if (hour == str2)
                {
                    
                    //شمارش معکوس
                    int d = str0 - (min - Class1.takhir);
                    if (d == 1)
                    {

                        // int b = Convert.ToInt32(str0);
                        int a = 60 - sec;
                        if (a > 0)
                        {
                            this.Show();
                            this.WindowState = FormWindowState.Normal;
                            label3.Text = Convert.ToString(a);
                        }
                    }
                    //**********************
                    if (Class1.rabana == true)
                    {
                        int indahan = str0 - (10 - Class1.takhir);
                        if (min == indahan)
                        {

                            if (sec == 30 & Class1.indahan == true)
                            {

                                System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\indahan.wav");
                                s.Play();
                                button4.Show();



                            }
                        }
                    }
                    else if (Class1.rabana == false)
                    {
                        int indahan = str0 - (5 - Class1.takhir); ;
                        if (min == indahan)
                        {

                            if (sec == 11 & Class1.indahan == true)
                            {

                                System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\indahan.wav");
                                s.Play();
                                button4.Show();



                            }
                        }
                    }
                    int rabana = str0 - (5 - Class1.takhir); ;
                    if (min == rabana)
                    {

                        if (sec == 31 & Class1.rabana == true)
                        {

                            System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\Rabana.wav");
                            s.Play();
                            button4.Show();



                        }
                    }
                    else if (min == ((str0 -1)+ Class1.takhir ) & Class1.azan == true)
                    {
                        if (sec == 48)
                        {


                           // System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\radio.wav");
                          // s.Play();
                           // button4.Show();


                        }
                        else if (sec == 57)
                        {
                            System.Media.SoundPlayer s = new System.Media.SoundPlayer(Application.StartupPath + "\\sound\\azan.wav");
                            s.Play();
                            button4.Show();
                        }
                        else if (sec == 59)
                        {


                            label3.Text = "قبول باشد";
                            notifyIcon1.BalloonTipTitle = ":برنامه اذان گو";
                            notifyIcon1.BalloonTipText = "قبول باشد";
                            notifyIcon1.ShowBalloonTip(500);
                          
                        }
                    }
                    else if (sec == 10)
                    {
                        label3.Text = "";

                    }
                    if (min == (str0 + 4) + Class1.takhir)
                    {
                        if (sec == 54)
                        {
                            button4.Hide();
                        }

                }
             
                }
                if (hour == 00)
                {
                    if (min == 00)
                    {
                        if (sec == 00)
                        {
                            
                                change_backgrounImage();
                                this.Refresh();


                          


                        }
                    }
                }

            }
        }
                
                 
               

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Class1.takhir);
           
            DateTimePicker dt = new DateTimePicker();
            string str, str1, str2, str4, str3, str5, str6, str7;
            int d1, d2, d3;
            str1 = dt.Value.Hour.ToString();
            d1 = Convert.ToInt32(str1);
            str2 = dt.Value.Minute.ToString();
            d2 = Convert.ToInt32(str2);
            str3 = dt.Value.Second.ToString();

            d3 = Convert.ToInt32(str3);

            if (d1 < 10)
            {
                str4 = "0" + dt.Value.Hour.ToString() + ":";
                str = str4 + dt.Value.Minute.ToString() + ":";
                str = str4 + dt.Value.Second.ToString() + "  " + dt.Value.Day.ToString() + ":" + dt.Value.Month + ":" + dt.Value.Year.ToString();
                label2.Text = str;
                if (d2 < 10)
                {

                    str5 = str4 + "0" + dt.Value.Minute.ToString() + ":";
                    str6 = str5 + dt.Value.Second.ToString();
                    label2.Text = str6 + "  " + dt.Value.Day.ToString() + ":" + dt.Value.Month + ":" + dt.Value.Year.ToString(); ;
                    if (d3 < 10)
                    {
                        str7 = str5 + "0" + dt.Value.Second.ToString() + "  " + dt.Value.Day.ToString() + ":" + dt.Value.Month + ":" + dt.Value.Year.ToString();
                    }
                }
                else
                {
                    str5 = str4 + dt.Value.Minute.ToString() + ":";
                    str6 = str5 + dt.Value.Second.ToString() + "  " + dt.Value.Day.ToString() + ":" + dt.Value.Month + ":" + dt.Value.Year.ToString();
                    label2.Text = str6;
                    if (d3 < 10)
                    {
                        str7 = str5 + "0" + dt.Value.Second.ToString() + "  " + dt.Value.Day.ToString() + ":" + dt.Value.Month + ":" + dt.Value.Year.ToString();
                        label2.Text = str7;
                    }
                }

            }


            else
            {
                str4 = dt.Value.Hour.ToString() + ":";
                str = str4 + dt.Value.Minute.ToString() + ":";
                str = str4 + dt.Value.Second.ToString() + "  " + dt.Value.Day.ToString() + ":" + dt.Value.Month + ":" + dt.Value.Year.ToString();
                label2.Text = str;
                if (d2 < 10)
                {

                    str5 = str4 + "0" + dt.Value.Minute.ToString() + ":";
                    str6 = str5 + dt.Value.Second.ToString();
                    label2.Text = str6 + "  " + dt.Value.Day.ToString() + ":" + dt.Value.Month + ":" + dt.Value.Year.ToString();
                    if (d3 < 10)
                    {
                        str7 = str5 + "0" + dt.Value.Second.ToString() + "  " + dt.Value.Day.ToString() + ":" + dt.Value.Month + ":" + dt.Value.Year.ToString();
                        label2.Text = str7;
                    }
                }
                else
                {
                    str5 = str4 + dt.Value.Minute.ToString() + ":";
                    str6 = str5 + dt.Value.Second.ToString() + "  " + dt.Value.Day.ToString() + ":" + dt.Value.Month + ":" + dt.Value.Year.ToString();
                    label2.Text = str6;
                    if (d3 < 10)
                    {
                        str7 = str5 + "0" + dt.Value.Second.ToString() + "  " + dt.Value.Day.ToString() + ":" + dt.Value.Month + ":" + dt.Value.Year.ToString();
                        label2.Text = str7;
                    }
                }


            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            change_backgrounImage();
            button4.Hide();
            int a = SystemInformation.PrimaryMonitorSize.Height;
            int b = SystemInformation.PrimaryMonitorSize.Width;
            this.Location = (new Point(b - 446, a - 363));
            notifyIcon1.Visible = true;
           
            using (StreamReader sr = File.OpenText(Application.StartupPath + "\\takhir.txt"))
            {
                takhir=Convert.ToInt32(  sr.ReadLine());
                Class1.takhir = takhir;
            }
            using (StreamReader sr = File.OpenText(Application.StartupPath + "\\shahr.txt"))
            {
                shahr = Convert.ToInt32(sr.ReadLine());
                Class1.shahr = shahr;
            }
            
            
         
            
          
           

           
        }

        private void label3_Resize(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.Stop();
            button4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fm = new Form2();
            fm.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "برنامه اذان گو ادامه به کار می باشد";
            notifyIcon1.BalloonTipText = "با دابل کلید بر روی ایکن می توانید برنامه را ببینید";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(600);

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form fm = new Form3();
            fm.Show();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Minimize to Tray App";
            notifyIcon1.BalloonTipText = "You have successfully minimized your form.";

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                dragging = false;
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));

                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);

                this.Location = pointMoveTo;
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

    

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            button1.Show();
            button2.Show();
            button3.Show();
            label9.Show();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new Form3();
            fm.Show();

        }

        private void بستنبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
      
    }
}
