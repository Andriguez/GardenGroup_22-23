namespace UI
{
    partial class UserManagementView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dashboard_bttn = new System.Windows.Forms.Button();
            this.incident_bttn = new System.Windows.Forms.Button();
            this.usermgnt_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 125);
            this.panel1.TabIndex = 0;
            // 
            // Dashboard_bttn
            // 
            this.Dashboard_bttn.Location = new System.Drawing.Point(1, 64);
            this.Dashboard_bttn.Name = "Dashboard_bttn";
            this.Dashboard_bttn.Size = new System.Drawing.Size(640, 56);
            this.Dashboard_bttn.TabIndex = 0;
            this.Dashboard_bttn.Text = "Dasboard";
            this.Dashboard_bttn.UseVisualStyleBackColor = true;
            // 
            // incident_bttn
            // 
            this.incident_bttn.Location = new System.Drawing.Point(638, 64);
            this.incident_bttn.Name = "incident_bttn";
            this.incident_bttn.Size = new System.Drawing.Size(640, 56);
            this.incident_bttn.TabIndex = 1;
            this.incident_bttn.Text = "Incident Management";
            this.incident_bttn.UseVisualStyleBackColor = true;
            // 
            // usermgnt_bttn
            // 
            this.usermgnt_bttn.Location = new System.Drawing.Point(1274, 64);
            this.usermgnt_bttn.Name = "usermgnt_bttn";
            this.usermgnt_bttn.Size = new System.Drawing.Size(640, 56);
            this.usermgnt_bttn.TabIndex = 2;
            this.usermgnt_bttn.Text = "User Management";
            this.usermgnt_bttn.UseVisualStyleBackColor = true;
            // 
            // UserManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Dashboard_bttn);
            this.Controls.Add(this.incident_bttn);
            this.Controls.Add(this.usermgnt_bttn);
            this.Controls.Add(this.panel1);
            this.Name = "UserManagementView";
            this.Text = "UserManagementView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Dashboard_bttn;
        private System.Windows.Forms.Button incident_bttn;
        private System.Windows.Forms.Button usermgnt_bttn;
    }
}