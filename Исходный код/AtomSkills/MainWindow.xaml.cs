using AtomSkills.Properties;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(Settings.Default.Login) && !string.IsNullOrWhiteSpace(Settings.Default.Password))
            {
                TbLogin.Text = Settings.Default.Login;
                TbPassword.Text = Settings.Default.Password;
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (CbSing.IsChecked == true)
            {
                Settings.Default.Login = TbLogin.Text;
                Settings.Default.Password = TbPassword.Text;
                Settings.Default.Save();
            }
            var user = Manager.context.Users.SingleOrDefault(x => x.Email == TbLogin.Text && x.Password == TbPassword.Text);
            if (user!=null)
            {
                Manager.user = user;
                new StartWindow(true).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            new StartWindow(false).Show();
            this.Close();
        }
    }
}
