
namespace UI
{
    partial class AddTicket
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
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.ServiceDeskEmployeePanel = new System.Windows.Forms.Panel();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.listBoxDeadline = new System.Windows.Forms.ListBox();
            this.listBoxPriority = new System.Windows.Forms.ListBox();
            this.listBoxReportedBy = new System.Windows.Forms.ListBox();
            this.listBoxType = new System.Windows.Forms.ListBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelReportedBy = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelCreateIncident = new System.Windows.Forms.Label();
            this.panelHeading = new System.Windows.Forms.Panel();
            this.labelLicensedTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ServiceDeskEmployeePanel.SuspendLayout();
            this.panelHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.Location = new System.Drawing.Point(889, 234);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(498, 431);
            this.EmployeePanel.TabIndex = 0;
            this.EmployeePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EmployeePanel_Paint);
            // 
            // ServiceDeskEmployeePanel
            // 
            this.ServiceDeskEmployeePanel.AutoSize = true;
            this.ServiceDeskEmployeePanel.Controls.Add(this.textBoxSubject);
            this.ServiceDeskEmployeePanel.Controls.Add(this.textBoxDescription);
            this.ServiceDeskEmployeePanel.Controls.Add(this.listBoxDeadline);
            this.ServiceDeskEmployeePanel.Controls.Add(this.listBoxPriority);
            this.ServiceDeskEmployeePanel.Controls.Add(this.listBoxReportedBy);
            this.ServiceDeskEmployeePanel.Controls.Add(this.listBoxType);
            this.ServiceDeskEmployeePanel.Controls.Add(this.buttonSubmit);
            this.ServiceDeskEmployeePanel.Controls.Add(this.buttonCancel);
            this.ServiceDeskEmployeePanel.Controls.Add(this.labelDescription);
            this.ServiceDeskEmployeePanel.Controls.Add(this.labelDeadline);
            this.ServiceDeskEmployeePanel.Controls.Add(this.labelPriority);
            this.ServiceDeskEmployeePanel.Controls.Add(this.labelReportedBy);
            this.ServiceDeskEmployeePanel.Controls.Add(this.labelType);
            this.ServiceDeskEmployeePanel.Controls.Add(this.labelSubject);
            this.ServiceDeskEmployeePanel.Controls.Add(this.labelDateTime);
            this.ServiceDeskEmployeePanel.Controls.Add(this.labelCreateIncident);
            this.ServiceDeskEmployeePanel.Location = new System.Drawing.Point(0, 109);
            this.ServiceDeskEmployeePanel.Name = "ServiceDeskEmployeePanel";
            this.ServiceDeskEmployeePanel.Size = new System.Drawing.Size(1902, 927);
            this.ServiceDeskEmployeePanel.TabIndex = 1;
            this.ServiceDeskEmployeePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ServiceDeskEmployeePanel_Paint);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSubject.Location = new System.Drawing.Point(229, 185);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(376, 32);
            this.textBoxSubject.TabIndex = 15;
            this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AllowDrop = true;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(229, 481);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(401, 32);
            this.textBoxDescription.TabIndex = 14;
            // 
            // listBoxDeadline
            // 
            this.listBoxDeadline.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxDeadline.FormattingEnabled = true;
            this.listBoxDeadline.ItemHeight = 25;
            this.listBoxDeadline.Location = new System.Drawing.Point(229, 419);
            this.listBoxDeadline.Name = "listBoxDeadline";
            this.listBoxDeadline.Size = new System.Drawing.Size(401, 29);
            this.listBoxDeadline.TabIndex = 13;
            // 
            // listBoxPriority
            // 
            this.listBoxPriority.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPriority.FormattingEnabled = true;
            this.listBoxPriority.ItemHeight = 25;
            this.listBoxPriority.Location = new System.Drawing.Point(229, 371);
            this.listBoxPriority.Name = "listBoxPriority";
            this.listBoxPriority.Size = new System.Drawing.Size(401, 29);
            this.listBoxPriority.TabIndex = 12;
            // 
            // listBoxReportedBy
            // 
            this.listBoxReportedBy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxReportedBy.FormattingEnabled = true;
            this.listBoxReportedBy.ItemHeight = 25;
            this.listBoxReportedBy.Location = new System.Drawing.Point(229, 294);
            this.listBoxReportedBy.Name = "listBoxReportedBy";
            this.listBoxReportedBy.Size = new System.Drawing.Size(401, 29);
            this.listBoxReportedBy.TabIndex = 11;
            // 
            // listBoxType
            // 
            this.listBoxType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.ItemHeight = 25;
            this.listBoxType.Location = new System.Drawing.Point(229, 238);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(401, 29);
            this.listBoxType.TabIndex = 10;
            this.listBoxType.SelectedIndexChanged += new System.EventHandler(this.listBoxType_SelectedIndexChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.Location = new System.Drawing.Point(628, 743);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(171, 96);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "SUBMIT TICKET";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(88, 754);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(151, 74);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(28, 481);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(112, 25);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Description:";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDeadline.Location = new System.Drawing.Point(28, 419);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(177, 25);
            this.labelDeadline.TabIndex = 6;
            this.labelDeadline.Text = "Deadline/follow up:";
            this.labelDeadline.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriority.Location = new System.Drawing.Point(32, 371);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(77, 25);
            this.labelPriority.TabIndex = 5;
            this.labelPriority.Text = "Priority:";
            // 
            // labelReportedBy
            // 
            this.labelReportedBy.AutoSize = true;
            this.labelReportedBy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReportedBy.Location = new System.Drawing.Point(32, 294);
            this.labelReportedBy.Name = "labelReportedBy";
            this.labelReportedBy.Size = new System.Drawing.Size(158, 25);
            this.labelReportedBy.TabIndex = 4;
            this.labelReportedBy.Text = "Reported by user:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(32, 242);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(150, 25);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type of incident:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubject.Location = new System.Drawing.Point(32, 185);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(173, 25);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Subject of incident:";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateTime.Location = new System.Drawing.Point(32, 127);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(181, 25);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "Date/Time reported:";
            this.labelDateTime.Click += new System.EventHandler(this.labelDateTime_Click);
            // 
            // labelCreateIncident
            // 
            this.labelCreateIncident.AutoSize = true;
            this.labelCreateIncident.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCreateIncident.Location = new System.Drawing.Point(266, 67);
            this.labelCreateIncident.Name = "labelCreateIncident";
            this.labelCreateIncident.Size = new System.Drawing.Size(230, 25);
            this.labelCreateIncident.TabIndex = 0;
            this.labelCreateIncident.Text = "Create new incident ticket";
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.SystemColors.Control;
            this.panelHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeading.Controls.Add(this.labelLicensedTo);
            this.panelHeading.Controls.Add(this.label1);
            this.panelHeading.Location = new System.Drawing.Point(0, 0);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(1902, 103);
            this.panelHeading.TabIndex = 2;
            // 
            // labelLicensedTo
            // 
            this.labelLicensedTo.AutoSize = true;
            this.labelLicensedTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLicensedTo.Location = new System.Drawing.Point(1663, 67);
            this.labelLicensedTo.Name = "labelLicensedTo";
            this.labelLicensedTo.Size = new System.Drawing.Size(218, 20);
            this.labelLicensedTo.TabIndex = 1;
            this.labelLicensedTo.Text = "Licensed To : The Garden Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1820, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NoDesk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 103);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelHeading);
            this.Controls.Add(this.EmployeePanel);
            this.Controls.Add(this.ServiceDeskEmployeePanel);
            this.Name = "AddTicket";
            this.Text = "AddTicket";
            this.ServiceDeskEmployeePanel.ResumeLayout(false);
            this.ServiceDeskEmployeePanel.PerformLayout();
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel EmployeePanel;
        private System.Windows.Forms.Panel ServiceDeskEmployeePanel;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelCreateIncident;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelReportedBy;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ListBox listBoxDeadline;
        private System.Windows.Forms.ListBox listBoxPriority;
        private System.Windows.Forms.ListBox listBoxReportedBy;
        private System.Windows.Forms.ListBox listBoxType;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panelHeading;
        private System.Windows.Forms.Label labelLicensedTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}