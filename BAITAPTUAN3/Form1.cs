using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPTUAN3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtLast.Text);
            item.SubItems.Add(txtFirst.Text);
            item.SubItems.Add(txtPhone.Text);

            lvSV.Items.Add(item);

            
            txtLast.Clear();
            txtFirst.Clear();
            txtPhone.Clear();
            txtLast.Focus();
        }

        private void lvSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSV.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSV.SelectedItems[0];

                txtLast.Text = item.SubItems[0].Text;
                txtFirst.Text = item.SubItems[1].Text;
                txtPhone.Text = item.SubItems[2].Text;
            }
        }
    }
}
