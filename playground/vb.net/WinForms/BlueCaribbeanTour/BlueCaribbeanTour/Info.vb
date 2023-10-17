Public Class Info
    ' The customer must register at least
    ' 7 days before the departure date.
    Public Shared minimum_preregistration As Integer = 7
    ' Key: Destination
    ' Values: {7 days cost, 14 days cost}
    Public Shared tour_prices As New Dictionary(Of String, Double()) From {
        {"Caribbean", {3250.0, 6000.0}},
        {"Mediterranean", {4250.0, 7999.0}},
        {"Alaska", {3300.0, 7200.0}},
        {"Europe", {5000.0, 9000.0}}
    }

    Public Shared modes_of_payment As String() = {
        "Cash",
        "Credit Card",
        "E-Banking"
    }
End Class
