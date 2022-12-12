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

namespace Term_Project
{
    /// <summary>
    /// SubjectWin.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SubjectWin : Window
    {
        public SubjectWin()
        {
            InitializeComponent();
            SubN.Focus();
        }
        public string SubName
        {
            get { return SubN.Text; }
        }
        public string SubCode
        {
            get { return SubC.Text; }
        }
        public string SubWeapon
        {
            get { return SubW.Text; }
        }
        public string SubPower => SubP.Text;


        private void OnOk(object sender, RoutedEventArgs e)
        {

            DialogResult = true;
        }
        private void OnCancel(object sender, RoutedEventArgs e)
        {

            DialogResult = false;
        }
    }
}
