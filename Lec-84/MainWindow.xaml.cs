using System;
using System.Collections;
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

namespace Lec_84
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;

        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }
                        
        private void AddBtn(object sender, RoutedEventArgs e)
        {
            hashtable.Add(Keytxt.Text,Valuetxt.Text);
            MessageBox.Show("Key: "+Keytxt.Text+", Value: "+Valuetxt.Text);
            
        }

        private void RemoveBtn(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(Keytxt.Text);
            MessageBox.Show("Remove Key: "+Keytxt.Text);
        }

        private void ShowallBtn(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            foreach (string key in icollection) 
            {
                MessageBox.Show("Key: "+key+", Value: "+hashtable[key].ToString());
            }
        }
    }
}
