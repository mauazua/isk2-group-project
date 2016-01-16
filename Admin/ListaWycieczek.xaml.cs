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

namespace Admin
{
    /// <summary>
    /// Interaction logic for Wycieczki.xaml
    /// </summary>
    public partial class Wycieczki : Window
    {
        public Wycieczki()
        {
            InitializeComponent();
        }

        public void ZaladujListe(Object [] wycieczka)
        {
            foreach(Object i in wycieczka)
            {
                lbxListaWycieczek.Items.Add(i.ToString());
            }
        }

    }
}
