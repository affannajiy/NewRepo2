Public Class CylinderKalat
    'Declare Varibles' 
    Dim cylinder_radius, cylinder_height, cylinder_volume, pi As Double

    'Get Cylinder Radius' 
    Private Sub txtradius_TextChanged(sender As Object, e As EventArgs) Handles txtradius.TextChanged
        cylinder_radius = Val(txtradius.Text)
    End Sub

    'Get Cylinder Height' 
    Private Sub txtheight_TextChanged(sender As Object, e As EventArgs) Handles txtheight.TextChanged
        cylinder_height = Val(txtheight.Text)
    End Sub

    'Choosing Pi1' 
    Private Sub btnPi1_Click(sender As Object, e As EventArgs) Handles btnPi1.Click
        pi = 3.142
    End Sub

    'Choosing Pi2' 
    Private Sub btnPi2_Click(sender As Object, e As EventArgs) Handles btnPi2.Click
        pi = 22 / 7
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Reset All' 
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtradius.Clear()
        txtheight.Clear()
        lblVolume.Text = "Volume = 0"
    End Sub

    'Volume Calculator' 
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        cylinder_volume = pi * cylinder_height * cylinder_radius * cylinder_radius
        lblVolume.Text = "Volume = " & cylinder_volume
    End Sub

    'Close Form' 
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class