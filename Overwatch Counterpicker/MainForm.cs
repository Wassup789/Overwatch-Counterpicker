using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Overwatch_Team_Overview.JSONObjects;

namespace Overwatch_Team_Overview
{
    public partial class MainForm : Form
    {
        public Settings settings = new Settings();
        public int[,] data;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("settings.json"))
            {
                string settingsString = "{\"key\": \"g\",}";
                System.IO.StreamWriter file = new System.IO.StreamWriter("settings.json");
                file.WriteLine(settingsString);
                file.Close();
            }

            string jsonData = File.ReadAllText("data.json");
            data = JsonConvert.DeserializeObject<int[,]>(jsonData);

            jsonData = File.ReadAllText("settings.json");
            settings = JsonConvert.DeserializeObject<Settings>(jsonData);

            refreshButtonValue.Text = settings.key.ToUpper();
        }

        public void onHeroesChange()
        {
            mainListView.Items.Clear();

            int[] overallValues = new int[Program.heroes.Length];
            for (int i = 0; i < Program.currentHeroes.Length; i++)
            {
                int heroIndex = Program.currentHeroes[i];

                ListViewItem item = new ListViewItem();
                item.UseItemStyleForSubItems = false;
                item.Text = Program.heroes[heroIndex].First().ToString().ToUpper() + Program.heroes[heroIndex].Substring(1);
                item.Group = mainListView.Groups[0];

                for (int j = 0; j < Program.heroes.Length; j++)
                {
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                    switch (data[j, heroIndex])
                    {
                        case -1:
                            subitem.Text = "Weak";
                            subitem.BackColor = Color.Red;
                            break;
                        case 1:
                            subitem.Text = "Strong";
                            subitem.BackColor = Color.LightGreen;
                            break;
                        default:
                            subitem.BackColor = Color.DarkGray;
                            break;
                    }
                    overallValues[j] += data[j, heroIndex];

                    item.SubItems.Add(subitem);
                }
                mainListView.Items.Add(item);
            }

            // Overall

            ListViewItem itemOverall = new ListViewItem();
            itemOverall.UseItemStyleForSubItems = false;
            itemOverall.Group = mainListView.Groups[1];

            for (int i = 0; i < overallValues.Length; i++)
            {
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                if (overallValues[i] < 0)
                {
                    subitem.Text = "Weak x" + Math.Abs(overallValues[i]);
                    subitem.BackColor = Color.Red;
                }
                else if (overallValues[i] > 0)
                {
                    subitem.Text = "Strong x" + overallValues[i];
                    subitem.BackColor = Color.LightGreen;
                }
                else
                {
                    subitem.BackColor = Color.DarkGray;
                }

                itemOverall.SubItems.Add(subitem);
            }
            mainListView.Items.Add(itemOverall);
        }

        private void mainListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
                e.Item.Selected = false;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            System.IO.StreamWriter file = new System.IO.StreamWriter("settings.json");
            file.WriteLine(json);
            file.Close();
            MessageBox.Show("Saved!", "Success");
        }

        private void refreshButtonValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.key = refreshButtonValue.Text.ToLower();
        }

        private void viewInstructionsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. When in game and enemy heroes are visible in the scoreboard, hold the scoreboard key.\n2. Press the Refresh Key (default: G)", "Instructions");
        }

        private void dataStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=ZAEdu9VCbLQ");
        }

        private void wassup789StripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Wassup789/");
        }

        private void versionStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Wassup789/Overwatch-Counterpicker/");
        }
    }
}
