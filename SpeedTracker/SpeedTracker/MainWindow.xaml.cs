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

namespace SpeedTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var time1 = int.Parse(timePassed1stSpeedCamera.Text);

            // TODO: Replace '0' with code to read timePassed2ndSpeedCamera & convert to an integer
            var time2 = 0;

            // TODO: Replace '0' with code to read distanceBetweenSpeedCameras & convert to an integer
            var distance = int.Parse(distanceBetweenSpeedCameras.Text);
             
            // Replace '0' with code to calculate average speed.  Tip: cast time1 (or time2) to float.
            float averageSpeed = 0;

            this.speedTextBox.Text = averageSpeed.ToString();
        }
    }
}