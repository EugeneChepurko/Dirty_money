using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Dirty_money
{
    public partial class MainWindow : Window
    {
        // 1,2,3 extruders
        const double mach420_459 = 0.34304;
        const double oper420_459 = 0.23757;

        const double mach460_549 = 0.27408;
        const double oper460_549 = 0.1897;

        const double mach550_600 = 0.24608;
        const double oper550_600 = 0.16973;

        const double mach601_999 = 0.1864;
        const double oper601_999 = 0.128;

        const double mach1000_1800 = 0.35776;
        const double oper1000_1800 = 0.24678;

        const double mach600_850_color = 0.22;
        const double oper600_850_color = 0.1527;

        const double mach1000_1800_color = 0.42112;
        const double oper1000_1800_color = 0.32692;

        // 4 extruder
        const double mach1000_1800_4EX = 0.548;
        const double oper1000_1800_4EX = 0.37786;

        const double mach1000_1800_color_4EX = 0.56448;
        const double oper1000_1800_color_4EX = 0.38925;
        // FBR
        const double mach1500_1700_FBR_4EX = 0.548;
        const double oper1500_1700_FBR_4EX = 0.37786;

        const double mach1500_1700_color_FBR_4EX = 0.56448;
        const double oper1500_1700_color_FBR_4EX = 0.38925;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calc(object sender, RoutedEventArgs e)
        {
            double result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11 = 0;
            double sumSalary = 0;

            try
            {
                //420 - 440
                if (cbMach.Text == "Машинист")
                {
                    if (tbRate1.Text != "" && tbKg1.Text != "")
                    {
                        result1 = double.Parse(tbKg1.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate1.Text, CultureInfo.InvariantCulture) * mach420_459;
                        tbCash1.Text = result1.ToString();
                        tbCash12.Text += tbCash1.Text;
                        tbCash12.Text = tbCash12.ToString();
                    }
                }
                if (cbMach.Text == "Оператор")
                {
                    if (tbRate1.Text != "" && tbKg1.Text != "")
                    {
                        result1 = double.Parse(tbKg1.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate1.Text, CultureInfo.InvariantCulture) * oper420_459;
                        tbCash1.Text = result1.ToString();
                        tbCash12.Text += tbCash1.Text;
                    }
                }

                //460 - 549
                if (cbMach.Text == "Машинист")
                {
                    if (tbRate2.Text != "" && tbKg2.Text != "")
                    {
                        result2 = double.Parse(tbKg2.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate2.Text, CultureInfo.InvariantCulture) * mach460_549;
                        tbCash2.Text = result2.ToString();
                        tbCash12.Text += tbCash2.Text;
                        tbCash12.Text = tbCash12.ToString();
                    }
                }
                if (cbMach.Text == "Оператор")
                {
                    if (tbRate2.Text != "" && tbKg2.Text != "")
                    {
                        result2 = double.Parse(tbKg2.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate2.Text, CultureInfo.InvariantCulture) * oper460_549;
                        tbCash2.Text = result2.ToString();
                        tbCash12.Text += tbCash2.Text;
                        tbCash12.Text = tbCash12.ToString();
                    }
                }

                //550 - 600
                if (cbMach.Text == "Машинист")
                {
                    if (tbRate3.Text != "" && tbKg3.Text != "")
                    {
                        result3 = double.Parse(tbKg3.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate3.Text, CultureInfo.InvariantCulture) * mach550_600;
                        tbCash3.Text = result3.ToString();
                    }
                }
                if (cbMach.Text == "Оператор")
                {
                    if (tbRate3.Text != "" && tbKg3.Text != "")
                    {
                        result3 = double.Parse(tbKg3.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate3.Text, CultureInfo.InvariantCulture) * oper550_600;
                        tbCash3.Text = result3.ToString();
                    }
                }

                //601 - 999
                if (cbMach.Text == "Машинист")
                {
                    if (tbRate4.Text != "" && tbKg4.Text != "")
                    {
                        result4 = double.Parse(tbKg4.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate4.Text, CultureInfo.InvariantCulture) * mach601_999;
                        tbCash4.Text = result4.ToString();
                    }
                }
                if (cbMach.Text == "Оператор")
                {
                    if (tbRate4.Text != "" && tbKg4.Text != "")
                    {
                        result4 = double.Parse(tbKg4.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate4.Text, CultureInfo.InvariantCulture) * oper601_999;
                        tbCash4.Text = result4.ToString();
                    }
                }

                //1000 - 1800
                if (cbMach.Text == "Машинист")
                {
                    if (tbRate5.Text != "" && tbKg5.Text != "")
                    {
                        result5 = double.Parse(tbKg5.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate5.Text, CultureInfo.InvariantCulture) * mach1000_1800;
                        tbCash5.Text = result5.ToString();
                    }
                }
                if (cbMach.Text == "Оператор")
                {
                    if (tbRate5.Text != "" && tbKg5.Text != "")
                    {
                        result5 = double.Parse(tbKg5.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate5.Text, CultureInfo.InvariantCulture) * oper1000_1800;
                        tbCash5.Text = result5.ToString();
                    }
                }

                //600 - 850 color
                if (cbMach.Text == "Машинист")
                {
                    if (tbRate6.Text != "" && tbKg6.Text != "")
                    {
                        result6 = double.Parse(tbKg6.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate6.Text, CultureInfo.InvariantCulture) * mach600_850_color;
                        tbCash6.Text = result6.ToString();
                    }
                }
                if (cbMach.Text == "Оператор")
                {
                    if (tbRate6.Text != "" && tbKg6.Text != "")
                    {
                        result6 = double.Parse(tbKg6.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate6.Text, CultureInfo.InvariantCulture) * oper600_850_color;
                        tbCash6.Text = result6.ToString();
                    }
                }

                //1000 - 1800 color
                if (cbMach.Text == "Машинист")
                {
                    if (tbRate7.Text != "" && tbKg7.Text != "")
                    {
                        result7 = double.Parse(tbKg7.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate7.Text, CultureInfo.InvariantCulture) * mach1000_1800_color;
                        tbCash7.Text = result7.ToString();
                    }
                }
                if (cbMach.Text == "Оператор")
                {
                    if (tbRate7.Text != "" && tbKg7.Text != "")
                    {
                        result7 = double.Parse(tbKg7.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate7.Text, CultureInfo.InvariantCulture) * oper1000_1800_color;
                        tbCash7.Text = result7.ToString();
                    }
                }

                //1000 - 1800 4ex
                if (cbMach.Text == "Машинист")
                {
                    if (tbRate8.Text != "" && tbKg8.Text != "")
                    {
                        result8 = double.Parse(tbKg8.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate8.Text, CultureInfo.InvariantCulture) * mach1000_1800_4EX;
                        tbCash8.Text = result8.ToString();
                    }
                }
                if (cbMach.Text == "Оператор")
                {
                    if (tbRate8.Text != "" && tbKg8.Text != "")
                    {
                        result8 = double.Parse(tbKg8.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate8.Text, CultureInfo.InvariantCulture) * oper1000_1800_4EX;
                        tbCash8.Text = result8.ToString();
                    }
                }

                //1000 - 1800 4ex color
                if (cbMach.Text == "Машинист")
                {
                    if (tbRate9.Text != "" && tbKg9.Text != "")
                    {
                        result9 = double.Parse(tbKg9.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate9.Text, CultureInfo.InvariantCulture) * mach1000_1800_color_4EX;
                        tbCash9.Text = result9.ToString();
                    }
                }
                if (cbMach.Text == "Оператор")
                {
                    if (tbRate9.Text != "" && tbKg9.Text != "")
                    {
                        result9 = double.Parse(tbKg9.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate9.Text, CultureInfo.InvariantCulture) * oper1000_1800_color_4EX;
                        tbCash9.Text = result9.ToString();
                    }
                }

                //1500 - 1700 4ex FBR
                if (cbMach.Text == "Машинист")
                {
                    if (tbRate10.Text != "" && tbKg10.Text != "")
                    {
                        result10 = double.Parse(tbKg10.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate10.Text, CultureInfo.InvariantCulture) * mach1500_1700_FBR_4EX;
                        tbCash10.Text = result10.ToString();
                    }
                }
                if (cbMach.Text == "Оператор")
                {
                    if (tbRate10.Text != "" && tbKg10.Text != "")
                    {
                        result10 = double.Parse(tbKg10.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate10.Text, CultureInfo.InvariantCulture) * oper1500_1700_FBR_4EX;
                        tbCash10.Text = result10.ToString();
                    }
                }
                //1500 - 1700 4ex FBR color
                if (cbMach.Text == "Машинист")
                {
                    if (tbRate11.Text != "" && tbKg11.Text != "")
                    {
                        result11 = double.Parse(tbKg11.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate11.Text, CultureInfo.InvariantCulture) * mach1500_1700_color_FBR_4EX;
                        tbCash11.Text = result11.ToString();
                    }
                }
                if (cbMach.Text == "Оператор")
                {
                    if (tbRate11.Text != "" && tbKg11.Text != "")
                    {
                        result11 = double.Parse(tbKg11.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate11.Text, CultureInfo.InvariantCulture) * oper1500_1700_color_FBR_4EX;
                        tbCash11.Text = result11.ToString();
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }

        private void TbKg1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9.]+");
        }
    }
}
