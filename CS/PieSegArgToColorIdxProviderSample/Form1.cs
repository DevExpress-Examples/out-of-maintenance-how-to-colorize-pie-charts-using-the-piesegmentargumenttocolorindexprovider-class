using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraMap;


namespace PieSegArgToColorIdxProviderSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap() {
            // Create a map control.
            MapControl map = new MapControl() { Dock = DockStyle.Fill };
            this.Controls.Add(map);

            // Create a vector items layer.
            VectorItemsLayer layer = new VectorItemsLayer() {
                Data = CreateData(),
                Colorizer = CreateColorizrer()
            };
            map.Layers.Add(layer);
            map.Legends.Add(new ColorListLegend() { Layer = layer });
        }

        MapDataAdapterBase CreateData() {
            MapItemStorage storage = new MapItemStorage();
            
            // Create a MapPie object.
            MapPie pie = new MapPie() { Size = 100 };
            pie.Segments.Add(new PieSegment() { Argument = 0, Value = 10 });
            pie.Segments.Add(new PieSegment() { Argument = 1, Value = 9 });
            pie.Segments.Add(new PieSegment() { Argument = 2, Value = 12 });
            storage.Items.Add(pie);

            return storage;

        }

        MapColorizer CreateColorizrer() {
            // Create a color index colorizer and set PieSegmentArgumentToColorIndexProvider
            // object to the ColorIndexProvider property of the colorizer.
            ColorIndexColorizer colorizer = new ColorIndexColorizer() { ColorIndexProvider = 
                new PieSegmentArgumentToColorIndexProvider() };
            colorizer.ColorItems.Add(new ColorizerColorTextItem(Color.Red, "Argument 0"));
            colorizer.ColorItems.Add(new ColorizerColorTextItem(Color.Green, "Argument 1"));
            colorizer.ColorItems.Add(new ColorizerColorTextItem(Color.Blue, "Argument 2"));

            return colorizer;
        }

    }
}
