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

namespace Term_Project
{
    public partial class MainWindow : Window
    {

        SubjectViewModel SubjectList = new SubjectViewModel();

        public MainWindow()
        {
            InitializeComponent();

            Grid.ItemsSource = SubjectList.List;
            SubjectList.Add(new Subject("재키", "06M-RF01", "단검, 양손검, 쌍검, 도끼", "공격력"));
            SubjectList.Add(new Subject("아야", "14M-RFT11", "권총, 돌격소총, 저격총", "스킬증폭"));
            SubjectList.Add(new Subject("매그너스", "15M-RFT18", "방망이, 망치", "치명타"));
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            SubjectWin s = new SubjectWin();
            if(s.ShowDialog() != true)
            {
                return;
            }

            SubjectList.Add(new Subject(s.SubName, s.SubCode, s.SubWeapon, s.SubPower));
        }

        private void OnSelected(object sender, SelectionChangedEventArgs e)
        {
            Subject s = (Subject)Grid.SelectedItem;
            BitmapImage sub_i = new BitmapImage(new Uri($"images/{s.Sub_name}.png", UriKind.RelativeOrAbsolute));
            Image.Source = sub_i;
        }
    }
}
