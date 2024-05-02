using Microsoft.Win32;
using PraductShop_WPF.Models;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace PraductShop_WPF;

public partial class EditPraduct : Window
{
    OpenFileDialog openFileDialog = new OpenFileDialog();

    public Product OrginalProduct { get; set; }
    
    private Product? _praduct { get; set; }

    public EditPraduct(Product praduct)
    {
        InitializeComponent();
        OrginalProduct = praduct;
        DataContext = this;
        
    }

    private void ImageShow_Click(object sender, RoutedEventArgs e)
    {
        openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg";
        openFileDialog.FilterIndex = 2;
        if (openFileDialog.ShowDialog() == true)
        {
            string selectedImagePath = openFileDialog.FileName;
            BitmapImage bitmap = new BitmapImage(new Uri(selectedImagePath));
            ImageBox.Source = bitmap;
        }
    }

    private void ChangePraduct_Clik(object sender, RoutedEventArgs e)
    {
        if (ImageBox is not null && txtBoxName is not null && double.TryParse(txtBoxPrice.Text, out double result))
        {
            _praduct = new()
            {
                Name = txtBoxName.Text,
                Price = result,
                Image = openFileDialog.FileName
            };

            OrginalProduct = _praduct;
            MessageBox.Show($"Change Praduct !!!");
        }
        else MessageBox.Show("Please Enter Correct Information !!!");
    }
}
