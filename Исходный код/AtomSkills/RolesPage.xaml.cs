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
    /// Логика взаимодействия для RolesPage.xaml
    /// </summary>
    public partial class RolesPage : Page
    {
        public RolesPage()
        {
            InitializeComponent();
            Load();
            SetNormal();
        }


        void SetNormal()
        {
            BtnSave.Visibility = Visibility.Collapsed;
            BtnCancel.Visibility = Visibility.Collapsed;
            BtnAdd.Visibility = Visibility.Visible;
            BtnAddFunction.Visibility = Visibility.Collapsed;
            stack2.Visibility = Visibility.Collapsed;
        }

        void SetEntry()
        {
            BtnSave.Visibility = Visibility.Visible;
            BtnCancel.Visibility = Visibility.Visible;
            BtnAdd.Visibility = Visibility.Collapsed;
            BtnAddFunction.Visibility = Visibility.Visible;

        }

        void Load()
        {
            RolesDataGrid.ItemsSource = Manager.context.Roles.ToList();
            FunctionListBox.ItemsSource = Manager.context.Functions.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            SetEntry();
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
                        try
                        {
                            Manager.context.SaveChanges();

                        }
                        catch (Exception)
                        {

                            return;
                        }
                    }
                }
                foreach (var item in Manager.context.FunctionsRole.ToList())
                {
                    if (item.IDRole == (((sender as Button).DataContext) as Roles).ID)
                    {
                        Manager.context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                        try
                        {
                            Manager.context.SaveChanges();

                        }
                        catch (Exception)
                        {

                            return;
                        }
                    }
                }
                Manager.context.Entry((sender as Button).DataContext).State = System.Data.Entity.EntityState.Deleted;
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

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Roles roles = (sender as Button).DataContext as Roles;
            if (roles != null)
            {
                grid1.DataContext = roles;
                isEdit = true;
            }
        }

        bool isEdit = false;
        private void BtnFilter_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TbLastNameSearch.Text) && !string.IsNullOrWhiteSpace(TbNameSearch.Text))
            {
                RolesDataGrid.ItemsSource = Manager.context.Roles.ToList().Where(x => x.SystemName == TbLastNameSearch.Text && x.Name == TbNameSearch.Text).ToList();
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (isEdit)
            {
                Manager.context.Entry(grid1.DataContext).State = System.Data.Entity.EntityState.Modified;
                Manager.context.SaveChanges();
                Load();
                isEdit = false;
            }
            else
            {
                Roles role = new Roles
                {
                    SystemName = TbSystemName.Text,
                    Name = TbName.Text,
                    DateStart = Convert.ToDateTime(TbStart.Text),
                    DateFinish = Convert.ToDateTime(TbFinish.Text),
                };
                foreach (var item in ListFunctions)
                {
                    role.FunctionsRole.Add(new FunctionsRole { IDFunction = item.ID });
                }
                Manager.context.Entry(role).State = System.Data.Entity.EntityState.Added;
                Manager.context.SaveChanges();
                Load();
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            SetNormal();
        }

        private void BtnAddFunction_Click(object sender, RoutedEventArgs e)
        {
            //
            stack2.Visibility = Visibility.Visible;
            stack1.Visibility = Visibility.Collapsed;
        }


        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            ListFunctions = ListFunctions.GroupBy(x => x.Name).Select(x => x.FirstOrDefault()).ToList();
        }

        private void BtnCancelStack_Click(object sender, RoutedEventArgs e)
        {
            stack2.Visibility = Visibility.Collapsed;
            stack1.Visibility = Visibility.Visible;
        }

        List<Functions> ListFunctions = new List<Functions>();
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as CheckBox).DataContext as Functions;
            ListFunctions.Add(item);
        }
    }
}
