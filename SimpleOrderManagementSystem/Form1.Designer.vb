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
        Me.txtCustomersName = New System.Windows.Forms.TextBox()
        Me.cmbBeverage = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtFinalTotal = New System.Windows.Forms.TextBox()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomersName
        '
        Me.txtCustomersName.Location = New System.Drawing.Point(310, 23)
        Me.txtCustomersName.Name = "txtCustomersName"
        Me.txtCustomersName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomersName.TabIndex = 0
        '
        'cmbBeverage
        '
        Me.cmbBeverage.FormattingEnabled = True
        Me.cmbBeverage.Items.AddRange(New Object() {"Espresso", "Latte", "Cappuccino", "Americano ", "Mocha"})
        Me.cmbBeverage.Location = New System.Drawing.Point(310, 72)
        Me.cmbBeverage.Name = "cmbBeverage"
        Me.cmbBeverage.Size = New System.Drawing.Size(121, 21)
        Me.cmbBeverage.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(333, 109)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(310, 163)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 3
        '
        'txtFinalTotal
        '
        Me.txtFinalTotal.Location = New System.Drawing.Point(310, 209)
        Me.txtFinalTotal.Name = "txtFinalTotal"
        Me.txtFinalTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtFinalTotal.TabIndex = 4
        '
        'numQuantity
        '
        Me.numQuantity.Location = New System.Drawing.Point(456, 73)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(120, 20)
        Me.numQuantity.TabIndex = 5
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Location = New System.Drawing.Point(456, 115)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(68, 17)
        Me.chkDiscount.TabIndex = 6
        Me.chkDiscount.Text = "Discount"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chkDiscount)
        Me.Controls.Add(Me.numQuantity)
        Me.Controls.Add(Me.txtFinalTotal)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.cmbBeverage)
        Me.Controls.Add(Me.txtCustomersName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustomersName As TextBox
    Friend WithEvents cmbBeverage As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtFinalTotal As TextBox
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents chkDiscount As CheckBox
End Class
