using System.Windows;
using System.Windows.Controls;

namespace GuidGeneratorViews.Views
{
    /// <summary>
    /// Interaction logic for GenerateGuidView.xaml
    /// </summary>
    public partial class GenerateGuidView : UserControl
    {
        public GenerateGuidView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            GuidTextBox.Focus();
        }
    }
}
