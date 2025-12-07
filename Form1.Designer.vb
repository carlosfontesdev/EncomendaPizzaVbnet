<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbPizza = New System.Windows.Forms.ComboBox()
        Me.chkAzeitona = New System.Windows.Forms.CheckBox()
        Me.chkAnanas = New System.Windows.Forms.CheckBox()
        Me.chkPimenta = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbSim = New System.Windows.Forms.RadioButton()
        Me.rdbNao = New System.Windows.Forms.RadioButton()
        Me.txtCalcular = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbPizza
        '
        Me.cmbPizza.FormattingEnabled = True
        Me.cmbPizza.Location = New System.Drawing.Point(149, 57)
        Me.cmbPizza.Name = "cmbPizza"
        Me.cmbPizza.Size = New System.Drawing.Size(121, 21)
        Me.cmbPizza.TabIndex = 0
        '
        'chkAzeitona
        '
        Me.chkAzeitona.AutoSize = True
        Me.chkAzeitona.Location = New System.Drawing.Point(441, 57)
        Me.chkAzeitona.Name = "chkAzeitona"
        Me.chkAzeitona.Size = New System.Drawing.Size(67, 17)
        Me.chkAzeitona.TabIndex = 1
        Me.chkAzeitona.Text = "Azeitona"
        Me.chkAzeitona.UseVisualStyleBackColor = True
        '
        'chkAnanas
        '
        Me.chkAnanas.AutoSize = True
        Me.chkAnanas.Location = New System.Drawing.Point(441, 91)
        Me.chkAnanas.Name = "chkAnanas"
        Me.chkAnanas.Size = New System.Drawing.Size(62, 17)
        Me.chkAnanas.TabIndex = 2
        Me.chkAnanas.Text = "Ananás"
        Me.chkAnanas.UseVisualStyleBackColor = True
        '
        'chkPimenta
        '
        Me.chkPimenta.AutoSize = True
        Me.chkPimenta.Location = New System.Drawing.Point(441, 127)
        Me.chkPimenta.Name = "chkPimenta"
        Me.chkPimenta.Size = New System.Drawing.Size(64, 17)
        Me.chkPimenta.TabIndex = 3
        Me.chkPimenta.Text = "Pimenta"
        Me.chkPimenta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Quantidade"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(229, 131)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tem desconto?"
        '
        'rdbSim
        '
        Me.rdbSim.AutoSize = True
        Me.rdbSim.Location = New System.Drawing.Point(149, 253)
        Me.rdbSim.Name = "rdbSim"
        Me.rdbSim.Size = New System.Drawing.Size(42, 17)
        Me.rdbSim.TabIndex = 7
        Me.rdbSim.TabStop = True
        Me.rdbSim.Text = "Sim"
        Me.rdbSim.UseVisualStyleBackColor = True
        '
        'rdbNao
        '
        Me.rdbNao.AutoSize = True
        Me.rdbNao.Location = New System.Drawing.Point(252, 253)
        Me.rdbNao.Name = "rdbNao"
        Me.rdbNao.Size = New System.Drawing.Size(45, 17)
        Me.rdbNao.TabIndex = 8
        Me.rdbNao.TabStop = True
        Me.rdbNao.Text = "Não"
        Me.rdbNao.UseVisualStyleBackColor = True
        '
        'txtCalcular
        '
        Me.txtCalcular.Location = New System.Drawing.Point(282, 308)
        Me.txtCalcular.Name = "txtCalcular"
        Me.txtCalcular.Size = New System.Drawing.Size(100, 20)
        Me.txtCalcular.TabIndex = 10
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(149, 306)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Preços:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 52)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "-> Magarita 8 €" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-> Fiambre 9 € " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-> Peperoni 10 € " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-> 4 Queijos 13 €  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 487)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Desconto = 10 %"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(319, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Extras:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(322, 419)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 39)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "-> Azeitona 1€" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-> Ananás 2 €" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-> Pimenta 3€" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(441, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Extras :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(149, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Pizzas :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(570, 544)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtCalcular)
        Me.Controls.Add(Me.rdbNao)
        Me.Controls.Add(Me.rdbSim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkPimenta)
        Me.Controls.Add(Me.chkAnanas)
        Me.Controls.Add(Me.chkAzeitona)
        Me.Controls.Add(Me.cmbPizza)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbPizza As ComboBox
    Friend WithEvents chkAzeitona As CheckBox
    Friend WithEvents chkAnanas As CheckBox
    Friend WithEvents chkPimenta As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rdbSim As RadioButton
    Friend WithEvents rdbNao As RadioButton
    Friend WithEvents txtCalcular As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
