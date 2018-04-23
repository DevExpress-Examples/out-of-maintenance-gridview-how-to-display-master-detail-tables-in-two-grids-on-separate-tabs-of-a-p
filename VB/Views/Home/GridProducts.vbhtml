@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gvProducts"
            settings.KeyFieldName = "ProductID"
            settings.CallbackRouteValues = New With { _
             Key .Controller = "Home", _
             Key .Action = "GridProductsAction" _
            }

            settings.ClientSideEvents.BeginCallback = "OnProductsBeginCallback"

            settings.Columns.Add("ProductName")
            settings.Columns.Add(Function(column)
                                         column.FieldName = "CategoryID"
                                         column.Caption = "Category"

                                         column.ColumnType = MVCxGridViewColumnType.ComboBox
                                         Dim comboBoxProperties = TryCast(column.PropertiesEdit, ComboBoxProperties)
                                         comboBoxProperties.DataSource = VB.MyModel.GetCategories()
                                         comboBoxProperties.TextField = "CategoryName"
                                         comboBoxProperties.ValueField = "CategoryID"
                                         comboBoxProperties.ValueType = GetType(Integer)

                                 End Function)
            settings.Columns.Add("QuantityPerUnit")
            settings.Columns.Add(Function(column)
                                         column.FieldName = "UnitPrice"

                                         column.ColumnType = MVCxGridViewColumnType.SpinEdit
                                         Dim spinEditProperties = TryCast(column.PropertiesEdit, SpinEditProperties)
                                         spinEditProperties.DisplayFormatString = "c"
                                         spinEditProperties.DisplayFormatInEditMode = True
                                         spinEditProperties.MinValue = 0
                                         spinEditProperties.MaxValue = 1000000
                                         spinEditProperties.SpinButtons.ShowLargeIncrementButtons = True

                                 End Function)
            settings.Columns.Add(Function(column)
                                         column.FieldName = "UnitsInStock"

                                         column.ColumnType = MVCxGridViewColumnType.SpinEdit
                                         Dim spinEditProperties = TryCast(column.PropertiesEdit, SpinEditProperties)
                                         spinEditProperties.NumberType = SpinEditNumberType.[Integer]
                                         spinEditProperties.MinValue = 0
                                         spinEditProperties.MaxValue = 10000

                                 End Function)
            settings.Columns.Add("Discontinued", MVCxGridViewColumnType.CheckBox)

    End Sub).Bind(Model).GetHtml()