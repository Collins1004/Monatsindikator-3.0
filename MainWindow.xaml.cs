using System;
using System.Threading;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Monatsindikator_3._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBest_Click(object sender, RoutedEventArgs e)
        {
            //Abfrage zur Eingabe
            //Monate Zahl -> Name
            if (tbZahl.Text == "1")
            {
                lblErg.Content = "Januar";
            }
            else if (tbZahl.Text == "2")
            {
                lblErg.Content = "Februar";
            }
            else if (tbZahl.Text == "3")
            {
                lblErg.Content = "März";
            }
            else if (tbZahl.Text == "4")
            {
                lblErg.Content = "April";
            }
            else if (tbZahl.Text == "5")
            {
                lblErg.Content = "Mai";
            }
            else if (tbZahl.Text == "6")
            {
                lblErg.Content = "Juni";
            }
            else if (tbZahl.Text == "7")
            {
                lblErg.Content = "Juli";
            }
            else if (tbZahl.Text == "8")
            {
                lblErg.Content = "August";
            }
            else if (tbZahl.Text == "9")
            {
                lblErg.Content = "September";
            }
            else if (tbZahl.Text == "10")
            {
                lblErg.Content = "Oktober";
            }
            else if (tbZahl.Text == "11")
            {
                lblErg.Content = "November";
            }
            else if (tbZahl.Text == "12")
            {
                lblErg.Content = "Dezember";
            }
            
            //Jahreszeiten Name -> Monate
            else if (tbZahl.Text == "Winter" || tbZahl.Text == "winter")
            {
                lblErg.Content = "Novemver, Dezember, Januar";
            }
            else if (tbZahl.Text == "Frühling" || tbZahl.Text == "frühling" || tbZahl.Text == "Frueling" || tbZahl.Text == "frueling")
            {
                lblErg.Content = "Februar, März, April";
            }
            else if (tbZahl.Text == "Sommer" || tbZahl.Text == "sommer")
            {
                lblErg.Content = "Mai, Juni, Juli";
            }
            else if (tbZahl.Text == "Herbst" || tbZahl.Text == "herbst")
            {
                lblErg.Content = "August, September, Oktober";
            }
            
            //Monate Name -> Zahl
            else if (tbZahl.Text == "Januar" || tbZahl.Text == "januar")
            {
                lblErg.Content = "1";
            }
            else if (tbZahl.Text == "Februar" || tbZahl.Text == "februar")
            {
                lblErg.Content = "2";
            }
            else if (tbZahl.Text == "März" || tbZahl.Text == "märz" || tbZahl.Text == "Maerz" || tbZahl.Text == "maerz")
            {
                lblErg.Content = "3";
            }
            else if (tbZahl.Text == "April" || tbZahl.Text == "april")
            {
                lblErg.Content = "4";
            }
            else if (tbZahl.Text == "Mai" || tbZahl.Text == "mai")
            {
                lblErg.Content = "5";
            }
            else if (tbZahl.Text == "Juni" || tbZahl.Text == "juni")
            {
                lblErg.Content = "6";
            }
            else if (tbZahl.Text == "Juli" || tbZahl.Text == "juli")
            {
                lblErg.Content = "7";
            }
            else if (tbZahl.Text == "August" || tbZahl.Text == "august")
            {
                lblErg.Content = "8";
            }
            else if (tbZahl.Text == "September" || tbZahl.Text == "september")
            {
                lblErg.Content = "9";
            }
            else if (tbZahl.Text == "Oktober" || tbZahl.Text == "Oktober")
            {
                lblErg.Content = "10";
            }
            else if (tbZahl.Text == "November" || tbZahl.Text == "november")
            {
                lblErg.Content = "11";
            }
            else if (tbZahl.Text == "Dezember" || tbZahl.Text == "dezember")
            {
                lblErg.Content = "12";
            }
            else if (tbZahl.Text == "")
            {
                lblErg.Content = "";
            }
            else
            {
                lblErg.Content = "Üngültige Eingabe";
            }
        }
    }
}