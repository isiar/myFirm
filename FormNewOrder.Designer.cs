
namespace MyFirm
{
    partial class FormNewOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_orderNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_qty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_Description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBox_deliveryDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox_totalPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cui = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_client = new System.Windows.Forms.ComboBox();
            this.comboBox_ProdName = new System.Windows.Forms.ComboBox();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.richTxtBox_address = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order No.";
            // 
            // txtBox_orderNo
            // 
            this.txtBox_orderNo.Location = new System.Drawing.Point(161, 25);
            this.txtBox_orderNo.Name = "txtBox_orderNo";
            this.txtBox_orderNo.Size = new System.Drawing.Size(111, 23);
            this.txtBox_orderNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Name: ";
            // 
            // txtBox_qty
            // 
            this.txtBox_qty.Location = new System.Drawing.Point(161, 422);
            this.txtBox_qty.Name = "txtBox_qty";
            this.txtBox_qty.Size = new System.Drawing.Size(97, 23);
            this.txtBox_qty.TabIndex = 10;
            this.txtBox_qty.Text = "0";
            this.txtBox_qty.TextChanged += new System.EventHandler(this.txtBox_qty_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(481, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Placed on: ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(594, 26);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(113, 23);
            this.textBox5.TabIndex = 13;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(159, 62);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(113, 23);
            this.txt_id.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Id client: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(35, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Address:";
            // 
            // txtBox_Description
            // 
            this.txtBox_Description.Location = new System.Drawing.Point(161, 357);
            this.txtBox_Description.Name = "txtBox_Description";
            this.txtBox_Description.Size = new System.Drawing.Size(213, 23);
            this.txtBox_Description.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(37, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Description: ";
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Location = new System.Drawing.Point(161, 551);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(97, 23);
            this.txtBox_Price.TabIndex = 21;
            this.txtBox_Price.Text = "0";
            this.txtBox_Price.TextChanged += new System.EventHandler(this.txtBox_Price_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(37, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Price: ";
            // 
            // txtBox_deliveryDate
            // 
            this.txtBox_deliveryDate.Location = new System.Drawing.Point(161, 486);
            this.txtBox_deliveryDate.Name = "txtBox_deliveryDate";
            this.txtBox_deliveryDate.Size = new System.Drawing.Size(97, 23);
            this.txtBox_deliveryDate.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(37, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Delivery Date: ";
            // 
            // txtBox_totalPrice
            // 
            this.txtBox_totalPrice.Location = new System.Drawing.Point(161, 608);
            this.txtBox_totalPrice.Name = "txtBox_totalPrice";
            this.txtBox_totalPrice.ReadOnly = true;
            this.txtBox_totalPrice.Size = new System.Drawing.Size(97, 23);
            this.txtBox_totalPrice.TabIndex = 25;
            this.txtBox_totalPrice.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(35, 607);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total Price: ";
            // 
            // txt_cui
            // 
            this.txt_cui.Location = new System.Drawing.Point(159, 219);
            this.txt_cui.Name = "txt_cui";
            this.txt_cui.Size = new System.Drawing.Size(126, 23);
            this.txt_cui.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(35, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "CUI:";
            // 
            // comboBox_client
            // 
            this.comboBox_client.FormattingEnabled = true;
            this.comboBox_client.Location = new System.Drawing.Point(159, 106);
            this.comboBox_client.Name = "comboBox_client";
            this.comboBox_client.Size = new System.Drawing.Size(213, 23);
            this.comboBox_client.TabIndex = 30;
            this.comboBox_client.SelectedIndexChanged += new System.EventHandler(this.comboBox_client_SelectedIndexChanged);
            // 
            // comboBox_ProdName
            // 
            this.comboBox_ProdName.FormattingEnabled = true;
            this.comboBox_ProdName.Location = new System.Drawing.Point(161, 298);
            this.comboBox_ProdName.Name = "comboBox_ProdName";
            this.comboBox_ProdName.Size = new System.Drawing.Size(211, 23);
            this.comboBox_ProdName.TabIndex = 31;
            this.comboBox_ProdName.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProdName_SelectedIndexChanged);
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_addOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addOrder.Location = new System.Drawing.Point(458, 545);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(103, 74);
            this.btn_addOrder.TabIndex = 32;
            this.btn_addOrder.Text = "Add New Order";
            this.btn_addOrder.UseVisualStyleBackColor = false;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(604, 546);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 74);
            this.btn_cancel.TabIndex = 33;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // richTxtBox_address
            // 
            this.richTxtBox_address.Location = new System.Drawing.Point(159, 149);
            this.richTxtBox_address.Name = "richTxtBox_address";
            this.richTxtBox_address.Size = new System.Drawing.Size(249, 50);
            this.richTxtBox_address.TabIndex = 34;
            this.richTxtBox_address.Text = "";
            // 
            // FormNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 669);
            this.Controls.Add(this.richTxtBox_address);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.comboBox_ProdName);
            this.Controls.Add(this.comboBox_client);
            this.Controls.Add(this.txt_cui);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBox_totalPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBox_deliveryDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBox_Price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBox_Description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_qty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_orderNo);
            this.Controls.Add(this.label1);
            this.Name = "FormNewOrder";
            this.Text = "FormNewOrder";
            this.Load += new System.EventHandler(this.FormNewOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_orderNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_qty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_Description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBox_deliveryDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_totalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cui;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_client;
        private System.Windows.Forms.ComboBox comboBox_ProdName;
        private System.Windows.Forms.Button btn_addOr;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.RichTextBox richTxtBox_address;
        private System.Windows.Forms.TextBox txtBox_orderNo;
    }
}