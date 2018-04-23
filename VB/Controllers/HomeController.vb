Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web
Imports System.Web.Mvc

Namespace CS.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"
            ViewData("CategoryList") = MyModel.GetCategories()
            ViewData("ProductList") = MyModel.GetProducts()

            Return View()
        End Function

        Public Function GridCategoriesAction() As ActionResult
            Return PartialView("GridCategories", MyModel.GetCategories())
        End Function
        Public Function GridProductsAction(CategoryID As System.Nullable(Of Integer)) As ActionResult
            Return PartialView("GridProducts", MyModel.GetProductsByCategory(CategoryID))
        End Function

	End Class
End Namespace
