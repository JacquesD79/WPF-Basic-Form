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

namespace WPF_Basics {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, RoutedEventArgs e) {
            
        }

        private void resetBtn_Click(object sender, RoutedEventArgs e) {
            foreach (var child in chkGroup1.Children) {
                if (child.GetType().Name.Equals("CheckBox")) {
                    ((CheckBox)child).IsChecked = false;
                }
            }
            foreach (var child in chkGroup2.Children) {
                if (child.GetType().Name.Equals("CheckBox")) {
                    ((CheckBox)child).IsChecked = false;
                }
            }
        }
    }
}
