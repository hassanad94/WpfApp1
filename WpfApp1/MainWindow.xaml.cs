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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            DataContext = _vm;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            PlanguageViewModel plviewModel = new PlanguageViewModel(new Planguage()) { IsNew = true } ;
            PlanguageView plView = new PlanguageView { DataContext = plviewModel };
            plView.ShowDialog();
            var plList = _vm.LanguageList;
            if (plView.DialogResult == true)
                plList.Add(plviewModel.Planguage);


        }

        private void Modify_Click(object sender, RoutedEventArgs e)
        {
            if (_vm.SelectedPlanguage != null)
            {
                PlanguageViewModel viewModel = new PlanguageViewModel(_vm.SelectedPlanguage);
                PlanguageView view = new PlanguageView { DataContext = viewModel };
                view.ShowDialog();

            }


        }
    }
}
