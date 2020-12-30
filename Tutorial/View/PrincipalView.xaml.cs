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

namespace Tutorial.View
{
    /// <summary>
    /// Lógica de interacción para PrincipalView.xaml
    /// </summary>
    public partial class PrincipalView : Window
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        private void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Mouse Leave desde CodeBehind");
            ckecking.IsChecked = true;
        }

        private void Button_Drop(object sender, DragEventArgs e)
        {
            ckecking.IsChecked = true;

        }
    }
}
