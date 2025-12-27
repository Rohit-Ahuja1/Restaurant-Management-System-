Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form3
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim dt As DataTable
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datelbl.Text = DateTime.Now.ToLongTimeString

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles NuddCb.CheckedChanged

        If NuddCb.Checked = True Then
            NuddTb.Enabled = True

        End If
        If NuddCb.Checked = False Then
            NuddTb.Enabled = False
            NuddTb.Text = "0"

        End If




    End Sub

    Private Sub NuddTb_TextChanged(sender As Object, e As EventArgs) Handles NuddTb.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles PizzaTb.TextChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles PizzaCb.CheckedChanged
        If PizzaCb.Checked = True Then
            PizzaTb.Enabled = True



        End If
        If PizzaCb.Checked = False Then
            PizzaTb.Enabled = False
            PizzaTb.Text = "0"

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FriesCb_CheckedChanged(sender As Object, e As EventArgs) Handles FriesCb.CheckedChanged
        If FriesCb.Checked = True Then
            FriesTb.Enabled = True


        End If
        If FriesCb.Checked = False Then
            FriesTb.Enabled = False
            FriesTb.Text = "0"

        End If
    End Sub

    Private Sub WrapCb_CheckedChanged(sender As Object, e As EventArgs) Handles WrapCb.CheckedChanged
        If WrapCb.Checked = True Then
            WrapTb.Enabled = True

        End If
        If WrapCb.Checked = False Then
            WrapTb.Enabled = False
            WrapTb.Text = "0"

        End If
    End Sub

    Private Sub SubCb_CheckedChanged(sender As Object, e As EventArgs) Handles SubCb.CheckedChanged
        If SubCb.Checked = True Then
            SubTb.Enabled = True

        End If
        If SubCb.Checked = False Then
            SubTb.Enabled = False
            SubTb.Text = "0"

        End If
    End Sub

    Private Sub CapCb_CheckedChanged(sender As Object, e As EventArgs) Handles CapCb.CheckedChanged
        If CapCb.Checked = True Then
            CapTb.Enabled = True

        End If
        If CapCb.Checked = False Then
            CapTb.Enabled = False
            CapTb.Text = "0"

        End If
    End Sub

    Private Sub MozCb_CheckedChanged(sender As Object, e As EventArgs) Handles MozCb.CheckedChanged
        If MozCb.Checked = True Then
            MozTb.Enabled = True

        End If
        If MozCb.Checked = False Then
            MozTb.Enabled = False
            MozTb.Text = "0"

        End If
    End Sub

    Private Sub CoffeCb_CheckedChanged(sender As Object, e As EventArgs) Handles CoffeCb.CheckedChanged
        If CoffeCb.Checked = True Then
            CoffeTb.Enabled = True

        End If
        If CoffeCb.Checked = False Then
            CoffeTb.Enabled = False
            CoffeTb.Text = "0"

        End If
    End Sub

    Private Sub PastyCb_CheckedChanged(sender As Object, e As EventArgs) Handles PastyCb.CheckedChanged
        If PastyCb.Checked = True Then
            PastyTb.Enabled = True

        End If
        If PastyCb.Checked = False Then
            PastyTb.Enabled = False
            PastyTb.Text = "0"

        End If
    End Sub

    Private Sub WaffCb_CheckedChanged(sender As Object, e As EventArgs) Handles WaffCb.CheckedChanged
        If WaffCb.Checked = True Then
            WaffTb.Enabled = True

        End If
        If WaffCb.Checked = False Then
            WaffTb.Enabled = False
            WaffTb.Text = "0"

        End If
    End Sub

    Private Sub IceCb_CheckedChanged(sender As Object, e As EventArgs) Handles IceCb.CheckedChanged
        If IceCb.Checked = True Then
            IceTb.Enabled = True

        End If
        If IceCb.Checked = False Then
            IceTb.Enabled = False
            IceTb.Text = "0"

        End If
    End Sub

    Private Sub BurgerCb_CheckedChanged(sender As Object, e As EventArgs) Handles BurgerCb.CheckedChanged
        If BurgerCb.Checked = True Then
            BurgerTb.Enabled = True

        End If
        If BurgerCb.Checked = False Then
            BurgerTb.Enabled = False
            BurgerTb.Text = "0"

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub FriesTb_TextChanged(sender As Object, e As EventArgs) Handles FriesTb.TextChanged

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub BurgerTb_TextChanged(sender As Object, e As EventArgs) Handles BurgerTb.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class