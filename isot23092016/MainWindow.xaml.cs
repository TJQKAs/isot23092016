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

namespace isot23092016
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Boolean var2 = false;
        public Boolean var4 = false;

        public TextBox tbxaSide;
        public TextBox tbxRadius;
        public TextBox tbxAngle;
        public TextBox tbxbSide;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aside"></param>
        /// <param name="bside"></param>
        /// <param name="aAngleg"></param>
        /// <returns></returns>
        public static List<string> getDataVar4(double aside, double bside, double aAngleg)
        {
            List<string> getDataTriangle = new List<string>();

            double aAngle = aAngleg * Math.PI / 180;
            double squareTriangle = (aside * bside * Math.Sin(aAngle)) / 2;
            double cside = Math.Pow((Math.Pow(aside,2) + Math.Pow(bside,2)-(2*aside*bside*Math.Cos(aAngle))), 0.5);
            double cAngle = cside / aside * Math.Sin(aAngle);
            double cAngleg = cAngle * 180 / Math.PI;
            double bAngle = (180 - aAngleg - cAngleg)*Math.PI/180;
            double bAngleg = bAngle * 180 / Math.PI;

            getDataTriangle.Add("Площадь треугольника " + squareTriangle + " кв.ед");
            getDataTriangle.Add("Длина A-стороны " + aside + " ед.");
            getDataTriangle.Add("Длина B-стороны " + bside + " ед.");
            getDataTriangle.Add("Длина C-стороны " + cside + " ед.");
            getDataTriangle.Add("A-угол " + aAngle + " рад");
            getDataTriangle.Add("B-угол " + bAngle + " рад");
            getDataTriangle.Add("C-угол " + cAngle + " рад");
            getDataTriangle.Add("A-угол " + aAngleg + " град.");
            getDataTriangle.Add("B-угол " + bAngleg + " град.");
            getDataTriangle.Add("C-угол " + cAngleg + " град.");
            return getDataTriangle;         
        }
        
        public static List<string> getDataVar2(double aside, double radius)
        {
            List<string> getDataTriagnle1 = new List<string>();
            double bside = (2 * radius * (aside - radius)) / (aside - 2 * radius);
            double cside = Math.Pow((Math.Pow(aside, 2) + Math.Pow(bside, 2)), 0.5);
            double square = aside * bside / 2;
            double aAngle = Math.Sin(aside / cside);
            double bAngle = Math.Sin(bside / cside);
            double cAngle = 90 * Math.PI / 180;
            double aAngleg = aAngle * 180 / Math.PI;
            double bAngleg = bAngle * 180 / Math.PI;
            double cAngleg = cAngle * 180 / Math.PI;

            getDataTriagnle1.Add("Площадь треугольника " + square + " кв.ед");
            getDataTriagnle1.Add("Длина A-стороны " + aside + " ед.");
            getDataTriagnle1.Add("Длина B-стороны " + bside + " ед.");
            getDataTriagnle1.Add("Длина C-стороны " + cside + " ед.");
            getDataTriagnle1.Add("A-угол " + aAngle + "рад");
            getDataTriagnle1.Add("B-угол " + bAngle + "рад");
            getDataTriagnle1.Add("C-угол " + cAngle + "рад");
            getDataTriagnle1.Add("A-угол " + aAngleg + "град.");
            getDataTriagnle1.Add("B-угол " + bAngleg + "град.");
            getDataTriagnle1.Add("C-угол " + cAngleg + "град.");
            return getDataTriagnle1;

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var4 = false;
            var2 = true;

            while (stcp1.Children.Count != 0)
            {
                int i = 0;
                stcp1.Children.RemoveAt(0);
                i++;
            }


            StackPanel stp1 = new StackPanel();
            stp1.Width = 200;
            stp1.Height = 100;
            TextBlock tb1 = new TextBlock();
            tb1.Height = 20;
            tb1.Width = 200;
            tb1.Background = Brushes.BurlyWood;
            tb1.Text = "Введите данные для рассчета варианта № 2";
            tb1.TextWrapping = TextWrapping.Wrap;
            tb1.TextAlignment = TextAlignment.Center;

            TextBlock tb2 = new TextBlock();
            tb2.Height = 20;
            tb2.Width = 200;
            tb2.Background = Brushes.LightCoral;
            tb2.Text = "Введите длину катета А";
            tb2.TextWrapping = TextWrapping.Wrap;
            tb2.TextAlignment = TextAlignment.Center;

            TextBox tbx1 = new TextBox();
            tbx1.Width = 200;
            tbx1.Height = 20;
            tbxaSide = tbx1;

            TextBlock tb3 = new TextBlock();
            tb3.Height = 20;
            tb3.Width = 200;
            tb3.Background = Brushes.LightCoral;
            tb3.Text = "Введите радиус";
            tb3.TextWrapping = TextWrapping.Wrap;
            tb3.TextAlignment = TextAlignment.Center;

            TextBox tbx2 = new TextBox();
            tbx1.Width = 200;
            tbx1.Height = 20;
            tbxRadius = tbx2;

            stp1.Children.Add(tb1);
            stp1.Children.Add(tb2);
            stp1.Children.Add(tbx1);
            stp1.Children.Add(tb3);
            stp1.Children.Add(tbx2);
            stcp1.Children.Add(stp1);
     
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            while (stcp1.Children.Count != 0)
            {
                int i = 0;
                stcp1.Children.RemoveAt(0);
                i++;
            }

            var4 = true;
            var2 = false;

            StackPanel stp1 = new StackPanel();
            stp1.Width = 200;
            stp1.Height = 180;
            TextBlock tb1 = new TextBlock();
            tb1.Height = 20;
            tb1.Width = 200;
            tb1.Background = Brushes.Honeydew;
            tb1.Text = "Введите данные для рассчета варианта № 4";
            tb1.TextWrapping = TextWrapping.Wrap;
            tb1.TextAlignment = TextAlignment.Center;

            TextBlock tb2 = new TextBlock();
            tb2.Height = 20;
            tb2.Width = 200;
            tb2.Background = Brushes.Lavender;
            tb2.Text = "Введите длину стороны А";
            tb2.TextWrapping = TextWrapping.Wrap;
            tb2.TextAlignment = TextAlignment.Center;

            TextBox tbx1 = new TextBox();
            tbx1.Width = 200;
            tbx1.Height = 20;
            tbxaSide = tbx1;

            TextBlock tb4 = new TextBlock();
            tb4.Height = 20;
            tb4.Width = 200;
            tb4.Background = Brushes.Lavender;
            tb4.Text = "Введите длину стороны В";
            tb4.TextWrapping = TextWrapping.Wrap;
            tb4.TextAlignment = TextAlignment.Center;

            TextBox tbx3 = new TextBox();
            tbx3.Width = 200;
            tbx3.Height = 20;
            tbxbSide = tbx3;

            TextBlock tb3 = new TextBlock();
            tb3.Height = 40;
            tb3.Width = 200;
            tb3.Background = Brushes.Lavender;
            tb3.Text = "Введите значение угла в градусах между сторонами";
            tb3.TextWrapping = TextWrapping.Wrap;
            tb3.TextAlignment = TextAlignment.Center;

            TextBox tbx2 = new TextBox();
            tbx2.Width = 200;
            tbx2.Height = 20;
            tbxAngle = tbx2;

            stp1.Children.Add(tb1);
            stp1.Children.Add(tb2);
            stp1.Children.Add(tbx1);
            stp1.Children.Add(tb4);
            stp1.Children.Add(tbx3);
            stp1.Children.Add(tb3);
            stp1.Children.Add(tbx2);
            stcp1.Children.Add(stp1);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            while (stcp2.Children.Count != 0)
            {
                int i = 0;
                stcp2.Children.RemoveAt(0);
                i++;
            }

            if (var2 == true)
            {
                double aSide;
                double gRadius;
                Double.TryParse(tbxaSide.Text, out aSide);
                Double.TryParse(tbxRadius.Text, out gRadius);

                if (aSide > 0 && gRadius > 0)
                {
                    List<string> var2List = getDataVar2(aSide,gRadius);
                    var2List.ForEach(x => {
                        ListBoxItem lbi = new ListBoxItem();
                        lbi.Width = 200;
                        lbi.Height = 20;
                        lbi.Background = Brushes.LightGreen;
                        lbi.Content = x;
                        stcp2.Children.Add(lbi);
                    });
                }
                else
                {
                    MessageBox.Show("Введены не верные значение, или вовсе не введены");
                }
            } 
             else if (var4 == true)
            {
                double aSide;
                double bSide;
                double gAngle;
                Double.TryParse(tbxaSide.Text, out aSide);
                Double.TryParse(tbxbSide.Text, out bSide);
                Double.TryParse(tbxAngle.Text, out gAngle);

                if (aSide >= 0 && bSide >= 0 && gAngle <= 180 && gAngle >=0)
                {
                    List<string> var4List = getDataVar4(aSide, bSide, gAngle);
                    var4List.ForEach(x => {
                        ListBoxItem lbi = new ListBoxItem();
                        lbi.Width = 200;
                        lbi.Height = 20;
                        lbi.Background = Brushes.LemonChiffon;
                        lbi.Content = x;
                        stcp2.Children.Add(lbi);
                    });
                }
                else
                {
                    MessageBox.Show("Введены не верные значение, или вовсе не введены");
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали вариант для рассчета!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             var2 = false;
             var4 = false;
             rdb1.IsChecked = false;
             rdb2.IsChecked = false;

            while (stcp1.Children.Count != 0)
            {
                int i = 0;
                stcp1.Children.RemoveAt(0);
                i++;
            }

            while (stcp2.Children.Count != 0)
            {
                int i = 0;
                stcp2.Children.RemoveAt(0);
                i++;
            }
        }
    }   
}
