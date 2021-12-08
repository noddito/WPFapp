﻿using System;
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
using System.Collections.ObjectModel;
using ConsoleApp1.Models;

namespace WPFapp
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public ObservableCollection<ProductModel> Products { get; set; }
        public MainPage()
        {
            InitializeComponent();
            
            Loaded += MainPage_Loaded;
        }
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {

            listProduct.ItemsSource = new ProductOrderModel[] {
             new ProductOrderModel()
            { ProductModels = new[] {
             new ProductModel() { ImagePath = "/Images/product1.jpg", Name = "Сырная", Price = 349 } } },
             new ProductOrderModel()
            { ProductModels = new[] {
             new ProductModel() { ImagePath = "/Images/product2.jpg", Name = "Хот Пепперони", Price = 459 } } },
             new ProductOrderModel()
            { ProductModels = new[] {
             new ProductModel() { ImagePath = "/Images/product3.jpg", Name = "Капричиоза", Price = 439 } } },
             new ProductOrderModel()
            { ProductModels = new[] {
             new ProductModel() { ImagePath = "/Images/product4.jpg", Name = "10 Сыров ", Price = 499 } } },
             new ProductOrderModel()
            { ProductModels = new[] {
             new ProductModel() { ImagePath = "/Images/product5.jpg", Name = "Ветчина и грибы", Price = 439 } } },
             new ProductOrderModel()
            { ProductModels = new[] {
             new ProductModel() { ImagePath = "/Images/product6.jpg", Name = "Папа Микс", Price = 869 } } },
             new ProductOrderModel(){
             ProductModels = new[] {
             new ProductModel() { ImagePath = "/Images/product7.jpg", Name = "Мясное Удовольствие", Price = 509 }} }};

        }

        private void plus(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ProductOrderModel product = button.DataContext as ProductOrderModel;
            product.Count += 1;
            listProduct.Items.Refresh();
        }

        private void minus(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ProductOrderModel product = button.DataContext as ProductOrderModel;
            if (product.Count > 0) { product.Count -= 1; }
            listProduct.Items.Refresh();
        }

        
        public void Order(object sender, RoutedEventArgs e)
        {
            var orderPage = new OrderPage();
            
            NavigationService.Navigate(orderPage);
        }

        private void Orders(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersPage());
        }

    }
}