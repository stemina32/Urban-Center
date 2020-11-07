namespace Urban_Centre_Classification
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openButton = new System.Windows.Forms.Button();
            this.urbanListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.calculationButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberUrbanLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.largestLabel = new System.Windows.Forms.Label();
            this.smallestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(45, 3);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(89, 24);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // urbanListBox
            // 
            this.urbanListBox.FormattingEnabled = true;
            this.urbanListBox.Location = new System.Drawing.Point(45, 32);
            this.urbanListBox.Margin = new System.Windows.Forms.Padding(2);
            this.urbanListBox.Name = "urbanListBox";
            this.urbanListBox.Size = new System.Drawing.Size(224, 290);
            this.urbanListBox.TabIndex = 1;
            this.urbanListBox.SelectedIndexChanged += new System.EventHandler(this.urbanListBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(344, 112);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 24);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Data";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(436, 111);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 25);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Data";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // calculationButton
            // 
            this.calculationButton.Location = new System.Drawing.Point(383, 217);
            this.calculationButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(89, 26);
            this.calculationButton.TabIndex = 4;
            this.calculationButton.Text = "Calculations";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(342, 32);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Population:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(342, 158);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 7;
            this.locationLabel.Text = "Location:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(425, 32);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(76, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // populationTextBox
            // 
            this.populationTextBox.Location = new System.Drawing.Point(425, 66);
            this.populationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(76, 20);
            this.populationTextBox.TabIndex = 9;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(425, 154);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(76, 20);
            this.locationTextBox.TabIndex = 10;
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(436, 271);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(76, 19);
            this.averageLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Average:";
            // 
            // numberUrbanLabel
            // 
            this.numberUrbanLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberUrbanLabel.Location = new System.Drawing.Point(436, 307);
            this.numberUrbanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberUrbanLabel.Name = "numberUrbanLabel";
            this.numberUrbanLabel.Size = new System.Drawing.Size(76, 19);
            this.numberUrbanLabel.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Number of Urban Centers:";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(176, 332);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(76, 19);
            this.totalLabel.TabIndex = 15;
            // 
            // largestLabel
            // 
            this.largestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largestLabel.Location = new System.Drawing.Point(264, 332);
            this.largestLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.largestLabel.Name = "largestLabel";
            this.largestLabel.Size = new System.Drawing.Size(76, 19);
            this.largestLabel.TabIndex = 16;
            // 
            // smallestLabel
            // 
            this.smallestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallestLabel.Location = new System.Drawing.Point(348, 332);
            this.smallestLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.smallestLabel.Name = "smallestLabel";
            this.smallestLabel.Size = new System.Drawing.Size(76, 19);
            this.smallestLabel.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.smallestLabel);
            this.Controls.Add(this.largestLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberUrbanLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.calculationButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.urbanListBox);
            this.Controls.Add(this.openButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ListBox urbanListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button calculationButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberUrbanLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label largestLabel;
        private System.Windows.Forms.Label smallestLabel;
    }
}

