namespace FormsUserInterface
{
    partial class frmBuddiesHome
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
            this.lblLogoTitle = new System.Windows.Forms.Label();
            this.lblMyFriendList = new System.Windows.Forms.Label();
            this.lstFriendList = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogoTitle
            // 
            this.lblLogoTitle.AutoSize = true;
            this.lblLogoTitle.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoTitle.Location = new System.Drawing.Point(23, 23);
            this.lblLogoTitle.Name = "lblLogoTitle";
            this.lblLogoTitle.Size = new System.Drawing.Size(107, 25);
            this.lblLogoTitle.TabIndex = 0;
            this.lblLogoTitle.Text = "Buddies";
            // 
            // lblMyFriendList
            // 
            this.lblMyFriendList.AutoSize = true;
            this.lblMyFriendList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyFriendList.Location = new System.Drawing.Point(25, 73);
            this.lblMyFriendList.Name = "lblMyFriendList";
            this.lblMyFriendList.Size = new System.Drawing.Size(91, 18);
            this.lblMyFriendList.TabIndex = 1;
            this.lblMyFriendList.Text = "My Friends";
            // 
            // lstFriendList
            // 
            this.lstFriendList.FormattingEnabled = true;
            this.lstFriendList.Location = new System.Drawing.Point(28, 94);
            this.lstFriendList.Name = "lstFriendList";
            this.lstFriendList.Size = new System.Drawing.Size(227, 147);
            this.lstFriendList.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(188, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // frmBuddiesHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstFriendList);
            this.Controls.Add(this.lblMyFriendList);
            this.Controls.Add(this.lblLogoTitle);
            this.Name = "frmBuddiesHome";
            this.Load += new System.EventHandler(this.frmBuddiesHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogoTitle;
        private System.Windows.Forms.Label lblMyFriendList;
        private System.Windows.Forms.ListBox lstFriendList;
        private System.Windows.Forms.Button btnDelete;
    }
}

