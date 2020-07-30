using System;
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

namespace AtomSkills
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
            Load();
            grid1.DataContext = new Orders();
        }
        void Load()
        {
            OrdersDataGrid.ItemsSource = Manager.context.Orders.Where(x=>x.Users.ID==Manager.user.ID).ToList();
            CmbOperators.ItemsSource = Manager.context.Users.ToList();
            CmbSuppliers.ItemsSource = Manager.context.Users.ToList();
            CmbTransports.ItemsSource = Manager.context.Transports.ToList();
            CmbStatus.ItemsSource = Manager.context.Statuses.ToList();
            CmbStatusF.ItemsSource = Manager.context.Statuses.ToList();
        }

        bool isEdit = false;
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Orders order = OrdersDataGrid.SelectedItem as Orders;
            if (order!=null)
            {
                grid1.DataContext = order;
                CmbOperators.SelectedItem = order.Users1;
                CmbSuppliers.SelectedItem = order.Users;
                CmbStatus.SelectedItem = order.Statuses.Name;
                CmbTransports.SelectedItem = order.Transports.Number;
                isEdit = true;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            Users supplier = CmbSuppliers.SelectedItem as Users;
            Users @operator = CmbOperators.SelectedItem as Users;
            Transports transport = CmbTransports.SelectedItem as Transports;
            Statuses status = CmbStatus.SelectedItem as Statuses;
            if (isEdit)
            {
                Manager.context.Entry(grid1.DataContext as Orders).Property(x => x.IDSupplier).CurrentValue = supplier.ID;
                Manager.context.Entry(grid1.DataContext as Orders).Property(x => x.IDOperator).CurrentValue = @operator.ID;
                Manager.context.Entry(grid1.DataContext as Orders).Property(x => x.IDStatus).CurrentValue = status.ID;
                Manager.context.Entry(grid1.DataContext as Orders).Property(x => x.IDTrans).CurrentValue = transport.ID;
                Manager.context.Entry(grid1.DataContext).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                Manager.context.Entry(grid1.DataContext as Orders).Property(x=>x.IDSupplier).CurrentValue=supplier.ID;
                Manager.context.Entry(grid1.DataContext as Orders).Property(x=>x.IDOperator).CurrentValue=@operator.ID;
                Manager.context.Entry(grid1.DataContext as Orders).Property(x=>x.IDStatus).CurrentValue=status.ID;
                Manager.context.Entry(grid1.DataContext as Orders).Property(x=>x.IDTrans).CurrentValue=transport.ID;
                Manager.context.Entry(grid1.DataContext).State = System.Data.Entity.EntityState.Added;
            }
            Manager.context.SaveChanges();
            Load();
            isEdit = false;
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            Statuses status=CmbStatusF.SelectedItem as Statuses;
            if (DpStart.SelectedDate!=null&&DpFinish.SelectedDate!=null)
            {
                OrdersDataGrid.ItemsSource = Manager.context.Orders.Where(x => x.IDStatus == status.ID&&x.Date>DpStart.SelectedDate&&x.Date<DpFinish.SelectedDate).ToList();

            }
        }
    }
}
