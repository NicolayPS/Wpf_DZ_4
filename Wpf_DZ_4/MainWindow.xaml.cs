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

namespace Wpf_DZ_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateD.Text);
            double sumDollar = Convert.ToDouble(sumD.Text);
            double resDouble = rateDollar * sumDollar;
            resSumD.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble(rateE.Text);
            double sumEvro = Convert.ToDouble(sumE.Text);
            double resEvro = rateEvro * sumEvro;
            resSumE.Text = resEvro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rateG.Text);
            double sumGriv = Convert.ToDouble(sumG.Text);
            double resGriv = rateGriv * sumGriv;
            resSumG.Text = resGriv.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rateA.Text);
            double sumDram = Convert.ToDouble(sumA.Text);
            double resDram = rateDram * sumDram;
            resSumA.Text = resDram.ToString();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateDuim = Convert.ToDouble(rateDu.Text);
            double resDu = rateDuim * 0.0254;
            resSumDu.Text = resDu.ToString();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateFut = Convert.ToDouble(rateF.Text);
            double resF = rateFut / 3.28;
            resSumF.Text = resF.ToString();
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateMil = Convert.ToDouble(rateM.Text);
            double resM = rateMil * 1609.344;
            resSumM.Text = resM.ToString();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rateV.Text);
            double resV = rateVerst * 1066.781;
            resSumV.Text = resV.ToString();
        }
    }
}
