<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONTROLES
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
        Me.CVCURSIVA = New System.Windows.Forms.CheckBox()
        Me.BoLectura = New System.Windows.Forms.RadioButton()
        Me.BoEscritura = New System.Windows.Forms.RadioButton()
        Me.BtAñadir = New System.Windows.Forms.Button()
        Me.ctdato = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.itOpcionesColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.itOpcionesSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.IsLista = New System.Windows.Forms.ListBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.itAyudaAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgcolor = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CVCURSIVA
        '
        Me.CVCURSIVA.AutoSize = True
        Me.CVCURSIVA.Location = New System.Drawing.Point(38, 134)
        Me.CVCURSIVA.Name = "CVCURSIVA"
        Me.CVCURSIVA.Size = New System.Drawing.Size(73, 17)
        Me.CVCURSIVA.TabIndex = 0
        Me.CVCURSIVA.Text = "CURSIVA"
        Me.CVCURSIVA.UseVisualStyleBackColor = True
        '
        'BoLectura
        '
        Me.BoLectura.AutoSize = True
        Me.BoLectura.Location = New System.Drawing.Point(38, 206)
        Me.BoLectura.Name = "BoLectura"
        Me.BoLectura.Size = New System.Drawing.Size(75, 17)
        Me.BoLectura.TabIndex = 1
        Me.BoLectura.Text = "LECTURA"
        Me.BoLectura.UseVisualStyleBackColor = True
        '
        'BoEscritura
        '
        Me.BoEscritura.AutoSize = True
        Me.BoEscritura.Checked = True
        Me.BoEscritura.Location = New System.Drawing.Point(38, 274)
        Me.BoEscritura.Name = "BoEscritura"
        Me.BoEscritura.Size = New System.Drawing.Size(87, 17)
        Me.BoEscritura.TabIndex = 3
        Me.BoEscritura.TabStop = True
        Me.BoEscritura.Text = "ESCRITURA"
        Me.BoEscritura.UseVisualStyleBackColor = True
        '
        'BtAñadir
        '
        Me.BtAñadir.Location = New System.Drawing.Point(109, 54)
        Me.BtAñadir.Name = "BtAñadir"
        Me.BtAñadir.Size = New System.Drawing.Size(122, 23)
        Me.BtAñadir.TabIndex = 4
        Me.BtAñadir.Text = "AÑADIR LISTA"
        Me.BtAñadir.UseVisualStyleBackColor = True
        '
        'ctdato
        '
        Me.ctdato.Enabled = False
        Me.ctdato.Location = New System.Drawing.Point(96, 398)
        Me.ctdato.Name = "ctdato"
        Me.ctdato.Size = New System.Drawing.Size(177, 20)
        Me.ctdato.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpciones, Me.mnuAyuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(672, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuOpciones
        '
        Me.mnuOpciones.Checked = True
        Me.mnuOpciones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itOpcionesColor, Me.itOpcionesSalir})
        Me.mnuOpciones.Name = "mnuOpciones"
        Me.mnuOpciones.Size = New System.Drawing.Size(69, 20)
        Me.mnuOpciones.Text = "&Opciones"
        '
        'mnuAyuda
        '
        Me.mnuAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itAyudaAcercaDe})
        Me.mnuAyuda.Name = "mnuAyuda"
        Me.mnuAyuda.Size = New System.Drawing.Size(53, 20)
        Me.mnuAyuda.Text = "Ay&uda"
        '
        'itOpcionesColor
        '
        Me.itOpcionesColor.Name = "itOpcionesColor"
        Me.itOpcionesColor.Size = New System.Drawing.Size(170, 22)
        Me.itOpcionesColor.Text = "&color caja de texto"
        '
        'itOpcionesSalir
        '
        Me.itOpcionesSalir.Name = "itOpcionesSalir"
        Me.itOpcionesSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.itOpcionesSalir.Size = New System.Drawing.Size(170, 22)
        Me.itOpcionesSalir.Text = "  &Salir"
        '
        'IsLista
        '
        Me.IsLista.FormattingEnabled = True
        Me.IsLista.Location = New System.Drawing.Point(309, 91)
        Me.IsLista.Name = "IsLista"
        Me.IsLista.Size = New System.Drawing.Size(322, 186)
        Me.IsLista.TabIndex = 7
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(183, 318)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(80, 17)
        Me.HScrollBar1.TabIndex = 8
        '
        'itAyudaAcercaDe
        '
        Me.itAyudaAcercaDe.Name = "itAyudaAcercaDe"
        Me.itAyudaAcercaDe.Size = New System.Drawing.Size(152, 22)
        Me.itAyudaAcercaDe.Text = "&Acerca de…"
        '
        'dlgcolor
        '
        Me.dlgcolor.AllowFullOpen = False
        '
        'CONTROLES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 446)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.IsLista)
        Me.Controls.Add(Me.ctdato)
        Me.Controls.Add(Me.BtAñadir)
        Me.Controls.Add(Me.BoEscritura)
        Me.Controls.Add(Me.BoLectura)
        Me.Controls.Add(Me.CVCURSIVA)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CONTROLES"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CVCURSIVA As System.Windows.Forms.CheckBox
    Friend WithEvents BoLectura As System.Windows.Forms.RadioButton
    Friend WithEvents BoEscritura As System.Windows.Forms.RadioButton
    Friend WithEvents BtAñadir As System.Windows.Forms.Button
    Friend WithEvents ctdato As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuOpciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itOpcionesColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itOpcionesSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IsLista As System.Windows.Forms.ListBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents itAyudaAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgcolor As System.Windows.Forms.ColorDialog

End Class
