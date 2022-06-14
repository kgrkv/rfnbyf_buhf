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

namespace MyGameIS_20_03.Forms
{
    /// <summary>
    /// Логика взаимодействия для Prdmt.xaml
    /// </summary>
    public partial class Prdmt : Page
    {
        public double minqualifications { get; private set; }

        public Prdmt()
        {
            InitializeComponent();
            List<Model.Prdmt> Prdmt = new List<Model.Prdmt>
            {
                 new Model.Prdmt{ Name ="Учитель  в  сельской школе "  , minqualifications=1 , salary=100} ,
                 new Model.Prdmt{ Name ="Зауч   в  сельской школе "  , minqualifications=10 , salary=120} ,
                 new Model.Prdmt{ Name ="Профессор  в  Оксфорде "  , minqualifications=25000 , salary=120000} ,
            };

            listPrdmt.ItemsSource = Prdmt;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Prdmt Prdmt = listPrdmt.SelectedItem as Prdmt;

            if (Prdmt.minqualifications <= App.myGamer.Experience)
            {
                App.myGamer.Prdmt = Prdmt.Name;
                Close();
            }
            else
            {
                MessageBox.Show("Вы не  можете  занять эту должность ");
            }
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
