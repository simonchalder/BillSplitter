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
            decimal result;
            bool digits = decimal.TryParse(input_box.Text, out result);

            if (input_box.Text != null && digits == true)
            {
                newCalc.SetBill(decimal.Parse(input_box.Text));
                newCalc.SetTipPercentage(int.Parse(tip_comboBox.Text));
                newCalc.SetPersons(int.Parse(persons_comboBox.Text));
            }
            else
            {
                MessageBox.Show(this, "Please enter a valid amount", "BillSplitter");
                Console.WriteLine();
                newCalc.SetBill(0.01M);
                newCalc.SetTipPercentage(int.Parse(tip_comboBox.Text));
                newCalc.SetPersons(int.Parse(persons_comboBox.Text));
            }
            
            share_output.Text = $"£{newCalc.CalculateShare().ToString()}";
            tip_output.Text = $"£{newCalc.CalculateTip().ToString()}";
            total_output.Text = $"£{newCalc.CalculateTotal().ToString()}";
        }
    }
}
