using System;
using System.Collections.Generic;
using System.IO;
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

namespace ipcimWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   List<Domain> list = new List<Domain>();
        public MainWindow()
        {
            InitializeComponent();
           
            StreamReader s = new StreamReader("csudh.txt");
            s.ReadLine();
            while (!s.EndOfStream)
            {
                list.Add(new Domain(s.ReadLine()));
            }
            s.Close();
            datagrig.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Add(new Domain($"{domname.Text};{ipcim.Text}"));
            datagrig.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter w = new StreamWriter("domainek.txt");
                for (int i = 0; i < list.Count; i++)
                {
                    w.WriteLine($"{list[i].nev} {list[i].ip}");
                }
                w.Close();
                MessageBox.Show("Sikeres mentés!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
