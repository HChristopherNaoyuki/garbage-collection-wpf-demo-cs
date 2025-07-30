using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace garbage_collection_wpf_demo_cs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            garbage_collected();
        } // END: MainWindow Method

        // METHOD: Display Garbage Collection after collection.
        private void garbage_collected()
        {
            // CREATE: Instance for the functions object.
            object memory = new object();

            // DISPLAY: After collecting all the generations.
            // GENERATION: gen 0, gen 1, and gen 2.
            GC.GetGeneration(memory);

            // DISPLAY: What has been displayed by the object.
            garbage_bin.Text += GC.GetTotalMemory(false);
        }
    }
}