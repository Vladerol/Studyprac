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

namespace verstka
{
    /// <summary>
    /// Логика взаимодействия для mainKalen.xaml
    /// </summary>
    public partial class mainKalen : Page
    {
        public mainKalen()
        {
            InitializeComponent();
           List<Print> users = new List<Print>();
            users.Add(new Print(1, "Зайнетдинов", "Вильдан", 18, "Пекин"));
            users.Add(new Print(2, "Чунетдинов", "Вильдус", 68, "Катар"));
            users.Add(new Print(3, "Чубутдинов", "Чильдун", 38, "Бешкек"));
            users.Add(new Print(4, "Pунидинов", "Вильдуни", 68, "Рим"));
            users.Add(new Print(5, "Pунидинов", "Вильдуни", 68, "Рим"));
            DG.ItemsSource = users;
        }
        
    }
}
