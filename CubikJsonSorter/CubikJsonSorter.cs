using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubikJsonSorter
{
    public partial class CubikJsonSorter : Form
    {
        public static string filepath;
        public static string savepath;
        public static List<String> transparant = new List<string>();

        public void refreshListBox()
        {
            color_listview.Items.Clear();
            foreach (string elem in transparant)
            {
                color_listview.Items.Add(elem);
            }
         }
        public CubikJsonSorter()
        {
            InitializeComponent();
        }

        private void ofd_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a Json file";
            ofd.Filter = "Json file|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                ofd_txtbox.Text = filepath;
            }
        }

        private void savepath_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save path";
            sfd.Filter = "Json file|*.json";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                savepath = sfd.FileName;
                savepath_txtbox.Text = savepath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JObject data;
            if (!(filepath == null) && !(savepath == null) && transparant.Count != 0)
            {
                data = JObject.Parse(File.ReadAllText(filepath));
                var jsonElements = data["elements"];
                var elements = JArray.FromObject(jsonElements);
                JArray test = new JArray();
                JObject result = new JObject();
                result.Add("__comment", data["__comment"]);
                result.Add("textures", data["textures"]);
                foreach(var elem in elements)
                {
                    if(!transparant.Contains(elem.Value<string>("__comment").Replace("Voxels-", ""))) {
                        test.Add(elem);
                    }
                }
                foreach(string color in transparant)
                {
                    foreach(var elem in elements)
                    {
                        if(elem.Value<string>("__comment").Equals("Voxels-" + color))
                        {
                            test.Add(elem);
                        }
                    }
                }
                result.Add("elements", test);
                string json = result.ToString();
                File.WriteAllText(savepath, json);
                result_lbl.Text = "Your Json have been sorted !";
            } else
            {
                result_lbl.Text = "Error occured !";
                MessageBox.Show("Select you'r file path and fill the transparant color list please");
                result_lbl.Text = null;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            transparant.Clear();
            refreshListBox();
        }

        private void addcolor_button_Click(object sender, EventArgs e)
        {
            if(!(color_txtbox.Text == null) && !transparant.Contains(color_txtbox.Text))
            {
                transparant.Add(color_txtbox.Text);
                refreshListBox();
                color_txtbox.Text = null;
            }
        }
    }
}
