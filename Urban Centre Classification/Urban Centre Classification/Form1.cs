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
                string StartsWith;
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
                //outputFile.Write("," + locationTextBox.Text);

                outputFile.Close(); //close file

                MessageBox.Show("Urban Center data added!"); // notification to user

                nameTextBox.Text = ""; //Clear TextBox
                populationTextBox.Text = ""; //Clear TextBox
                locationTextBox.Text = ""; //Clear TextBox
                nameTextBox.Focus(); // Cursor back to nameTextBox 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("Urban Center.txt",
            File.ReadLines("Urban Center.txt").Where(l => l == nameTextBox.Text).ToList());
           /* string tempFile = "temp.txt";


               try
               {

               }
               catch(Exception ex)
               {

               }
               /*StreamReader inputFile;
               inputFile = File.OpenText("Urban Center.txt");
               StreamWriter onputFile;
               while((line = inputFile.ReadLine()) != null)
               {
                   if(line == "nameTextBox.Text")
               }*/
            urbanListBox.Items.RemoveAt(urbanListBox.SelectedIndex);
            StreamWriter outputFile;
           //while ()
        }

        private void calculationButton_Click(object sender, EventArgs e)
        {
            try
            {
                int population, total = 0; //Variables for population and total population
                int average = 0; 
                StreamReader sr = File.OpenText("Urban Center.Txt");
                StreamReader inputFile;
                inputFile = File.OpenText("Urban Center.Txt");

                // counter for not empty or commented lines
                var lineCount = 0;
                var lines = File.ReadAllLines("Urban Center.Txt").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
                foreach (var line in lines)
                {
                    if (!line.StartsWith("#"))
                    {
                        lineCount++;
                    }
                }

                numberUrbanLabel.Text = lineCount.ToString();

                while (!inputFile.EndOfStream)
                { 
                    population = int.Parse(inputFile.ReadLine());
                    total += population;
                    average = total / lineCount;
                    averageLabel.Text = average.ToString();
                }
                inputFile.Close();
                
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
