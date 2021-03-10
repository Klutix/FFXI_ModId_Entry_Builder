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

        private void AddToList()
        {

            try
            {
                //get old values
                Dictionary<string, string> dctAddedItems = new Dictionary<string, string>();


                List<string> lstOldItems = new List<string>();

                foreach ( string val in lstAddedValues.Items)
                {
                    lstOldItems.Add(val);
                }


                if (lstModValues.SelectedItem != null & txtSelectedItem.Text != "" & txtModValue.Text != "" & txtId.Text != "")
                {
                    //if (dctAddedItems.ContainsKey(txtId.Text + ' ' + lstModValues.SelectedItem.ToString()))
                    //dctAddedItems.Remove(txtId.Text + ' ' + lstModValues.SelectedItem.ToString());
                    //dctAddedItems.Add(dctAddedItems.Count.ToString(), txtId.Text + ' ' + lstModValues.SelectedItem.ToString() + ' ' + cboPetId.SelectedItem == null ? txtModValue.Text : txtModValue.Text + ',' + cboPetId.SelectedIndex.ToString());
                    lstOldItems.Add(txtId.Text + ' ' + lstModValues.SelectedItem.ToString() + ' ' + (cboPetId.SelectedItem == null ? txtModValue.Text : txtModValue.Text + ',' + cboPetId.SelectedIndex.ToString()));
                    lstAddedValues.DataSource = new BindingSource(lstOldItems, null);
                    lstAddedValues.SelectedIndex = lstOldItems.Count - 1;

                }


                txtFilter.Focus();

            }
            catch (Exception z)
            {
                //ooooooooo lala
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToList();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //get old values
            int index = 0;
            List<string> lstOldItems = new List<string>();
            if (lstAddedValues.Items.Count > 0)
            
                try
                {
                    //Dictionary<string, string> dctAddedItems = new Dictionary<string, string>();
                    foreach (string  val in lstAddedValues.Items)
                    {
                        if (lstAddedValues.SelectedIndex != index)
                            lstOldItems.Add(val);
                        index++;
                    }
                    if (lstOldItems.Count > 0)
                    {
                        lstAddedValues.DataSource = new BindingSource(lstOldItems, null);
                        lstAddedValues.SelectedIndex = lstAddedValues.Items.Count - 1 ;
                    }
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


        private void createPetCSVExport()
        {

            //begin export pets
            int index = 0;
            if (lstAddedValues.Items.Count > 0)
                try
                {
                    if (txtSelectedPath.Text != "")
                    {
                        string newPath = txtSelectedPath.Text.Substring(0, txtSelectedPath.Text.LastIndexOf(".") - 1) + "_pet_mods.csv";
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(newPath, true))
                        {
                            //Dictionary<string, string> dctAddedItems = new Dictionary<string, string>();
                            foreach (string val in lstAddedValues.Items)
                            {
                                string entry = val;
                                //first replace brackets with comma
                                entry = entry.Replace('[', ',');
                                entry = entry.Replace(']', ',');
                                //clean up string
                                entry = entry.Trim();


                                string[] values = entry.Split(',');
                                //this logic could be improved and moved up
                                if (values.Length > 4)
                                {

                                    string id = values[0].Trim();
                                    string modid = values[2].Trim();
                                    string value = values[3].Trim();
                                    string petId = values[4].Trim();


                                    file.WriteLine(id + "," + modid + "," + value + "," + petId);
                                }

                            }
                        };
                    
                    }
                }
                catch (Exception a)
                {
                    Console.WriteLine(a.Message);
                }


        }

        private void exportToCSV()
        {
            bool createPetCSV = true;
            //begin export
            int index = 0;
            if (lstAddedValues.Items.Count > 0)
                try
                {
                    if (txtSelectedPath.Text != "")
                    {

                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(txtSelectedPath.Text, true))
                        {
                           //Dictionary<string, string> dctAddedItems = new Dictionary<string, string>();
                            foreach (string val in lstAddedValues.Items)
                            {
                                string entry = val;
                                //first replace brackets with comma
                                entry = entry.Replace('[', ',');
                                entry = entry.Replace(']', ',');
                                //clean up string
                                entry = entry.Trim();

                                string[] values = entry.Split(',');
                                if (values.Length > 4 && createPetCSV)
                                {

                                    createPetCSVExport();
                                    createPetCSV = false;
                                    continue;
                                }

                                if (values.Length <= 4)
                                {
                                    string id = values[0].Trim();
                                    string modid = values[2].Trim();
                                    string value = values[3].Trim();


                                    file.WriteLine(id + "," + modid + "," + value);
                                }

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

        private void btnExport_Click(object sender, EventArgs e)
        {
            exportToCSV();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstAddedValues.DataSource = null;
            lstAddedValues.Items.Clear();
            cboPetId.SelectedItem = "";
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

        private void lstModValues_KeyPress(object sender, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Space)
            {
                txtModValue.Focus();

                e.Handled = true;
            }else if(e.KeyChar == (char)Keys.Tab)
            {
                txtFilter.Focus();
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Tab)
            {
                lstModValues.Focus();

                e.Handled = true;
            }
        }

        private void txtItemSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Tab)
            {
                lstItems.Focus();

                e.Handled = true;
            }
        }

            

            private void lstItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Tab)
            {
                if (lstItems.SelectedItem != null)
                {
                    string[] vals = lstItems.SelectedItem.ToString().Split('#');
                    string name = vals[1].Replace(',', ' ').Trim();
                    string id = vals[2].Replace(',', ' ').Trim();

                    txtSelectedItem.Text = name;
                    txtId.Text = id;
                }

                txtFilter.Focus();

            }
        }

        private void txtModValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Tab)
            {
                AddToList();
                txtFilter.Focus();
                
                
            }
   
        }

        private void lstItems_Enter(object sender, EventArgs e)
        {
            lstItems.BackColor = Color.DarkSlateBlue;
            
        }

        private void lstItems_Leave(object sender, EventArgs e)
        {
            lstItems.BackColor = SystemColors.WindowFrame;
        }

        private void cboPetId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPetId.SelectedText == "NA" || cboPetId.SelectedIndex == 9)
            {
                cboPetId.SelectedItem = null;
            }
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            txtFilter.BackColor = Color.DarkSlateBlue;
            txtFilter.ForeColor = Color.White;
        }

        private void lstModValues_Leave(object sender, EventArgs e)
        {
            lstModValues.BackColor = SystemColors.WindowFrame;
            
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            txtFilter.BackColor = SystemColors.ControlDark;
            
        }

        private void lstModValues_Enter(object sender, EventArgs e)
        {
            lstModValues.BackColor = Color.DarkSlateBlue;
        }

        private void txtModValue_Enter(object sender, EventArgs e)
        {
            txtModValue.BackColor = Color.DarkSlateBlue;
            txtModValue.ForeColor = Color.White;
        }

        private void txtModValue_Leave(object sender, EventArgs e)
        {
            txtModValue.BackColor = SystemColors.ControlDark;
        }

        private void txtItemSearch_Enter(object sender, EventArgs e)
        {
            txtItemSearch.BackColor = Color.DarkSlateBlue;
            txtItemSearch.ForeColor = Color.White;
        }

        private void txtItemSearch_Leave(object sender, EventArgs e)
        {
            txtItemSearch.BackColor = SystemColors.ControlDark;
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

