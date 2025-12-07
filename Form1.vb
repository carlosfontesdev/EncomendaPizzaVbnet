Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPizza.Items.Add("Margarita")
        cmbPizza.Items.Add("Fiambre")
        cmbPizza.Items.Add("Peperoni")
        cmbPizza.Items.Add("4 Queijos")

        txtQuantidade.Text = (1)

        rdbNao.Checked = True



    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim precoPizza As Integer
        precoPizza = 0
        Dim qtdPizza As Integer
        qtdPizza = 0
        Dim totalPagar As Decimal
        totalPagar = 0

        If cmbPizza.Text = "Margarita" Then
            precoPizza = 8
        ElseIf cmbPizza.Text = "Fiambre" Then
            precoPizza = 9
        ElseIf cmbPizza.Text = "Peperoni" Then
            precoPizza = 10
        ElseIf cmbPizza.Text = "4 Queijos" Then
            precoPizza = 13
        End If

        qtdPizza = txtQuantidade.Text

        totalPagar = qtdPizza * precoPizza

        If chkAzeitona.Checked Then
            totalPagar = totalPagar + 1
        End If

        If chkAnanas.Checked Then
            totalPagar = totalPagar + 2
        End If
        If chkPimenta.Checked Then
            totalPagar = totalPagar + 3
        End If

        If rdbSim.Checked Then
            totalPagar = totalPagar - totalPagar * 0.1
        End If

        txtCalcular.Text = totalPagar.ToString() + " €"



    End Sub


End Class
