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

namespace PR9Kile.MainPage
{
    /// <summary>
    /// Логика взаимодействия для Psychologists.xaml
    /// </summary>
    public partial class Psychologists : Page
    {
        public Psychologists()
        {
            InitializeComponent();
            DGPsychologists.ItemsSource = RussianPsychologicalSocietyEntities1.GetContext().PsychologistTable.ToList();
        }
    }
}
