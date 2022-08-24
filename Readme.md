<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549928/13.2.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T107662)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [Details.cshtml](./CS/Views/Home/Details.cshtml)
* **[GridViewPartial.cshtml](./CS/Views/Home/GridViewPartial.cshtml)**
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to display a hyperlink in templated column 
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/128549928/)**
<!-- run online end -->


This example illustrates how to use the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMvcMVCxGridViewColumn_SetDataItemTemplateContenttopic2592">MVCxGridViewColumn.SetDataItemTemplateContent(Action`1) Method</a> to display a hyperlink in a specific column. The hyperlink parameters (text, navigate url) are calculated based on the template's container. Here is the most important part of the code that is responsible for hyperlink creation:<br /><br />


```cs
    settings.Columns.Add(column => {
        column.Caption = "Details";
        column.SetDataItemTemplateContent(container => {
            Html.DevExpress().HyperLink(hyperlink => {
                var visibleIndex = container.VisibleIndex;
                var keyValue = container.KeyValue;
                var lastName = DataBinder.Eval(container.DataItem, "LastName");

                hyperlink.Name = "hl" + keyValue.ToString();
                hyperlink.Properties.Text = lastName.ToString();
                hyperlink.NavigateUrl = Url.Action("Details", "Home", new { id = keyValue });
            }).Render();
        });
    });
```


<br />


```vb
            settings.Columns.Add( _
                   Sub(column)
                           column.Caption = "Details"
                           column.SetDataItemTemplateContent( _
                               Sub(container)
                                       Html.DevExpress().HyperLink( _
                                            Sub(hl)
                                                    Dim visibleIndex = container.VisibleIndex
                                                    Dim keyValue = container.KeyValue
                                                    Dim lastName = DataBinder.Eval(container.DataItem, "LastName")

                                                    hl.Name = "hl" + keyValue.ToString()
                                                    hl.Properties.Text = lastName.ToString()
                                                    hl.NavigateUrl = Url.Action("Details", "Home", New With {.id = keyValue})
                                            End Sub).Render()
                               End Sub)
                   End Sub)
```



<br/>


