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
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            UsersDataGrid.ItemsSource = Manager.context.Users.ToList();
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ProfilePage(false));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Users user = UsersDataGrid.SelectedItem as Users;
            if (user != null)
            {
                var message = MessageBox.Show("Действительно удалить выбранного пользователя?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Error);
                if (message==MessageBoxResult.Yes)
                {
                    Manager.context.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                    try
                    {
                        Manager.context.SaveChanges();
                        Load();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                    }
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Users user = UsersDataGrid.SelectedItem as Users;
            if (user != null)
            {
                Manager.user = user;
                Manager.MainFrame.Navigate(new ProfilePage(true));
            }
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TbLastName.Text)&&!string.IsNullOrWhiteSpace(TbDate.Text))
            {
                UsersDataGrid.ItemsSource = Manager.context.Users.Where(x => x.LastName == TbLastName.Text && x.BirthDate == TbDate.SelectedDate).ToList();
            }
        }
    }
}
