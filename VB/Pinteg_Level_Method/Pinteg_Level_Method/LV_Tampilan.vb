Module LV_Tampilan
    Sub Main()
        Dim p As rest = New rest("http://localhost/P.Integ_Level_Method/")
        p.List("application/json")

    End Sub

End Module