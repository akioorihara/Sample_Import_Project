
namespace Sample_Import_Project
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
            this.ImportFilePathTextbox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ImportFileDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearScreenButton = new System.Windows.Forms.Button();
            this.ImportFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImportFileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportFilePathTextbox
            // 
            this.ImportFilePathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportFilePathTextbox.Location = new System.Drawing.Point(15, 49);
            this.ImportFilePathTextbox.Name = "ImportFilePathTextbox";
            this.ImportFilePathTextbox.Size = new System.Drawing.Size(580, 20);
            this.ImportFilePathTextbox.TabIndex = 0;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(601, 47);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(76, 23);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ImportFileDataGridView
            // 
            this.ImportFileDataGridView.AllowUserToAddRows = false;
            this.ImportFileDataGridView.AllowUserToDeleteRows = false;
            this.ImportFileDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportFileDataGridView.Location = new System.Drawing.Point(12, 132);
            this.ImportFileDataGridView.Name = "ImportFileDataGridView";
            this.ImportFileDataGridView.ReadOnly = true;
            this.ImportFileDataGridView.Size = new System.Drawing.Size(664, 400);
            this.ImportFileDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Import File Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Path to Import File:";
            // 
            // ClearScreenButton
            // 
            this.ClearScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearScreenButton.Location = new System.Drawing.Point(601, 76);
            this.ClearScreenButton.Name = "ClearScreenButton";
            this.ClearScreenButton.Size = new System.Drawing.Size(76, 23);
            this.ClearScreenButton.TabIndex = 5;
            this.ClearScreenButton.Text = "Clear Screen";
            this.ClearScreenButton.UseVisualStyleBackColor = true;
            this.ClearScreenButton.Click += new System.EventHandler(this.ClearScreenButton_Click);
            // 
            // ImportFileButton
            // 
            this.ImportFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportFileButton.Location = new System.Drawing.Point(520, 76);
            this.ImportFileButton.Name = "ImportFileButton";
            this.ImportFileButton.Size = new System.Drawing.Size(75, 23);
            this.ImportFileButton.TabIndex = 6;
            this.ImportFileButton.Text = "Import File";
            this.ImportFileButton.UseVisualStyleBackColor = true;
            this.ImportFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 544);
            this.Controls.Add(this.ImportFileButton);
            this.Controls.Add(this.ClearScreenButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImportFileDataGridView);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ImportFilePathTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImportFileDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImportFilePathTextbox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.DataGridView ImportFileDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearScreenButton;
        private System.Windows.Forms.Button ImportFileButton;
    }
}

