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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtCliente = New TextBox()
        txtHoras = New TextBox()
        txtCusto = New TextBox()
        ListBox1 = New ListBox()
        btnCalculo = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(46, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(216, 28)
        Label1.TabIndex = 0
        Label1.Text = "Pedido de Orçamento"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 1
        Label2.Text = "Cliente:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 20)
        Label3.TabIndex = 2
        Label3.Text = "Número de Horas:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(46, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 3
        Label4.Text = "Valor Peças:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(46, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 20)
        Label5.TabIndex = 4
        Label5.Text = "Dados:"
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(240, 80)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(471, 27)
        txtCliente.TabIndex = 5
        ' 
        ' txtHoras
        ' 
        txtHoras.Location = New Point(240, 125)
        txtHoras.Name = "txtHoras"
        txtHoras.Size = New Size(244, 27)
        txtHoras.TabIndex = 6
        ' 
        ' txtCusto
        ' 
        txtCusto.Location = New Point(240, 168)
        txtCusto.Name = "txtCusto"
        txtCusto.Size = New Size(244, 27)
        txtCusto.TabIndex = 7
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(246, 217)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(465, 144)
        ListBox1.TabIndex = 8
        ' 
        ' btnCalculo
        ' 
        btnCalculo.BackColor = SystemColors.Highlight
        btnCalculo.FlatAppearance.BorderColor = SystemColors.Highlight
        btnCalculo.ForeColor = SystemColors.ButtonHighlight
        btnCalculo.Location = New Point(533, 126)
        btnCalculo.Name = "btnCalculo"
        btnCalculo.Size = New Size(178, 69)
        btnCalculo.TabIndex = 9
        btnCalculo.Text = "Total a Pagar"
        btnCalculo.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalculo)
        Controls.Add(ListBox1)
        Controls.Add(txtCusto)
        Controls.Add(txtHoras)
        Controls.Add(txtCliente)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Gestão de Oficina"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents txtCusto As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnCalculo As Button
End Class
