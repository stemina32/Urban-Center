using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Urban_Centre_Classification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e) //Could Have done a load event but seemed less practical here for this app
        {
            try 
            {
                string urbanCenter;
                StreamReader inputFile; //declare StreamReader 
                inputFile = File.OpenText("Urban Center.txt"); // Get Object + Open File "x"

                //inputFile.WriteLine(urbanTextBox.Text);
                urbanListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    var listOfLines = File.ReadAllLines("Urban Center.txt")
                    .Where(x => !string.IsNullOrWhiteSpace(x));
                    urbanCenter = inputFile.ReadLine();
                    urbanListBox.Items.Add(urbanCenter);

                }
                inputFile.Close();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message); //Error Message
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                StreamWriter outputFile; //declare StreamWriter
                outputFile = File.AppendText("Urban Center.txt"); //Open File + Get Object for appending
                outputFile.Write( "\n" + nameTextBox.Text); //Get data from textboxes to write in file
                outputFile.Write("," + populationTextBox.Text);

                outputFile.Close(); //close file

                MessageBox.Show("Urban Center data added!"); // notification to user
                int fileSize = File.ReadAllLines("Urban Center.txt").Count();
                //Log Added Data into Log.txt file
                List<string> linesList = File.ReadAllLines("Urban Center.txt").ToList();
                File.WriteAllLines("Urban Center.txt", linesList.ToArray());
                File.AppendAllText("logs.txt", "Added : \"" + nameTextBox.Text + "," + populationTextBox.Text + "\" at " + DateTime.Now.ToString() + Environment.NewLine);

                nameTextBox.Text = ""; //Clear TextBox
                populationTextBox.Text = ""; //Clear TextBox
                nameTextBox.Focus(); // Cursor back to nameTextBox 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int lineIndex = urbanListBox.SelectedIndex;
                int fileSize = File.ReadAllLines("Urban Center.txt").Count();
                string deletedLine;
                // Delete and log deleted lines into another file called logs.txt
                if (lineIndex >= 0 && lineIndex < fileSize)
                {
                    urbanListBox.Items.RemoveAt(lineIndex);
                    List<string> linesList = File.ReadAllLines("Urban Center.txt").ToList();
                    deletedLine = linesList[lineIndex].Trim();
                    linesList.RemoveAt(lineIndex);
                    File.WriteAllLines("Urban Center.txt", linesList.ToArray());
                    File.AppendAllText("logs.txt", "Deleted : \"" + deletedLine + "\" at " + DateTime.Now.ToString() + Environment.NewLine);
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void calculationButton_Click(object sender, EventArgs e)
        {
            try
            {
                var urbCenterCount = 0;//declare Count variable
                List<string> names = new List<string>(); //create list string for names
                List<int> populations = new List<int>();
                // counter for not empty or commented lines
                var lines = File.ReadAllLines("Urban Center.Txt").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
                foreach (var line in lines)
                {
                    if (!line.StartsWith("#"))//Ignore Commented lines
                    {
                        urbCenterCount++;
                        names.Add(line.Split(',')[0]);//Split Names and population using ","
                        populations.Add(Convert.ToInt32(line.Split(',')[1]));
                    }
                }
                //Delare Variables for Calculations
                var totalPop = populations.Sum();
                var averagePop = Math.Round(populations.Average());
                var largestPop = populations.Max();
                var smallestPop = populations.Min();

                // Assign values to labels
                numberUrbanLabel.Text = urbCenterCount.ToString();
                totalLabel.Text = totalPop.ToString();
                averageLabel.Text = averagePop.ToString();
                largestLabel.Text = largestPop.ToString();
                smallestLabel.Text = smallestPop.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void urbanListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
