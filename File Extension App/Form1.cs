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


    }
}

