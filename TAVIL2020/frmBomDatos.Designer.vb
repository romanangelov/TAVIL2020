﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBomDatos
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
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BLOCKS = New System.Windows.Forms.TabControl()
        Me.UNIONES = New System.Windows.Forms.TabPage()
        Me.LblTotalUniones = New System.Windows.Forms.Label()
        Me.BtnReportUnions = New System.Windows.Forms.Button()
        Me.TvUnions = New System.Windows.Forms.TreeView()
        Me.GRUPOS = New System.Windows.Forms.TabPage()
        Me.cbPLANTA = New System.Windows.Forms.CheckBox()
        Me.BtnReportSelected = New System.Windows.Forms.Button()
        Me.LblCountGroups = New System.Windows.Forms.Label()
        Me.TvGroups = New System.Windows.Forms.TreeView()
        Me.PATAS = New System.Windows.Forms.TabPage()
        Me.LblTotalPatas = New System.Windows.Forms.Label()
        Me.pb1 = New System.Windows.Forms.ProgressBar()
        Me.CbSoloPlanta = New System.Windows.Forms.CheckBox()
        Me.cbXXX = New System.Windows.Forms.CheckBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.BtnReportPatas = New System.Windows.Forms.Button()
        Me.TvPatas = New System.Windows.Forms.TreeView()
        Me.BOM = New System.Windows.Forms.TabPage()
        Me.BLOCKS.SuspendLayout()
        Me.UNIONES.SuspendLayout()
        Me.GRUPOS.SuspendLayout()
        Me.PATAS.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCerrar.Location = New System.Drawing.Point(317, 356)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(89, 28)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.Text = "Cerrar"
        '
        'BLOCKS
        '
        Me.BLOCKS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BLOCKS.Controls.Add(Me.UNIONES)
        Me.BLOCKS.Controls.Add(Me.GRUPOS)
        Me.BLOCKS.Controls.Add(Me.PATAS)
        Me.BLOCKS.Controls.Add(Me.BOM)
        Me.BLOCKS.Location = New System.Drawing.Point(12, 12)
        Me.BLOCKS.Name = "BLOCKS"
        Me.BLOCKS.SelectedIndex = 0
        Me.BLOCKS.Size = New System.Drawing.Size(381, 337)
        Me.BLOCKS.TabIndex = 1
        '
        'UNIONES
        '
        Me.UNIONES.Controls.Add(Me.LblTotalUniones)
        Me.UNIONES.Controls.Add(Me.BtnReportUnions)
        Me.UNIONES.Controls.Add(Me.TvUnions)
        Me.UNIONES.Location = New System.Drawing.Point(4, 25)
        Me.UNIONES.Name = "UNIONES"
        Me.UNIONES.Padding = New System.Windows.Forms.Padding(3)
        Me.UNIONES.Size = New System.Drawing.Size(373, 308)
        Me.UNIONES.TabIndex = 1
        Me.UNIONES.Text = "UNIONES"
        Me.UNIONES.UseVisualStyleBackColor = True
        '
        'LblTotalUniones
        '
        Me.LblTotalUniones.AutoSize = True
        Me.LblTotalUniones.Location = New System.Drawing.Point(149, 16)
        Me.LblTotalUniones.Name = "LblTotalUniones"
        Me.LblTotalUniones.Size = New System.Drawing.Size(113, 17)
        Me.LblTotalUniones.TabIndex = 4
        Me.LblTotalUniones.Text = "Total Unions = X"
        '
        'BtnReportUnions
        '
        Me.BtnReportUnions.Enabled = False
        Me.BtnReportUnions.Location = New System.Drawing.Point(152, 258)
        Me.BtnReportUnions.Name = "BtnReportUnions"
        Me.BtnReportUnions.Size = New System.Drawing.Size(193, 32)
        Me.BtnReportUnions.TabIndex = 3
        Me.BtnReportUnions.Text = "Report UNIONS"
        Me.BtnReportUnions.UseVisualStyleBackColor = True
        '
        'TvUnions
        '
        Me.TvUnions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TvUnions.HideSelection = False
        Me.TvUnions.Location = New System.Drawing.Point(5, 5)
        Me.TvUnions.Name = "TvUnions"
        Me.TvUnions.Size = New System.Drawing.Size(121, 296)
        Me.TvUnions.TabIndex = 1
        '
        'GRUPOS
        '
        Me.GRUPOS.Controls.Add(Me.cbPLANTA)
        Me.GRUPOS.Controls.Add(Me.BtnReportSelected)
        Me.GRUPOS.Controls.Add(Me.LblCountGroups)
        Me.GRUPOS.Controls.Add(Me.TvGroups)
        Me.GRUPOS.Location = New System.Drawing.Point(4, 25)
        Me.GRUPOS.Name = "GRUPOS"
        Me.GRUPOS.Padding = New System.Windows.Forms.Padding(3)
        Me.GRUPOS.Size = New System.Drawing.Size(373, 308)
        Me.GRUPOS.TabIndex = 0
        Me.GRUPOS.Text = "GRUPOS"
        Me.GRUPOS.UseVisualStyleBackColor = True
        '
        'cbPLANTA
        '
        Me.cbPLANTA.AutoSize = True
        Me.cbPLANTA.Checked = True
        Me.cbPLANTA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPLANTA.Location = New System.Drawing.Point(152, 51)
        Me.cbPLANTA.Name = "cbPLANTA"
        Me.cbPLANTA.Size = New System.Drawing.Size(116, 21)
        Me.cbPLANTA.TabIndex = 40
        Me.cbPLANTA.Text = "Sólo PLANTA"
        Me.cbPLANTA.UseVisualStyleBackColor = True
        '
        'BtnReportSelected
        '
        Me.BtnReportSelected.Enabled = False
        Me.BtnReportSelected.Location = New System.Drawing.Point(152, 258)
        Me.BtnReportSelected.Name = "BtnReportSelected"
        Me.BtnReportSelected.Size = New System.Drawing.Size(193, 32)
        Me.BtnReportSelected.TabIndex = 2
        Me.BtnReportSelected.Text = "Report Selected Group"
        Me.BtnReportSelected.UseVisualStyleBackColor = True
        '
        'LblCountGroups
        '
        Me.LblCountGroups.AutoSize = True
        Me.LblCountGroups.Location = New System.Drawing.Point(149, 15)
        Me.LblCountGroups.Name = "LblCountGroups"
        Me.LblCountGroups.Size = New System.Drawing.Size(133, 17)
        Me.LblCountGroups.TabIndex = 1
        Me.LblCountGroups.Text = "Blocks in Group = X"
        '
        'TvGroups
        '
        Me.TvGroups.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TvGroups.HideSelection = False
        Me.TvGroups.Location = New System.Drawing.Point(5, 5)
        Me.TvGroups.Name = "TvGroups"
        Me.TvGroups.Size = New System.Drawing.Size(121, 296)
        Me.TvGroups.TabIndex = 0
        '
        'PATAS
        '
        Me.PATAS.Controls.Add(Me.LblTotalPatas)
        Me.PATAS.Controls.Add(Me.pb1)
        Me.PATAS.Controls.Add(Me.CbSoloPlanta)
        Me.PATAS.Controls.Add(Me.cbXXX)
        Me.PATAS.Controls.Add(Me.btnActualizar)
        Me.PATAS.Controls.Add(Me.BtnReportPatas)
        Me.PATAS.Controls.Add(Me.TvPatas)
        Me.PATAS.Location = New System.Drawing.Point(4, 25)
        Me.PATAS.Name = "PATAS"
        Me.PATAS.Padding = New System.Windows.Forms.Padding(3)
        Me.PATAS.Size = New System.Drawing.Size(373, 308)
        Me.PATAS.TabIndex = 2
        Me.PATAS.Text = "PATAS"
        Me.PATAS.UseVisualStyleBackColor = True
        '
        'LblTotalPatas
        '
        Me.LblTotalPatas.AutoSize = True
        Me.LblTotalPatas.Location = New System.Drawing.Point(149, 14)
        Me.LblTotalPatas.Name = "LblTotalPatas"
        Me.LblTotalPatas.Size = New System.Drawing.Size(105, 17)
        Me.LblTotalPatas.TabIndex = 48
        Me.LblTotalPatas.Text = "Total Patas = X"
        '
        'pb1
        '
        Me.pb1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb1.Location = New System.Drawing.Point(152, 144)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(189, 18)
        Me.pb1.TabIndex = 47
        Me.pb1.Visible = False
        '
        'CbSoloPlanta
        '
        Me.CbSoloPlanta.AutoSize = True
        Me.CbSoloPlanta.Checked = True
        Me.CbSoloPlanta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbSoloPlanta.Location = New System.Drawing.Point(152, 77)
        Me.CbSoloPlanta.Name = "CbSoloPlanta"
        Me.CbSoloPlanta.Size = New System.Drawing.Size(116, 21)
        Me.CbSoloPlanta.TabIndex = 46
        Me.CbSoloPlanta.Text = "Sólo PLANTA"
        Me.CbSoloPlanta.UseVisualStyleBackColor = True
        '
        'cbXXX
        '
        Me.cbXXX.AutoSize = True
        Me.cbXXX.Checked = True
        Me.cbXXX.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbXXX.Location = New System.Drawing.Point(152, 50)
        Me.cbXXX.Name = "cbXXX"
        Me.cbXXX.Size = New System.Drawing.Size(89, 21)
        Me.cbXXX.TabIndex = 45
        Me.cbXXX.Text = "Sólo XXX"
        Me.cbXXX.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Red
        Me.btnActualizar.Location = New System.Drawing.Point(152, 114)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(128, 24)
        Me.btnActualizar.TabIndex = 44
        Me.btnActualizar.Text = "Actualizar Lista"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'BtnReportPatas
        '
        Me.BtnReportPatas.Enabled = False
        Me.BtnReportPatas.Location = New System.Drawing.Point(152, 258)
        Me.BtnReportPatas.Name = "BtnReportPatas"
        Me.BtnReportPatas.Size = New System.Drawing.Size(193, 32)
        Me.BtnReportPatas.TabIndex = 43
        Me.BtnReportPatas.Text = "Report PATAS"
        Me.BtnReportPatas.UseVisualStyleBackColor = True
        '
        'TvPatas
        '
        Me.TvPatas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TvPatas.HideSelection = False
        Me.TvPatas.Location = New System.Drawing.Point(5, 5)
        Me.TvPatas.Name = "TvPatas"
        Me.TvPatas.Size = New System.Drawing.Size(121, 296)
        Me.TvPatas.TabIndex = 41
        '
        'BOM
        '
        Me.BOM.Location = New System.Drawing.Point(4, 25)
        Me.BOM.Name = "BOM"
        Me.BOM.Padding = New System.Windows.Forms.Padding(3)
        Me.BOM.Size = New System.Drawing.Size(373, 308)
        Me.BOM.TabIndex = 3
        Me.BOM.Text = "BOM (Bill Of Material)"
        Me.BOM.UseVisualStyleBackColor = True
        '
        'frmBomDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCerrar
        Me.ClientSize = New System.Drawing.Size(409, 388)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BLOCKS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBomDatos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reports TAVIL"
        Me.BLOCKS.ResumeLayout(False)
        Me.UNIONES.ResumeLayout(False)
        Me.UNIONES.PerformLayout()
        Me.GRUPOS.ResumeLayout(False)
        Me.GRUPOS.PerformLayout()
        Me.PATAS.ResumeLayout(False)
        Me.PATAS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BLOCKS As Windows.Forms.TabControl
    Friend WithEvents GRUPOS As Windows.Forms.TabPage
    Friend WithEvents TvGroups As Windows.Forms.TreeView
    Friend WithEvents UNIONES As Windows.Forms.TabPage
    Friend WithEvents LblCountGroups As Windows.Forms.Label
    Friend WithEvents BtnReportSelected As Windows.Forms.Button
    Friend WithEvents BtnReportUnions As Windows.Forms.Button
    Friend WithEvents TvUnions As Windows.Forms.TreeView
    Friend WithEvents LblTotalUniones As Windows.Forms.Label
    Friend WithEvents cbPLANTA As Windows.Forms.CheckBox
    Friend WithEvents PATAS As Windows.Forms.TabPage
    Friend WithEvents BOM As Windows.Forms.TabPage
    Friend WithEvents BtnReportPatas As Windows.Forms.Button
    Friend WithEvents TvPatas As Windows.Forms.TreeView
    Friend WithEvents CbSoloPlanta As Windows.Forms.CheckBox
    Friend WithEvents cbXXX As Windows.Forms.CheckBox
    Friend WithEvents btnActualizar As Windows.Forms.Button
    Friend WithEvents pb1 As Windows.Forms.ProgressBar
    Friend WithEvents LblTotalPatas As Windows.Forms.Label
End Class
