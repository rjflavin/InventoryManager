namespace AssetManagement
{
    partial class AddAssetForm
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
            this.addAssetButton = new System.Windows.Forms.Button();
            this.assetGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.assetGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addAssetButton
            // 
            this.addAssetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addAssetButton.Location = new System.Drawing.Point(0, 450);
            this.addAssetButton.Name = "addAssetButton";
            this.addAssetButton.Size = new System.Drawing.Size(660, 79);
            this.addAssetButton.TabIndex = 8;
            this.addAssetButton.Text = "Add Asset";
            this.addAssetButton.UseVisualStyleBackColor = true;
            // 
            // assetGrid
            // 
            this.assetGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetGrid.Location = new System.Drawing.Point(0, 0);
            this.assetGrid.Name = "assetGrid";
            this.assetGrid.RowTemplate.Height = 24;
            this.assetGrid.Size = new System.Drawing.Size(660, 453);
            this.assetGrid.TabIndex = 9;
            // 
            // AddAssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 529);
            this.Controls.Add(this.assetGrid);
            this.Controls.Add(this.addAssetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddAssetForm";
            this.Text = "Add Asset";
            ((System.ComponentModel.ISupportInitialize)(this.assetGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addAssetButton;
        private System.Windows.Forms.DataGridView assetGrid;
    }
}