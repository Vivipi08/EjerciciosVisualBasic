<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SISTEMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEGURIDADToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SERVICIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INVENTARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REALIZARTESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INVENTARIOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SISTEMAToolStripMenuItem, Me.SEGURIDADToolStripMenuItem, Me.SERVICIOSToolStripMenuItem, Me.INVENTARIOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(598, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SISTEMAToolStripMenuItem
        '
        Me.SISTEMAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.SISTEMAToolStripMenuItem.Font = New System.Drawing.Font("Impact", 12.0!)
        Me.SISTEMAToolStripMenuItem.Name = "SISTEMAToolStripMenuItem"
        Me.SISTEMAToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.SISTEMAToolStripMenuItem.Text = "SISTEMA"
        '
        'SEGURIDADToolStripMenuItem
        '
        Me.SEGURIDADToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambioDeContraseñaToolStripMenuItem})
        Me.SEGURIDADToolStripMenuItem.Font = New System.Drawing.Font("Impact", 12.0!)
        Me.SEGURIDADToolStripMenuItem.Name = "SEGURIDADToolStripMenuItem"
        Me.SEGURIDADToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.SEGURIDADToolStripMenuItem.Text = "SEGURIDAD"
        '
        'SERVICIOSToolStripMenuItem
        '
        Me.SERVICIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistoClienteToolStripMenuItem, Me.AxToolStripMenuItem, Me.REALIZARTESTToolStripMenuItem})
        Me.SERVICIOSToolStripMenuItem.Font = New System.Drawing.Font("Impact", 12.0!)
        Me.SERVICIOSToolStripMenuItem.Name = "SERVICIOSToolStripMenuItem"
        Me.SERVICIOSToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.SERVICIOSToolStripMenuItem.Text = "SERVICIOS"
        '
        'INVENTARIOToolStripMenuItem
        '
        Me.INVENTARIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INVENTARIOToolStripMenuItem1})
        Me.INVENTARIOToolStripMenuItem.Font = New System.Drawing.Font("Impact", 12.0!)
        Me.INVENTARIOToolStripMenuItem.Name = "INVENTARIOToolStripMenuItem"
        Me.INVENTARIOToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.INVENTARIOToolStripMenuItem.Text = "VENTAS"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.SalirToolStripMenuItem.Text = "SALIR"
        '
        'CambioDeContraseñaToolStripMenuItem
        '
        Me.CambioDeContraseñaToolStripMenuItem.Name = "CambioDeContraseñaToolStripMenuItem"
        Me.CambioDeContraseñaToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.CambioDeContraseñaToolStripMenuItem.Text = "CAMBIO DE CONTRASEÑA"
        '
        'RegistoClienteToolStripMenuItem
        '
        Me.RegistoClienteToolStripMenuItem.Name = "RegistoClienteToolStripMenuItem"
        Me.RegistoClienteToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.RegistoClienteToolStripMenuItem.Text = "REGISTRO CLIENTE"
        '
        'AxToolStripMenuItem
        '
        Me.AxToolStripMenuItem.Name = "AxToolStripMenuItem"
        Me.AxToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.AxToolStripMenuItem.Text = "ACTUALIZAR CLIENTE"
        '
        'REALIZARTESTToolStripMenuItem
        '
        Me.REALIZARTESTToolStripMenuItem.Name = "REALIZARTESTToolStripMenuItem"
        Me.REALIZARTESTToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.REALIZARTESTToolStripMenuItem.Text = "REALIZAR TEST"
        '
        'INVENTARIOToolStripMenuItem1
        '
        Me.INVENTARIOToolStripMenuItem1.Name = "INVENTARIOToolStripMenuItem1"
        Me.INVENTARIOToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.INVENTARIOToolStripMenuItem1.Text = "INVENTARIO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(72, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 257)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(598, 467)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SISTEMAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SEGURIDADToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SERVICIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INVENTARIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioDeContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REALIZARTESTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INVENTARIOToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
