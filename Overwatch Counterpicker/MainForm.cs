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
using Overwatch_Counterpicker;
using Overwatch_Counterpicker.JSONObjects;
using Overwatch_Team_Overview.JSONObjects;

namespace Overwatch_Team_Overview
{
    public partial class MainForm : Form
    {
        public Settings settings = new Settings();
        public Data data = new Data();
        private EditDataForm editDataForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("settings.json"))
            {
                string settingsString = "{\"key\": \"g\",}";
                System.IO.StreamWriter file = new System.IO.StreamWriter("settings.json");
                file.WriteLine(settingsString);
                file.Close();
            }

            MainForm_ResizeEnd(null, null);
            MinimumSize = new Size(800, this.Height);
            MaximumSize = new Size(Screen.AllScreens.Max(s => s.Bounds.Width), this.Height);

            RefreshData();

            String jsonData = File.ReadAllText("settings.json");
            settings = JsonConvert.DeserializeObject<Settings>(jsonData);

            refreshButtonValue.Text = settings.key.ToUpper();
        }

        public void onHeroesChange()
        {
            mainListView.Items.Clear();

            if (!Program.hasRefreshedOnce)
            {
                ListViewItem item = new ListViewItem();
                item.Group = mainListView.Groups[2];
                mainListView.Items.Add(item);
                return;
            }

            int[] overallValues = new int[Program.heroes.Length];
            for (int i = 0; i < Program.currentHeroes.Length; i++)
            {
                int heroIndex = Program.currentHeroes[i];

                ListViewItem item = new ListViewItem();
                item.UseItemStyleForSubItems = false;
                item.Text = Program.GetHeroName(heroIndex);
                item.Group = mainListView.Groups[0];

                for (int j = 0; j < Program.heroes.Length; j++)
                {
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                    switch (data.data[j, heroIndex])
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
                    overallValues[j] += data.data[j, heroIndex];

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
            MainForm_ResizeEnd(null, null);
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
            if(data.link != "" && VerifyURL(data.link))
                System.Diagnostics.Process.Start(data.link);
        }

        private void wassup789StripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Wassup789/");
        }

        private void versionStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Wassup789/Overwatch-Counterpicker/");
        }

        public static bool VerifyURL(string source)
        {
            Uri uriResult;
            return Uri.TryCreate(source, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        public void RefreshData()
        {
            string jsonData = File.ReadAllText("data.json");
            data = JsonConvert.DeserializeObject<Data>(jsonData);
            if (data.creator == "")
                data.creator = "Unknown";

            dataStripMenuItem.Text = "Data by " + data.creator;
            mainListView.Groups[0].Header = "Enemies (Data by " + data.creator + ")";

            onHeroesChange();
        }

        private void reloadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void editDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editDataForm == null || editDataForm.IsDisposed)
            {
                editDataForm = new EditDataForm(this);
                editDataForm.Show();
            }
            else if (!editDataForm.IsDisposed)
            {
                editDataForm.Focus();
            }
        }
        
        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            foreach (ColumnHeader column in mainListView.Columns)
            {
                column.Width = -2;
            }
        }
    }
}
