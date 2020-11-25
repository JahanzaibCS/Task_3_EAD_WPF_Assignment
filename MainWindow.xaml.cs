using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Task_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        ObservableCollection<string> lst1 = new ObservableCollection<string>();
        ObservableCollection<string> lst2 = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            
            listBox1.ItemsSource = lst1;
            listBox2.ItemsSource = lst2;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
           if(listBox1.SelectedItem==null)
            {
                MessageBox.Show("Please select an item");

            }
            else
            {
                lst2.Add(listBox1.SelectedItem as string);
                int i = listBox1.SelectedIndex;
                lst1.RemoveAt(i);
            }
        }

        private void AddValue1(object sender, RoutedEventArgs e)
        {
            if(txtBox1.Text.Length==0)
            {
                MessageBox.Show("Please enter some value");
            }
            else
            {
                string temp = txtBox1.Text;
                lst1.Add(temp);
                txtBox1.Text = "";

            }
        }

        private void getBack(object sender, RoutedEventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");

            }
            else
            {
                lst1.Add(listBox2.SelectedItem as string);
                int i = listBox2.SelectedIndex;
                lst2.RemoveAt(i);
            }
        }

        private void box1Tobox2(object sender, RoutedEventArgs e)
        {
            if(lst1.Count==0)
            {
                MessageBox.Show("Please enter some values");

            }
            else
            {
                while (lst1.Count != 0)
                {
                    for (int i = 0; i < lst1.Count; i++)
                    {
                        lst2.Add(lst1[i]);
                        lst1.RemoveAt(i);
                    }

                }
            }
           
        }

        private void box2Tobox1(object sender, RoutedEventArgs e)
        {
            if (lst2.Count == 0)
            {
                MessageBox.Show("Please enter some values");

            }
            else
            {
                while (lst2.Count != 0)
                {
                    for (int i = 0; i < lst2.Count; i++)
                    {
                        lst1.Add(lst2[i]);
                        lst2.RemoveAt(i);
                    }

                }
            }
           
        }

        private void AddValue2(object sender, RoutedEventArgs e)
        {
            if (txtBox2.Text.Equals(""))
            {
                MessageBox.Show("Please enter some value");
            }
            else
            {
                string temp = txtBox2.Text;
                lst2.Add(temp);
                txtBox2.Text = "";
            }
        }
    }
}
