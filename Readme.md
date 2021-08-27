<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620132/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T371660)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DataProvider.cs](./CS/DXApplication1/DataProvider.cs) (VB: [DataProvider.vb](./VB/DXApplication1/DataProvider.vb))
* **[Main.cs](./CS/DXApplication1/Main.cs) (VB: [Main.vb](./VB/DXApplication1/Main.vb))**
<!-- default file list end -->
# How to create cascading lookup editors 


This example illustrates how to filter drop-down items of one lookup editor based on a value in another lookup editor. It is possible to implement this functionality with a single code line. For this, we set the <strong>LookUpEditBase.CascadingOwner</strong> property of a child lookup control to a parent lookup control. Once you set this property, our inner mechanism will try to guess what cascading member is. That is, what child data field corresponds to a parent data field. The child drop-down list should be filtered against this found field. If the automatic algorithm does not recognize any related fields, you can specify such a field (or even fields) manually by using the<strong> RepositoryItemLookUpEditBase.CascadingMember</strong> property. <br><br>Note that this feature is in effect in <strong>Standalone Mode</strong> and it is applicable to <strong>LookUpEdit</strong>, <strong>GridLookUpEdit</strong>, and <strong>SearchLookUpEdit</strong>.<br><br>Review the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument116018">Cascading Lookups</a> help article for more information in this regard. 

<br/>


