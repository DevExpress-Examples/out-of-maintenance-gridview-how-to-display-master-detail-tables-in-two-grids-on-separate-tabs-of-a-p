<h2>@ViewBag.Message</h2>
<p>
    To learn more about DevExpress Extensions for ASP.NET MVC visit <a href="http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/" title="ASP.NET MVC Website">http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/</a>.
</p>
<script type="text/javascript">
    function OnActiveTabChanging(s, e) {
        gvProducts.PerformCallback();
    }
    function OnProductsBeginCallback(s, e) {
        var index = gvCategories.GetFocusedRowIndex();
        var focusedRowKey = gvCategories.GetRowKey(index);
        if (focusedRowKey != null) {
            e.customArgs["CategoryID"] = focusedRowKey;
        }
    }
</script>

@Html.DevExpress().PageControl( _
    Sub(settings)
            settings.Name = "PageControl"
            
            settings.TabPages.Add("Categories").SetContent(Function()
                                                                   Html.RenderPartial("GridCategories", ViewData("CategoryList"))
                                                           End Function)
            settings.TabPages.Add("Products").SetContent(Function()
                                                                 Html.RenderPartial("GridProducts", ViewData("ProductList"))
                                                         End Function)

            settings.ClientSideEvents.ActiveTabChanging = "OnActiveTabChanging"
    End Sub).GetHtml()


