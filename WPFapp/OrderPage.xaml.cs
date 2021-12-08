using ConsoleApp1.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WPFapp
{

    public partial class OrderPage : Page
    {
        public ObservableCollection<OrderList> Orderss { get; set; }
        

        public ProductModel[] productModel;
        public OrderPage()
        {
            InitializeComponent();
           
            
        }

        public class OrderList
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public ProductModel[] productModel;


        }

        private void orders_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new OrdersPage());

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}

