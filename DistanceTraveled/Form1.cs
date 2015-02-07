using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceTraveled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fivehourButton_Click(object sender, EventArgs e)
        {
            double speed;
            double distance;
            // Get variable values
            speed = double.Parse(speedTextBox.Text);
            // Calculate distance
            distance = speed * 5.0;
            // Output to distanceLabel
            outputLabel.Text = distance.ToString("n1");
        }

        private void eighthourButton_Click(object sender, EventArgs e)
        {
            double speed;
            double distance;
            // Get variable values
            speed = double.Parse(speedTextBox.Text);
            // Calculate distance
            distance = speed * 8.0;
            // Output to distanceLabel
            outputLabel.Text = distance.ToString("n1");
        }

        private void twelvehourButton_Click(object sender, EventArgs e)
        {
            double speed;
            double distance;
            // Gat variable values
            speed = double.Parse(speedTextBox.Text);
            // Calculate distance
            distance = speed * 12.0;
            // Output to distanceLabel
            outputLabel.Text = distance.ToString("n1");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear each label and text box
            outputLabel.Text = String.Empty;
            speedTextBox.Text = String.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}