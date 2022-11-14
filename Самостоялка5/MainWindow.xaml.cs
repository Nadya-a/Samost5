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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Самостоялка5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            //MessageBox.Show("Узел " + tvItem.Header.ToString() + " раскрыт");
        }

        private void TreeViewItem1_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            //MessageBox.Show("Выбран узел: " + tvItem.Header.ToString());
            //picture1.Visibility = Visibility.Visible;
        }

        private void TreeViewItem2_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            //MessageBox.Show("Выбран узел: " + tvItem.Header.ToString());
            //picture2.Visibility = Visibility.Visible;

            listBox1.Items.Clear();
            textblock.Text = "Пушистые породы кошек";
            //listBox1.Items.Add(textblock.Text);
            listBox1.Items.Add("Мейн-кун");
            listBox1.Items.Add("Гималайская кошка");
            listBox1.Items.Add("Норвежская лесная");
            listBox1.Items.Add("Сибирская кошка");
            listBox1.Items.Add("Рэгдолл");
        }

        

        private void TreeViewItem3_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            //MessageBox.Show("Выбран узел: " + tvItem.Header.ToString());
            //picture3.Visibility = Visibility.Visible;

            listBox1.Items.Clear();
            textblock.Text = "Гладкошерстные породы кошек";
            listBox1.Items.Add("Абиссинская кошка");
            listBox1.Items.Add("Австралийский мист");
            listBox1.Items.Add("Британская короткошерстная");
            listBox1.Items.Add("Бомбейская кошка");
            listBox1.Items.Add("Корниш-рекс");
        }

        private void TreeViewItem4_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            //MessageBox.Show("Выбран узел: " + tvItem.Header.ToString());
            //picture4.Visibility = Visibility.Visible;

            listBox1.Items.Clear();
            textblock.Text = "Сфинксы";
            listBox1.Items.Add("Потерболд");
            listBox1.Items.Add("Прямошерстный");
            listBox1.Items.Add("Канадский сфинкс");
            listBox1.Items.Add("Украинский левкой");
        }

        private void listBox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            if (listBox1.SelectedItem != null)
            {
                //MessageBox.Show(listBox1.SelectedItem.ToString());
                string a = (string)listBox1.SelectedItem;
                string V = "C:\\Users\\Nadya\\Desktop\\Самостоялка\\коты\\"+a +".jpg";
                //public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context);
                //ImageSourceValueSerializer.ConvertFromString(V, IValueSerializerContext context);
                photo.Source = new ImageSourceConverter().ConvertFromString(V) as ImageSource;
    }
        }
    }
}
