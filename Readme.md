<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620132/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T371660)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Lookup - Create cascading lookup editors 

`LookUpEdit`, `GridLookUpEdit`, and `SearchLookUpEdit` controls can automatically filter their data sources based on a value in another lookup.

Use the secondary lookup's [CascadingOwner](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.LookUpEditBase.CascadingOwner) property to specify the primary lookup. Lookups use an internal algorithm that identifies a key field in a data source. The algorithm checks the names of data objects, the key attributes, and the data type of the primary keys. The algorithm is based on a common naming convention of key fields (for example, `ID`, `Key`, and `OID`).

Use the [CascadingMember](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemLookUpEditBase.CascadingMember) property to manually specify a key field of the secondary lookup if the lookup's algorithm cannot identify a key field. Use the `;` character to delimit field names in a compound foreign key field.

Read the following help topic for additional information: [Cascading Lookups](https://docs.devexpress.com/WindowsForms/116018/controls-and-libraries/editors-and-simple-controls/lookup-editors/cascading-lookups).


## Files to Review

* [DataProvider.cs](./CS/DXApplication1/DataProvider.cs) (VB: [DataProvider.vb](./VB/DXApplication1/DataProvider.vb))
* [Main.cs](./CS/DXApplication1/Main.cs) (VB: [Main.vb](./VB/DXApplication1/Main.vb))


## Documentation

* [Cascading Lookups](https://docs.devexpress.com/WindowsForms/116018/controls-and-libraries/editors-and-simple-controls/lookup-editors/cascading-lookups)
* [Lookup Main Settings](https://docs.devexpress.com/WindowsForms/116029/controls-and-libraries/editors-and-simple-controls/lookup-editors/lookup-editors-and-main-settings)
* [WinForms Lookup Editors](https://docs.devexpress.com/WindowsForms/116008/controls-and-libraries/editors-and-simple-controls/lookup-editors)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-cascading-lookups&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-cascading-lookups&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
