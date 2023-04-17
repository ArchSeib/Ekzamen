using System;
using System.Collections.Generic;
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
using Xceed.Wpf.Toolkit;


namespace Ekzamen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Regex regYear = new Regex(@"^\d{4}$");
        public MainWindow()
        {
            InitializeComponent();
        }
        public static bool CheckEmpty(String value)
        {
            if (value == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckYearEmpty(String value)
        {
            if (value == "____")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckAuthor(String value)
        {
            if (value.Length < 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckName(String value)
        {
            if (value.Length < 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckYear(String value)
        {
            if (regYear.IsMatch(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
