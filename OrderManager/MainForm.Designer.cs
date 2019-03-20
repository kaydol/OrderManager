namespace OrderManager
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_ClientTabs = new System.Windows.Forms.TabControl();
            this.tabPage1_ActiveOrder = new System.Windows.Forms.TabPage();
            this.treeView_ActiveOrder = new System.Windows.Forms.TreeView();
            this.textBox_Cost = new System.Windows.Forms.TextBox();
            this.textBox_DueDate = new System.Windows.Forms.TextBox();
            this.label_Cost = new System.Windows.Forms.Label();
            this.button_MoveOrderToHistory = new System.Windows.Forms.Button();
            this.label_DueDate = new System.Windows.Forms.Label();
            this.tabPage2_History = new System.Windows.Forms.TabPage();
            this.treeView_history = new System.Windows.Forms.TreeView();
            this.textBox_OverdueTotal = new System.Windows.Forms.TextBox();
            this.label_OverdueTotal = new System.Windows.Forms.Label();
            this.label_ClientName = new System.Windows.Forms.Label();
            this.textBox_ClientName = new System.Windows.Forms.TextBox();
            this.listBox_Menu = new System.Windows.Forms.ListBox();
            this.groupBox_Clients = new System.Windows.Forms.GroupBox();
            this.button_RemoveClient = new System.Windows.Forms.Button();
            this.listBox_AllClients = new System.Windows.Forms.ListBox();
            this.button_AddClient = new System.Windows.Forms.Button();
            this.groupBox_SelectedClient = new System.Windows.Forms.GroupBox();
            this.groupBox_Menu = new System.Windows.Forms.GroupBox();
            this.button_RemoveAssortmentItem = new System.Windows.Forms.Button();
            this.button_AddAssortmentItem = new System.Windows.Forms.Button();
            this.button_AddToActiveOrder = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_LoadCustomerDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_SaveCustomerDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_LoadMenuDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_SaveMenuDB = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_ClientTabs.SuspendLayout();
            this.tabPage1_ActiveOrder.SuspendLayout();
            this.tabPage2_History.SuspendLayout();
            this.groupBox_Clients.SuspendLayout();
            this.groupBox_SelectedClient.SuspendLayout();
            this.groupBox_Menu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_ClientTabs
            // 
            this.tabControl_ClientTabs.Controls.Add(this.tabPage1_ActiveOrder);
            this.tabControl_ClientTabs.Controls.Add(this.tabPage2_History);
            this.tabControl_ClientTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl_ClientTabs.Location = new System.Drawing.Point(6, 63);
            this.tabControl_ClientTabs.Name = "tabControl_ClientTabs";
            this.tabControl_ClientTabs.SelectedIndex = 0;
            this.tabControl_ClientTabs.Size = new System.Drawing.Size(350, 384);
            this.tabControl_ClientTabs.TabIndex = 4;
            // 
            // tabPage1_ActiveOrder
            // 
            this.tabPage1_ActiveOrder.Controls.Add(this.treeView_ActiveOrder);
            this.tabPage1_ActiveOrder.Controls.Add(this.textBox_Cost);
            this.tabPage1_ActiveOrder.Controls.Add(this.textBox_DueDate);
            this.tabPage1_ActiveOrder.Controls.Add(this.label_Cost);
            this.tabPage1_ActiveOrder.Controls.Add(this.button_MoveOrderToHistory);
            this.tabPage1_ActiveOrder.Controls.Add(this.label_DueDate);
            this.tabPage1_ActiveOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPage1_ActiveOrder.Name = "tabPage1_ActiveOrder";
            this.tabPage1_ActiveOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_ActiveOrder.Size = new System.Drawing.Size(342, 355);
            this.tabPage1_ActiveOrder.TabIndex = 0;
            this.tabPage1_ActiveOrder.Text = "Active Order";
            this.tabPage1_ActiveOrder.UseVisualStyleBackColor = true;
            // 
            // treeView_ActiveOrder
            // 
            this.treeView_ActiveOrder.Location = new System.Drawing.Point(6, 6);
            this.treeView_ActiveOrder.Name = "treeView_ActiveOrder";
            this.treeView_ActiveOrder.Size = new System.Drawing.Size(329, 278);
            this.treeView_ActiveOrder.TabIndex = 14;
            // 
            // textBox_Cost
            // 
            this.textBox_Cost.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Cost.Location = new System.Drawing.Point(231, 290);
            this.textBox_Cost.Name = "textBox_Cost";
            this.textBox_Cost.Size = new System.Drawing.Size(104, 24);
            this.textBox_Cost.TabIndex = 13;
            this.textBox_Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_DueDate
            // 
            this.textBox_DueDate.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_DueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DueDate.Location = new System.Drawing.Point(83, 290);
            this.textBox_DueDate.Name = "textBox_DueDate";
            this.textBox_DueDate.Size = new System.Drawing.Size(99, 24);
            this.textBox_DueDate.TabIndex = 11;
            this.textBox_DueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Cost
            // 
            this.label_Cost.AutoSize = true;
            this.label_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Cost.Location = new System.Drawing.Point(188, 292);
            this.label_Cost.Name = "label_Cost";
            this.label_Cost.Size = new System.Drawing.Size(42, 20);
            this.label_Cost.TabIndex = 12;
            this.label_Cost.Text = "Cost";
            // 
            // button_MoveOrderToHistory
            // 
            this.button_MoveOrderToHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MoveOrderToHistory.Location = new System.Drawing.Point(6, 319);
            this.button_MoveOrderToHistory.Name = "button_MoveOrderToHistory";
            this.button_MoveOrderToHistory.Size = new System.Drawing.Size(330, 30);
            this.button_MoveOrderToHistory.TabIndex = 9;
            this.button_MoveOrderToHistory.Text = "Move order to history";
            this.button_MoveOrderToHistory.UseVisualStyleBackColor = true;
            this.button_MoveOrderToHistory.Click += new System.EventHandler(this.button_MoveOrderToHistory_Click);
            // 
            // label_DueDate
            // 
            this.label_DueDate.AutoSize = true;
            this.label_DueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DueDate.Location = new System.Drawing.Point(6, 292);
            this.label_DueDate.Name = "label_DueDate";
            this.label_DueDate.Size = new System.Drawing.Size(75, 20);
            this.label_DueDate.TabIndex = 10;
            this.label_DueDate.Text = "Due date";
            // 
            // tabPage2_History
            // 
            this.tabPage2_History.Controls.Add(this.treeView_history);
            this.tabPage2_History.Controls.Add(this.textBox_OverdueTotal);
            this.tabPage2_History.Controls.Add(this.label_OverdueTotal);
            this.tabPage2_History.Location = new System.Drawing.Point(4, 25);
            this.tabPage2_History.Name = "tabPage2_History";
            this.tabPage2_History.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_History.Size = new System.Drawing.Size(342, 355);
            this.tabPage2_History.TabIndex = 1;
            this.tabPage2_History.Text = "History";
            this.tabPage2_History.UseVisualStyleBackColor = true;
            // 
            // treeView_history
            // 
            this.treeView_history.Location = new System.Drawing.Point(6, 6);
            this.treeView_history.Name = "treeView_history";
            this.treeView_history.Size = new System.Drawing.Size(329, 278);
            this.treeView_history.TabIndex = 15;
            // 
            // textBox_OverdueTotal
            // 
            this.textBox_OverdueTotal.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_OverdueTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_OverdueTotal.Location = new System.Drawing.Point(163, 313);
            this.textBox_OverdueTotal.Name = "textBox_OverdueTotal";
            this.textBox_OverdueTotal.Size = new System.Drawing.Size(99, 24);
            this.textBox_OverdueTotal.TabIndex = 13;
            this.textBox_OverdueTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_OverdueTotal
            // 
            this.label_OverdueTotal.AutoSize = true;
            this.label_OverdueTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_OverdueTotal.Location = new System.Drawing.Point(53, 313);
            this.label_OverdueTotal.Name = "label_OverdueTotal";
            this.label_OverdueTotal.Size = new System.Drawing.Size(104, 20);
            this.label_OverdueTotal.TabIndex = 12;
            this.label_OverdueTotal.Text = "Overdue total";
            // 
            // label_ClientName
            // 
            this.label_ClientName.AutoSize = true;
            this.label_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ClientName.Location = new System.Drawing.Point(10, 35);
            this.label_ClientName.Name = "label_ClientName";
            this.label_ClientName.Size = new System.Drawing.Size(51, 20);
            this.label_ClientName.TabIndex = 7;
            this.label_ClientName.Text = "Name";
            // 
            // textBox_ClientName
            // 
            this.textBox_ClientName.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ClientName.Location = new System.Drawing.Point(67, 33);
            this.textBox_ClientName.Name = "textBox_ClientName";
            this.textBox_ClientName.Size = new System.Drawing.Size(284, 24);
            this.textBox_ClientName.TabIndex = 8;
            this.textBox_ClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBox_Menu
            // 
            this.listBox_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Menu.FormattingEnabled = true;
            this.listBox_Menu.ItemHeight = 16;
            this.listBox_Menu.Location = new System.Drawing.Point(10, 33);
            this.listBox_Menu.Name = "listBox_Menu";
            this.listBox_Menu.Size = new System.Drawing.Size(198, 340);
            this.listBox_Menu.Sorted = true;
            this.listBox_Menu.TabIndex = 9;
            // 
            // groupBox_Clients
            // 
            this.groupBox_Clients.Controls.Add(this.button_RemoveClient);
            this.groupBox_Clients.Controls.Add(this.listBox_AllClients);
            this.groupBox_Clients.Controls.Add(this.button_AddClient);
            this.groupBox_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Clients.Location = new System.Drawing.Point(8, 24);
            this.groupBox_Clients.Name = "groupBox_Clients";
            this.groupBox_Clients.Size = new System.Drawing.Size(196, 453);
            this.groupBox_Clients.TabIndex = 12;
            this.groupBox_Clients.TabStop = false;
            this.groupBox_Clients.Text = "Customers";
            // 
            // button_RemoveClient
            // 
            this.button_RemoveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_RemoveClient.Location = new System.Drawing.Point(6, 417);
            this.button_RemoveClient.Name = "button_RemoveClient";
            this.button_RemoveClient.Size = new System.Drawing.Size(184, 30);
            this.button_RemoveClient.TabIndex = 3;
            this.button_RemoveClient.Text = "Remove customer";
            this.button_RemoveClient.UseVisualStyleBackColor = true;
            this.button_RemoveClient.Click += new System.EventHandler(this.button_RemoveClient_Click);
            // 
            // listBox_AllClients
            // 
            this.listBox_AllClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_AllClients.FormattingEnabled = true;
            this.listBox_AllClients.ItemHeight = 16;
            this.listBox_AllClients.Location = new System.Drawing.Point(6, 33);
            this.listBox_AllClients.Name = "listBox_AllClients";
            this.listBox_AllClients.Size = new System.Drawing.Size(184, 340);
            this.listBox_AllClients.Sorted = true;
            this.listBox_AllClients.TabIndex = 1;
            this.listBox_AllClients.SelectedIndexChanged += new System.EventHandler(this.listbox_AllClients_SelectedItemChanged);
            // 
            // button_AddClient
            // 
            this.button_AddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddClient.Location = new System.Drawing.Point(6, 382);
            this.button_AddClient.Name = "button_AddClient";
            this.button_AddClient.Size = new System.Drawing.Size(184, 30);
            this.button_AddClient.TabIndex = 2;
            this.button_AddClient.Text = "New customer";
            this.button_AddClient.UseVisualStyleBackColor = true;
            this.button_AddClient.Click += new System.EventHandler(this.button_AddClient_Click);
            // 
            // groupBox_SelectedClient
            // 
            this.groupBox_SelectedClient.Controls.Add(this.tabControl_ClientTabs);
            this.groupBox_SelectedClient.Controls.Add(this.textBox_ClientName);
            this.groupBox_SelectedClient.Controls.Add(this.label_ClientName);
            this.groupBox_SelectedClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_SelectedClient.Location = new System.Drawing.Point(210, 24);
            this.groupBox_SelectedClient.Name = "groupBox_SelectedClient";
            this.groupBox_SelectedClient.Size = new System.Drawing.Size(362, 453);
            this.groupBox_SelectedClient.TabIndex = 13;
            this.groupBox_SelectedClient.TabStop = false;
            this.groupBox_SelectedClient.Text = "Selected Customer";
            // 
            // groupBox_Menu
            // 
            this.groupBox_Menu.Controls.Add(this.button_RemoveAssortmentItem);
            this.groupBox_Menu.Controls.Add(this.button_AddAssortmentItem);
            this.groupBox_Menu.Controls.Add(this.button_AddToActiveOrder);
            this.groupBox_Menu.Controls.Add(this.listBox_Menu);
            this.groupBox_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Menu.Location = new System.Drawing.Point(578, 24);
            this.groupBox_Menu.Name = "groupBox_Menu";
            this.groupBox_Menu.Size = new System.Drawing.Size(214, 453);
            this.groupBox_Menu.TabIndex = 14;
            this.groupBox_Menu.TabStop = false;
            this.groupBox_Menu.Text = "Assortment";
            // 
            // button_RemoveAssortmentItem
            // 
            this.button_RemoveAssortmentItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_RemoveAssortmentItem.Location = new System.Drawing.Point(115, 382);
            this.button_RemoveAssortmentItem.Name = "button_RemoveAssortmentItem";
            this.button_RemoveAssortmentItem.Size = new System.Drawing.Size(93, 30);
            this.button_RemoveAssortmentItem.TabIndex = 12;
            this.button_RemoveAssortmentItem.Text = "Remove";
            this.button_RemoveAssortmentItem.UseVisualStyleBackColor = true;
            this.button_RemoveAssortmentItem.Click += new System.EventHandler(this.button_RemoveAssortmentItem_Click);
            // 
            // button_AddAssortmentItem
            // 
            this.button_AddAssortmentItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddAssortmentItem.Location = new System.Drawing.Point(10, 382);
            this.button_AddAssortmentItem.Name = "button_AddAssortmentItem";
            this.button_AddAssortmentItem.Size = new System.Drawing.Size(99, 30);
            this.button_AddAssortmentItem.TabIndex = 11;
            this.button_AddAssortmentItem.Text = "New item";
            this.button_AddAssortmentItem.UseVisualStyleBackColor = true;
            this.button_AddAssortmentItem.Click += new System.EventHandler(this.button_AddAssortmentItem_Click);
            // 
            // button_AddToActiveOrder
            // 
            this.button_AddToActiveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddToActiveOrder.Location = new System.Drawing.Point(10, 417);
            this.button_AddToActiveOrder.Name = "button_AddToActiveOrder";
            this.button_AddToActiveOrder.Size = new System.Drawing.Size(198, 30);
            this.button_AddToActiveOrder.TabIndex = 10;
            this.button_AddToActiveOrder.Text = "Add to active order";
            this.button_AddToActiveOrder.UseVisualStyleBackColor = true;
            this.button_AddToActiveOrder.Click += new System.EventHandler(this.button_AddToActiveOrder_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_File,
            this.toolStripMenuItem_Menu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_LoadCustomerDB,
            this.toolStripMenuItem_SaveCustomerDB});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItem_File.Text = "Customers";
            // 
            // toolStripMenuItem_LoadCustomerDB
            // 
            this.toolStripMenuItem_LoadCustomerDB.Name = "toolStripMenuItem_LoadCustomerDB";
            this.toolStripMenuItem_LoadCustomerDB.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem_LoadCustomerDB.Text = "Load database...";
            this.toolStripMenuItem_LoadCustomerDB.Click += new System.EventHandler(this.toolStripMenuItem_LoadCustomerDB_Click);
            // 
            // toolStripMenuItem_SaveCustomerDB
            // 
            this.toolStripMenuItem_SaveCustomerDB.Name = "toolStripMenuItem_SaveCustomerDB";
            this.toolStripMenuItem_SaveCustomerDB.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem_SaveCustomerDB.Text = "Save database";
            this.toolStripMenuItem_SaveCustomerDB.Click += new System.EventHandler(this.toolStripMenuItem_SaveCustomerDB_Click);
            // 
            // toolStripMenuItem_Menu
            // 
            this.toolStripMenuItem_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_LoadMenuDB,
            this.toolStripMenuItem_SaveMenuDB});
            this.toolStripMenuItem_Menu.Name = "toolStripMenuItem_Menu";
            this.toolStripMenuItem_Menu.Size = new System.Drawing.Size(80, 20);
            this.toolStripMenuItem_Menu.Text = "Assortment";
            // 
            // toolStripMenuItem_LoadMenuDB
            // 
            this.toolStripMenuItem_LoadMenuDB.Name = "toolStripMenuItem_LoadMenuDB";
            this.toolStripMenuItem_LoadMenuDB.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem_LoadMenuDB.Text = "Load database...";
            this.toolStripMenuItem_LoadMenuDB.Click += new System.EventHandler(this.toolStripMenuItem_LoadMenuDB_Click);
            // 
            // toolStripMenuItem_SaveMenuDB
            // 
            this.toolStripMenuItem_SaveMenuDB.Name = "toolStripMenuItem_SaveMenuDB";
            this.toolStripMenuItem_SaveMenuDB.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem_SaveMenuDB.Text = "Save database";
            this.toolStripMenuItem_SaveMenuDB.Click += new System.EventHandler(this.toolStripMenuItem_SaveMenuDB_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.groupBox_Menu);
            this.Controls.Add(this.groupBox_SelectedClient);
            this.Controls.Add(this.groupBox_Clients);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Manager";
            this.tabControl_ClientTabs.ResumeLayout(false);
            this.tabPage1_ActiveOrder.ResumeLayout(false);
            this.tabPage1_ActiveOrder.PerformLayout();
            this.tabPage2_History.ResumeLayout(false);
            this.tabPage2_History.PerformLayout();
            this.groupBox_Clients.ResumeLayout(false);
            this.groupBox_SelectedClient.ResumeLayout(false);
            this.groupBox_SelectedClient.PerformLayout();
            this.groupBox_Menu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_ClientTabs;
        private System.Windows.Forms.TabPage tabPage1_ActiveOrder;
        private System.Windows.Forms.TabPage tabPage2_History;
        private System.Windows.Forms.Label label_ClientName;
        private System.Windows.Forms.TextBox textBox_ClientName;
        private System.Windows.Forms.ListBox listBox_Menu;
        private System.Windows.Forms.Button button_RemoveClient;
        private System.Windows.Forms.Button button_AddClient;
        private System.Windows.Forms.GroupBox groupBox_Clients;
        private System.Windows.Forms.ListBox listBox_AllClients;
        private System.Windows.Forms.GroupBox groupBox_SelectedClient;
        private System.Windows.Forms.TextBox textBox_Cost;
        private System.Windows.Forms.Label label_Cost;
        private System.Windows.Forms.TextBox textBox_DueDate;
        private System.Windows.Forms.Label label_DueDate;
        private System.Windows.Forms.Button button_MoveOrderToHistory;
        private System.Windows.Forms.GroupBox groupBox_Menu;
        private System.Windows.Forms.Button button_AddToActiveOrder;
        private System.Windows.Forms.TreeView treeView_ActiveOrder;
        private System.Windows.Forms.TextBox textBox_OverdueTotal;
        private System.Windows.Forms.Label label_OverdueTotal;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LoadCustomerDB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SaveCustomerDB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LoadMenuDB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SaveMenuDB;
        private System.Windows.Forms.Button button_RemoveAssortmentItem;
        private System.Windows.Forms.Button button_AddAssortmentItem;
        private System.Windows.Forms.TreeView treeView_history;
    }
}

