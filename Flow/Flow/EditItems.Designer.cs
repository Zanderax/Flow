namespace Flow
{
    partial class EditItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Items = new System.Windows.Forms.ListBox();
            this.Add_Item = new System.Windows.Forms.Button();
            this.Remove_Item = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Task = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Task = new System.Windows.Forms.RichTextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Add_Document = new System.Windows.Forms.Button();
            this.lb_Documents = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Items
            // 
            this.Items.FormattingEnabled = true;
            this.Items.Location = new System.Drawing.Point(63, 12);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(209, 173);
            this.Items.TabIndex = 0;
            this.Items.SelectedIndexChanged += new System.EventHandler(this.Items_SelectedIndexChanged);
            // 
            // Add_Item
            // 
            this.Add_Item.Location = new System.Drawing.Point(278, 12);
            this.Add_Item.Name = "Add_Item";
            this.Add_Item.Size = new System.Drawing.Size(82, 58);
            this.Add_Item.TabIndex = 1;
            this.Add_Item.Text = "Add Item";
            this.Add_Item.UseVisualStyleBackColor = true;
            this.Add_Item.Click += new System.EventHandler(this.Add_Item_Click);
            // 
            // Remove_Item
            // 
            this.Remove_Item.Location = new System.Drawing.Point(278, 76);
            this.Remove_Item.Name = "Remove_Item";
            this.Remove_Item.Size = new System.Drawing.Size(82, 58);
            this.Remove_Item.TabIndex = 2;
            this.Remove_Item.Text = "Remove Item";
            this.Remove_Item.UseVisualStyleBackColor = true;
            this.Remove_Item.Click += new System.EventHandler(this.Remove_Item_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(63, 191);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 56);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 4;
            this.Title.Text = "Title";
            // 
            // Task
            // 
            this.Task.AutoSize = true;
            this.Task.Location = new System.Drawing.Point(6, 45);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(31, 13);
            this.Task.TabIndex = 5;
            this.Task.Text = "Task";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_Task);
            this.panel1.Controls.Add(this.tb_title);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.Task);
            this.panel1.Location = new System.Drawing.Point(366, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 227);
            this.panel1.TabIndex = 8;
            // 
            // tb_Task
            // 
            this.tb_Task.Location = new System.Drawing.Point(9, 64);
            this.tb_Task.MaxLength = 500;
            this.tb_Task.Name = "tb_Task";
            this.tb_Task.Size = new System.Drawing.Size(268, 160);
            this.tb_Task.TabIndex = 7;
            this.tb_Task.Text = "";
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(9, 17);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(268, 20);
            this.tb_title.TabIndex = 6;
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(12, 30);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(36, 23);
            this.btn_up.TabIndex = 9;
            this.btn_up.Text = "⇧";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(12, 59);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(36, 23);
            this.btn_down.TabIndex = 10;
            this.btn_down.Text = "⇩";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(879, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 58);
            this.button2.TabIndex = 13;
            this.button2.Text = "Remove Document";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Document
            // 
            this.btn_Add_Document.Location = new System.Drawing.Point(879, 12);
            this.btn_Add_Document.Name = "btn_Add_Document";
            this.btn_Add_Document.Size = new System.Drawing.Size(82, 58);
            this.btn_Add_Document.TabIndex = 12;
            this.btn_Add_Document.Text = "Add Document";
            this.btn_Add_Document.UseVisualStyleBackColor = true;
            this.btn_Add_Document.Click += new System.EventHandler(this.btn_Add_Document_Click);
            // 
            // lb_Documents
            // 
            this.lb_Documents.FormattingEnabled = true;
            this.lb_Documents.Location = new System.Drawing.Point(664, 12);
            this.lb_Documents.Name = "lb_Documents";
            this.lb_Documents.Size = new System.Drawing.Size(209, 173);
            this.lb_Documents.TabIndex = 11;
            // 
            // EditItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 263);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Add_Document);
            this.Controls.Add(this.lb_Documents);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.Remove_Item);
            this.Controls.Add(this.Add_Item);
            this.Controls.Add(this.Items);
            this.Name = "EditItems";
            this.Text = "EditItems";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Items;
        private System.Windows.Forms.Button Add_Item;
        private System.Windows.Forms.Button Remove_Item;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Task;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox tb_Task;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Add_Document;
        private System.Windows.Forms.ListBox lb_Documents;
    }
}