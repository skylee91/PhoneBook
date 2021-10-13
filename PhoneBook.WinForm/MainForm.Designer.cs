
namespace PhoneBook.WinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInput = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelContactDetails = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCreateOrEdit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelEnterKeyword = new System.Windows.Forms.Label();
            this.flowLayoutPanelContact = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInput.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.buttonClear);
            this.panelInput.Controls.Add(this.textBoxAddress);
            this.panelInput.Controls.Add(this.labelAddress);
            this.panelInput.Controls.Add(this.textBoxPhone);
            this.panelInput.Controls.Add(this.labelPhone);
            this.panelInput.Controls.Add(this.labelContactDetails);
            this.panelInput.Controls.Add(this.buttonDelete);
            this.panelInput.Controls.Add(this.buttonCreateOrEdit);
            this.panelInput.Controls.Add(this.textBoxName);
            this.panelInput.Controls.Add(this.labelName);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(376, 533);
            this.panelInput.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(134, 343);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(107, 46);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddress.Location = new System.Drawing.Point(20, 261);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(334, 59);
            this.textBoxAddress.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(20, 235);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(74, 23);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Address";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhone.Location = new System.Drawing.Point(20, 181);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(334, 30);
            this.textBoxPhone.TabIndex = 2;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(20, 155);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(130, 23);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelContactDetails
            // 
            this.labelContactDetails.AutoSize = true;
            this.labelContactDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContactDetails.Location = new System.Drawing.Point(12, 9);
            this.labelContactDetails.Name = "labelContactDetails";
            this.labelContactDetails.Size = new System.Drawing.Size(157, 28);
            this.labelContactDetails.TabIndex = 8;
            this.labelContactDetails.Text = "Contact Details";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(20, 343);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 46);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCreateOrEdit
            // 
            this.buttonCreateOrEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateOrEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateOrEdit.Location = new System.Drawing.Point(247, 343);
            this.buttonCreateOrEdit.Name = "buttonCreateOrEdit";
            this.buttonCreateOrEdit.Size = new System.Drawing.Size(107, 46);
            this.buttonCreateOrEdit.TabIndex = 4;
            this.buttonCreateOrEdit.Text = "Create";
            this.buttonCreateOrEdit.UseVisualStyleBackColor = true;
            this.buttonCreateOrEdit.Click += new System.EventHandler(this.buttonCreateOrEdit_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(20, 107);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(334, 30);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(20, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.labelEnterKeyword);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(376, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(554, 104);
            this.panelSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(435, 43);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(107, 46);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(14, 51);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(401, 30);
            this.textBoxSearch.TabIndex = 5;
            // 
            // labelEnterKeyword
            // 
            this.labelEnterKeyword.AutoSize = true;
            this.labelEnterKeyword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnterKeyword.Location = new System.Drawing.Point(6, 9);
            this.labelEnterKeyword.Name = "labelEnterKeyword";
            this.labelEnterKeyword.Size = new System.Drawing.Size(247, 28);
            this.labelEnterKeyword.TabIndex = 13;
            this.labelEnterKeyword.Text = "Enter keyword to search:\r\n";
            // 
            // flowLayoutPanelContact
            // 
            this.flowLayoutPanelContact.AutoScroll = true;
            this.flowLayoutPanelContact.AutoSize = true;
            this.flowLayoutPanelContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContact.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelContact.Location = new System.Drawing.Point(376, 104);
            this.flowLayoutPanelContact.Name = "flowLayoutPanelContact";
            this.flowLayoutPanelContact.Size = new System.Drawing.Size(554, 429);
            this.flowLayoutPanelContact.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 533);
            this.Controls.Add(this.flowLayoutPanelContact);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelInput);
            this.Name = "MainForm";
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContact;
        private System.Windows.Forms.Label labelContactDetails;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCreateOrEdit;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelEnterKeyword;
        private System.Windows.Forms.Button buttonClear;
    }
}

