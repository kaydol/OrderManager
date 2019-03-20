namespace OrderManager
{
    partial class NewCustomerForm
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
            this.textBox_CreateNewCustomer = new System.Windows.Forms.TextBox();
            this.label_EnterFullName = new System.Windows.Forms.Label();
            this.button_CreateNewCustomer = new System.Windows.Forms.Button();
            this.button_CancelNewCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_CreateNewCustomer
            // 
            this.textBox_CreateNewCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_CreateNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CreateNewCustomer.Location = new System.Drawing.Point(138, 28);
            this.textBox_CreateNewCustomer.Name = "textBox_CreateNewCustomer";
            this.textBox_CreateNewCustomer.Size = new System.Drawing.Size(284, 24);
            this.textBox_CreateNewCustomer.TabIndex = 10;
            this.textBox_CreateNewCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_EnterFullName
            // 
            this.label_EnterFullName.AutoSize = true;
            this.label_EnterFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_EnterFullName.Location = new System.Drawing.Point(16, 28);
            this.label_EnterFullName.Name = "label_EnterFullName";
            this.label_EnterFullName.Size = new System.Drawing.Size(116, 20);
            this.label_EnterFullName.TabIndex = 9;
            this.label_EnterFullName.Text = "Enter full name";
            // 
            // button_CreateNewCustomer
            // 
            this.button_CreateNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CreateNewCustomer.Location = new System.Drawing.Point(32, 79);
            this.button_CreateNewCustomer.Name = "button_CreateNewCustomer";
            this.button_CreateNewCustomer.Size = new System.Drawing.Size(367, 35);
            this.button_CreateNewCustomer.TabIndex = 11;
            this.button_CreateNewCustomer.Text = "Create new customer";
            this.button_CreateNewCustomer.UseVisualStyleBackColor = true;
            this.button_CreateNewCustomer.Click += new System.EventHandler(this.button_CreateNewCustomer_Click);
            // 
            // button_CancelNewCustomer
            // 
            this.button_CancelNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CancelNewCustomer.Location = new System.Drawing.Point(32, 129);
            this.button_CancelNewCustomer.Name = "button_CancelNewCustomer";
            this.button_CancelNewCustomer.Size = new System.Drawing.Size(367, 31);
            this.button_CancelNewCustomer.TabIndex = 12;
            this.button_CancelNewCustomer.Text = "Cancel";
            this.button_CancelNewCustomer.UseVisualStyleBackColor = true;
            this.button_CancelNewCustomer.Click += new System.EventHandler(this.button_CancelNewCustomer_Click);
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 185);
            this.Controls.Add(this.button_CancelNewCustomer);
            this.Controls.Add(this.button_CreateNewCustomer);
            this.Controls.Add(this.textBox_CreateNewCustomer);
            this.Controls.Add(this.label_EnterFullName);
            this.Name = "NewCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Customer Dialogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CreateNewCustomer;
        private System.Windows.Forms.Label label_EnterFullName;
        private System.Windows.Forms.Button button_CreateNewCustomer;
        private System.Windows.Forms.Button button_CancelNewCustomer;
    }
}