using ConsoleApp1.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WPFapp
{


    public partial class OrderPage : Page
    {
        
        public ObservableCollection<ProductOrderModel> Orderss { get; set; }

        public class Data 
        {

            public decimal FinalPrice { get; set; }

        }

        public OrderPage(ObservableCollection<ProductOrderModel> product , decimal finalPrice)
        {

            InitializeComponent();
            listOrder.ItemsSource = product;
            Data data = new Data() { FinalPrice = finalPrice};
            DataContext = data;
            Orderss = product;
        }


        public class OrderList
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public ProductModel[] productModel;


        }

        private void orders_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new OrdersPage(Orderss));

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}

