using PraductShop_WPF.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
namespace PraductShop_WPF;

public partial class MainWindow : Window
{
    public ObservableCollection<Product> Praducts { get; set; }
    //public ObservableCollection<ProductBox> SelectedProducts { get; set; }
    public Product SelectedProduct
    {
        get { return (Product)GetValue(SelectedProductProperty); }
        set { SetValue(SelectedProductProperty, value); }
    }

    // Using a DependencyProperty as the backing store for SelectedProduct.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty SelectedProductProperty =
        DependencyProperty.Register("SelectedProduct", typeof(Product), typeof(MainWindow));


    public ObservableCollection<Product> MyShopList { get; set; }

    public MainWindow()
    {
        Praducts = new()
        {
            new Product {Name="Kişi Eynək Gümüş" , Price = 38 , Image="Images/KisiEynek.png" },
            new Product {Name="Kişi Eynək Qizili" , Price = 38 , Image="Images/KisiEynekQizili.png" },
            new Product {Name="Kişi Eynək Ray-Ban" , Price = 38 , Image="Images/KisiEynekrayban.png" }
        };
        InitializeComponent();
        DataContext = this;
    }

    private void AddShoping_click(object sender, RoutedEventArgs e)
    {
        Button button = sender as Button;
        SelectedProduct = button.Tag as Product;
        //SelectedProduct.IsCheck = true;   
        MyShopList.Add(new Product(SelectedProduct));
    }

    private void Basket_Click(object sender, RoutedEventArgs e)
    {
        Shoping shoping = new(MyShopList);
        Hide();
        shoping.ShowDialog();
        Show();
    }

    private void AddProduct_Click(object sender, RoutedEventArgs e)
    {
        AddPraduct addPraductWindow = new();
        Hide();
        addPraductWindow.ShowDialog();
        Show();
    }

    private void TextBoxSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
    {
        //listboxShop.Items.Clear();
        //if(txtBoxSearch.Text = )  
    }
}
