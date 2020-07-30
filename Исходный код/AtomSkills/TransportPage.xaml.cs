using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace AtomSkills
{
    /// <summary>
    /// Логика взаимодействия для TransportPage.xaml
    /// </summary>
    public partial class TransportPage : Page
    {
        public TransportPage()
        {
            InitializeComponent();
            Load();
            grid1.DataContext = new Transports();
        }
        void Load()
        {
            TransportDataGrid.ItemsSource = Manager.context.Transports.ToList();
            CmbBrands.ItemsSource = Manager.context.Brands.ToList();
            CmbBrandF.ItemsSource = Manager.context.Brands.ToList();
        }

        bool isEdit = false;
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Transports transport = (sender as Button).DataContext as Transports;
            if (transport!=null)
            {
                grid1.DataContext = transport;
                CmbBrands.SelectedItem = transport.Brands.Name;
                isEdit = true;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbModel.Text)) sb.Append("Поле модель не может быть пустым!\n");
            if (string.IsNullOrWhiteSpace(TbRegNumber.Text)) sb.Append("Поле рег.номер не может быть пустым!\n");
            if (string.IsNullOrWhiteSpace(TbYear.Text)) sb.Append("Поле год не может быть пустым!\n");
            if (string.IsNullOrWhiteSpace(TbDate.Text)) sb.Append("Поле рег.дата не может быть пустым!\n");
            if (!Regex.Match(TbRegNumber.Text, @"[A-Z]{3} [0-9]{3}-[0-9]{3}-[0-9]{3}").Success) sb.Append("Неверный формат рег. номера (пример: ABV 992-123-983)!\n");
            if (sb.Length > 1)
            {
                MessageBox.Show(sb.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Brands brand = CmbBrands.SelectedItem as Brands;
            if (isEdit)
            {
                Manager.context.Entry(grid1.DataContext as Transports).Property(x => x.IDBrand).CurrentValue = brand.ID;
                Manager.context.Entry(grid1.DataContext as Transports).State = System.Data.Entity.EntityState.Modified;
                Manager.context.SaveChanges();
            }
            else
            {
                Manager.context.Entry(grid1.DataContext as Transports).Property(x => x.IDBrand).CurrentValue = brand.ID;
                Manager.context.Entry(grid1.DataContext as Transports).State = System.Data.Entity.EntityState.Added;
                Manager.context.SaveChanges();
            }
            isEdit = false;
            Load();
        }

        private void TransportDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Transports transport = TransportDataGrid.SelectedItem as Transports;
            ImageItems.ItemsSource = Manager.context.TransportImages.Where(x => x.IDTransport == transport.ID).ToList();
        }

        private void BtnImage_Click(object sender, RoutedEventArgs e)
        {
            new InsertImages().ShowDialog();
            Load();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Transports transport = TransportDataGrid.SelectedItem as Transports;
            if (transport != null)
            {
                var message = MessageBox.Show("Вы действительно хотите списать выбранный транспорт?", "Списание", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (message == MessageBoxResult.Yes)
                {
                    Manager.context.Entry(transport).Property(x => x.DateOff).CurrentValue = DateTime.Now;
                    Manager.context.Entry(transport).State = System.Data.Entity.EntityState.Modified;
                    Manager.context.SaveChanges();
                    Load();
                }
            }
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            Brands brand = CmbBrandF.SelectedItem as Brands;
            if (!string.IsNullOrWhiteSpace(TbRegNumberF.Text)&&!string.IsNullOrWhiteSpace(TbModelF.Text))
            {
                TransportDataGrid.ItemsSource = Manager.context.Transports.Where(x => x.Number == TbRegNumberF.Text&&x.Model==TbModelF.Text&&x.IDBrand==brand.ID).ToList();
            }
            if (string.IsNullOrWhiteSpace(TbRegNumberF.Text) && !string.IsNullOrWhiteSpace(TbModelF.Text))
            {
                //model&brand
                TransportDataGrid.ItemsSource = Manager.context.Transports.Where(x => x.Model == TbModelF.Text && x.IDBrand == brand.ID).ToList();

            }
            if (!string.IsNullOrWhiteSpace(TbRegNumberF.Text) && string.IsNullOrWhiteSpace(TbModelF.Text))
            {
                //reg&brand
                TransportDataGrid.ItemsSource = Manager.context.Transports.Where(x => x.Number == TbRegNumberF.Text && x.IDBrand == brand.ID).ToList();

            }
            if (string.IsNullOrWhiteSpace(TbRegNumberF.Text) && string.IsNullOrWhiteSpace(TbModelF.Text))
            {
                //brand
                TransportDataGrid.ItemsSource = Manager.context.Transports.Where(x =>x.IDBrand == brand.ID).ToList();
            }
        }
    }
}
