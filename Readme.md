<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549928/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T107662)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Grid View for ASP.NET MVC - How to display a hyperlink in a templated column 

This example illustrates how to use the  [MVCxGridViewColumn.SetDataItemTemplateContent](https://documentation.devexpress.com/#AspNet/DevExpressWebMvcMVCxGridViewColumn_SetDataItemTemplateContenttopic2592) method to display a hyperlink in a grid column. The hyperlink parameters (text, navigate url) are calculated based on the template's container. The code below creates the hyperlink:

**C#**

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

**Visual Basic**

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

## Files to Look At:

- [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
- [Details.cshtml](./CS/Views/Home/Details.cshtml) (VB: [Details.vbhtml](./VB/Views/Home/Details.vbhtml))
- [GridViewPartial.cshtml](./CS/Views/Home/GridViewPartial.cshtml) (VB: [GridViewPartial.vbhtml](./VB/Views/Home/GridViewPartial.vbhtml))
- [Index.cshtml](./CS/Views/Home/Index.cshtml) (VB: [Index.vbhtml](./VB/Views/Home/Index.vbhtml))

## Documentation

- [Templates](https://docs.devexpress.com/AspNetMvc/14721/common-features/templates)
- [Hyperlink](https://docs.devexpress.com/AspNetMvc/8987/components/data-editors-extensions/hyperlink)

## More Examples

- [Grid View for ASP.NET Web Forms - How to show a popup when a user clicks a hyperlink in a grid column's DataItemTemplate](https://github.com/DevExpress-Examples/aspxgridview-dataitemtemplate-hyperlink-popup)
- [Grid View for APS.NET MVC - How to use the jQuery.ajax function with DevExpress MVC extensions](https://github.com/DevExpress-Examples/mvc-gridview-jqueryajax-function)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-gridview-display-hyperlink-in-templated-column&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-gridview-display-hyperlink-in-templated-column&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
