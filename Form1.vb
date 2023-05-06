' Program name: Rushing yard totals
' Name: Zachary Conley
' Date: May 6, 2023
' Description: User selects the player and then inserts a year to recieve the rushing yard total from that year

Option Strict On

Public Class FrmRushingyards
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ' This event calls the clearform() sub down below
        Clearform()
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        ' This event closes the app
        Close()

    End Sub

    Private Sub FrmRushingyards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The form load event calls clearform()
        Clearform()
    End Sub

    Private Sub Clearform()
        ' Clearform() clears the text box, focuses the test box, and ensures that the first radio button is checked
        Txtyearinput.Clear()
        LblYards.Text = ""
        RadHenry.Checked = True
        RadMccoy.Checked = False
        RadBell.Checked = False
        RadElliot.Checked = False
        Txtyearinput.Focus()
        LblYards.Visible = False

    End Sub

    Private Sub Btnconfirm_Click(sender As Object, e As EventArgs) Handles Btnconfirm.Click
        ' Clicking this button makes the label for the yards become visible with the stats
        LblYards.Visible = True

        Dim intgroup As Integer = 0


        If IsNumeric(Txtyearinput.Text) Then
            intgroup = Convert.ToInt32(Txtyearinput.Text)
            ' This very elongated if statement checks to see which radio button is checked as well as checks the number in the intgroup
            ' and then inserts the statement into the label according to the year and player selected

            If intgroup > 2015 And intgroup < 2021 Then
                If RadHenry.Checked And intgroup = 2016 Then
                    LblYards.Text = "In " & intgroup & " Derrick Henry rushed for 490 yards and 5 touchdowns."
                ElseIf RadHenry.Checked And intgroup = 2017 Then
                    LblYards.Text = "In " & intgroup & " Derrick Henry rushed for 744 yards and 5 touchdowns."
                ElseIf RadHenry.Checked And intgroup = 2018 Then
                    LblYards.Text = "In " & intgroup & " Derrick Henry rushed for 1,059 yards and 12 touchdowns."
                ElseIf RadHenry.Checked And intgroup = 2019 Then
                    LblYards.Text = "In " & intgroup & " Derrick Henry rushed for 1,540 yards and 16 touchdowns."
                ElseIf RadHenry.Checked And intgroup = 2020 Then
                    LblYards.Text = "In " & intgroup & " Derrick Henry rushed for 2,027 yards and 17 touchdowns."
                ElseIf RadMccoy.Checked And intgroup = 2016 Then
                    LblYards.Text = "In " & intgroup & " Lesean Mccoy rushed for 1,267 yards and 13 touchdowns."
                ElseIf RadMccoy.Checked And intgroup = 2017 Then
                    LblYards.Text = "In " & intgroup & " Lesean Mccoy rushed for 1,138 yards and 6 touchdowns."
                ElseIf RadMccoy.Checked And intgroup = 2018 Then
                    LblYards.Text = "In " & intgroup & " Lesean Mccoy rushed for 514 yards and 3 touchdowns."
                ElseIf RadMccoy.Checked And intgroup = 2019 Then
                    LblYards.Text = "In " & intgroup & " Lesean Mccoy rushed for 465 yards and 4 touchdowns."
                ElseIf RadMccoy.Checked And intgroup = 2020 Then
                    LblYards.Text = "In " & intgroup & " Lesean Mccoy rushed for a career low 31 yards and 0 touchdowns."
                ElseIf RadBell.Checked And intgroup = 2016 Then
                    LblYards.Text = "In " & intgroup & " Le'Veon Bell rushed for 1,268 yards and 7 touchdowns."
                ElseIf RadBell.Checked And intgroup = 2017 Then
                    LblYards.Text = "In " & intgroup & " Le'Veon Bell rushed for 1,291 yards and 9 touchdowns."
                ElseIf RadBell.Checked And intgroup = 2018 Then
                    LblYards.Text = "In " & intgroup & " Le'Veon Bell did not play due to contract disagreements."
                ElseIf RadBell.Checked And intgroup = 2019 Then
                    LblYards.Text = "In " & intgroup & " Le'Veon Bell rushed for 789 yards and 3 touchdowns."
                ElseIf RadBell.Checked And intgroup = 2020 Then
                    LblYards.Text = "In " & intgroup & " Le'Veon Bell rushed for 74 yards on the jets and 254 yards on the chiefs for 2 total touchdowns."
                ElseIf RadElliot.Checked And intgroup = 2016 Then
                    LblYards.Text = "In " & intgroup & " Ezekiel Elliot rushed for 1,631 yards and 15 touchdowns."
                ElseIf RadElliot.Checked And intgroup = 2017 Then
                    LblYards.Text = "In " & intgroup & " Ezekiel Elliot rushed for 983 yards and 7 touchdowns."
                ElseIf RadElliot.Checked And intgroup = 2018 Then
                    LblYards.Text = "In " & intgroup & " Ezekiel Elliot rushed for 1,434 yards and 6 touchdowns."
                ElseIf RadElliot.Checked And intgroup = 2019 Then
                    LblYards.Text = "In " & intgroup & " Ezekiel Elliot rushed for 1,357 yards and 12 touchdowns."
                ElseIf RadElliot.Checked And intgroup = 2020 Then
                    LblYards.Text = "In " & intgroup & " Ezekiel Elliot rushed for 979 yards and 6 touchdowns."
                End If
            Else
                ' This msgbox pops up when the user enters a value bigger than 2020 or smaller than 2016 and then clears the text box and
                ' puts focus back on it for easier use after seeing the message
                MsgBox("Please enter a value between 2016 and 2020")
                Txtyearinput.Text = ""
                Txtyearinput.Focus()
            End If
        Else
            ' This message box pops up when the user inserts a character that is not a number value and then clears the txt box then 
            ' puts focus back onto it
            MsgBox("Please enter numeric values only")
            Txtyearinput.Text = ""
            Txtyearinput.Focus()

        End If
    End Sub
End Class
