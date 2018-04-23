@ModelType System.Collections.IEnumerable
@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "GridView"
            settings.KeyFieldName = "PersonID"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}

            settings.Columns.Add("FirstName")
            settings.Columns.Add("MiddleName")
            settings.Columns.Add("LastName")

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
    End Sub).Bind(Model).GetHtml()