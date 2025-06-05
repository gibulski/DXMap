namespace DXMapControlAzureMaps
{
    partial class Form1
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
            mapControl1 = new DevExpress.XtraMap.MapControl();
            imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            azureMapDataProvider1 = new DevExpress.XtraMap.AzureMapDataProvider();
            imageLayer2 = new DevExpress.XtraMap.ImageLayer();
            openStreetMapDataProvider1 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            azureSearchDataProvider1 = new DevExpress.XtraMap.AzureSearchDataProvider();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            lblAddress = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)mapControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // mapControl1
            // 
            mapControl1.Layers.Add(imageLayer1);
            mapControl1.Layers.Add(imageLayer2);
            mapControl1.Layers.Add(informationLayer1);
            mapControl1.Location = new Point(0, 0);
            mapControl1.Name = "mapControl1";
            mapControl1.Size = new Size(499, 294);
            mapControl1.TabIndex = 0;
            imageLayer1.DataProvider = azureMapDataProvider1;
            imageLayer2.DataProvider = openStreetMapDataProvider1;
            openStreetMapDataProvider1.TileUriTemplate = "https://{0}.tile.INSERT_SERVER_NAME.com/{1}/{2}/{3}.png";
            informationLayer1.DataProvider = azureSearchDataProvider1;
            azureSearchDataProvider1.AzureKey = null;
            azureSearchDataProvider1.CultureName = "en-US";
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new Point(508, 60);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(182, 234);
            memoEdit1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(508, 31);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(182, 23);
            simpleButton1.TabIndex = 2;
            simpleButton1.Text = "Search";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(577, 5);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(113, 20);
            textEdit1.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(508, 7);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(39, 13);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 301);
            Controls.Add(lblAddress);
            Controls.Add(textEdit1);
            Controls.Add(simpleButton1);
            Controls.Add(memoEdit1);
            Controls.Add(mapControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)mapControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.AzureMapDataProvider azureMapDataProvider1;
        private DevExpress.XtraMap.ImageLayer imageLayer2;
        private DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider1;
        private DevExpress.XtraMap.InformationLayer informationLayer1;
        private DevExpress.XtraMap.AzureSearchDataProvider azureSearchDataProvider1;
    }
}
