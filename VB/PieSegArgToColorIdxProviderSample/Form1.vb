Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraMap


Namespace PieSegArgToColorIdxProviderSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            InitializeMap()
        End Sub

        Private Sub InitializeMap()
            ' Create a map control.
            Dim map As New MapControl() With {.Dock = DockStyle.Fill}
            Me.Controls.Add(map)

            ' Create a vector items layer.
            Dim layer As New VectorItemsLayer() With {.Data = CreateData(), .Colorizer = CreateColorizrer()}
            map.Layers.Add(layer)
            map.Legends.Add(New ColorListLegend() With {.Layer = layer})
        End Sub

        Private Function CreateData() As MapDataAdapterBase
            Dim storage As New MapItemStorage()

            ' Create a MapPie object.
            Dim pie As New MapPie() With {.Size = 100}
            pie.Segments.Add(New PieSegment() With {.Argument = 0, .Value = 10})
            pie.Segments.Add(New PieSegment() With {.Argument = 1, .Value = 9})
            pie.Segments.Add(New PieSegment() With {.Argument = 2, .Value = 12})
            storage.Items.Add(pie)

            Return storage

        End Function

        Private Function CreateColorizrer() As MapColorizer
            ' Create a color index colorizer and set PieSegmentArgumentToColorIndexProvider
            ' object to the ColorIndexProvider property of the colorizer.
            Dim colorizer As New ColorIndexColorizer() With {.ColorIndexProvider = New PieSegmentArgumentToColorIndexProvider()}
            colorizer.ColorItems.Add(New ColorizerColorTextItem(Color.Red, "Argument 0"))
            colorizer.ColorItems.Add(New ColorizerColorTextItem(Color.Green, "Argument 1"))
            colorizer.ColorItems.Add(New ColorizerColorTextItem(Color.Blue, "Argument 2"))

            Return colorizer
        End Function

    End Class
End Namespace
