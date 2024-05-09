// Form1.Designer.cs

using System;

namespace pogice3
{
    partial class Form1
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
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnDisplayReceipt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(41, 32);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(200, 21);
            this.comboBoxItems.TabIndex = 0;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(41, 79);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantity.TabIndex = 1;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(41, 131);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddToOrder.TabIndex = 2;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnDisplayReceipt
            // 
            this.btnDisplayReceipt.Location = new System.Drawing.Point(41, 183);
            this.btnDisplayReceipt.Name = "btnDisplayReceipt";
            this.btnDisplayReceipt.Size = new System.Drawing.Size(105, 23);
            this.btnDisplayReceipt.TabIndex = 3;
            this.btnDisplayReceipt.Text = "Display Receipt";
            this.btnDisplayReceipt.UseVisualStyleBackColor = true;
            this.btnDisplayReceipt.Click += new System.EventHandler(this.btnDisplayReceipt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDisplayReceipt);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.comboBoxItems);
            this.Name = "Form1";
            this.Text = "Order Form";
     
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnDisplayReceipt;

        
    }
}
