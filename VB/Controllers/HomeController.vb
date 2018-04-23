Imports System
Imports System.Web.Mvc
Imports Sample.Models

Namespace GridViewLinkColumnMvc.Controllers
    Public Class HomeController
        Inherits Controller
        Private personsList As New PersonsList()

        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function GridViewPartial() As ActionResult
            Return PartialView(personsList.GetPersons())
        End Function

        Public Function Details(ByVal id As Object) As ActionResult
            Return View(id)
        End Function
    End Class
End Namespace