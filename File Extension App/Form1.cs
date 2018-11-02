using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Extension_App
    //Awet Fessha
    //Dictionary Hash tables
    //02/11/18
{
    public partial class Form1 : Form
    {

        Dictionary<String, String> list = new Dictionary<string, string>();
        String key, value, removeKey, searchKey;

        public Form1()
        {
            InitializeComponent();
        }

        //Method for finding all the items and displaying

        private void btnFind_Click(object sender, EventArgs e)
        {
            ListOfFiles.Items.Clear();
            foreach (KeyValuePair<String, String> item in list)
            {
                ListOfFiles.Items.Add(item.Key + "  " + item.Value);
            }
        }

        // Method to add to the list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddKey.Text) && !string.IsNullOrEmpty(txtAddValue.Text))
            {
                key = txtAddKey.Text;
                value = txtAddValue.Text;
                list.Add(key, value);
                txtAddKey.Text = "";
                txtAddValue.Text = "";
            }
        }

        //Method to remove an item from the list

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRemoveItem.Text))
            {
                removeKey = txtRemoveItem.Text;
                txtRemoveItem.Text = "";

                if (list.ContainsKey(removeKey))
                {
                    list.Remove(removeKey);
                    ListOfFiles.Items.Clear();
                    foreach (KeyValuePair<String, String> item in list)
                    {
                        ListOfFiles.Items.Add(item.Key + "  " + item.Value);
                    }
                }
                else
                {
                    MessageBox.Show("Item doesn't exist!");
                }


            }

        }

        //Method to search an item from the list

        private void btnSearch_Click(object sender, EventArgs e)
        {


            if (!String.IsNullOrEmpty(txtSearchItem.Text))
            {

                searchKey = txtSearchItem.Text;
                txtSearchItem.Text = "";
                ListOfFiles.Items.Clear();
                if (list.ContainsKey(searchKey))
                {
                    MessageBox.Show("item is in the list");
                }
                else
                {
                    MessageBox.Show("Item doesn't exist in the list");
                }


            }
        }






    }
}

