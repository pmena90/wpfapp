using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using WpfApp.Data;
using WpfApp.Model;

namespace WpfApp.ViewModel
{
    public class ProductsViewModel : ViewModelBase
    {
        private readonly IProductDataProvider _productDataProvider;

        public ProductsViewModel(IProductDataProvider productDataProvider)
        {
            this._productDataProvider = productDataProvider;
        }

        public ObservableCollection<Product> Products { get; } = new();

        public override async Task LoadAsync()
        {
            if (Products.Any()) { return; }

            var products = await _productDataProvider.GetAllAsync();
            if (products != null)
            {
                foreach (var customer in products)
                {
                    Products.Add(customer);
                }
            }
        }
    }
}