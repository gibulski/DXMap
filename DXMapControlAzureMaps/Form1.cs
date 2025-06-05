using DevExpress.XtraMap;
using System.Text;

namespace DXMapControlAzureMaps
{
    public partial class Form1 : Form
    {
        const string azureKey = "Enter Azure Maps Key here";
        AzureSearchDataProvider azureSearchProvider;

        public Form1()
        {
            InitializeComponent();

            imageLayer1.DataProvider = new AzureMapDataProvider()
            {
                AzureKey = azureKey,
                Tileset = AzureTileset.Imagery
            };
            imageLayer2.DataProvider = new AzureMapDataProvider()
            {
                AzureKey = azureKey,
                Tileset = AzureTileset.BaseLabelsRoad,
            };
            azureSearchProvider = new AzureSearchDataProvider()
            {
                AzureKey = azureKey,
            };
            informationLayer1.DataProvider = azureSearchProvider;
            informationLayer1.DataRequestCompleted += OnDataRequestCompleted;
            azureSearchProvider.SearchCompleted += new AzureSearchCompletedEventHandler(OnSearchCompleted);
            mapControl1.SearchPanelOptions.Visible = false;

        }

        void OnDataRequestCompleted(object sender, RequestCompletedEventArgs e)
        {
            mapControl1.ZoomToFitLayerItems(0.4);
        }
        void OnSearchCompleted(object sender, AzureSearchCompletedEventArgs e)
        {
            if (e.Cancelled) return;
            if (e.RequestResult.ResultCode != RequestResultCode.Success)
            {
                memoEdit1.Text = "The Azure Search service does not work for this location.";
                return;
            }
            StringBuilder resultList = new StringBuilder("");
            int resCounter = 1;
            foreach (LocationInformation resultInfo in e.RequestResult.SearchResults)
            {
                resultList.Append(String.Format("Result {0}:  \r\n", resCounter));
                resultList.Append(String.Format("Address: {0}\r\n", resultInfo.Address.FormattedAddress));
                resultList.Append(String.Format("Geographic coordinates:  {0}\r\n", resultInfo.Location));
                resultList.Append(String.Format("__________________\r\n"));
                resCounter++;
            }
            memoEdit1.Text = resultList.ToString();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            azureSearchProvider.Search(textEdit1.Text, maxResults: 2);
        }
    }
}
