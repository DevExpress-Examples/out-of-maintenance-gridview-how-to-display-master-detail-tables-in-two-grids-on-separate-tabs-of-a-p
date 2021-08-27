<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549987/12.1.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4433)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [Model.cs](./CS/Models/Model.cs) (VB: [Model.vb](./VB/Models/Model.vb))
* [GridCategories.cshtml](./CS/Views/Home/GridCategories.cshtml)
* [GridProducts.cshtml](./CS/Views/Home/GridProducts.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to display master-detail tables in two grids on separate tabs of a PageControl
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4433)**
<!-- run online end -->


<p>This example demonstrates how to use two GridView extensions to display related tables. The GridView extensions are located on the PageControl TabPages. To filter data in the second (detail) GridView, focus a row of the first (master) GridView and activate the second TabPage. </p><p><strong>Note</strong> that the detail GridView does not get filtered until you change the active TabPage. This was made for performance reasons.</p>

<br/>


