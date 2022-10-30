Public Class Form1

    Dim Celsius, Fahrenheit, Kelvin As Double
    Dim Kilo, Liter, Mililiter, Gram, Centimeter As Double

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        ioperation = "KG"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        ioperation = "GK"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        ioperation = "LM"
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        ioperation = "ML"
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        ioperation = "KM"
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        ioperation = "MK"
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        ioperation = "MF"
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        ioperation = "FI"
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        ioperation = "CM"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case (ioperation)
            Case "KM"
                'Kilometer to Meter
                Kilometer = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((1000 * Kilometer).ToString())

            Case "MK"
                'Meter to Kilometer
                Meter = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Meter / 1000).ToString())

            Case "MF"
                'Meter to Feet
                Inches = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((3.2808399 * Inches).ToString())

            Case "FI"
                'Feet to Inches
                Feet = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Feet * 12).ToString())

            Case "KG"
                'Kilogram to Gram
                Kilo = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((1000 * Kilo).ToString())

            Case "GK"
                'Gram to Kilogram
                Gram = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Gram / 1000).ToString())

            Case "LM"
                'Liter to Mililiter
                Liter = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((1000 * Liter).ToString())

            Case "ML"
                'Mililiter to Liter
                Mililiter = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Mililiter / 1000).ToString())

            Case "CM"
                'Centimeter to Meter
                Centimeter = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Centimeter / 100).ToString())
            Case "CF"
                'Celsius to Fahrenheit
                Celsius = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((((9 * Celsius) / 5) + 32).ToString())

            Case "FC"
                'Fahrenheit to Celsius
                Fahrenheit = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((((Fahrenheit - 32) * 5) / 9).ToString())

            Case "K"
                'Convert Celsius to Kelvin
                Kelvin = Double.Parse(txtConvert.Text)
                lblConvert.Text = (((((1 * Kelvin) / 1) + 1) + 272.15).ToString())
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtConvert.Clear()
        lblConvert.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        RadioButton11.Checked = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub lblConvert_Click(sender As Object, e As EventArgs) Handles lblConvert.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ioperation = "K"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ioperation = "FC"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ioperation = "CF"
    End Sub

    Dim Kilometer, Meter, Inches, Feet As Double

    Dim ioperation As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
