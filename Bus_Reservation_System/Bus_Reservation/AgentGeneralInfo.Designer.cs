
namespace Bus_Reservation
{
    partial class AgentGeneralInfo
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
            this.btnPass = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.textNewname = new System.Windows.Forms.TextBox();
            this.dataGridAgentView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCurrCname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgentView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPass
            // 
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.Location = new System.Drawing.Point(700, 202);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(86, 33);
            this.btnPass.TabIndex = 39;
            this.btnPass.Text = "Update";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(473, 174);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(99, 17);
            this.lblPass.TabIndex = 38;
            this.lblPass.Text = "New password";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(578, 174);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(208, 22);
            this.textPass.TabIndex = 37;
            // 
            // btnName
            // 
            this.btnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.Location = new System.Drawing.Point(700, 135);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(86, 33);
            this.btnName.TabIndex = 36;
            this.btnName.Text = "Update";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(473, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 17);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "New name";
            // 
            // textNewname
            // 
            this.textNewname.Location = new System.Drawing.Point(578, 107);
            this.textNewname.Name = "textNewname";
            this.textNewname.Size = new System.Drawing.Size(208, 22);
            this.textNewname.TabIndex = 34;
            // 
            // dataGridAgentView
            // 
            this.dataGridAgentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAgentView.Location = new System.Drawing.Point(12, 80);
            this.dataGridAgentView.Name = "dataGridAgentView";
            this.dataGridAgentView.RowHeadersWidth = 51;
            this.dataGridAgentView.RowTemplate.Height = 24;
            this.dataGridAgentView.Size = new System.Drawing.Size(451, 213);
            this.dataGridAgentView.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(204, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 61);
            this.button3.TabIndex = 31;
            this.button3.Text = "Update password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 61);
            this.button1.TabIndex = 30;
            this.button1.Text = "Update name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 39);
            this.button2.TabIndex = 40;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Company Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(578, 13);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(208, 22);
            this.textEmail.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Current Name";
            // 
            // textCurrCname
            // 
            this.textCurrCname.Location = new System.Drawing.Point(578, 52);
            this.textCurrCname.Name = "textCurrCname";
            this.textCurrCname.Size = new System.Drawing.Size(208, 22);
            this.textCurrCname.TabIndex = 44;
            // 
            // AgentGeneralInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(798, 305);
            this.Controls.Add(this.textCurrCname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textNewname);
            this.Controls.Add(this.dataGridAgentView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "AgentGeneralInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgentGeneralInfo";
            this.Load += new System.EventHandler(this.AgentGeneralInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textNewname;
        private System.Windows.Forms.DataGridView dataGridAgentView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCurrCname;
    }
}