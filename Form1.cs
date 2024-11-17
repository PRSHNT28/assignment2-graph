namespace bar
{
    public partial class Form1 : Form
    {
        // Stores the numerical values for the bar chart
        List<float> values = new List<float>();
        // Stores the corresponding labels for the bar chart
        List<string> labels = new List<string>();

        // Constructor for initializing Form1
        public Form1()
        {
            InitializeComponent();
        }

        // Triggered when button1 is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            // Reset the values and labels from previous inputs
            values.Clear();
            labels.Clear();

            // Retrieve user inputs from the text boxes
            string inputval = txtValues.Text;
            string inputlab = txtlabels.Text;

            // Validate if the values input is not empty or blank
            if (string.IsNullOrWhiteSpace(inputval))
            {
                MessageBox.Show("Please enter at least the values to create a graph.", "Error");
            }
            else
            {
                // Split the input strings into arrays using commas as delimiters
                string[] stringLab = inputlab.Split(',');
                string[] stringL = inputval.Split(",");

                // Convert the values from string format to an integer array
                int[] inpvalues = Array.ConvertAll(stringL, int.Parse);

                // Automatically generate labels (A, B, C, etc.) if none are provided
                if (string.IsNullOrWhiteSpace(inputlab))
                {
                    for (int i = 0; i < inpvalues.Length; i++)
                    {
                        char letter = (char)('A' + i);
                        string l = letter.ToString();
                        labels.Add(l);
                    }
                }
                // Show an error if there are more labels than values
                else if (stringLab.Length > inpvalues.Length)
                {
                    MessageBox.Show("Please provide labels for all the values.");
                    return;
                }
                // Show an error if there are fewer labels than values
                else if (stringLab.Length < inpvalues.Length)
                {
                    MessageBox.Show("Please provide all labels for the values.");
                    return;
                }
                else
                {
                    // Add the user-provided labels to the list
                    foreach (string v in stringLab)
                    {
                        labels.Add(v);
                    }
                }

                // Add the numerical input values to the list
                foreach (int v in inpvalues)
                {
                    values.Add(v);
                }
            }

            // Update the bar graph component with the input values and labels
            bar1.set(values, labels);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
