using System;
using System.Windows;

namespace garbage_collection_wpf_demo_cs
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DisplayCollectedMemory();
        }

        // Method to display garbage collection memory usage
        private void DisplayCollectedMemory()
        {
            // Get the total memory collected (false means don't force GC collection)
            long totalMemory = GC.GetTotalMemory(false);

            // Display the collected memory in the TextBlock
            garbage_bin.Text = $"Memory Collected: {totalMemory / 1024} KB";
        }
    }
}
