using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursAgain
{
    //Описание переменных
    public partial class Form1 : Form
    {
        double step = 0;
        int flag = 0;
        int time = 1000;
        int pressureMin;
        int pressureMax;
        int concentrationsMin;
        int concentrationMax;
        int value;
        int value1;
        int valueres;
        int valueres1;
        int tankV;
        int tankarr;
        int fuel_all = 0;
        double temp = 30.0;
        double temp_0 = 30;
        double prop;
        int storageV;
        int neededTemperature;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        bool validateIsEmptry()
        {
            bool isValid = true;
            List<string> errors = new List<string>();

            if (this.tbPressureMin.Text == "")
            {
                isValid = false;
                errors.Add("Не заполнено минимальное давление");
            }

            if (this.tbPressureMax.Text == "")
            {
                isValid = false;
                errors.Add("Не заполнено максимальное давление");
            }

            if (this.tbConcentrationMin.Text == "")
            {
                isValid = false;
                errors.Add("Не заполнено минимальная концентрация");
            }

            if (this.tbConcentrationMax.Text == "")
            {
                isValid = false;
                errors.Add("Не заполнено максимальная концентрация");
            }

            if (this.tbVStorage.Text == "")
            {
                isValid = false;
                errors.Add("Не заполнено объем хранилища");
            }

            if (this.tbVTank.Text == "")
            {
                isValid = false;
                errors.Add("Не заполнено объем цистерны");
            }

            if (this.tbNeededTemperature.Text == "")
            {
                isValid = false;
                errors.Add("Не заполнено необходимая температура");
            }

            if (!isValid)
            {
                MessageBox.Show(String.Join("\n", errors));
            }

            return isValid;
        }
        
        

        public void button1_Click(object sender, EventArgs e)
        {
            if (!validateIsEmptry())
            {
                return;
            }

            pressureMin = Convert.ToInt32(tbPressureMin.Text);
            pressureMax = Convert.ToInt32(tbPressureMax.Text);
            concentrationsMin = Convert.ToInt32(tbConcentrationMin.Text);
            concentrationMax = Convert.ToInt32(tbConcentrationMax.Text);
            tankV = Convert.ToInt32(tbVTank.Text);
            neededTemperature = Convert.ToInt32(tbNeededTemperature.Text);
            storageV = Convert.ToInt32(tbVStorage.Text);
            
            int tanksCount = storageV % tankV;

            if ((pressureMin >= 500) && (pressureMax <= 1700) && (concentrationsMin >= 20) &&
                (concentrationMax <= 99) && ((concentrationMax - concentrationsMin) >= 15) &&
                (neededTemperature >= 40) && (neededTemperature <= 45) && (tanksCount == 0))
            {
    
                progressBar1.Maximum = tankV + 100;
                progressBar2.Maximum = storageV;

                timer3.Stop();
                timer2.Stop();
                timer1.Start();
                textBox7.Text += "\r\n" + "Сисетма запущена";
                textBox8.Text += "Резервуар наполняется";
                step++;
            }
            else
            {
                MessageBox.Show("Неверно введены параметры, смотри справку");
            }
        }

        //Инициализация копки СТОП
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            textBox7.Text += "\r\n" + "Сисетма остановлена".ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //Инициализация кнопки СТАРТ
        public void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd1 = new Random();

            time = time - 1;
            if (fuel_all > 0)
            {
                temp = temp + 0.3;
                lblTemperature.Text = Math.Round(temp, 1).ToString();
            }

            label6.Update();
            label6.Text = time.ToString();
            //    label3.Text = time.ToString();
            int value = rnd.Next(pressureMin - 40, pressureMax + 40);
            // valueres = value;
            int value1 = rnd1.Next(concentrationsMin - 3, concentrationMax + 3);
            //valueres1 = value1;
            // label4.Text = concentrationsMin.ToString();
            /*  label5.Text = pressureMax.ToString();
              */
            //Давление в системе
            label1.Text = value.ToString();

            if (((value >= pressureMin) && (value < pressureMax)))
            {
                textBox5.Clear();
                textBox5.Text += "\r\n" + "Давление в норме.".ToString();
                textBox5.Update();
            }
            else
            {
                textBox5.Clear();
                textBox5.Text += "\r\n" + "Нарушение давления в системе.".ToString();
                textBox5.Update();
            }

            //пропорции концентратов
            label2.Text = value1.ToString();
            if ((value1 >= concentrationsMin) && (value1 < concentrationMax))
            {
                textBox6.Clear();
                textBox6.Text += "\r\n" + "Концентрация реагентов в норме.".ToString();
                textBox6.Update();
            }
            else
            {
                textBox6.Clear();
                textBox6.Text += "\r\n" + "Нарушение концентрации реагентов.".ToString();
                textBox6.Update();
            }

            tankarr = tankarr + value / 15;
            label22.Text = (value / 15).ToString();
            label19.Text = tankarr.ToString();
            if (tankarr >= tankV)
            {
                textBox8.Clear();
                textBox8.Text += "Резервуар переполнен!".ToString();
                textBox8.Update();
                tankarr = tankV;
                label19.Text = tankV.ToString();
                fuel_all = fuel_all + tankarr;
                temp = ((temp - temp_0) / 2 + temp_0);
                lblTemperature.Text = Math.Round(temp, 1).ToString();
                progressBar2.Value = progressBar2.Value + tankarr;
                label29.Text = fuel_all.ToString();
                tankarr = 0;
                textBox8.Clear();
                textBox8.Text += "Резервуар наполняется".ToString();
                progressBar1.Value = 0;
            }

            if (fuel_all == storageV)
            {
                textBox7.Update();
                textBox7.Text += "\r\n" + "Резервуары наполнены, идет нагрев нефтепродуктов".ToString();
                textBox7.Update();

                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Start();
            }
            //      MessageBox.Show("Нефтекачамба закрыта, гаси компутор");

            if (temp == neededTemperature)
            {
                timer4.Stop();
                MessageBox.Show("Нефть в хранилище нагрета");
            }

            if (fuel_all > 0)
            {
                temp = temp + 0.3;
            }

            if (fuel_all == storageV)
            {
                flag = 1;
                if (flag == 1)
                {
                    lblTemperature.Text = Math.Round(temp, 1).ToString();
                }
                else
                {
                    flag = 0;
                    lblTemperature.Text = Math.Round((temp / 2), 1).ToString();
                }
            }


            if (progressBar1.Value < tankV)
            {
                progressBar1.Value = progressBar1.Value + value / 15;
            }
            else
            {
                progressBar1.Value = tankV;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        //Инициализация аварии клапана
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            timer3.Stop();
        }

        //Таймер клапана
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Start();
            Random rnd2 = new Random();
            time = time - 35;
            if (fuel_all > 0)
            {
                temp = temp + 0.3;
            }

            if (time > 300)
            {
                time = time - 15;
            }

            if (time < 50)
            {
                time = 50;
            }

            textBox5.Clear();
            textBox5.Text += "\r\n" + "Нарушение давления в системе.".ToString();
            textBox5.Update();
            label6.Text = time.ToString();
            label6.Update();
            int i = pressureMin;
            int k = value1;
            int value11 = rnd2.Next(concentrationsMin - 3, concentrationMax + 3);
            if ((value11 >= concentrationsMin) && (value11 < concentrationMax))
            {
                textBox6.Clear();
                textBox6.Text += "\r\n" + "Концентрация реагентов в норме.".ToString();
                textBox6.Update();
            }
            else
            {
                textBox6.Clear();
                textBox6.Text += "\r\n" + "Нарушение концентрации реагентов.".ToString();
                textBox6.Update();
            }

            label1.Update();

            label1.Text = time.ToString();
            label2.Text = value11.ToString();
            tankarr = tankarr + time / 15;
            label22.Text = (time / 15).ToString();
            label19.Text = tankarr.ToString();
            if (tankarr >= tankV)
            {
                textBox8.Clear();
                textBox8.Text += "Резервуар переполнен!".ToString();
                textBox8.Update();
                tankarr = tankV;
                label19.Text = tankV.ToString();
                fuel_all = fuel_all + tankarr;
                temp = ((temp - temp_0) / 2 + temp_0);
                lblTemperature.Text = Math.Round(temp, 1).ToString();
                progressBar2.Value = progressBar2.Value + tankarr;
                label29.Text = fuel_all.ToString();
                tankarr = 0;
                textBox8.Clear();
                textBox8.Text += "Резервуар наполняется".ToString();
                progressBar1.Value = 0;
            }

            if (fuel_all == storageV)
            {
                textBox7.Update();
                textBox7.Text += "\r\n" + "Резервуары наполнены, идет нагрев нефтепродуктов".ToString();
                textBox7.Update();
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                //  MessageBox.Show("Нефтекачамба закрыта, гаси компутор");
                timer4.Start();
            }

            if (temp >= neededTemperature)
            {
                timer4.Stop();
                MessageBox.Show("Нефть в хранилище нагрета");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            time = 1000;
            timer2.Stop();
            timer3.Stop();
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Stop();
            timer3.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        int stepp = 30;

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Start();
            Random rnd1 = new Random();
            if (time > 30)
            {
                time = time / stepp - 1;
                stepp = 1;
            }

            if ((time == 30) || (time < 30))
            {
                time = time / stepp - 3;
            }

            if (time < 3)
            {
                time = 1;
            }

            if (fuel_all > 0)
            {
                temp = temp + 0.3;
            }

            textBox6.Clear();
            textBox6.Text += "\r\n" + "Нарушение концентрации.".ToString();
            textBox6.Update();
            label6.Text = time.ToString();
            label6.Update();
            int i = concentrationsMin;
            int k = value;
            int value12 = rnd1.Next(pressureMin - 40, pressureMax + 40);
            label2.Update();
            if (((value12 >= pressureMin) && (value12 < pressureMax)))
            {
                textBox5.Clear();
                textBox5.Text += "\r\n" + "Давление в норме.".ToString();
                textBox5.Update();
            }
            else
            {
                textBox5.Clear();
                textBox5.Text += "\r\n" + "Нарушение давления в системе.".ToString();
                textBox5.Update();
            }

            tankarr = tankarr + value12 / 15;
            label22.Text = (value12 / 15).ToString();

            label19.Text = tankarr.ToString();
            if (tankarr >= tankV)
            {
                textBox8.Clear();
                textBox8.Text += "Резервуар переполнен!".ToString();
                textBox8.Update();
                tankarr = tankV;
                label19.Text = tankV.ToString();
                fuel_all = fuel_all + tankarr;
                temp = ((temp - temp_0) / 2 + temp_0);
                lblTemperature.Text = Math.Round(temp, 1).ToString();
                progressBar2.Value = progressBar2.Value + tankarr;
                label29.Text = fuel_all.ToString();
                tankarr = 0;
                textBox8.Clear();
                textBox8.Text += "Резервуар наполняется".ToString();
                progressBar1.Value = 0;
                if (fuel_all == storageV)
                {
                    textBox7.Text += "\r\n" + "Резервуары наполнены, идет нагрев нефтепродуктов".ToString();
                    textBox7.Update();
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    //  MessageBox.Show("Нефтекачамба закрыта, гаси компутор");
                    timer4.Start();
                }

                if (temp == neededTemperature)
                {
                    timer4.Stop();
                    MessageBox.Show("Нефть в хранилище нагрета");
                }
            }

            label2.Text = time.ToString();
            label1.Text = value12.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            time = 1000;
            timer2.Stop();
            timer3.Stop();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fuel_all = fuel_all + tankarr;
            progressBar2.Value = progressBar2.Value + tankarr;
            label29.Text = fuel_all.ToString();
            tankarr = 0;
            textBox8.Clear();
            textBox8.Text += "Резервуар наполняется".ToString();
            progressBar1.Value = 0;
            temp = ((temp - temp_0) / 2 + temp_0);
            if (fuel_all == storageV)
            {
                textBox7.Text += "\r\n" + "Резервуары наполнены, идет нагрев нефтепродуктов".ToString();
                textBox7.Update();
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                // MessageBox.Show("Нефтекачамба закрыта, гаси компутор");
                timer4.Start();
            }

            if (temp == neededTemperature)
            {
                timer4.Stop();
                MessageBox.Show("Нефть в хранилище нагрета");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label27_Click(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Random rnd4 = new Random();
            timer4.Start();
            time = time - 1;
            temp = temp + 0.3;
            lblTemperature.Text = Math.Round(temp, 1).ToString();
            if ((temp == neededTemperature) || (temp > neededTemperature))
            {
                timer4.Stop();
                MessageBox.Show("Нефть в хранилище нагрета");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}