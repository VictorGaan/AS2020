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
using System.Windows.Shapes;

namespace AtomSkills
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow(bool valid)
        {
            InitializeComponent();
            if (valid)
            {
                Item1.Visibility = Visibility.Hidden;
                Item2.Visibility = Visibility.Hidden;
                Item3.Visibility = Visibility.Hidden;
                //проверка ролей
                var query = Manager.context.RolesUser.Where(x => x.IDUser == Manager.user.ID);
                foreach (var x in query)
                {
                    foreach (var y in Manager.context.FunctionsRole)
                    {
                        if (x.IDRole==y.IDRole)
                        {
                            switch (y.IDFunction)
                            {
                                case 1:
                                    Item1.Visibility = Visibility.Visible;
                                    break;
                                case 2:
                                    Item2.Visibility = Visibility.Visible;
                                    break;
                                case 3:
                                    Item3.Visibility = Visibility.Visible;
                                    break;
                                case 4:
                                    Item4.Visibility = Visibility.Visible;
                                    Item5.Visibility = Visibility.Visible;
                                    break;
                            }
                        }
                    }
                }
            }
            else
            {
                Item2.Visibility = Visibility.Hidden;
                Item3.Visibility = Visibility.Hidden;
                Item4.Visibility = Visibility.Hidden;
                Item5.Visibility = Visibility.Hidden;
            }
            Manager.MainFrame = MainFrame;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Item1_Click(object sender, RoutedEventArgs e)
        {
            TbTitle.Text = "Мой Профиль";
            Manager.Title = "Мой Профиль";
            if (Manager.user!=null)
            {
                Manager.MainFrame.Navigate(new ProfilePage(true));
            }
            else
            {
                Manager.MainFrame.Navigate(new ProfilePage(false));
            }
        }

        private void Item2_Click(object sender, RoutedEventArgs e)
        {
            TbTitle.Text = "Управление пользователями";
            Manager.Title = "Управление пользователями";
            Manager.MainFrame.Navigate(new UsersPage());
        }

        private void Item3_Click(object sender, RoutedEventArgs e)
        {

            TbTitle.Text = "Управление ролями";
            Manager.Title = "Управление ролями";
            Manager.MainFrame.Navigate(new RolesPage());

        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Item4_Click(object sender, RoutedEventArgs e)
        {
            TbTitle.Text = "Управление заказами";
            Manager.Title = "Управление заказами";
            Manager.MainFrame.Navigate(new OrdersPage());
        }

        private void Item5_Click(object sender, RoutedEventArgs e)
        {
            TbTitle.Text = " Управление транспортом";
            Manager.Title = " Управление транспортом";
            Manager.MainFrame.Navigate(new TransportPage());
        }
    }
}
