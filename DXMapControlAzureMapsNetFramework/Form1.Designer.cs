namespace DXMapControlAzureMapsNetFramework
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
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.azureMapDataProvider1 = new DevExpress.XtraMap.AzureMapDataProvider();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.openStreetMapDataProvider1 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            this.imageLayer2 = new DevExpress.XtraMap.ImageLayer();
            this.informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            this.azureSearchDataProvider1 = new DevExpress.XtraMap.AzureSearchDataProvider();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.imageLayer2);
            this.mapControl1.Layers.Add(this.informationLayer1);
            this.mapControl1.Location = new System.Drawing.Point(3, 1);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(498, 321);
            this.mapControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(524, 35);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(180, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(524, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Location";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(604, 11);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(524, 62);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(180, 260);
            this.memoEdit1.TabIndex = 4;
            this.imageLayer1.DataProvider = this.azureMapDataProvider1;
            this.openStreetMapDataProvider1.TileUriTemplate = "https://{0}.tile.INSERT_SERVER_NAME.com/{1}/{2}/{3}.png";
            this.imageLayer2.DataProvider = this.openStreetMapDataProvider1;
            this.informationLayer1.DataProvider = this.azureSearchDataProvider1;
            this.azureSearchDataProvider1.AzureKey = null;
            this.azureSearchDataProvider1.CultureName = "en-US";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 333);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.mapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.AzureMapDataProvider azureMapDataProvider1;
        private DevExpress.XtraMap.ImageLayer imageLayer2;
        private DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider1;
        private DevExpress.XtraMap.InformationLayer informationLayer1;
        private DevExpress.XtraMap.AzureSearchDataProvider azureSearchDataProvider1;
    }
}