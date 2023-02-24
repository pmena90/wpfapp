using System.Windows;
using System.Windows.Controls;
using WpfApp.Data;
using WpfApp.ViewModel;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        private CustomersViewModel _viewModel;

        public CustomerView()
        {
            InitializeComponent();
            _viewModel = new CustomersViewModel(new CustomerDataProvider());
            DataContext = _viewModel;
            Loaded += CustomerView_LoadedAsync;
        }

        private async void CustomerView_LoadedAsync(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }
    }
}