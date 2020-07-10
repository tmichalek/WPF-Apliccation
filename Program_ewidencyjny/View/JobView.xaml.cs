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

namespace program_ewidencyjny.View
{
    /// <summary>
    /// Interaction logic for JobView.xaml
    /// </summary>
    public partial class JobView : Window
    {
        public JobView()
        {
            InitializeComponent();
        }

        private void ViewJobGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
