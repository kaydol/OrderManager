namespace OrderManager
{
    partial class NewItemForm
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
            this.button_CancelNewItem = new System.Windows.Forms.Button();
            this.button_CreateNewItem = new System.Windows.Forms.Button();
            this.textBox_CreateNewCustomer = new System.Windows.Forms.TextBox();
            this.label_EnterItemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ItemCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_CancelNewItem
            // 
            this.button_CancelNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CancelNewItem.Location = new System.Drawing.Point(41, 161);
            this.button_CancelNewItem.Name = "button_CancelNewItem";
            this.button_CancelNewItem.Size = new System.Drawing.Size(367, 31);
            this.button_CancelNewItem.TabIndex = 16;
            this.button_CancelNewItem.Text = "Cancel";
            this.button_CancelNewItem.UseVisualStyleBackColor = true;
            this.button_CancelNewItem.Click += new System.EventHandler(this.button_CancelNewItem_Click);
            // 
            // button_CreateNewItem
            // 
            this.button_CreateNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CreateNewItem.Location = new System.Drawing.Point(41, 111);
            this.button_CreateNewItem.Name = "button_CreateNewItem";
            this.button_CreateNewItem.Size = new System.Drawing.Size(367, 35);
            this.button_CreateNewItem.TabIndex = 15;
            this.button_CreateNewItem.Text = "Create new item";
            this.button_CreateNewItem.UseVisualStyleBackColor = true;
            this.button_CreateNewItem.Click += new System.EventHandler(this.button_CreateNewItem_Click);
            // 
            // textBox_CreateNewCustomer
            // 
            this.textBox_CreateNewCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_CreateNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CreateNewCustomer.Location = new System.Drawing.Point(165, 19);
            this.textBox_CreateNewCustomer.Name = "textBox_CreateNewCustomer";
            this.textBox_CreateNewCustomer.Size = new System.Drawing.Size(272, 24);
            this.textBox_CreateNewCustomer.TabIndex = 14;
            this.textBox_CreateNewCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_EnterItemName
            // 
            this.label_EnterItemName.AutoSize = true;
            this.label_EnterItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_EnterItemName.Location = new System.Drawing.Point(21, 21);
            this.label_EnterItemName.Name = "label_EnterItemName";
            this.label_EnterItemName.Size = new System.Drawing.Size(126, 20);
            this.label_EnterItemName.TabIndex = 13;
            this.label_EnterItemName.Text = "Enter item name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter item cost";
            // 
            // textBox_ItemCost
            // 
            this.textBox_ItemCost.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ItemCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ItemCost.Location = new System.Drawing.Point(165, 58);
            this.textBox_ItemCost.Name = "textBox_ItemCost";
            this.textBox_ItemCost.Size = new System.Drawing.Size(272, 24);
            this.textBox_ItemCost.TabIndex = 18;
            this.textBox_ItemCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 215);
            this.Controls.Add(this.textBox_ItemCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CancelNewItem);
            this.Controls.Add(this.button_CreateNewItem);
            this.Controls.Add(this.textBox_CreateNewCustomer);
            this.Controls.Add(this.label_EnterItemName);
            this.Name = "NewItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Item Dialogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CancelNewItem;
        private System.Windows.Forms.Button button_CreateNewItem;
        private System.Windows.Forms.TextBox textBox_CreateNewCustomer;
        private System.Windows.Forms.Label label_EnterItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ItemCost;
    }
}