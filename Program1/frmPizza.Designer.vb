<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPizza))
        Me.lblChoosePizza = New System.Windows.Forms.Label()
        Me.picThinCrust = New System.Windows.Forms.PictureBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.picDeepDish = New System.Windows.Forms.PictureBox()
        Me.btnDeepDish = New System.Windows.Forms.Button()
        Me.btnThinCrust = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChoosePizza
        '
        Me.lblChoosePizza.AutoSize = True
        Me.lblChoosePizza.Location = New System.Drawing.Point(12, 24)
        Me.lblChoosePizza.Name = "lblChoosePizza"
        Me.lblChoosePizza.Size = New System.Drawing.Size(139, 13)
        Me.lblChoosePizza.TabIndex = 2
        Me.lblChoosePizza.Text = "Please choose a pizza type:"
        '
        'picThinCrust
        '
        Me.picThinCrust.Image = CType(resources.GetObject("picThinCrust.Image"), System.Drawing.Image)
        Me.picThinCrust.Location = New System.Drawing.Point(59, 211)
        Me.picThinCrust.Name = "picThinCrust"
        Me.picThinCrust.Size = New System.Drawing.Size(119, 94)
        Me.picThinCrust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThinCrust.TabIndex = 3
        Me.picThinCrust.TabStop = False
        Me.picThinCrust.Visible = False
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(15, 322)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(163, 23)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select Pizza"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'picDeepDish
        '
        Me.picDeepDish.Image = CType(resources.GetObject("picDeepDish.Image"), System.Drawing.Image)
        Me.picDeepDish.Location = New System.Drawing.Point(59, 69)
        Me.picDeepDish.Name = "picDeepDish"
        Me.picDeepDish.Size = New System.Drawing.Size(119, 94)
        Me.picDeepDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeepDish.TabIndex = 5
        Me.picDeepDish.TabStop = False
        Me.picDeepDish.Visible = False
        '
        'btnDeepDish
        '
        Me.btnDeepDish.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeepDish.Location = New System.Drawing.Point(59, 40)
        Me.btnDeepDish.Name = "btnDeepDish"
        Me.btnDeepDish.Size = New System.Drawing.Size(99, 23)
        Me.btnDeepDish.TabIndex = 6
        Me.btnDeepDish.Text = "Deep-Dish Pizza"
        Me.btnDeepDish.UseVisualStyleBackColor = True
        '
        'btnThinCrust
        '
        Me.btnThinCrust.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThinCrust.Location = New System.Drawing.Point(59, 182)
        Me.btnThinCrust.Name = "btnThinCrust"
        Me.btnThinCrust.Size = New System.Drawing.Size(99, 23)
        Me.btnThinCrust.TabIndex = 7
        Me.btnThinCrust.Text = "Thin-Crust Pizza"
        Me.btnThinCrust.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(201, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'frmPizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 352)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnThinCrust)
        Me.Controls.Add(Me.btnDeepDish)
        Me.Controls.Add(Me.picDeepDish)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.picThinCrust)
        Me.Controls.Add(Me.lblChoosePizza)
        Me.Name = "frmPizza"
        Me.Text = "Pizza"
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChoosePizza As Label
    Friend WithEvents picThinCrust As PictureBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents picDeepDish As PictureBox
    Friend WithEvents btnDeepDish As Button
    Friend WithEvents btnThinCrust As Button
    Friend WithEvents btnExit As Button
End Class
