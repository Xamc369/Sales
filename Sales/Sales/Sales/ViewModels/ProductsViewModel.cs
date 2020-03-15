

namespace Sales.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Common.Models;
    using Services;
    using Xamarin.Forms;

    public class ProductsViewModel : BaseViewModel
    {
        //permite consumir
        private ApiService apiService;

        //permite consumir la lista de productos y ver que se actualice
        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products {

            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }

        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }

        private async void LoadProducts()
        {

            //-https://salesapi20200312045220.azurewebsites.net
            //-https://salesbackend20200312025808.azurewebsites.net/
            var response = await this.apiService.GetList<Product>("https://salesapi20200312045220.azurewebsites.net", "/api","/Products");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
                return;
            }

            var list = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(list);
        }
    }
}
