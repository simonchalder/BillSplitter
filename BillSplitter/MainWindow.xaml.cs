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
            Calculation newCalc = new Calculation();

            if(input_box.Text != null)
            {
                newCalc.SetBill(decimal.Parse(input_box.Text));
            }
            else
            {
                Console.WriteLine("Value passed for bill was null, please enter a value");
                newCalc.SetBill(0.00M);
            }
            
            newCalc.SetTipPercentage(int.Parse(tip_comboBox.Text));
            newCalc.SetPersons(int.Parse(persons_comboBox.Text));

            share_output.Text = newCalc.CalculateShare().ToString();
            tip_output.Text = newCalc.CalculateTip().ToString();
            total_output.Text = newCalc.CalculateTotal().ToString();

        }
    }
}
