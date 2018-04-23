@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gvCategories"
            settings.KeyFieldName = "CategoryID"
            settings.CallbackRouteValues = New With { _
             Key .Controller = "Home", _
             Key .Action = "GridCategoriesAction" _
            }
            settings.SettingsBehavior.AllowFocusedRow = True
            settings.Columns.Add("CategoryName")

            settings.Columns.Add("Description")

    
    End Sub).Bind(Model).GetHtml()