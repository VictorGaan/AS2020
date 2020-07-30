using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage(bool isEdit)
        {
            InitializeComponent();
            if (Manager.Title == "Мой Профиль")
            {
                BtnTemplate.Visibility = Visibility.Collapsed;

            }
            else
            {
                BtnTemplate.Visibility = Visibility.Visible;

            }
            if (isEdit == true)
            {
                DataContext = Manager.user;
                imageByte = Manager.user.Image;
                if (Manager.user.Gender)
                {
                    ChM.IsChecked = true;
                    ChJ.IsChecked = false;
                }
                else
                {
                    ChM.IsChecked = false;
                    ChJ.IsChecked = true;
                }
                BtnSave.Visibility = Visibility.Collapsed;
                BtnCancel.Visibility = Visibility.Collapsed;
                BtnEditProfile.Visibility = Visibility.Visible;
                BtnUpdate.Visibility = Visibility.Collapsed;
                SetStyleNormal();
                Load();
                UprStack.Visibility = Visibility.Collapsed;
            }
            else
            {
                BtnSave.Visibility = Visibility.Visible;
                BtnCancel.Visibility = Visibility.Visible;
                BtnEditProfile.Visibility = Visibility.Collapsed;
                BtnUpdate.Visibility = Visibility.Visible;
                SetStyle();
                PathImage.Source=new BitmapImage(new Uri("pack://application:,,,/img/clear-prof.png"));
                UprStack.Visibility = Visibility.Visible;
                CmbRoles.ItemsSource = Manager.context.Roles.ToList();
            }

        }
        List<Functions> Functions = new List<Functions>();
        List<Roles> Roles = new List<Roles>();
        void Load()
        {
            CmbRoles.ItemsSource = Manager.context.Roles.ToList();
            Roles.Clear();
            Functions.Clear();
            var roles = Manager.context.RolesUser.Where(x => x.IDUser == Manager.user.ID);
            foreach (var x in roles)
            {
                foreach (var y in Manager.context.Roles)
                {
                    if (x.IDRole == y.ID)
                    {
                        Roles.Add(y);
                    }
                }
            }
            foreach (var x in roles)
            {
                foreach (var y in Manager.context.FunctionsRole)
                {
                    if (x.IDRole == y.IDRole)
                    {
                        Functions.Add(y.Functions);
                    }
                }
            }
            Functions = Functions.GroupBy(x => x.Name).Select(x => x.FirstOrDefault()).ToList();
            RolesDataGrid.ItemsSource = Roles.ToList();
            FunctionListBox.ItemsSource = Functions.ToList();
        }
        bool isGender = true;
        byte[] imageByte = null;

        private void SetStyleNormal()
        {
            TbFirstName.Style = (Style)FindResource("normalPlaceHolder");
            TbLastName.Style = (Style)FindResource("normalPlaceHolder");
            TbMiddleName.Style = (Style)FindResource("normalPlaceHolder");
            TbBirthDate.Style = (Style)FindResource("normalDatePicker");
            TbEmail.Style = (Style)FindResource("normalPlaceHolder");
            TbPhone.Style = (Style)FindResource("normalPlaceHolder");
            TbPassword.Style = (Style)FindResource("normalPlaceHolder");
            TbPasswordSecond.Style = (Style)FindResource("normalPassword");
            TbPasswordSecondSubmit.Style = (Style)FindResource("normalPassword");
            TbPasswordSubmit.Style = (Style)FindResource("normalPlaceHolder");
        }
        private void SetStyle()
        {
            TbBirthDate.Style = (Style)FindResource("DatePicker");
            TbFirstName.Style = (Style)FindResource("placeHolder");
            TbLastName.Style = (Style)FindResource("placeHolder");
            TbMiddleName.Style = (Style)FindResource("placeHolder");
            TbEmail.Style = (Style)FindResource("placeHolder");
            TbPhone.Style = (Style)FindResource("placeHolder");
            TbPassword.Style = (Style)FindResource("placeHolder");
            TbPasswordSecond.Style = (Style)FindResource("Password");
            TbPasswordSecondSubmit.Style = (Style)FindResource("Password");
            TbPasswordSubmit.Style = (Style)FindResource("placeHolder");
        }
        private void BtnVisible_Click(object sender, RoutedEventArgs e)
        {
            if (TbPassword.Visibility == Visibility.Visible)
            {
                isPassword = true;
                TbPassword.Visibility = Visibility.Collapsed;
                TbPasswordSecond.Visibility = Visibility.Visible;
                TbPasswordSecond.Password = TbPassword.Text;
            }
            else
            {
                isPassword = false;
                TbPassword.Visibility = Visibility.Visible;
                TbPasswordSecond.Visibility = Visibility.Collapsed;
                TbPassword.Text = TbPasswordSecond.Password;
            }
        }

        bool isPassword = true;
        bool isSubmit = true;
        private void BtnVisibleSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (TbPasswordSubmit.Visibility == Visibility.Visible)
            {
                isSubmit = true;
                TbPasswordSubmit.Visibility = Visibility.Collapsed;
                TbPasswordSecondSubmit.Visibility = Visibility.Visible;
                TbPasswordSecondSubmit.Password = TbPasswordSubmit.Text;
            }
            else
            {
                isSubmit = false;
                TbPasswordSubmit.Visibility = Visibility.Visible;
                TbPasswordSecondSubmit.Visibility = Visibility.Collapsed;
                TbPasswordSubmit.Text = TbPasswordSecondSubmit.Password;
            }
        }

        string password = string.Empty;
        bool isValid = false;
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbFirstName.Text)) sb.Append("Поле имя не заполнено!\n");
            if (imageByte == null) sb.Append("Загрузите фотографию!\n");
            if (string.IsNullOrWhiteSpace(TbLastName.Text)) sb.Append("Поле фамилия не заполнено!\n");
            if (string.IsNullOrWhiteSpace(TbEmail.Text)) sb.Append("Поле email не заполнено!\n");
            if (string.IsNullOrWhiteSpace(TbBirthDate.Text)) sb.Append("Поле Дата рождения не заполнено!\n");
            if (string.IsNullOrWhiteSpace(TbPassword.Text) && string.IsNullOrWhiteSpace(TbPasswordSecond.Password)) sb.Append("Поле пароль не заполнено!\n");
            if (string.IsNullOrWhiteSpace(TbPasswordSubmit.Text) && string.IsNullOrWhiteSpace(TbPasswordSecondSubmit.Password)) sb.Append("Поле подтвердите пароль не заполнено!\n");
            if (!Regex.Match(TbPhone.Text, @"[0-9]{1} [0-9]{3}-[0-9]{3}-[0-9]{4}").Success) sb.Append("Неверный формат телефона!\n");
            if (!Regex.Match(TbEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success) sb.Append("Неверный формат email!\n");
            if (isPassword != isSubmit) sb.Append("Переведите пароли в один режим (например режим скрытого пароля)!\n");
            //первый
            if (isPassword == isSubmit)
            {
                if (isPassword)
                {
                    if (TbPassword.Text == TbPasswordSubmit.Text)
                    {
                        foreach (var x in TbPassword.Text)
                        {
                            if (x.ToString() == x.ToString().ToUpper())
                            {
                                isValid = true;
                            }
                        }
                        if (TbPassword.Text.Length < 6 || !Regex.Match(TbPassword.Text, @"\d").Success || isValid == false)
                        {
                            sb.Append("Пароль должен быть длинной более 6 символов, содержать 1 цифру и 1 символ в верхнем регистре!\n");
                        }
                        password = TbPassword.Text;
                    }
                    else
                    {
                        sb.Append("Пароли не совпадают!\n");
                    }

                }
                else
                {
                    if (TbPasswordSecond.Password == TbPasswordSecond.Password)
                    {
                        foreach (var x in TbPasswordSecond.Password)
                        {
                            if (x.ToString() == x.ToString().ToUpper())
                            {
                                isValid = true;
                            }
                        }
                        if (TbPasswordSecond.Password.Length < 6 || !Regex.Match(TbPasswordSecond.Password, @"\d").Success || isValid == false)
                        {
                            sb.Append("Пароль должен быть длинной более 6 символов, содержать 1 цифру и 1 символ в верхнем регистре!\n");
                        }
                        password = TbPasswordSecond.Password;
                    }
                    else
                    {
                        sb.Append("Пароли не совпадают!\n");
                    }
                }
            }
            if (sb.Length > 1)
            {
                MessageBox.Show(sb.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (isEdit)
            {

                Manager.context.Entry(DataContext as Users).Property(x => x.LastName).CurrentValue = TbLastName.Text;
                Manager.context.Entry(DataContext as Users).Property(x => x.FirstName).CurrentValue = TbFirstName.Text;
                Manager.context.Entry(DataContext as Users).Property(x => x.MiddleName).CurrentValue = TbMiddleName.Text;
                Manager.context.Entry(DataContext as Users).Property(x => x.Gender).CurrentValue = isGender;
                Manager.context.Entry(DataContext as Users).Property(x => x.BirthDate).CurrentValue = Convert.ToDateTime(TbBirthDate.Text);
                Manager.context.Entry(DataContext as Users).Property(x => x.Email).CurrentValue = TbEmail.Text;
                Manager.context.Entry(DataContext as Users).Property(x => x.Image).CurrentValue = imageByte;
                Manager.context.Entry(DataContext as Users).Property(x => x.Password).CurrentValue = password;
                Manager.context.Entry(DataContext as Users).Property(x => x.PhoneNumber).CurrentValue = TbPhone.Text;
                Manager.context.Entry(DataContext as Users).State = System.Data.Entity.EntityState.Modified;
                try
                {
                    Manager.context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                Users user = new Users
                {
                    LastName = TbLastName.Text,
                    FirstName = TbFirstName.Text,
                    MiddleName = TbMiddleName.Text,
                    Gender = isGender,
                    BirthDate = Convert.ToDateTime(TbBirthDate.Text),
                    Email = TbEmail.Text,
                    Image = imageByte,
                    Password = password,
                    PhoneNumber = TbPhone.Text
                };
                Manager.context.Entry(user).State = System.Data.Entity.EntityState.Added;
                Manager.user = user;
                try
                {
                    Manager.context.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            //Не уверен
            BtnSave.Visibility = Visibility.Collapsed;
            BtnCancel.Visibility = Visibility.Collapsed;
            BtnEditProfile.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Collapsed;
            UprStack.Visibility = Visibility.Collapsed;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.FileName = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                fileDialog.ShowDialog();
                imageByte = File.ReadAllBytes(fileDialog.FileName);
                PathImage.Source = new BitmapImage(new Uri(fileDialog.FileName));
            }
            catch (Exception)
            {
                return;
            }
        }

        private void ChM_Click(object sender, RoutedEventArgs e)
        {
            if (ChM.IsChecked == true)
            {
                isGender = true;
                ChJ.IsChecked = false;
            }
        }

        private void ChJ_Click(object sender, RoutedEventArgs e)
        {
            if (ChJ.IsChecked == true)
            {
                isGender = false;
                ChM.IsChecked = false;
            }
        }
        bool isEdit = false;
        private void BtnEditProfile_Click(object sender, RoutedEventArgs e)
        {
            BtnSave.Visibility = Visibility.Visible;
            BtnCancel.Visibility = Visibility.Visible;
            BtnEditProfile.Visibility = Visibility.Collapsed;
            BtnUpdate.Visibility = Visibility.Visible;
            isEdit = true;
            SetStyle();
            UprStack.Visibility = Visibility.Visible;
        }

        private void RolesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Roles roles = (sender as DataGrid).SelectedItem as Roles;
            if (roles != null)
            {
                grid1.DataContext = roles;
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var message = MessageBox.Show("Действительно удалить выбранную роль?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Error);
            if (message == MessageBoxResult.Yes)
            {
                foreach (var item in Manager.context.RolesUser.ToList())
                {
                    if (item.IDRole == (((sender as Button).DataContext) as Roles).ID)
                    {
                        Manager.context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                        Manager.context.SaveChanges();
                        Load();
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Roles role = CmbRoles.SelectedItem as Roles;
            RolesUser roleUser = new RolesUser
            {
                IDRole = role.ID,
                IDUser = Manager.user.ID,
            };
            Manager.context.Entry(roleUser).State = System.Data.Entity.EntityState.Added;
            try
            {
                Manager.context.SaveChanges();
                Load();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void BtnDeleteFunction_Click(object sender, RoutedEventArgs e)
        {
            if (Manager.Title == "Мой Профиль")
            {
                (sender as Button).IsEnabled = false;
            }
            else
            {
                (sender as Button).IsEnabled = true;
                if ((grid1.DataContext as Roles) != null)
                {
                    Functions function = (sender as Button).DataContext as Functions;
                    Roles role = grid1.DataContext as Roles;
                    var query = Manager.context.FunctionsRole.SingleOrDefault(x => x.IDRole == role.ID && x.IDFunction == function.ID);
                    if (query != null)
                    {
                        Manager.context.Entry(query).State = System.Data.Entity.EntityState.Deleted;
                        try
                        {
                            Manager.context.SaveChanges();
                            Load();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
        }
    }
}
