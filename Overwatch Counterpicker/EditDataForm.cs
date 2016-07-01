using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Overwatch_Counterpicker.JSONObjects;
using Overwatch_Team_Overview;

namespace Overwatch_Counterpicker
{
    public partial class EditDataForm : Form
    {
        private MainForm mainForm;

        public EditDataForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void EditDataForm_Load(object sender, EventArgs e)
        {
            creatorTextbox.Text = mainForm.data.creator;
            linkTextbox.Text = mainForm.data.link;
            
            mainDataGridView.Rows.Clear();
            mainDataGridView.Columns.Clear();

            DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn.HeaderText = "";
            dataGridViewTextBoxColumn.ReadOnly = true;
            dataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            mainDataGridView.Columns.Add(dataGridViewTextBoxColumn);

            // Create all the columns
            for (int i = 0; i < Program.heroes.Length; i++)
            {
                string heroName = Program.GetHeroName(i);

                dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
                dataGridViewTextBoxColumn.HeaderText = heroName;
                dataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                mainDataGridView.Columns.Add(dataGridViewTextBoxColumn);
            }

            // Add in data
            for (int i = 0; i < Program.heroes.Length; i++)
            {
                string heroName = Program.GetHeroName(i);

                int index = mainDataGridView.Rows.Add();

                DataGridViewRow dataGridViewRow = mainDataGridView.Rows[index];

                // Styling for the first column
                dataGridViewRow.Cells[0].Value = heroName;
                dataGridViewRow.Cells[0].Style.BackColor = SystemColors.ControlDarkDark;
                dataGridViewRow.Cells[0].Style.ForeColor = SystemColors.Window;
                dataGridViewRow.Cells[0].Style.SelectionBackColor = SystemColors.ControlDarkDark;
                for (int j = 0; j < Program.heroes.Length; j++)
                {
                    dataGridViewRow.Cells[0].Value = heroName;
                    dataGridViewRow.Cells[j + 1].Value = "" + mainForm.data.data[i, j];
                    switch (mainForm.data.data[i, j])
                    {
                        case -1:
                            dataGridViewRow.Cells[j + 1].Style.BackColor = Color.Red;
                            break;
                        case 1:
                            dataGridViewRow.Cells[j + 1].Style.BackColor = Color.LightGreen;
                            break;
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Data outputData = new Data();
            outputData.creator = creatorTextbox.Text;
            outputData.link = linkTextbox.Text;
            outputData.data = new int[Program.heroes.Length, Program.heroes.Length];

            for (int i = 0; i < Program.heroes.Length; i++)
            {
                for (int j = 0; j < Program.heroes.Length; j++)
                {
                    string value = (string) mainDataGridView.Rows[i].Cells[j + 1].Value;
                    outputData.data[i, j] = int.Parse(value);
                }
            }
            
            string json = JsonConvert.SerializeObject(outputData, Formatting.Indented);
            System.IO.StreamWriter file = new System.IO.StreamWriter("data.json");
            file.WriteLine(json);
            file.Close();

            mainForm.data = outputData;
            mainForm.RefreshData();

            MessageBox.Show("Saved!", "Success");
        }

        private void mainDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewCell dataGridViewCell = mainDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            int intValue;

            if (e.ColumnIndex == 0)
                return;
            
            if (int.TryParse(e.FormattedValue.ToString(), out intValue))
            {
                if (intValue == -1 || intValue == 0 || intValue == 1)
                {
                    switch (intValue)
                    {
                        case -1:
                            dataGridViewCell.Style.BackColor = Color.Red;
                            break;
                        case 0:
                            dataGridViewCell.Style.BackColor = SystemColors.Control;
                            break;
                        case 1:
                            dataGridViewCell.Style.BackColor = Color.LightGreen;
                            break;
                    }
                }
                else
                {
                    e.Cancel = true;

                    MessageBox.Show("Value must be -1, 0, or 1.", "Invalid value");
                }
            }
            else
            {
                e.Cancel = true;

                MessageBox.Show("Value must be an integer.", "Invalid value");
                return;
            }
        }

        private void undoAllButton_Click(object sender, EventArgs e)
        {
            EditDataForm_Load(null, null);
        }
    }
}
