using system;
using system.Drawing;
using system.Windows.Forms;

namespace AlgorithmSorter
{
    //main window of the application
    public class mainform : form
    {

        //array to hold the numbers
        private int [] numbers;

        //button to start the process of sorting
        private Button startButton;

        //label to show the current status (running, completed, etc)
        private Label statusLabel;

        //panel where the bars will be.
        private Panel visualPanel;

        public mainform()
        {
            //set up the main window details and properties
            this.text = "algorithm sorter - Visual demo";
            this.size = new size(1000, 750);
            this.startposition = formstartposition.centerScreen;

            //initialise our array with random numbers
            numbers = new int[] { 15, 2, 7, 87, 62, 59, 42, 33, 15, 19, 23, 45, 72, 88, 95, 3, 50, 98};

            InitializeControls();
        }
    }
}