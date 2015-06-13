using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using StoreProject.Core;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace StoreProject.UI.WpfApplication.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        Store store = null;
        Cart cart = null;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            store = new Store();
            Products = new ObservableCollection<Product>(store.AllProducts());

            AddProductToCartCommand = new RelayCommand(AddProductToCartAction);
        }

        public ObservableCollection<Product> Products { get; set; }

        Product selectedProduct;
        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set { Set(() => SelectedProduct, ref selectedProduct, value); }
        }

        int addQuantity;
        public int AddQuantity
        {
            get { return addQuantity; }
            set { Set(() => AddQuantity, ref addQuantity, value); }
        }

        public Cart Cart
        {
            get { return cart; }
        }

        public ICommand AddProductToCartCommand { get; set; }

        private void AddProductToCartAction()
        {
            cart = (cart ?? new Cart());
            cart.Add(SelectedProduct, AddQuantity);

            SelectedProduct = null;
            AddQuantity = 1;
            RaisePropertyChanged(() => Cart);
        }
    }
}