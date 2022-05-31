
namespace MyFirm
{
    partial class FormSales
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_newOrder = new System.Windows.Forms.Button();
            this.btn_viewProducts = new System.Windows.Forms.Button();
            this.btn_clients = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(282, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders in Course";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(476, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search Order";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_newOrder
            // 
            this.btn_newOrder.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_newOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_newOrder.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_newOrder.Location = new System.Drawing.Point(20, 16);
            this.btn_newOrder.Name = "btn_newOrder";
            this.btn_newOrder.Size = new System.Drawing.Size(114, 66);
            this.btn_newOrder.TabIndex = 2;
            this.btn_newOrder.Text = "Insert New Order";
            this.btn_newOrder.UseVisualStyleBackColor = false;
            this.btn_newOrder.Click += new System.EventHandler(this.btn_newOrder_Click);
            // 
            // btn_viewProducts
            // 
            this.btn_viewProducts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_viewProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_viewProducts.Location = new System.Drawing.Point(224, 16);
            this.btn_viewProducts.Name = "btn_viewProducts";
            this.btn_viewProducts.Size = new System.Drawing.Size(117, 66);
            this.btn_viewProducts.TabIndex = 3;
            this.btn_viewProducts.Text = "View All Products";
            this.btn_viewProducts.UseVisualStyleBackColor = false;
            this.btn_viewProducts.Click += new System.EventHandler(this.btn_viewProducts_Click);
            // 
            // btn_clients
            // 
            this.btn_clients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_clients.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clients.Location = new System.Drawing.Point(432, 16);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(124, 66);
            this.btn_clients.TabIndex = 4;
            this.btn_clients.Text = "Clients";
            this.btn_clients.UseVisualStyleBackColor = false;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(621, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 69);
            this.button5.TabIndex = 5;
            this.button5.Text = "Production";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btn_newOrder);
            this.panel1.Controls.Add(this.btn_clients);
            this.panel1.Controls.Add(this.btn_viewProducts);
            this.panel1.Location = new System.Drawing.Point(12, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 97);
            this.panel1.TabIndex = 6;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowTemplate.Height = 25;
            this.dataGridViewOrders.Size = new System.Drawing.Size(776, 262);
            this.dataGridViewOrders.TabIndex = 7;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormSales";
            this.Text = "FormSales";

            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_viewProducts;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_newOrder;
        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridViewOrders;
    }
}