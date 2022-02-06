using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarkStartup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            question1.Focus();
        }
        public string[] SelectedValue { get; private set; }

        //public string SelectedValue1 { get; private set; }
        //public string SelectedValue2 { get; private set; }
        //public string SelectedValue3 { get; private set; }
        //public string SelectedValue4 { get; private set; }
        //public string SelectedValue5 { get; private set; }
        //public string SelectedValue6 { get; private set; }
        //public string SelectedValue7 { get; private set; }
        //public string SelectedValue8 { get; private set; }
        //public string SelectedValue9 { get; private set; }
        //public string SelectedValue10 { get; private set; }
        //public string SelectedValue11 { get; private set; }
        //public string SelectedValue12 { get; private set; }
        //public string SelectedValue13 { get; private set; }
        //public string SelectedValue14 { get; private set; }
        //public string SelectedValue15 { get; private set; }
        //public string SelectedValue16 { get; private set; }
        //public string SelectedValue17 { get; private set; }
        //public string SelectedValue18 { get; private set; }
        //public string SelectedValue19 { get; private set; }
        //public string SelectedValue20 { get; private set; }
        //public string SelectedValue21 { get; private set; }
        //public string SelectedValue22 { get; private set; }
        //public string SelectedValue23 { get; private set; }
        //public string SelectedValue24 { get; private set; }




        private void Button_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < 24; i++)
            {
                if (SelectedValue[i] == null)
                {
                    MessageBox.Show("Поставте всюди галочки!", "Помилка!");
                    break;
                }
            }

            //MessageBox.Show(SelectedValue[1]);
            //MessageBox.Show(SelectedValue[2]);
            //MessageBox.Show(SelectedValue[3]);

            double[] quest = new double[24];
            double quest1 = Convert.ToDouble(question1.Text);
            quest[0] = quest1;
            double quest2 = Convert.ToDouble(question2.Text);
            quest[1] = quest2;
            double quest3 = Convert.ToDouble(question3.Text);
            quest[2] = quest3;
            double quest4 = Convert.ToDouble(question4.Text);
            quest[3] = quest4;
            double quest5 = Convert.ToDouble(question5.Text);
            quest[4] = quest5;
            double quest6 = Convert.ToDouble(question6.Text);
            quest[5] = quest6;
            double quest7 = Convert.ToDouble(question7.Text);
            quest[6] = quest7;
            double quest8 = Convert.ToDouble(question8.Text);
            quest[7] = quest8;
            double quest9 = Convert.ToDouble(question9.Text);
            quest[8] = quest9;
            double quest10 = Convert.ToDouble(question10.Text);
            quest[9] = quest10;
            double quest11 = Convert.ToDouble(question11.Text);
            quest[10] = quest11;
            double quest12 = Convert.ToDouble(question12.Text);
            quest[11] = quest12;
            double quest13 = Convert.ToDouble(question13.Text);
            quest[12] = quest13;
            double quest14 = Convert.ToDouble(question14.Text);
            quest[13] = quest14;
            double quest15 = Convert.ToDouble(question15.Text);
            quest[14] = quest15;
            double quest16 = Convert.ToDouble(question16.Text);
            quest[15] = quest16;
            double quest17 = Convert.ToDouble(question17.Text);
            quest[16] = quest17;
            double quest18 = Convert.ToDouble(question18.Text);
            quest[17] = quest18;
            double quest19 = Convert.ToDouble(question19.Text);
            quest[18] = quest19;
            double quest20 = Convert.ToDouble(question20.Text);
            quest[19] = quest20;
            double quest21 = Convert.ToDouble(question21.Text);
            quest[20] = quest21;
            double quest22 = Convert.ToDouble(question22.Text);
            quest[21] = quest22;
            double quest23 = Convert.ToDouble(question23.Text);
            quest[22] = quest23;
            double quest24 = Convert.ToDouble(question24.Text);
            quest[23] = quest24;





            // group 1
            double[] counter1 = new double[5];

            for (int i = 0; i < 9; i++)
            {
                if (SelectedValue[i] == "Н")
                {
                    counter1[0] = counter1[0] + 1;
                }
                else if (SelectedValue[i] == "НС")
                {
                    counter1[1] = counter1[1] + 1;
                }
                else if (SelectedValue[i] == "С")
                {
                    counter1[2] = counter1[2] + 1;
                }
                else if (SelectedValue[i] == "ВС")
                {
                    counter1[3] = counter1[3] + 1;
                }
                else if (SelectedValue[i] == "В")
                {
                    counter1[4] = counter1[4] + 1;
                }
            }

            double max1 = -1;
            int index1 = -1;
            for (int i = 0; i < counter1.Length; i++)
                if (max1 <= counter1[i])
                {
                    max1 = counter1[i];
                    index1 = i;
                }

            //MessageBox.Show(index1.ToString());




            // group 2
            double[] counter2 = new double[5];

            for (int i = 9; i < 14; i++)
            {
                if (SelectedValue[i] == "Н")
                {
                    counter2[0] = counter2[0] + 1;
                }
                else if (SelectedValue[i] == "НС")
                {
                    counter2[1] = counter2[1] + 1;
                }
                else if (SelectedValue[i] == "С")
                {
                    counter2[2] = counter2[2] + 1;
                }
                else if (SelectedValue[i] == "ВС")
                {
                    counter2[3] = counter2[3] + 1;
                }
                else if (SelectedValue[i] == "В")
                {
                    counter2[4] = counter2[4] + 1;
                }
            }
            double max2 = -1;
            int index2 = -1;
            for (int i = 0; i < counter2.Length; i++)
                if (max2 <= counter2[i])
                {
                    max2 = counter2[i];
                    index2 = i;
                }

            //MessageBox.Show(index2.ToString());

            // group 3
            double[] counter3 = new double[5];

            for (int i = 14; i < 19; i++)
            {
                if (SelectedValue[i] == "Н")
                {
                    counter3[0] = counter3[0] + 1;
                }
                else if (SelectedValue[i] == "НС")
                {
                    counter3[1] = counter3[1] + 1;
                }
                else if (SelectedValue[i] == "С")
                {
                    counter3[2] = counter3[2] + 1;
                }
                else if (SelectedValue[i] == "ВС")
                {
                    counter3[3] = counter3[3] + 1;
                }
                else if (SelectedValue[i] == "В")
                {
                    counter3[4] = counter3[4] + 1;
                }
            }

            double max3 = -1;
            int index3 = -1;
            for (int i = 0; i < counter3.Length; i++)
                if (max3 <= counter3[i])
                {
                    max3 = counter3[i];
                    index3 = i;
                }

            //MessageBox.Show(index3.ToString());

            // group 4
            double[] counter4 = new double[5];

            for (int i = 19; i < 24; i++)
            {
                if (SelectedValue[i] == "Н")
                {
                    counter4[0] = counter4[0] + 1;
                }
                else if (SelectedValue[i] == "НС")
                {
                    counter4[1] = counter4[1] + 1;
                }
                else if (SelectedValue[i] == "С")
                {
                    counter4[2] = counter4[2] + 1;
                }
                else if (SelectedValue[i] == "ВС")
                {
                    counter4[3] = counter4[3] + 1;
                }
                else if (SelectedValue[i] == "В")
                {
                    counter4[4] = counter4[4] + 1;
                }
            }
            double max4 = -1;
            int index4 = -1;
            for (int i = 0; i < counter4.Length; i++)
                if (max4 <= counter4[i])
                {
                    max4 = counter4[i];
                    index4 = i;
                }

            //MessageBox.Show(index4.ToString());
            //group1
            if (index1 == 0)
                letterResForm1.Text = "Н";
            else if (index1 == 1)
                letterResForm1.Text = "НС";
            else if (index1 == 2)
                letterResForm1.Text = "С";
            else if (index1 == 3)
                letterResForm1.Text = "ВС";
            else if (index1 == 4)
                letterResForm1.Text = "В";

            //group2
            if (index2 == 0)
                letterResForm2.Text = "Н";
            else if (index2 == 1)
                letterResForm2.Text = "НС";
            else if (index2 == 2)
                letterResForm2.Text = "С";
            else if (index2 == 3)
                letterResForm2.Text = "ВС";
            else if (index2 == 4)
                letterResForm2.Text = "В";
            //group3
            if (index3 == 0)
                letterResForm3.Text = "Н";
            else if (index3 == 1)
                letterResForm3.Text = "НС";
            else if (index3 == 2)
                letterResForm3.Text = "С";
            else if (index3 == 3)
                letterResForm3.Text = "ВС";
            else if (index3 == 4)
                letterResForm3.Text = "В";
            //group4
            if (index4 == 0)
                letterResForm4.Text = "Н";
            else if (index4 == 1)
                letterResForm4.Text = "НС";
            else if (index4 == 2)
                letterResForm4.Text = "С";
            else if (index4 == 3)
                letterResForm4.Text = "ВС";
            else if (index4 == 4)
                letterResForm4.Text = "В";





            double[] letterList = new double[24];

            for (int i = 0; i < 24; i++)
            {
                if (SelectedValue[i] == "Н")
                {
                    letterList[i] = 0;
                }
                else if (SelectedValue[i] == "НС")
                {
                    letterList[i] = 1;
                }
                else if (SelectedValue[i] == "С")
                {
                    letterList[i] = 2;
                }
                else if (SelectedValue[i] == "ВС")
                {
                    letterList[i] = 3;
                }
                else if (SelectedValue[i] == "В")
                {
                    letterList[i] = 4;
                }
            }
            //MessageBox.Show(letterList[0].ToString());
            //MessageBox.Show(letterList[1].ToString());
            //MessageBox.Show(letterList[2].ToString());

            //group1
            double res1 = 0;
            for (int i = 0; i < 9; i++)
            {
                if (letterResForm1.Text == "Н")
                {
                    if (letterList[i] == 0)
                    {
                        res1 = res1 + quest[i];
                    }
                }
                else if (letterResForm1.Text == "НС")
                {
                    if (letterList[i] == 1)
                    {
                        res1 = res1 + quest[i];
                    }
                }
                else if (letterResForm1.Text == "С")
                {
                    if (letterList[i] == 2)
                    {
                        res1 = res1 + quest[i];
                    }
                }
                else if (letterResForm1.Text == "ВС")
                {
                    if (letterList[i] == 3)
                    {
                        res1 = res1 + quest[i];
                    }
                }
                else if (letterResForm1.Text == "В")
                {
                    if (letterList[i] == 4)
                    {
                        res1 = res1 + quest[i];
                    }
                }
            }
            //MessageBox.Show(res1.ToString());


            //group2
            double res2 = 0;
            for (int i = 9; i < 14; i++)
            {
                if (letterResForm2.Text == "Н")
                {
                    if (letterList[i] == 0)
                    {
                        res2 = res2 + quest[i];
                    }
                }
                else if (letterResForm2.Text == "НС")
                {
                    if (letterList[i] == 1)
                    {
                        res2 = res2 + quest[i];
                    }
                }
                else if (letterResForm2.Text == "С")
                {
                    if (letterList[i] == 2)
                    {
                        res2 = res2 + quest[i];
                    }
                }
                else if (letterResForm2.Text == "ВС")
                {
                    if (letterList[i] == 3)
                    {
                        res2 = res2 + quest[i];
                    }
                }
                else if (letterResForm2.Text == "В")
                {
                    if (letterList[i] == 4)
                    {
                        res2 = res2 + quest[i];
                    }
                }
            }
            //  MessageBox.Show(res2.ToString());

            //group3
            double res3 = 0;
            for (int i = 14; i < 19; i++)
            {
                if (letterResForm3.Text == "Н")
                {
                    if (letterList[i] == 0)
                    {
                        res3 = res3 + quest[i];
                    }
                }
                else if (letterResForm3.Text == "НС")
                {
                    if (letterList[i] == 1)
                    {
                        res3 = res3 + quest[i];
                    }
                }
                else if (letterResForm3.Text == "С")
                {
                    if (letterList[i] == 2)
                    {
                        res3 = res3 + quest[i];
                    }
                }
                else if (letterResForm3.Text == "ВС")
                {
                    if (letterList[i] == 3)
                    {
                        res3 = res3 + quest[i];
                    }
                }
                else if (letterResForm3.Text == "В")
                {
                    if (letterList[i] == 4)
                    {
                        res3 = res3 + quest[i];
                    }
                }
            }
            // MessageBox.Show(res3.ToString());


            //group4
            double res4 = 0;
            for (int i = 19; i < 24; i++)
            {
                if (letterResForm4.Text == "Н")
                {
                    if (letterList[i] == 0)
                    {
                        res4 = res4 + quest[i];
                    }
                }
                else if (letterResForm4.Text == "НС")
                {
                    if (letterList[i] == 1)
                    {
                        res4 = res4 + quest[i];
                    }
                }
                else if (letterResForm4.Text == "С")
                {
                    if (letterList[i] == 2)
                    {
                        res4 = res4 + quest[i];
                    }
                }
                else if (letterResForm4.Text == "ВС")
                {
                    if (letterList[i] == 3)
                    {
                        res4 = res4 + quest[i];
                    }
                }
                else if (letterResForm4.Text == "В")
                {
                    if (letterList[i] == 4)
                    {
                        res4 = res4 + quest[i];
                    }
                }
            }
            //MessageBox.Show(res4.ToString());


            double balRes1 = res1 / max1;
            double balRes2 = res2 / max2;
            double balRes3 = res3 / max3;
            double balRes4 = res4 / max4;

            balResForm1.Text = Math.Round(balRes1, 2).ToString();
            balResForm2.Text = Math.Round(balRes2, 2).ToString();
            balResForm3.Text = Math.Round(balRes3, 2).ToString();
            balResForm4.Text = Math.Round(balRes4, 2).ToString();



            double x0 = 0;
            double xI = 0;
            double xF = 0;
            double xS = 0;

            // [a;b],  Н – [0; 20], НС – [20; 40], С – [40;60], ВС – [60; 80], В – [80; 100].
            //x0
            if (balRes1 <= 0.5)
            {
                if (index1 == 0)
                    x0 = (Math.Sqrt((1 - balRes1) / 2)) * 20;
                else if (index1 == 1)
                    x0 = (Math.Sqrt((1 - balRes1) / 2)) * (40 - 20) + 20;
                else if (index1 == 2)
                    x0 = (Math.Sqrt((1 - balRes1) / 2)) * (60 - 40) + 40;
                else if (index1 == 3)
                    x0 = (Math.Sqrt((1 - balRes1) / 2)) * (80 - 60) + 60;
                else if (index1 == 4)
                    x0 = (Math.Sqrt((1 - balRes1) / 2)) * (100 - 80) + 80;
            }
            else
            {
                if (index1 == 0)
                    x0 = 20 - (Math.Sqrt((1 - balRes1) / 2)) * 20;
                else if (index1 == 1)
                    x0 = 40 - (Math.Sqrt((1 - balRes1) / 2)) * (40 - 20);
                else if (index1 == 2)
                    x0 = 60 - (Math.Sqrt((1 - balRes1) / 2)) * (60 - 40);
                else if (index1 == 3)
                    x0 = 80 - (Math.Sqrt((1 - balRes1) / 2)) * (80 - 60);
                else if (index1 == 4)
                    x0 = 100 - (Math.Sqrt((1 - balRes1) / 2)) * (100 - 80);

            }

            //xI
            if (balRes2 <= 0.5)
            {
                if (index2 == 0)
                    xI = (Math.Sqrt((1 - balRes2) / 2)) * 20;
                else if (index2 == 1)
                    xI = (Math.Sqrt((1 - balRes2) / 2)) * (40 - 20) + 20;
                else if (index2 == 2)
                    xI = (Math.Sqrt((1 - balRes2) / 2)) * (60 - 40) + 40;
                else if (index2 == 3)
                    xI = (Math.Sqrt((1 - balRes2) / 2)) * (80 - 60) + 60;
                else if (index2 == 4)
                    xI = (Math.Sqrt((1 - balRes2) / 2)) * (100 - 80) + 80;
            }
            else
            {
                if (index2 == 0)
                    xI = 20 - (Math.Sqrt((1 - balRes2) / 2)) * 20;
                else if (index2 == 1)
                    xI = 40 - (Math.Sqrt((1 - balRes2) / 2)) * (40 - 20);
                else if (index2 == 2)
                    xI = 60 - (Math.Sqrt((1 - balRes2) / 2)) * (60 - 40);
                else if (index2 == 3)
                    xI = 80 - (Math.Sqrt((1 - balRes2) / 2)) * (80 - 60);
                else if (index2 == 4)
                    xI = 100 - (Math.Sqrt((1 - balRes2) / 2)) * (100 - 80);

            }

            //xF
            if (balRes3 <= 0.5)
            {
                if (index3 == 0)
                    xF = (Math.Sqrt((1 - balRes3) / 2)) * 20;
                else if (index3 == 1)
                    xF = (Math.Sqrt((1 - balRes3) / 2)) * (40 - 20) + 20;
                else if (index3 == 2)
                    xF = (Math.Sqrt((1 - balRes3) / 2)) * (60 - 40) + 40;
                else if (index3 == 3)
                    xF = (Math.Sqrt((1 - balRes3) / 2)) * (80 - 60) + 60;
                else if (index3 == 4)
                    xF = (Math.Sqrt((1 - balRes3) / 2)) * (100 - 80) + 80;
            }
            else
            {
                if (index3 == 0)
                    xF = 20 - (Math.Sqrt((1 - balRes3) / 2)) * 20;
                else if (index3 == 1)
                    xF = 40 - (Math.Sqrt((1 - balRes3) / 2)) * (40 - 20);
                else if (index3 == 2)
                    xF = 60 - (Math.Sqrt((1 - balRes3) / 2)) * (60 - 40);
                else if (index3 == 3)
                    xF = 80 - (Math.Sqrt((1 - balRes3) / 2)) * (80 - 60);
                else if (index3 == 4)
                    xF = 100 - (Math.Sqrt((1 - balRes3) / 2)) * (100 - 80);

            }



            //xS
            if (balRes4 <= 0.5)
            {
                if (index4 == 0)
                    xS = (Math.Sqrt((1 - balRes4) / 2)) * 20;
                else if (index4 == 1)
                    xS = (Math.Sqrt((1 - balRes4) / 2)) * (40 - 20) + 20;
                else if (index4 == 2)
                    xS = (Math.Sqrt((1 - balRes4) / 2)) * (60 - 40) + 40;
                else if (index4 == 3)
                    xS = (Math.Sqrt((1 - balRes4) / 2)) * (80 - 60) + 60;
                else if (index4 == 4)
                    xS = (Math.Sqrt((1 - balRes4) / 2)) * (100 - 80) + 80;
            }
            else
            {
                if (index4 == 0)
                    xS = 20 - (Math.Sqrt((1 - balRes4) / 2)) * 20;
                else if (index4 == 1)
                    xS = 40 - (Math.Sqrt((1 - balRes4) / 2)) * (40 - 20);
                else if (index4 == 2)
                    xS = 60 - (Math.Sqrt((1 - balRes4) / 2)) * (60 - 40);
                else if (index4 == 3)
                    xS = 80 - (Math.Sqrt((1 - balRes4) / 2)) * (80 - 60);
                else if (index4 == 4)
                    xS = 100 - (Math.Sqrt((1 - balRes4) / 2)) * (100 - 80);

            }

            //MessageBox.Show(x0.ToString());
            //MessageBox.Show(xI.ToString());
            //MessageBox.Show(xF.ToString());
            //MessageBox.Show(xS.ToString());

            double z0 = x0 / 100;
            double zI = xI / 100;
            double zF = xF / 100;
            double zS = xS / 100;

            z0Form.Text = "z0: " + Math.Round(z0, 2);
            zIForm.Text = "zI: " + Math.Round(zI, 2);
            zFForm.Text = "zF: " + Math.Round(zF, 2);
            zSForm.Text = "zS: " + Math.Round(zS, 2);


            double result = ((1 - z0) + (1 - zI) + (1 - zF) + (1 - zS)) / 4;

            //Вивід даних
            markForm.Text = Math.Round(result, 2).ToString();
            if (result > 0.87)
            {
                conclusion.Text = "незначний ступінь ризику проекту";
            }
            else if (result > 0.67 && result <= 0.87)
            {
                conclusion.Text = "низький ступінь ризику проекту";
            }
            else if (result > 0.36 && result <= 0.67)
            {
                conclusion.Text = "середній ступінь ризику проекту";
            }
            else if (result > 0.21 && result <= 0.36)
            {
                conclusion.Text = "високий ступінь ризику проекту";
            }
            else if (result >= 0 && result <= 0.21)
            {
                conclusion.Text = "граничний ступінь ризику проекту";
            }
            else conclusion.Text = "це точно стартап?";
            //MessageBox.Show(result.ToString());

            //MessageBox.Show(letterMark[3].ToString());
            //MessageBox.Show(letterMark[4].ToString());
            //letterMark[0] = letterMark[0] * quest1;
            //MessageBox.Show(letterMark[0].ToString());
            //letterMark[1] = letterMark[1] * quest2;
            //MessageBox.Show(letterMark[1].ToString());
            //letterMark[2] = letterMark[2] * quest3;
            //MessageBox.Show(letterMark[2].ToString());
            //letterMark[3] = letterMark[3] * quest4;
            //MessageBox.Show(letterMark[3].ToString());
            //letterMark[4] = letterMark[4] * quest5;
            //MessageBox.Show(letterMark[4].ToString());
            //letterMark[5] = letterMark[5] * quest6;
            //letterMark[6] = letterMark[6] * quest7;
            //letterMark[7] = letterMark[7] * quest8;
            //letterMark[8] = letterMark[8] * quest9;
            //letterMark[9] = letterMark[9] * quest10;
            //letterMark[10] = letterMark[10] * quest11;
            //letterMark[11] = letterMark[11] * quest12;
            //letterMark[12] = letterMark[12] * quest13;
            //letterMark[13] = letterMark[13] * quest14;
            //letterMark[14] = letterMark[14] * quest15;
            //letterMark[15] = letterMark[15] * quest16;
            //letterMark[16] = letterMark[16] * quest17;
            //letterMark[17] = letterMark[17] * quest18;
            //letterMark[18] = letterMark[18] * quest19;
            //letterMark[19] = letterMark[19] * quest20;
            //letterMark[20] = letterMark[20] * quest21;
            //letterMark[21] = letterMark[21] * quest22;
            //letterMark[22] = letterMark[22] * quest23;
            //letterMark[23] = letterMark[23] * quest24;


            //// group 1
            //double group1 = 0; 
            //for (int i = 0; i < 9; i++)
            //{
            //    group1 = group1 + Convert.ToDouble(letterMark[i]);
            //}
            //group1 = group1 / 9;

            //// group 2
            //double group2 = 0;
            //for (int i = 9;  i<14; i++)
            //{
            //    group2 = group2 + Convert.ToDouble(letterMark[i]);
            //}
            //group2 = group2 / 5;

            //// group 3
            //double group3 = 0;
            //for (int i = 14; i < 19; i++)
            //{
            //    group3 = group3 + Convert.ToDouble(letterMark[i]);
            //}
            //group3 = group3 / 5;

            //// group 1
            //double group4 = 0;
            //for (int i = 19; i < 24; i++)
            //{
            //    group4 = group4 + Convert.ToDouble(letterMark[i]);
            //}
            //group4 = group4 / 5;

            //MessageBox.Show(group1.ToString());
            //MessageBox.Show(group2.ToString());
            //MessageBox.Show(group3.ToString());
            //MessageBox.Show(group4.ToString());


        }

        public void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SelectedValue = new string[24];
            if (sender is RadioButton item)
            {
                SelectedValue[0] = item.Content.ToString();
            }
        }

        public void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[1] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked3(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[2] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked4(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[3] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked5(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[4] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked6(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[5] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked7(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[6] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked8(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[7] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked9(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[8] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked10(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[9] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked11(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[10] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked12(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[11] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked13(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[12] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked14(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[13] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked15(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[14] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked16(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[15] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked17(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[16] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked18(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[17] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked19(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[18] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked20(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[19] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked21(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[20] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked22(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[21] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked23(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[22] = item.Content.ToString();
            }
        }

        private void RadioButton_Checked24(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedValue[23] = item.Content.ToString();
            }
        }
    }
}
