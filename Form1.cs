/*
 Sanyerlis Camacaro 09/12/2022 - CSC202 - Startup Company - Moms Talk Crypto Company Benefits - Sancamac@uat.edu
Log: As of September 8,2022 I believe this project will take me to complete in less than 8 hours splitted in 2-3 days.
09/09/2022 Started rewatching the class to follow along with the examples, Starting time was at 10:43am, I've finished following along the class video around 12:15am 
the next and continued working on the assignment until 3:13 am 9/10/2022.
On 9/10/2022 I continued working from 11am until 3:20pm with few mini breaks in between.

To Complete this StartUp Company Benifits project I've expected to complete the project within the most 3 days in total of 8 hours. In total I took 10 hours and 2 days 
to complete the assigment. I believe that it took longer than I've expected because I also rewatch the class to understand, read the class book and used google to
watch videos and learn more about coding in C#. I also took few breaks because I have kids. Next time, I will try to organize myself better with home responsabilities 
and rewatch the classes ahead of time and ask questions when it's needed. 
 */
/*
 Sanyerlis Camacaro 09/19/2022 - CSC202 - Starup CEO - Moms Talk Crypto Company Benefits - add loops, files, functions.
Log: As of September 14, 2022 I believe I will take a total of 8 hours divided in 2 days to complete this project.
09/17/2022: 9:30pm-11pm - worked 1 hour and half in total, it included watching the class videos and trying the class examples myself.
09/18/2022: 10am-12:30pm - worked 2 hours and half in total to enhance the current windows appareance, add button functions and I/O file. 
I was able to complete this assignment in less time than I expected. My plan for next week is to dedicate an extra hour just to read and watch
tutorials of loops examples that I can use in the future. 
 */

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

namespace Moms_Talk_Crypto_Company_Benefits
{
    public partial class Form1 : Form
    {
       
        int die;
        string textFile = "readfile.txt";
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Moms Talk Crypto Company Benefits Page");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBonusbutton1_Click(object sender, EventArgs e)
        {
            decimal calcula_percentage = (Convert.ToDecimal(comboBox1.Text) / 100) * Convert.ToDecimal(textBox1.Text);
            textBox2.Text = (decimal.Parse(textBox1.Text) + calcula_percentage).ToString();
            using (StreamWriter sw =File.AppendText(textFile))
            {
            sw.WriteLine(calcula_percentage.ToString());
            }

            using (StreamWriter sw = File.AppendText(textFile))// to append text - write format
            {
                sw.WriteLine(comboBox1.Text.ToString());
                sw.WriteLine(textBox1.Text.ToString());
                sw.WriteLine(textBox2.Text.ToString());
            }
            //reading files
            string[] lines = File.ReadAllLines(textFile);// to read appended text
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines)
            {
                    
            }
        }

        private void VacationDaysbutton1_Click(object sender, EventArgs e)
        {
            DateTime startdate = dobdateTimePicker1.Value;
            DateTime Enddate = dateTimePicker2.Value;
            textBox3.Text = CalcAge(startdate, Enddate).ToString();
            using (StreamWriter sw = File.AppendText(textFile))
            {
                sw.WriteLine(startdate.ToString());
                sw.WriteLine(Enddate.ToString());
            }

            using (StreamWriter sw = File.AppendText(textFile))// to append text - write format
            {
                sw.WriteLine(dobdateTimePicker1.Text.ToString());
                sw.WriteLine(dateTimePicker2.Text.ToString());
                sw.WriteLine(textBox3.Text.ToString());
            }
            //reading files
            string[] lines = File.ReadAllLines(textFile);// to read appended text
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines)
                {
                    
                }
            }
        public long CalcAge(System.DateTime StartDate, System.DateTime EndDate)
        {
            long age = 0;
            System.TimeSpan ts = new TimeSpan(EndDate.Ticks - StartDate.Ticks);
            age = (long)(ts.Days / 365);
            using (StreamWriter sw = File.AppendText(textFile))
            {
                sw.WriteLine(StartDate.ToString());
                sw.WriteLine(EndDate.ToString());
            }

            using (StreamWriter sw = File.AppendText(textFile))// to append text - write format
            {
                sw.WriteLine(age.ToString());
            }
            //reading files
            string[] lines = File.ReadAllLines(textFile);// to read appended text
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines)
                {
                   
                }
            return age; 
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            die = random.Next(1, 10);
            MessageBox.Show("Extra Vacation Days =" + die);
            die++; //SC equivalent to die = die +1;
            MessageBox.Show("Bonus JACKPOT =" + die);
            die = die + 8;
            using (StreamWriter sw = File.AppendText(textFile))
            {
                sw.WriteLine(random.ToString());
            }
            //reading files
            string[] lines = File.ReadAllLines(textFile);// to read appended text
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines)
                {
                   
                }




        }

        private void Salarylabel1_Click(object sender, EventArgs e)
        {

        }

        private void FindOutBonuslabel1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dobdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EnterYourAgelabel1_Click(object sender, EventArgs e)
        {

        }

        private void ExtraVacationlabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            die = random.Next(100, 10000);
            MessageBox.Show("Company Hourly Earnings =" + die);
            die++; //SC equivalent to die = die +1;
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void JackPacklabel1_Click(object sender, EventArgs e)
        {

        }

        private void calculateptodaysbutton2_Click(object sender, EventArgs e)
        {
            int result;
            string str = textBox4.Text;

            if (int.TryParse(str, out result))
            {
                if (result <=40)
                {
                    MessageBox.Show("You Have 3 Hours of Earned PTO");
                }

                else if (result <=80)
                {
                    MessageBox.Show("You Have 6 Hours of Earned PTO");
                }
            }

            try//if its not an integer it will catch the error
            {
                result = int.Parse(str);
            }
            catch
            {
                MessageBox.Show("Enter Valid Hours");
                using (StreamWriter sw = File.AppendText(textFile))//to append text - write format
                {
                    sw.WriteLine(calculateptodaysbutton2.Text.ToString());
                }
                {
                    using (StreamWriter sw = File.AppendText(textFile))// to append text - write format
                        sw.WriteLine(textBox4.Text.ToString());
                }
                //reading file
                string[] lines = File.ReadAllLines(textFile);//to read appended text
                using (StreamReader file = new StreamReader(textFile))
                    foreach (string line in lines)
                    {
                        
                    }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
    }

