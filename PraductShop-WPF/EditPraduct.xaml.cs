<<<<<<< HEAD
﻿using Microsoft.Win32;
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
=======
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
using System.Windows.Shapes;

namespace PraductShop_WPF
{
    /// <summary>
    /// Interaction logic for EditPraduct.xaml
    /// </summary>
    public partial class EditPraduct : Window
    {
        public EditPraduct()
        {
            InitializeComponent();
        }
    }
>>>>>>> a28e7851a93052bbfdc43dcc8915a20f10ffa235
}
