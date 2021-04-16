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

namespace BillSplitter
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

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            decimal bill;

            if(input_box.Text != null)
            {
                bill = decimal.Parse(input_box.Text);
            }
            else
            {
                Console.WriteLine("Value passed for bill was null, please enter a value");
                bill = 0.00M;
            }
            
            int tip_percent = int.Parse(tip_comboBox.Text);
            int persons = int.Parse(persons_comboBox.Text);

            decimal tip = decimal.Round(bill * tip_percent / 100 / persons, 2);
            Console.WriteLine(tip);
            decimal share = decimal.Round(bill / persons, 2);
            decimal total = decimal.Round(share + tip, 2);

            share_output.Text = share.ToString();
            tip_output.Text = tip.ToString();
            total_output.Text = total.ToString();

        }
    }
}
