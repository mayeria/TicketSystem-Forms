using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilety
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            toolTip1.SetToolTip(label3, "Scarlett Johansson powraca w roli Natashy Romanoff! Naszpikowany akcją thriller szpiegowski. \n" +
                "W wyniku niebezpiecznego spisku i podejrzanych powiązań sprzed czasów drużyny Avengers, \n" +
                "Natasha Romanoff aka Czarna Wdowa musi skonfrontować się z mrocznymi echami swojej przeszłości. \n" +
                "Bohaterka stawia czoła groźnemu, potężnemu przeciwnikowi, który nie cofnie się przed niczym, by ją zniszczyć. \n" +
                "Obok Scarlett Johannson w filmie zobaczymy również Rachel Weisz, Florence Pugh i Dawida Harboura.");
            toolTip1.SetToolTip(label4, "Wonder Woman przenosi się w czasie do lat 80. XX wieku. \n" +
                "Księżniczka Diana Prince podczas zimnej wojny stawia czoło niebezpiecznym przeciwnikom takim jak Cheetah i Max Lord.");
            toolTip1.SetToolTip(label5, "Obecność 3: Na rozkaz diabła to budząca grozę historia przerażającego morderstwa i nieznanych złych mocy. \n" +
                "Wstrząsnęła ona nawet doświadczonymi badaczami spraw paranormalnych Edem i Lorraine Warrenami. \n" +
                "Ten jeden z najbardziej zdumiewających przypadków w ich karierze zaczyna się od walki o duszę młodego chłopca. \n" +
                "Wkrótce małżeństwo staje w obliczu czegoś, z czym jeszcze nie miało do czynienia. Dochodzi do bezprecedensowego procesu. \n" +
                "Po raz pierwszy w historii Stanów Zjednoczonych podejrzany o morderstwo broni się, twierdząc, że był opętany przez demona.");
            toolTip1.SetToolTip(label6, "Adaptacja powieści science fiction Franka Herberta o synu szlachetnej rodziny, \n" +
                "której powierzono ochronę najcenniejszego zasobu i najważniejszego pierwiastka w galaktyce.");
            toolTip1.SetToolTip(label7, "Zdarzyło Ci się kiedyś zastanawiać, skąd wzięła się Twoja pasja, Twoje marzenia i zainteresowania? \n" +
                "Co sprawia, że jesteś... SOBĄ? W 2020 r. Pixar Animation Studios zabiorą Cię w podróż z ulic Nowego Jorku \n" +
                "do nigdy wcześniej niewidzianych kosmicznych sfer i do miejsca, gdzie wszyscy odkrywamy swoje niepowtarzalne osobowości.");
            toolTip1.SetToolTip(label8, "James Bond opuszcza czynną służbę i cieszy się spokojnym życiem na Jamajce. \n" +
                "Tymczasem jednak jego stary przyjaciel Felix Leiter z CIA zwraca się do niego o pomoc. \n" +
                "Misja uratowania porwanego naukowca okazuje się o wiele bardziej zdradliwa, niż mogłoby się wydawać i naprowadza agenta 007 \n" +
                "na ślad tajemniczego złoczyńcy, dysponującego nową, niezwykle niebezpieczną technologią.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        public static int suma = 0;
        public static string film1, film2, film3, film4, film5, film6, film7, film8, film9, film10, film11, film12, film13, film14;
        private bool IsButton1, IsButton2, IsButton3, IsButton4, IsButton5, IsButton6, IsButton7,
            IsButton8, IsButton9, IsButton10, IsButton11, IsButton12, IsButton13, IsButton14;

        private void visible_true(DateTimePicker a, Button b, ComboBox c, Label d, NumericUpDown e)
        {
            a.Visible = true;
            b.Visible = true;
            c.Visible = true;
            d.Visible = true;
            e.Visible = true;
        }

        private void visible_false(DateTimePicker a, Button b, ComboBox c, Label d, NumericUpDown e)
        {
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            d.Visible = false;
            e.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Visible == true)
            {
                visible_false(dateTimePicker1, button15, comboBox1, label9, numericUpDown1);
            }
            else
            {
                dateTimePicker1.Value = new DateTime(2020, 11, 30, 10, 30, 0);
                visible_true(dateTimePicker1, button15, comboBox1, label9, numericUpDown1);
            }
            IsButton1 = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Visible == true)
            {
                visible_false(dateTimePicker1, button15, comboBox1, label9, numericUpDown1);
            }
            else
            {
                dateTimePicker1.Value = new DateTime(2020, 11, 30, 15, 0, 0);
                visible_true(dateTimePicker1, button15, comboBox1, label9, numericUpDown1);
            }
            IsButton2 = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Visible == true)
            {
                visible_false(dateTimePicker1, button15, comboBox1, label9, numericUpDown1);
            }
            else
            {
                dateTimePicker1.Value = new DateTime(2020, 11, 30, 19, 30, 0);
                visible_true(dateTimePicker1, button15, comboBox1, label9, numericUpDown1);
            }
            IsButton3 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Visible == true)
            {
                visible_false(dateTimePicker2, button16, comboBox2, label10, numericUpDown2);
            }
            else
            {
                dateTimePicker2.Value = new DateTime(2020, 11, 30, 9, 0, 0);
                visible_true(dateTimePicker2, button16, comboBox2, label10, numericUpDown2);
            }
            IsButton4 = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Visible == true)
            {
                visible_false(dateTimePicker2, button16, comboBox2, label10, numericUpDown2);
            }
            else
            {
                visible_true(dateTimePicker2, button16, comboBox2, label10, numericUpDown2);
                dateTimePicker2.Value = new DateTime(2020, 11, 30, 15, 0, 0);
            }
            IsButton5 = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Visible == true)
            {
                visible_false(dateTimePicker2, button16, comboBox2, label10, numericUpDown2);
            }
            else
            {
                dateTimePicker2.Value = new DateTime(2020, 11, 30, 20, 30, 0);
                visible_true(dateTimePicker2, button16, comboBox2, label10, numericUpDown2);
            }
            IsButton6 = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dateTimePicker3.Visible == true)
            {
                visible_false(dateTimePicker3, button17, comboBox3, label11, numericUpDown3);
            }
            else
            {
                dateTimePicker3.Value = new DateTime(2020, 11, 30, 20, 30, 0);
                visible_true(dateTimePicker3, button17, comboBox3, label11, numericUpDown3);
            }
            IsButton7 = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dateTimePicker3.Visible == true)
            {
                visible_false(dateTimePicker3, button17, comboBox3, label11, numericUpDown3);
            }
            else
            {
                dateTimePicker3.Value = new DateTime(2020, 11, 30, 22, 30, 0);
                visible_true(dateTimePicker3, button17, comboBox3, label11, numericUpDown3);
            }
            IsButton8 = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dateTimePicker4.Visible == true)
            {
                visible_false(dateTimePicker4, button18, comboBox4, label12, numericUpDown4);
            }
            else
            {
                dateTimePicker4.Value = new DateTime(2020, 11, 30, 10, 0, 0);
                visible_true(dateTimePicker4, button18, comboBox4, label12, numericUpDown4);
            }
            IsButton9 = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dateTimePicker4.Visible == true)
            {
                visible_false(dateTimePicker4, button18, comboBox4, label12, numericUpDown4);
            }
            else
            {
                dateTimePicker4.Value = new DateTime(2020, 11, 30, 13, 30, 0);
                visible_true(dateTimePicker4, button18, comboBox4, label12, numericUpDown4);
            }
            IsButton10 = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dateTimePicker4.Visible == true)
            {
                visible_false(dateTimePicker4, button18, comboBox4, label12, numericUpDown4);
            }
            else
            {
                dateTimePicker4.Value = new DateTime(2020, 11, 30, 20, 30, 0);
                visible_true(dateTimePicker4, button18, comboBox4, label12, numericUpDown4);
            }
            IsButton11 = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dateTimePicker5.Visible == true)
            {
                visible_false(dateTimePicker5, button19, comboBox5, label13, numericUpDown5);
            }
            else
            {
                dateTimePicker5.Value = new DateTime(2020, 11, 30, 10, 15, 0);
                visible_true(dateTimePicker5, button19, comboBox5, label13, numericUpDown5);
            }
            IsButton12 = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (dateTimePicker5.Visible == true)
            {
                visible_false(dateTimePicker5, button19, comboBox5, label13, numericUpDown5);
            }
            else
            {
                dateTimePicker5.Value = new DateTime(2020, 11, 30, 12, 0, 0);
                visible_true(dateTimePicker5, button19, comboBox5, label13, numericUpDown5);
            }
            IsButton13 = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (dateTimePicker6.Visible == true)
            {
                visible_false(dateTimePicker6, button20, comboBox6, label14, numericUpDown6);
            }
            else
            {
                dateTimePicker6.Value = new DateTime(2020, 11, 30, 17, 0, 0);
                visible_true(dateTimePicker6, button20, comboBox6, label14, numericUpDown6);
            }
            IsButton14 = true;
        }

        private void cena(string film, int sum)
        {
            if (film != null && film.Contains("23"))
                suma += 23 * sum;
            if (film != null && film.Contains("19"))
                suma += 19 * sum;
        }

        private void nowa_cena(string rodzaj, int sum)
        {
            if (rodzaj.Contains("23"))
                suma += 23 * sum;
            else
                suma += 19 * sum;
        }

        private void dodaj(string film, string date, int sum, ComboBox combo, NumericUpDown numer, DateTimePicker data)
        {
            
        }

        private bool wyw_funkcja = false;
        private void contain(string x, string y, Button a)
        {
            if (x != null && x.Contains(y))
            {
                errorProvider1.SetError(a, "Wybrane bilety nakładają się na siebie czasowo!");
                wyw_funkcja = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            visible_false(dateTimePicker1, button15, comboBox1, label9, numericUpDown1);
            if (IsButton1 == true)
            {
                if (comboBox1.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox1, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker1, button15, comboBox1, label9, numericUpDown1);
                }
                else
                {
                    errorProvider1.Clear();
                    string date = dateTimePicker1.Value.ToShortDateString();
                    int sum = Decimal.ToInt32(numericUpDown1.Value);
                    
                    if (film1 != null)
                    {
                        string rodzaj = comboBox1.Text;
                        if (film1.Contains(date))
                        {
                            if (film1.Contains(rodzaj))
                            {
                                film1 = " / + x" + numericUpDown1.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film1 += " / " + rodzaj + " / x" + numericUpDown1.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film1 += " / " + dateTimePicker1.Value + " / " + comboBox1.Text + " / x" + numericUpDown1.Value;

                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film9, date, button1);
                        contain(film12, date, button1);
                        contain(film4, date, button1);
                        if (wyw_funkcja == true)
                        {
                            film1 = null;
                            wyw_funkcja = false;
                        }
                        else
                            film1 = "CZARNA WDOWA / " + dateTimePicker1.Value + " / " + comboBox1.Text + " / x" + numericUpDown1.Value;
                        IsButton1 = false;
                        cena(film1, sum);
                    }
                }
            }
            else if (IsButton2 == true)
            {
                if (comboBox1.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox1, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker1, button15, comboBox1, label9, numericUpDown1);
                }
                else
                {
                    errorProvider1.Clear();
                    string date = dateTimePicker1.Value.ToShortDateString();
                    int sum = Decimal.ToInt32(numericUpDown1.Value);
                    if (film2 != null)
                    {
                        string rodzaj = comboBox1.Text;
                        if (film2.Contains(date))
                        {
                            if (film2.Contains(rodzaj))
                            {
                                film2 = " / + x" + numericUpDown1.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film2 += " / " + rodzaj + " / x" + numericUpDown1.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film2 += " / " + dateTimePicker1.Value + " / " + comboBox1.Text + " / x" + numericUpDown1.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film5, date, button2);
                        contain(film10, date, button2);
                        if (wyw_funkcja == true)
                        {
                            film2 = null;
                            wyw_funkcja = false;
                        } 
                        else
                            film2 = "CZARNA WDOWA / " + dateTimePicker1.Value + " / " + comboBox1.Text + " / x" + numericUpDown1.Value;
                        IsButton2 = false;
                        cena(film2, sum);
                    }
                }
            }
            else if (IsButton3 == true)
            {
                if (comboBox1.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox1, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker1, button15, comboBox1, label9, numericUpDown1);
                }
                else
                {
                    errorProvider1.Clear();
                    string date = dateTimePicker1.Value.ToShortDateString();
                    int sum = Decimal.ToInt32(numericUpDown1.Value);
                    if (film3 != null)
                    {
                        string rodzaj = comboBox1.Text;
                        if (film3.Contains(date))
                        {
                            if (film3.Contains(rodzaj))
                            {
                                film3 = " / + x" + numericUpDown1.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film3 += " / " + rodzaj + " / x" + numericUpDown1.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film3 += " / " + dateTimePicker1.Value + " / " + comboBox1.Text + " / x" + numericUpDown1.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film6, date, button3);
                        contain(film7, date, button3);
                        contain(film11, date, button3);
                        if (wyw_funkcja == true)
                        {
                            film3 = null;
                            wyw_funkcja = false;
                        }
                        else
                            film3 = "CZARNA WDOWA / " + dateTimePicker1.Value + " / " + comboBox1.Text + " / x" + numericUpDown1.Value;
                        IsButton3 = false;
                        cena(film3, sum);
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            visible_false(dateTimePicker2, button16, comboBox2, label10, numericUpDown2);
            if (IsButton4 == true)
            {
                if (comboBox2.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox2, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker2, button16, comboBox2, label10, numericUpDown2);
                }
                else
                {
                    errorProvider1.Clear();
                    string date = dateTimePicker2.Value.ToShortDateString();
                    int sum = Decimal.ToInt32(numericUpDown2.Value);
                    if (film4 != null)
                    {
                        string rodzaj = comboBox2.Text;
                        if (film4.Contains(date))
                        {
                            if (film4.Contains(rodzaj))
                            {
                                film4 = " / + x" + numericUpDown2.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film4 += " / " + rodzaj + " / x" + numericUpDown2.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film4 += " / " + dateTimePicker2.Value + " / " + comboBox2.Text + " / x" + numericUpDown2.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film9, date, button4);
                        contain(film12, date, button4);
                        contain(film1, date, button4);
                        if (wyw_funkcja == true)
                        {
                            film4 = null;
                            wyw_funkcja = false;
                        }
                        else
                            film4 = "WONDER WOMAN / " + dateTimePicker2.Value + " / " + comboBox2.Text + " / x" + numericUpDown2.Value;
                        IsButton4 = false;
                        cena(film4, sum);
                    }
                }
            }
            else if (IsButton5 == true)
            {
                if (comboBox2.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox2, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker2, button16, comboBox2, label10, numericUpDown2);
                }
                else
                {
                    errorProvider1.Clear();
                    string date = dateTimePicker2.Value.ToShortDateString();
                    int sum = Decimal.ToInt32(numericUpDown2.Value);
                    if (film5 != null)
                    {
                        string rodzaj = comboBox2.Text;
                        if (film5.Contains(date))
                        {
                            if (film5.Contains(rodzaj))
                            {
                                film5 = " / + x" + numericUpDown2.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film5 += " / " + rodzaj + " / x" + numericUpDown2.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film5 += " / " + dateTimePicker2.Value + " / " + comboBox2.Text + " / x" + numericUpDown2.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film2, date, button5);
                        contain(film10, date, button5);
                        if (wyw_funkcja == true)
                        {
                            film5 = null;
                            wyw_funkcja = false;
                        }
                        film5 = "WONDER WOMAN / " + dateTimePicker2.Value + " / " + comboBox2.Text + " / x" + numericUpDown2.Value;
                        IsButton5 = false;
                        cena(film5, sum);
                    }
                }
            }
            else if (IsButton6 == true)
            {
                if (comboBox2.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox2, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker2, button16, comboBox2, label10, numericUpDown2);
                }
                else
                {
                    errorProvider1.Clear();
                    string date = dateTimePicker2.Value.ToShortDateString();
                    int sum = Decimal.ToInt32(numericUpDown2.Value);
                    if (film6 != null)
                    {
                        string rodzaj = comboBox2.Text;
                        if (film6.Contains(date))
                        {
                            if (film6.Contains(rodzaj))
                            {
                                film6 = " / + x" + numericUpDown2.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film6 += " / " + rodzaj + " / x" + numericUpDown2.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film6 += " / " + dateTimePicker2.Value + " / " + comboBox2.Text + " / x" + numericUpDown2.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film3, date, button6);
                        contain(film7, date, button6);
                        contain(film8, date, button6);
                        contain(film11, date, button6);
                        if (wyw_funkcja == true)
                        {
                            film6 = null;
                            wyw_funkcja = false;
                        }
                        film6 = "WONDER WOMAN / " + dateTimePicker2.Value + " / " + comboBox2.Text + " / x" + numericUpDown2.Value;
                        IsButton6 = false;
                        cena(film6, sum);
                    }
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            visible_false(dateTimePicker3, button17, comboBox3, label11, numericUpDown3);
            if (IsButton7 == true)
            {
                if (comboBox3.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox3, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker3, button17, comboBox3, label11, numericUpDown3);
                }
                else
                {
                    errorProvider1.Clear();
                    string date = dateTimePicker3.Value.ToShortDateString();
                    int sum = Decimal.ToInt32(numericUpDown3.Value);
                    if (film7 != null)
                    {
                        string rodzaj = comboBox3.Text;
                        if (film7.Contains(date))
                        {
                            if (film7.Contains(rodzaj))
                            {
                                film7 = " / + x" + numericUpDown3.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film7 += " / " + rodzaj + " / x" + numericUpDown3.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film7 += " / " + dateTimePicker3.Value + " / " + comboBox3.Text + " / x" + numericUpDown3.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film3, date, button7);
                        contain(film6, date, button7);
                        contain(film8, date, button7);
                        contain(film11, date, button7);
                        if (wyw_funkcja == true)
                        {
                            film7 = null;
                            wyw_funkcja = false;
                        }
                        film7 = "OBECNOŚĆ 3 / " + dateTimePicker3.Value + " / " + comboBox3.Text + " / x" + numericUpDown3.Value;
                        IsButton7 = false;
                        cena(film7, sum);
                    }
                }
            }
            else if (IsButton8 == true)
            {
                if (comboBox3.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox3, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker3, button17, comboBox3, label11, numericUpDown3);
                }
                else
                {
                    errorProvider1.Clear();
                    int sum = Decimal.ToInt32(numericUpDown3.Value);
                    string date = dateTimePicker3.Value.ToShortDateString();
                    if (film8 != null)
                    {
                        string rodzaj = comboBox3.Text;
                        if (film8.Contains(date))
                        {
                            if (film8.Contains(rodzaj))
                            {
                                film8 = " / + x" + numericUpDown3.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film8 += " / " + rodzaj + " / x" + numericUpDown3.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film8 += " / " + dateTimePicker3.Value + " / " + comboBox3.Text + " / x" + numericUpDown3.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        film8 = "OBECNOŚĆ 3 / " + dateTimePicker3.Value + " / " + comboBox3.Text + " / x" + numericUpDown3.Value;
                        IsButton8 = false;
                        cena(film8, sum);
                    }
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            visible_false(dateTimePicker4, button18, comboBox4, label12, numericUpDown4);
            if (IsButton9 == true)
            {
                if (comboBox4.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox4, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker4, button18, comboBox4, label12, numericUpDown4);
                }
                else
                {
                    errorProvider1.Clear();
                    string date = dateTimePicker4.Value.ToShortDateString();
                    int sum = Decimal.ToInt32(numericUpDown4.Value);
                    if (film9 != null)
                    {
                        string rodzaj = comboBox4.Text;
                        if (film9.Contains(date))
                        {
                            if (film9.Contains(rodzaj))
                            {
                                film9 = " / + x" + numericUpDown4.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film9 += " / " + rodzaj + " / x" + numericUpDown4.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film9 += " / " + dateTimePicker4.Value + " / " + comboBox4.Text + " / x" + numericUpDown4.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film1, date, button9);
                        contain(film4, date, button9);
                        contain(film12, date, button9);
                        if (wyw_funkcja == true)
                        {
                            film9 = null;
                            wyw_funkcja = false;
                        }
                        film9 = "DIUNA / " + dateTimePicker4.Value + " / " + comboBox4.Text + " / x" + numericUpDown4.Value;
                        IsButton9 = false;
                        cena(film9, sum);
                    }
                }
            }
            else if (IsButton10 == true)
            {
                if (comboBox4.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox4, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker4, button18, comboBox4, label12, numericUpDown4);
                }
                else
                {
                    errorProvider1.Clear();
                    string date = dateTimePicker4.Value.ToShortDateString();
                    int sum = Decimal.ToInt32(numericUpDown4.Value);
                    if (film10 != null)
                    {
                        string rodzaj = comboBox4.Text;
                        if (film10.Contains(date))
                        {
                            if (film10.Contains(rodzaj))
                            {
                                film10 = " / + x" + numericUpDown4.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film10 += " / " + rodzaj + " / x" + numericUpDown4.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film10 += " / " + dateTimePicker4.Value + " / " + comboBox4.Text + " / x" + numericUpDown4.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film2, date, button10);
                        contain(film5, date, button10);
                        if (wyw_funkcja == true)
                        {
                            film10 = null;
                            wyw_funkcja = false;
                        }
                        film10 = "DIUNA / " + dateTimePicker4.Value + " / " + comboBox4.Text + " / x" + numericUpDown4.Value;
                        IsButton10 = false;
                        cena(film10, sum);
                    }
                }
            }
            else if (IsButton11 == true)
            {
                if (comboBox4.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox4, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker4, button18, comboBox4, label12, numericUpDown4);
                }
                else
                {
                    errorProvider1.Clear();
                    string date = dateTimePicker4.Value.ToShortDateString();
                    int sum = Decimal.ToInt32(numericUpDown4.Value);
                    if (film11 != null)
                    {
                        string rodzaj = comboBox4.Text;
                        if (film11.Contains(date))
                        {
                            if (film11.Contains(rodzaj))
                            {
                                film11 = " / + x" + numericUpDown4.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film11 += " / " + rodzaj + " / x" + numericUpDown4.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film11 += " / " + dateTimePicker4.Value + " / " + comboBox4.Text + " / x" + numericUpDown4.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film3, date, button11);
                        contain(film6, date, button11);
                        contain(film14, date, button11);
                        if (wyw_funkcja == true)
                        {
                            film11 = null;
                            wyw_funkcja = false;
                        }
                        film11 = "DIUNA / " + dateTimePicker4.Value + " / " + comboBox4.Text + " / x" + numericUpDown4.Value;
                        IsButton11 = false;
                        cena(film11, sum);
                    }
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            visible_false(dateTimePicker5, button19, comboBox5, label13, numericUpDown5);
            if (IsButton12 == true)
            {
                if (comboBox5.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox5, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker5, button19, comboBox5, label13, numericUpDown5);
                }
                else
                {
                    errorProvider1.Clear();
                    int sum = Decimal.ToInt32(numericUpDown5.Value);
                    string date = dateTimePicker5.Value.ToShortDateString();
                    if (film12 != null)
                    {
                        string rodzaj = comboBox5.Text;
                        if (film12.Contains(date))
                        {
                            if (film12.Contains(rodzaj))
                            {
                                film12 = " / + x" + numericUpDown5.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film12 += " / " + rodzaj + " / x" + numericUpDown5.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film12 += " / " + dateTimePicker5.Value + " / " + comboBox5.Text + " / x" + numericUpDown5.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film1, date, button12);
                        contain(film4, date, button12);
                        contain(film9, date, button12);
                        contain(film13, date, button12);
                        if (wyw_funkcja == true)
                        {
                            film12 = null;
                            wyw_funkcja = false;
                        }
                        film12 = "CO W DUSZY GRA / " + dateTimePicker5.Value + " / " + comboBox5.Text + " / x" + numericUpDown5.Value;
                        IsButton12 = false;
                        cena(film12, sum);
                    }
                }
            }
            else if (IsButton13 == true)
            {
                if (comboBox5.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox5, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker5, button19, comboBox5, label13, numericUpDown5);
                }
                else
                {
                    errorProvider1.Clear();
                    string date = dateTimePicker5.Value.ToShortDateString();
                    int sum = Decimal.ToInt32(numericUpDown5.Value);
                    if (film13 != null)
                    {
                        string rodzaj = comboBox5.Text;
                        if (film13.Contains(date))
                        {
                            if (film13.Contains(rodzaj))
                            {
                                film13 = " / + x" + numericUpDown5.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film13 += " / " + rodzaj + " / x" + numericUpDown5.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film13 += " / " + dateTimePicker5.Value + " / " + comboBox5.Text + " / x" + numericUpDown5.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        contain(film1, date, button13);
                        contain(film10, date, button13);
                        contain(film12, date, button13);
                        if (wyw_funkcja == true)
                        {
                            film13 = null;
                            wyw_funkcja = false;
                        }
                        film13 = "CO W DUSZY GRA / " + dateTimePicker5.Value + " / " + comboBox5.Text + " / x" + numericUpDown5.Value;
                        IsButton13 = false;
                        cena(film13, sum);
                    }
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            visible_false(dateTimePicker6, button20, comboBox6, label14, numericUpDown6);
            if (IsButton14 == true)
            {
                if (comboBox6.Text.Contains("Ulgowy/Normalny"))
                {
                    errorProvider1.SetError(comboBox6, "Wybierz rodzaj biletu!");
                    visible_true(dateTimePicker6, button20, comboBox6, label14, numericUpDown6);
                }
                else
                {
                    errorProvider1.Clear();
                    int sum = Decimal.ToInt32(numericUpDown6.Value);
                    string date = dateTimePicker5.Value.ToShortDateString();
                    if (film14 != null)
                    {
                        string rodzaj = comboBox6.Text;
                        if (film14.Contains(date))
                        {
                            if (film13.Contains(rodzaj))
                            {
                                film14 = " / + x" + numericUpDown6.Value;
                                nowa_cena(rodzaj, sum);
                            }
                            else
                            {
                                film14 += " / " + rodzaj + " / x" + numericUpDown6.Value;
                                nowa_cena(rodzaj, sum);
                            }
                        }
                        else
                        {
                            film14 += " / " + dateTimePicker6.Value + " / " + comboBox6.Text + " / x" + numericUpDown6.Value;
                            nowa_cena(rodzaj, sum);
                        }
                    }
                    else
                    {
                        film14 = "NIE CZAS UMIERAĆ / " + dateTimePicker6.Value + " / " + comboBox6.Text + " / x" + numericUpDown6.Value;
                        IsButton14 = false;
                        cena(film14, sum);
                    }
                }
            }
        }
    }
}
