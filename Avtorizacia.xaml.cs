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

namespace PR9Kile
{
    /// <summary>
    /// Логика взаимодействия для Avtorizacia.xaml
    /// </summary>
    public partial class Avtorizacia : Window
    {
        public Avtorizacia()
        {
            InitializeComponent();
        }
        

        private void OnSubmit_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            string Login1 = Login.Text.Trim();
            string Password1 = Password.Text.Trim();

            string DispatcherLogin = "1";
            string DispatcherPassword = "2";

            if (DispatcherLogin == Login1 || DispatcherPassword == Password1)
            {
                MainWindow mainWindow = new MainWindow();
                Avtorizacia avtorizacia1 = new Avtorizacia();
                mainWindow.ShowAppointmentButton();
                mainWindow.ShowCustomersButton();
                mainWindow.Show();
                avtorizacia1.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
