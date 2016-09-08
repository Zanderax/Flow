//------------------------------------------------------------------------------
// <copyright file="ZoneControl.xaml.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Newtonsoft.Json;
using Constants = EnvDTE.Constants;


namespace Flow
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for ZoneControl.
    /// </summary>
    public partial class ZoneControl : UserControl
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneControl"/> class.
        /// </summary>

        private Items items;

        private int totalItems;
        private int currentItem;

        public ZoneControl()
        {
            this.InitializeComponent();
            totalItems = 0;
            currentItem = 0;
            items = new Items();
            LoadItems(); 
        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter",
            Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "Zone");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var edit = new EditItems(items);
            var result = edit.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetItems(edit.returnItems.items);
            }
        }

        private void SetItems(List<Item> newItems)
        {
            if (newItems.Count >= 1)
            {
                this.items.items = newItems;
                totalItems = newItems.Count;
                currentItem = 1;
                UpdateItem();
            }
            else
            {
                totalItems = 0;
                currentItem = 0;
                UpdateItem();
            }
        }

        private void UpdateItem()
        {
            Counter.Text = string.Format("{0}/{1}", currentItem, totalItems);
            if (totalItems > 0)
            {
                Task.Text = items.items[currentItem - 1].Task;
                Title.Text = items.items[currentItem - 1].Title;
            }
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            if (currentItem > 1)
            {
                currentItem--;
                UpdateItem();
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (currentItem < totalItems)
            {
                currentItem++;
                UpdateItem();
            }
        }

        [Import]
        internal SVsServiceProvider ServiceProvider = null;

        [DllImport("ole32.dll")]
        private static extern void CreateBindCtx(int reserved, out IBindCtx ppbc);

        [DllImport("ole32.dll")]
        private static extern int GetRunningObjectTable(int reserved, out IRunningObjectTable prot);

        IEnumerable<DTE> GetInstances()
        {
            IRunningObjectTable rot;
            IEnumMoniker enumMoniker;
            int retVal = GetRunningObjectTable(0, out rot);

            if (retVal == 0)
            {
                rot.EnumRunning(out enumMoniker);

                uint fetched = 0;
                IMoniker[] moniker = new IMoniker[1];
                while (enumMoniker.Next(1, moniker, out fetched) == 0)
                {
                    IBindCtx bindCtx;
                    CreateBindCtx(0, out bindCtx);
                    string displayName;
                    moniker[0].GetDisplayName(bindCtx, null, out displayName);
                    Console.WriteLine("Display Name: {0}", displayName);
                    bool isVisualStudio = displayName.StartsWith("!VisualStudio");
                    if (isVisualStudio)
                    {
                        object obj;
                        rot.GetObject(moniker[0], out obj);
                        var dte = obj as DTE;
                        yield return dte;
                    }
                }
            }
        }

        private void btn_OpenFiles_Click(object sender, RoutedEventArgs e)
        {
            var DTE = GetInstances().ElementAt(0);

            List<string> documentsPaths = items.items[currentItem].DocumentPaths;
            if (documentsPaths.Count > 1)
            {
                DTE.Documents.CloseAll();
            }
            foreach (string documentsPath in documentsPaths)
            {
                if (File.Exists(documentsPath))
                {

                    DTE.ExecuteCommand("File.OpenFile", documentsPath);
                }
            }
        }

        private void LoadItems()
        {
            //SetItems(new List<Item>());
            if (File.Exists(@"C:\temp\flowItems.txt"))
            {
                var existingItemsString = System.IO.File.ReadAllText(@"C:\temp\flowItems.txt");
                if (!string.IsNullOrEmpty(existingItemsString))
                {
                    var existingItems = JsonConvert.DeserializeObject<Items>(existingItemsString).items;
                    if (existingItems != null)
                    {
                        SetItems(existingItems);
                    }
                }
            }
        }
    }
}