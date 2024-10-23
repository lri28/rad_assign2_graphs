using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace PieChart
{
    public class PieChart
    {
        private double[] dataPoints; // Array for the pie chart data

        // Color pairs for the pie slices
        public Color[,] ColorPairs { get; } =
        {
            { Color.FromArgb(220, 20, 60), Color.FromArgb(255, 160, 122) }, // Red to Light Coral
            { Color.FromArgb(34, 139, 34), Color.FromArgb(245, 255, 250) }, // Green to Light Green
            { Color.FromArgb(255, 215, 0), Color.FromArgb(255, 250, 205) }  // Gold to Light Gold
        };

        // Constructor to initialize data points
        public PieChart(double[] dataPoints)
        {
            this.dataPoints = dataPoints; // Store the data points
        }

        // Draw the pie chart
        public void Draw(Graphics g, Rectangle area)
        {
            float total = (float)dataPoints.Sum(); // Calculate total of data points
            float startAngle = 0f; // Initial angle for pie slices

            for (int i = 0; i < dataPoints.Length; i++)
            {
                if (dataPoints[i] <= 0) continue; // Skip non-positive values

                // Calculate the sweep angle for the current slice
                float sweepAngle = (float)(dataPoints[i] / total * 360);

                // Create a gradient brush for the pie slice
                using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                    area, ColorPairs[i, 0], ColorPairs[i, 1], 45f)) // Gradient angle
                {
                    g.FillPie(gradientBrush, area, startAngle, sweepAngle); // Draw pie slice
                }

                // Calculate position for percentage text
                float percentage = (float)((dataPoints[i] / total) * 100);
                float midAngle = startAngle + (sweepAngle / 2);
                float x = area.X + area.Width / 2 + (float)(Math.Cos(midAngle * Math.PI / 180) * (area.Width / 2.2));
                float y = area.Y + area.Height / 2 + (float)(Math.Sin(midAngle * Math.PI / 180) * (area.Height / 2.2));

                g.DrawString($"{percentage:0.0}%", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, x, y); // Draw percentage text

                startAngle += sweepAngle; // Update the start angle for the next slice
            }

            // Draw the legend
            DrawLegend(g, area);
        }

        // Draw the legend for the chart
        private void DrawLegend(Graphics g, Rectangle area)
        {
            string[] labels = { "X", "Y", "Z" }; // Legend labels
            int legendX = area.X + area.Width + 20; // Position legend to the right
            int legendY = area.Y; // Start position for legend

            for (int i = 0; i < dataPoints.Length; i++)
            {
                using (Brush colorBrush = new SolidBrush(ColorPairs[i, 0]))
                {
                    g.FillRectangle(colorBrush, legendX, legendY + (i * 30), 20, 20); // Color box
                }

                g.DrawString($"{labels[i]}: {dataPoints[i]}", SystemFonts.DefaultFont, Brushes.Black, legendX + 30, legendY + (i * 30)); // Legend label
            }
        }
    }
}
