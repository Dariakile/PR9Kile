using PR9Kile.ApplicationData;
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

namespace PR9Kile
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.modelodb = new RussianPsychologicalSocietyEntities1();
            AppFrame.FrameMain = MyFrame;
        }
        public void ShowAppointmentButton()
        {
            Appointment.Visibility = Visibility.Visible;
        }
        public void ShowCustomersButton()
        {
            Customers.Visibility = Visibility.Visible;
        }

        private void VhodBut_Click(object sender, RoutedEventArgs e)
        {
            var MyWindow = Window.GetWindow(this);
            Avtorizacia avtorizacia1 = new Avtorizacia();
            avtorizacia1.Show();
            MyWindow.Close();
        }

        private void PsychologistsBut_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new MainPage.Psychologists());
        }
    }
}
