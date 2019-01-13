using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        const double mach1000_1800_color = 0.42112;
        const double oper1000_1800_color = 0.32692;

        const double mach600_850_color = 0.22;
        const double oper600_850_color = 0.1527;

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
            double result1, result2, result3, result4, result5, result6, result7, result8 = 0;
            try
            {
                //420 - 440
                if ((cbMach.Text == "Машинист" && cbExt.Text == "1,2,3 экс." && cbFBR.Text == "НЕТ") || cbFBR.SelectedIndex == -1)
                {
                    if (tbRate1.Text != "" && tbKg1.Text != "")
                    {
                        result1 = double.Parse(tbKg1.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate1.Text, CultureInfo.InvariantCulture) * mach420_459;
                        tbCash1.Text = result1.ToString();
                    }
                }
                if ((cbMach.Text == "Оператор" && cbExt.Text == "1,2,3 экс." && cbFBR.Text == "НЕТ") || cbFBR.SelectedIndex == -1)
                {
                    if (tbRate1.Text != "" && tbKg1.Text != "")
                    {
                        result1 = double.Parse(tbKg1.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate1.Text, CultureInfo.InvariantCulture) * oper420_459;
                        tbCash1.Text = result1.ToString();
                    }
                }

                //460 - 549
                if ((cbMach.Text == "Машинист" && cbExt.Text == "1,2,3 экс." && cbFBR.Text == "НЕТ") || cbFBR.SelectedIndex == -1)
                {
                    if (tbRate2.Text != "" && tbKg2.Text != "")
                    {
                        result2 = double.Parse(tbKg2.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate2.Text, CultureInfo.InvariantCulture) * mach460_549;
                        tbCash2.Text = result2.ToString();
                    }
                }
                if ((cbMach.Text == "Оператор" && cbExt.Text == "1,2,3 экс." && cbFBR.Text == "НЕТ") || cbFBR.SelectedIndex == -1)
                {
                    if (tbRate2.Text != "" && tbKg2.Text != "")
                    {
                        result2 = double.Parse(tbKg2.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate2.Text, CultureInfo.InvariantCulture) * oper460_549;
                        tbCash2.Text = result2.ToString();
                    }
                }

                //550 - 600
                if ((cbMach.Text == "Машинист" && cbExt.Text == "1,2,3 экс." && cbFBR.Text == "НЕТ") || cbFBR.SelectedIndex == -1)
                {
                    if (tbRate3.Text != "" && tbKg3.Text != "")
                    {
                        result3 = double.Parse(tbKg3.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate3.Text, CultureInfo.InvariantCulture) * mach550_600;
                        tbCash3.Text = result3.ToString();
                    }
                }
                if ((cbMach.Text == "Оператор" && cbExt.Text == "1,2,3 экс." && cbFBR.Text == "НЕТ") || cbFBR.SelectedIndex == -1)
                {
                    if (tbRate3.Text != "" && tbKg3.Text != "")
                    {
                        result3 = double.Parse(tbKg3.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate3.Text, CultureInfo.InvariantCulture) * oper550_600;
                        tbCash3.Text = result3.ToString();
                    }
                }
                //601 - 999
                if ((cbMach.Text == "Машинист" && cbExt.Text == "1,2,3 экс." && cbFBR.Text == "НЕТ") || cbFBR.SelectedIndex == -1)
                {
                    if (tbRate4.Text != "" && tbKg4.Text != "")
                    {
                        result4 = double.Parse(tbKg4.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate4.Text, CultureInfo.InvariantCulture) * mach601_999;
                        tbCash4.Text = result4.ToString();
                    }
                }
                if ((cbMach.Text == "Оператор" && cbExt.Text == "1,2,3 экс." && cbFBR.Text == "НЕТ") || cbFBR.SelectedIndex == -1)
                {
                    if (tbRate4.Text != "" && tbKg4.Text != "")
                    {
                        result4 = double.Parse(tbKg4.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate4.Text, CultureInfo.InvariantCulture) * oper601_999;
                        tbCash4.Text = result4.ToString();
                    }
                }
                //1000 - 1800
                if ((cbMach.Text == "Машинист" && cbExt.Text == "1,2,3 экс." && cbFBR.Text == "НЕТ") || cbFBR.SelectedIndex == -1)
                {
                    if (tbRate5.Text != "" && tbKg4.Text != "")
                    {
                        result5 = double.Parse(tbKg5.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate5.Text, CultureInfo.InvariantCulture) * mach1000_1800;
                        tbCash5.Text = result5.ToString();
                    }
                }
                if ((cbMach.Text == "Оператор" && cbExt.Text == "1,2,3 экс." && cbFBR.Text == "НЕТ") || cbFBR.SelectedIndex == -1)
                {
                    if (tbRate5.Text != "" && tbKg5.Text != "")
                    {
                        result5 = double.Parse(tbKg5.Text, CultureInfo.InvariantCulture) * double.Parse(tbRate5.Text, CultureInfo.InvariantCulture) * oper1000_1800;
                        tbCash5.Text = result5.ToString();
                    }
                }
                //
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
