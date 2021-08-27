<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576182/14.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T142507)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/PieSegArgToColorIdxProviderSample/Form1.cs) (VB: [Form1.vb](./VB/PieSegArgToColorIdxProviderSample/Form1.vb))**
<!-- default file list end -->
# How to colorize pie charts using the PieSegmentArgumentToColorIndexProvider class


The following instance demonstrates how to colorize pie charts, depends on pie segment arguments.


<h3>Description</h3>

<p>&nbsp;To do this, create a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapColorIndexColorizertopic">ColorIndexColorizer</a> object, then create&nbsp;an instance of the <strong>PieSegmentArgumentToColorIndexProvider</strong>&nbsp;class and set it to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapColorIndexColorizer_ColorIndexProvidertopic">ColorIndexColorizer.ColorIndexProvider</a> property of the colorizer.<br />Create several <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapColorizerColorTextItemtopic">ColorizerColorTextItem</a> objects and add them to <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapColorIndexColorizer_ColorItemstopic">ColorIndexColorizer.ColorItems</a>.<br /><br />Starting with version 14.2 you should use the KeyColorColorizer class instead of ColorIndexColorizer. Refer to the <a href="http://devexpress.com/example=T116241">How to manually add MapPie items to the map</a>&nbsp;example to learn how to use a key color colorizer.</p>

<br/>


