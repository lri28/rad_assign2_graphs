using System;
using System.Linq;
using System.Windows.Forms;

namespace PieChart
{
    public partial class Form1 : Form
    {
        private ChartInputData inputData = new ChartInputData(); // Manages input data
        private PieChart? pieChart; // Holds the pie chart instance

        public Form1()
        {
            InitializeComponent(); 
            btnCreate.Click += BtnCreate_Click; // Create button event
            btnClear.Click += BtnClear_Click; // Clear button event
            chartPanel.Paint += ChartPanel_Paint; // Chart paint event
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            // Try to parse input values
            if (inputData.TryParseInput(txtXvalue.Text.Trim(), txtYvalue.Text.Trim(), txtZvalue.Text.Trim()))
            {
                double[] dataPoints = { inputData.X, inputData.Y, inputData.Z }; // Get data points
                pieChart = new PieChart(dataPoints); // Create pie chart
                chartPanel.Invalidate(); // Refresh the chart
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values."); // Show error
            }
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            // Clear inputs and reset chart
            txtXvalue.Text = string.Empty;
            txtYvalue.Text = string.Empty;
            txtZvalue.Text = string.Empty;
            inputData = new ChartInputData(); // Reset input
            pieChart = null; // Clear pie chart
            chartPanel.Invalidate(); // Refresh the chart
        }

        private void ChartPanel_Paint(object? sender, PaintEventArgs e)
        {
            // Draw the pie chart if it exists
            if (pieChart != null)
            {
                pieChart.Draw(e.Graphics, new Rectangle(50, 50, 300, 300)); // Draw chart
            }
        }
    }
}
