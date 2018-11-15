<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/PieSegArgToColorIdxProviderSample/Form1.cs) (VB: [Form1.vb](./VB/PieSegArgToColorIdxProviderSample/Form1.vb))**
<!-- default file list end -->
# How to colorize pie charts using the PieSegmentArgumentToColorIndexProvider class


The following instance demonstrates how to colorize pie charts, depends on pie segment arguments.


<h3>Description</h3>

<p>&nbsp;To do this, create a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapColorIndexColorizertopic">ColorIndexColorizer</a> object, then create&nbsp;an instance of the <strong>PieSegmentArgumentToColorIndexProvider</strong>&nbsp;class and set it to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapColorIndexColorizer_ColorIndexProvidertopic">ColorIndexColorizer.ColorIndexProvider</a> property of the colorizer.<br />Create several <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapColorizerColorTextItemtopic">ColorizerColorTextItem</a> objects and add them to <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapColorIndexColorizer_ColorItemstopic">ColorIndexColorizer.ColorItems</a>.<br /><br />Starting with version 14.2 you should use the KeyColorColorizer class instead of ColorIndexColorizer. Refer to the <a href="http://devexpress.com/example=T116241">How to manually add MapPie items to the map</a>&nbsp;example to learn how to use a key color colorizer.</p>

<br/>


