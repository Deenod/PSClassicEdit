namespace PSClassicEdit.Interface
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SelectFolderTxt = new System.Windows.Forms.TextBox();
            this.SelectFolderBtn = new System.Windows.Forms.Button();
            this.SelectFolderLbl = new System.Windows.Forms.Label();
            this.GameList = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFolderTxt
            // 
            this.SelectFolderTxt.Enabled = false;
            this.SelectFolderTxt.Location = new System.Drawing.Point(26, 39);
            this.SelectFolderTxt.Name = "SelectFolderTxt";
            this.SelectFolderTxt.Size = new System.Drawing.Size(217, 20);
            this.SelectFolderTxt.TabIndex = 0;
            // 
            // SelectFolderBtn
            // 
            this.SelectFolderBtn.Location = new System.Drawing.Point(249, 37);
            this.SelectFolderBtn.Name = "SelectFolderBtn";
            this.SelectFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectFolderBtn.TabIndex = 1;
            this.SelectFolderBtn.Text = "Select";
            this.SelectFolderBtn.UseVisualStyleBackColor = true;
            this.SelectFolderBtn.Click += new System.EventHandler(this.SelectFolderBtn_Click);
            // 
            // SelectFolderLbl
            // 
            this.SelectFolderLbl.AutoSize = true;
            this.SelectFolderLbl.Location = new System.Drawing.Point(26, 20);
            this.SelectFolderLbl.Name = "SelectFolderLbl";
            this.SelectFolderLbl.Size = new System.Drawing.Size(88, 13);
            this.SelectFolderLbl.TabIndex = 2;
            this.SelectFolderLbl.Text = "Select USB drive";
            // 
            // GameList
            // 
            this.GameList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Publisher,
            this.Id});
            this.GameList.FullRowSelect = true;
            this.GameList.GridLines = true;
            this.GameList.LabelWrap = false;
            this.GameList.Location = new System.Drawing.Point(26, 83);
            this.GameList.MultiSelect = false;
            this.GameList.Name = "GameList";
            this.GameList.Size = new System.Drawing.Size(298, 119);
            this.GameList.TabIndex = 3;
            this.GameList.UseCompatibleStateImageBehavior = false;
            this.GameList.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 146;
            // 
            // Publisher
            // 
            this.Publisher.Text = "Publisher";
            this.Publisher.Width = 110;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 38;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Enabled = false;
            this.ApplyBtn.Location = new System.Drawing.Point(26, 230);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(298, 53);
            this.ApplyBtn.TabIndex = 4;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 301);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.GameList);
            this.Controls.Add(this.SelectFolderLbl);
            this.Controls.Add(this.SelectFolderBtn);
            this.Controls.Add(this.SelectFolderTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PS Classic Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SelectFolderTxt;
        private System.Windows.Forms.Button SelectFolderBtn;
        private System.Windows.Forms.Label SelectFolderLbl;
        private System.Windows.Forms.ListView GameList;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Publisher;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.ColumnHeader Id;
    }
}