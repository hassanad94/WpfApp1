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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PlanguageView.xaml
    /// </summary>
    public partial class PlanguageView : Window
    {
        public PlanguageView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var planVM = (PlanguageViewModel)DataContext;


            if (!planVM.Valid())
            {
                MessageBox.Show("hibás adatbevitel");
                return;
            }
            else
            {
                DialogResult = true;
                Close();
            }
        }
    }
}
