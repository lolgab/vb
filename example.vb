'three variables that store the two inputs from the interface and the value of pie
Dim radius As Decimal = txtRadius.Text
Dim height As Decimal = txtHeight.Text
Dim pie As Decimal = 3.14159
'calculations to work out the volume and surface area
Dim volume As Decimal = pie * (radius * radius) * height
Dim surfaceArea As Decimal= 2 * (pie * (radius * radius)) + 2 * (pie * radius * height)
#outputs the volume and surface area of the cylinder in a message box.
MessageBox.Show("The volume of your cylinder is: " & Decimal.Round(volume, 2).ToString & " to 2 decimal places" & vbNewLine & "The surface area of the cylinder is: " & Decimal.Round(surfaceArea, 2).ToString & " to 2 decimal places.")

Class C1(Of T)
End Class
Class C2(Of T)
    Inherits C1(Of C2 (Of T))
End Class
' ...
Dim c2 = New C2(Of Integer)
