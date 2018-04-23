Namespace DXApplication1
    Partial Public Class Main
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.lookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
            Me.gridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.searchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
            Me.searchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            DirectCast(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.searchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.searchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lookUpEdit1
            ' 
            Me.lookUpEdit1.Location = New System.Drawing.Point(364, 32)
            Me.lookUpEdit1.Name = "lookUpEdit1"
            Me.lookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpEdit1.Size = New System.Drawing.Size(298, 20)
            Me.lookUpEdit1.TabIndex = 0
            ' 
            ' gridLookUpEdit1
            ' 
            Me.gridLookUpEdit1.Location = New System.Drawing.Point(40, 32)
            Me.gridLookUpEdit1.Name = "gridLookUpEdit1"
            Me.gridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.gridLookUpEdit1.Properties.View = Me.gridLookUpEdit1View
            Me.gridLookUpEdit1.Size = New System.Drawing.Size(298, 20)
            Me.gridLookUpEdit1.TabIndex = 1
            ' 
            ' gridLookUpEdit1View
            ' 
            Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
            Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            ' 
            ' searchLookUpEdit1
            ' 
            Me.searchLookUpEdit1.Location = New System.Drawing.Point(686, 32)
            Me.searchLookUpEdit1.Name = "searchLookUpEdit1"
            Me.searchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.searchLookUpEdit1.Properties.View = Me.searchLookUpEdit1View
            Me.searchLookUpEdit1.Size = New System.Drawing.Size(298, 20)
            Me.searchLookUpEdit1.TabIndex = 2
            ' 
            ' searchLookUpEdit1View
            ' 
            Me.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.searchLookUpEdit1View.Name = "searchLookUpEdit1View"
            Me.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.searchLookUpEdit1View.OptionsView.ShowGroupPanel = False
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1039, 199)
            Me.Controls.Add(Me.searchLookUpEdit1)
            Me.Controls.Add(Me.gridLookUpEdit1)
            Me.Controls.Add(Me.lookUpEdit1)
            Me.Name = "Main"
            Me.Text = "How to create cascading lookup editors"
            DirectCast(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.searchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.searchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private lookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
        Private gridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
        Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
        Private searchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
        Private searchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

    End Class
End Namespace

