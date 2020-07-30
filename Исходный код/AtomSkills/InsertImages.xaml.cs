using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace AtomSkills
{
    /// <summary>
    /// Логика взаимодействия для InsertImages.xaml
    /// </summary>
    public partial class InsertImages : Window
    {
        public InsertImages()
        {
            InitializeComponent();
            CmbTransport.ItemsSource = Manager.context.Transports.ToList();
        }
        byte[] imageByte=null;
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.FileName = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                fileDialog.ShowDialog();
                imageByte = File.ReadAllBytes(fileDialog.FileName);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Transports transport = CmbTransport.SelectedItem as Transports;
            TransportImages transportImage = new TransportImages
            {
                IDTransport = transport.ID,
                Image = imageByte,
            };
            Manager.context.TransportImages.Add(transportImage);
            Manager.context.SaveChanges();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
