﻿using System;
using System.Windows.Forms;

namespace Karma
{
    public partial class MarketForm : Form
    {

        public MarketForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = CSVProcessing.DataTableFromCSV();
            //prodLabel.Text = "There are " + CSVProcessing.Items.Length + " items in the market";
        }


        private void AddNewButtonClick(object sender, EventArgs e)
        {
            Form addNewItemForm = new AddNewItemForm();

            addNewItemForm.TopLevel = false;
            addNewItemForm.FormBorderStyle = FormBorderStyle.None;
            addNewItemForm.Dock = DockStyle.Fill;
            this.Controls.Add(addNewItemForm);
            addNewItemForm.BringToFront();
            addNewItemForm.Show();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CSVProcessing.DataTableFromCSV();
            //prodLabel.Text = "There are " + CSVProcessing.Items.Length + " items in the market";
        }

        private void MarketFormLoad(object sender, EventArgs e)
        {

        }
    }
}
