using PraductShop_WPF.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
namespace PraductShop_WPF;

public partial class MainWindow : Window
{
    public ObservableCollection<Product> Praducts { get; set; }
    public ObservableCollection<Product> PraductsSearch { get; set; } = new();
    public ObservableCollection<Basket> BasketShop { get; set; } = new();


    public MainWindow()
    {
        Praducts = new()
        {
            new Product {Name="Kişi Eynək Gümüş" , Price = 120.88 , Image="Images/KisiEynek.png" },
            new Product {Name="Kişi Eynək Qizili" , Price = 130.85 , Image="Images/KisiEynekQizili.png" },
            new Product {Name="Kişi Eynək Ray-Ban" , Price = 18.59 , Image="Images/KisiEynekrayban.png" }
        };
        InitializeComponent();
        DataContext = this;
    }

    private void AddPraduct_Click(object sender, RoutedEventArgs e)
    {
        AddPraduct addPraduct = new AddPraduct();
        Hide();
        addPraduct.ShowDialog();
        Show();

    }

    private void listboxShop_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        var selectedItem = listboxShop.SelectedItem as Product;
        EditPraduct editPraduct = new EditPraduct(selectedItem!);
        Hide();
        editPraduct.ShowDialog();
        Show();
    }
    private void Basket_Click(object sender, RoutedEventArgs e)
    {
        Shoping shoping = new(BasketShop);
        Hide();
        shoping.ShowDialog();
        Show();
    }

    private void AddBasket_Click(object sender , RoutedEventArgs s)
    {
        bool check = false;
        Button? button = sender as Button;
        var selectedItem = button!.DataContext as Product;
        Basket data = new();

        foreach (var item in BasketShop)
        {
            if (selectedItem == item.Product)
            {
                check = true;
                data = item;
            }
        }
        
        if (check) data.Quantity++;        
        else
        {
            Basket basket = new() { Product = selectedItem };
            BasketShop.Add(basket);
        }
    }

    private void txtBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (txtBoxSearch.Text is null || txtBoxSearch.Text == "")
        {
            foreach (var item in Praducts)
            {
                if (!PraductsSearch.Contains(item))
                    PraductsSearch.Add(item);
            }
        }
        else
        {
            PraductsSearch.Clear();
            foreach (var item in Praducts)
            {
                if (item.Name!.Contains(txtBoxSearch.Text))
                {
                    if(!PraductsSearch.Contains(item))
                        PraductsSearch.Add(item);
                }
            }
        }
        
    }

    //private void AddShoping_click(object sender, RoutedEventArgs e)
    //{
    //    Button button = sender as Button;
    //    SelectedProduct = button.Tag as Product;
    //    //SelectedProduct.IsCheck = true;   
    //    MyShopList.Add(new Product(SelectedProduct));
    //}


    //private void AddProduct_Click(object sender, RoutedEventArgs e)
    //{
    //    AddPraduct addPraductWindow = new();
    //    Hide();
    //    addPraductWindow.ShowDialog();
    //    Show();
    //}

    //private void TextBoxSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
    //{
    //    //listboxShop.Items.Clear();
    //    //if(txtBoxSearch.Text = )  
    //}
}
