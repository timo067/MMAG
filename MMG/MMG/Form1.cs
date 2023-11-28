namespace MMG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Get the input numbers from the textbox
            string[] inputNumbers = textBox1.Text.Split(' ');

            // Convert the input numbers to a list of doubles
            List<double> numbers = new List<double>();
            foreach (string input in inputNumbers)
            {
                if (double.TryParse(input, out double number))
                {
                    numbers.Add(number);
                }
            }

            // Calculate median, mode, and average
            double median = CalculateMedian(numbers);
            double mode = CalculateMode(numbers);
            double average = numbers.Average();

            // Display results in labels
            medianLabel.Text = $"Median: {median}";
            modeLabel.Text = $"Mode: {mode}";
            averageLabel.Text = $"Average: {average}";
        }

        private double CalculateMedian(List<double> numbers)
        {
            numbers.Sort();
            double media = 0;
            if (numbers.Count % 2 == 1)
            {
                media = numbers[(numbers.Count - 1) / 2];
            }
            if (numbers.Count % 2 == 0)
            {
                var index = numbers.Count / 2;
                media = (numbers[index] + numbers[index - 1]) / 2.0;
            }
            return media;
        }

        private double CalculateMode(List<double> numbers)
        {
            var mode = numbers.GroupBy(x => x)
                 .OrderByDescending(x => x.Count()).ThenBy(x => x.Key)
                 .Select(x => (int)x.Key)
                 .FirstOrDefault();

            return mode;
        }
    }
}