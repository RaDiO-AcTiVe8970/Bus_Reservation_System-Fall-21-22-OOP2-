
namespace Bus_Reservation
{
    partial class View_Reservation_Info
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
            this.dataGridResInfo = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSHow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridResInfo
            // 
            this.dataGridResInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResInfo.Location = new System.Drawing.Point(12, 76);
            this.dataGridResInfo.Name = "dataGridResInfo";
            this.dataGridResInfo.RowHeadersWidth = 51;
            this.dataGridResInfo.RowTemplate.Height = 24;
            this.dataGridResInfo.Size = new System.Drawing.Size(939, 158);
            this.dataGridResInfo.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(262, 253);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSHow
            // 
            this.btnSHow.Location = new System.Drawing.Point(482, 253);
            this.btnSHow.Name = "btnSHow";
            this.btnSHow.Size = new System.Drawing.Size(127, 32);
            this.btnSHow.TabIndex = 3;
            this.btnSHow.Text = "Show";
            this.btnSHow.UseVisualStyleBackColor = true;
            this.btnSHow.Click += new System.EventHandler(this.btnSHow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(397, 27);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(212, 22);
            this.textUsername.TabIndex = 5;
            this.textUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // View_Reservation_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 297);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSHow);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridResInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View_Reservation_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Reservation_Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridResInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSHow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsername;
    }
}