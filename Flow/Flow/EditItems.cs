using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Flow
{
    public partial class EditItems : Form
    {
        public Items returnItems;
        private Items items;

        public EditItems(Items existingItems = null)
        {
            items = existingItems ?? new Items();
            InitializeComponent();
            updateTaskList();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\temp\flowItems.txt", JsonConvert.SerializeObject(items));
            returnItems = items;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void Add_Item_Click(object sender, EventArgs e)
        {
            items.items.Add(new Item {Title = tb_title.Text, Task = tb_Task.Text});
            tb_title.Clear();
            tb_Task.Clear();
            updateTaskList();
        }

        private void updateTaskList()
        {
            Items.Items.Clear();
            foreach (var item in items.items)
            {
                Items.Items.Add(item.Title);
            }
        }

        private void Remove_Item_Click(object sender, EventArgs e)
        {
            items.items.Remove(items.items.Find(x => x.Title == Items.SelectedItem.ToString()));
            updateTaskList();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            var sel = Items.SelectedIndex;
            if (Items.SelectedIndex > 0)
            {
                Swap(items.items, sel, sel - 1);
                updateTaskList();
                Items.SetSelected(sel - 1, true);
            }      
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            var sel = Items.SelectedIndex;
            if (Items.SelectedIndex > 0)
            {
                Swap(items.items, sel, sel + 1);
                updateTaskList();
                Items.SetSelected(sel + 1, true);
            }
        }

        private void Swap(List<Item> list, int firstIndex, int secondIndex)
        {
            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        private void btn_Add_Document_Click(object sender, EventArgs e)
        {
            var OFD = new OpenFileDialog();
            OFD.ShowDialog();
            items.items[Items.SelectedIndex].DocumentPaths.Add(OFD.FileName);
            UpdateDocumentList();
        }

        private void Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDocumentList();
        }

        private void UpdateDocumentList()
        {
            lb_Documents.Items.Clear();
            var allDocPaths = items.items[Items.SelectedIndex].DocumentPaths;
            foreach (var docPaths in allDocPaths)
            {
                lb_Documents.Items.Add(docPaths);
            }
        }
    }
    public class Items
    {
        public Items()
        {
            items = new List<Item>();
        }
        public List<Item> items;
    }

    public class Item
    {
        public string Title { get; set; }
        public string Task { get; set; }
        public List<string> DocumentPaths { get; set; }
        public Item()
        {
            DocumentPaths = new List<string>();
        }
    }
}
