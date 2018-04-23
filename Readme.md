# GridView - How to display a hyperlink in templated column 


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


