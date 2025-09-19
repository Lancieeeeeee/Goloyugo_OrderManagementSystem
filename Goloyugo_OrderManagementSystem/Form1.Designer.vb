<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.comB = New System.Windows.Forms.ComboBox()
        Me.QuadM = New System.Windows.Forms.NumericUpDown()
        Me.CheckB = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblDis = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.QuadM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(448, 146)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(121, 20)
        Me.txtBox.TabIndex = 0
        '
        'comB
        '
        Me.comB.FormattingEnabled = True
        Me.comB.Items.AddRange(New Object() {"Espresso", "Latte", "Cappuccino", "Americano", "Mocha"})
        Me.comB.Location = New System.Drawing.Point(448, 172)
        Me.comB.Name = "comB"
        Me.comB.Size = New System.Drawing.Size(121, 21)
        Me.comB.TabIndex = 1
        '
        'QuadM
        '
        Me.QuadM.Location = New System.Drawing.Point(448, 211)
        Me.QuadM.Name = "QuadM"
        Me.QuadM.Size = New System.Drawing.Size(120, 20)
        Me.QuadM.TabIndex = 2
        '
        'CheckB
        '
        Me.CheckB.AutoSize = True
        Me.CheckB.Location = New System.Drawing.Point(436, 246)
        Me.CheckB.Name = "CheckB"
        Me.CheckB.Size = New System.Drawing.Size(133, 17)
        Me.CheckB.TabIndex = 3
        Me.CheckB.Text = "Apply Loyalty Discount"
        Me.CheckB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select a Beverage:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Place Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quantity:"
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Location = New System.Drawing.Point(479, 327)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(49, 13)
        Me.lblSub.TabIndex = 7
        Me.lblSub.Text = "Subtotal:"
        '
        'lblDis
        '
        Me.lblDis.AutoSize = True
        Me.lblDis.Location = New System.Drawing.Point(479, 360)
        Me.lblDis.Name = "lblDis"
        Me.lblDis.Size = New System.Drawing.Size(52, 13)
        Me.lblDis.TabIndex = 8
        Me.lblDis.Text = "Discount:"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(472, 390)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(59, 13)
        Me.lblFinal.TabIndex = 9
        Me.lblFinal.Text = "Final Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(357, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Customer Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 572)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblDis)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckB)
        Me.Controls.Add(Me.QuadM)
        Me.Controls.Add(Me.comB)
        Me.Controls.Add(Me.txtBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.QuadM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox As TextBox
    Friend WithEvents comB As ComboBox
    Friend WithEvents QuadM As NumericUpDown
    Friend WithEvents CheckB As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents lblDis As Label
    Friend WithEvents lblFinal As Label
    Friend WithEvents Label6 As Label
End Class
