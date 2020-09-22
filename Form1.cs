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




namespace FFXIExtractSharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void LoadDescriptionListox(String filter = null)
        {
            Dictionary<string, string> filteredList = new Dictionary<string, string>();
            List<ItemDescriptionData> values = File.ReadAllLines("ffxi_item_data.csv")
                                        .Skip(1) //skip the header
                                        .Select(v => ItemDescriptionData.FromCsv(v))
                                        .ToList();
            if (filter.Length >= 3) {
                foreach (var item in values)

                {
                    if (item.name.ToLower().Contains(filter.ToLower()) || item.id.Contains(filter) || item.lname.Contains(filter.ToLower()))
                    {
                        try
                        {
                            filteredList.Add("#" + item.name, " #" + item.id + " #" + item.desrciption);
                        } catch (Exception e)
                        {
                            //ja
                        }     
                    }

                }
            }
            if (filteredList.Count > 0)
                lstItems.DataSource = new BindingSource(filteredList, null);
            else
            {
                lstItems.DataSource = null;
                lstItems.Items.Clear();
            }
        }


        public void LoadMidListBox(string filter = null)
        {

            Dictionary<string, string> filteredList = new Dictionary<string, string>();
            List<ModIdData> values = File.ReadAllLines("modid.csv")
                                        .Skip(1) //skip the header
                                        .Select(v => ModIdData.FromCsv(v))
                                        .ToList();

            foreach (var item in values)

            {
                if (filter == "")
                {
                    lstModValues.DataSource = null;
                    lstModValues.Items.Clear();
                    return;
                }
                //                    lstModValues.Items.Add(new ListViewItem(new string[] { item.mod, item.mid }));
                else
                {
                    if (item.mid.Contains(filter) || item.mod.Contains(filter.ToUpper()))
                    {
                        filteredList.Add(item.mod, item.mid);
                        //lstModValues.Items.Add(new ListViewItem(new string[] { item.mod, item.mid }));
                        Console.WriteLine("conatins");
                    }
                }
            }
            lstModValues.DataSource = new BindingSource(filteredList, null);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //  LoadMidListBox();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            LoadMidListBox(txtFilter.Text);

        }

        private void groupBox1_Enter(object sender, EventArgs e) ///dead DO NOT DELETE
        {

        }

        private void sd_Click(object sender, EventArgs e)//dead DO NOT DELETE
        {

        }

        private void txtItemSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDescriptionListox(CapFirstAllWords(txtItemSearch.Text));
        }

        public string CapFirstAllWords(string word)
        {
            string[] words;
            words = word.Split(' ');
            string newWord = "";
            if (words[words.Length-1] != "")
                foreach( string w in words){
                    string f = w[0].ToString().ToUpper();
                    newWord += f + w.Substring(1)+ " ";
                }
            return newWord.TrimEnd();
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem != null)
                rtxtDescription.Text = lstItems.SelectedItem.ToString();
            else
                rtxtDescription.Text = "";
        }

        

        private void lstItems_Click(object sender, EventArgs e)
        {
            //get id and name
            
            
            if (lstItems.SelectedItem != null)
            {
                string[] vals = lstItems.SelectedItem.ToString().Split('#');
                string name = vals[1].Replace(',', ' ').Trim();
                string id = vals[2].Replace(',', ' ').Trim();

                txtSelectedItem.Text = name;
                txtId.Text = id;
            }
        }


        private void label4_Click(object sender, EventArgs e)//dead do not delete
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //get old values
                Dictionary<string, string> dctAddedItems = new Dictionary<string, string>();
               
                foreach(KeyValuePair<string, string> val in lstAddedValues.Items)
                {
                    dctAddedItems.Add(val.Key.ToString(), val.Value.ToString());
                }

            
                if (lstModValues.SelectedItem != null & txtSelectedItem.Text != "" & txtModValue.Text != "" & txtId.Text != "")
                {
                    if (!dctAddedItems.ContainsKey(txtId.Text + ' ' + lstModValues.SelectedItem.ToString())) ;
                    dctAddedItems.Add(txtId.Text + ' ' + lstModValues.SelectedItem.ToString(), txtModValue.Text);
                    lstAddedValues.DataSource = new BindingSource(dctAddedItems, null);
                }
               
            }catch(Exception z)
            {
                //ooooooooo lala
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //get old values
            int index = 0;
            if (lstAddedValues.Items.Count > 0)
            
                try
                {
                    Dictionary<string, string> dctAddedItems = new Dictionary<string, string>();
                    foreach (KeyValuePair<string, string> val in lstAddedValues.Items)
                    {
                        if (lstAddedValues.SelectedIndex != index)
                            dctAddedItems.Add(val.Key.ToString(), val.Value.ToString());
                        index++;
                    }
                    if (dctAddedItems.Count > 0)
                        lstAddedValues.DataSource = new BindingSource(dctAddedItems, null);
                    else
                    {
                        lstAddedValues.DataSource = null;
                        lstAddedValues.Items.Clear();
                    }
                }
                catch (Exception a)
                {
                    //jup
                }
            
        }

        private void lstModValues_SelectedIndexChanged(object sender, EventArgs e) //dead no touch
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
                //begin export
                int index = 0;
                if (lstAddedValues.Items.Count > 0)
                    try
                    {
                        if (txtSelectedPath.Text != "")
                        {

                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(txtSelectedPath.Text,true))
                            {
                                Dictionary<string, string> dctAddedItems = new Dictionary<string, string>();
                                foreach (KeyValuePair<string, string> val in lstAddedValues.Items)
                                {
                                    string entry = val.Key.ToString() + val.Value.ToString();
                                    //first replace brackets with comma
                                    entry = entry.Replace('[', ',');
                                    entry = entry.Replace(']', ',');
                                    //clean up string
                                    entry = entry.Trim();

                                    string[] values = entry.Split(',');

                                    string id = values[0].Trim();
                                    string modid = values[2].Trim();
                                    string value = values[3].Trim();


                                    file.WriteLine(id+"," + modid+"," + value);
                       
                                }
                            };
                        MessageBox.Show("Finished Export");
                        }
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine(a.Message);
                    }

                }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstAddedValues.DataSource = null;
            lstAddedValues.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog1 = new SaveFileDialog();
            openFileDialog1.Title = "Export CSV";
            openFileDialog1.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
                txtSelectedPath.Text = openFileDialog1.FileName;
        }
    }


    public class ItemDescriptionData
    {
        public string id;
        public string name;
        public string desrciption;
        public string lname;

        public static ItemDescriptionData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            ItemDescriptionData descriptionData = new ItemDescriptionData();
            descriptionData.id = values[0];
            descriptionData.name = values[7];
            descriptionData.lname = values[1];
            descriptionData.desrciption = values[8];
            

            return descriptionData;
        }
    }

    public class ModIdData
    {
        public string mod;
        public string mid;

        public static ModIdData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            ModIdData ModIdData = new ModIdData();
            ModIdData.mod = values[0];
            ModIdData.mid = values[1];

            return ModIdData;
        }

    }


}

