Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace LineBetweenRows
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private dataSet1 As System.Data.DataSet
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private splitter1 As System.Windows.Forms.Splitter
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private bindingSource1 As BindingSource
		Private colColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.splitter1 = New System.Windows.Forms.Splitter()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.bindingSource1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(488, 282)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Table1"
			Me.bindingSource1.DataSource = Me.dataSet1
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colColumn1})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colColumn1
			' 
			Me.colColumn1.Caption = "Column1"
			Me.colColumn1.FieldName = "Column1"
			Me.colColumn1.Name = "colColumn1"
			Me.colColumn1.Visible = True
			Me.colColumn1.VisibleIndex = 0
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(0, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(2, 282)
			Me.splitter1.TabIndex = 2
			Me.splitter1.TabStop = False
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(349, 8)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(120, 23)
			Me.simpleButton1.TabIndex = 3
			Me.simpleButton1.Text = "Drag Me"
'			Me.simpleButton1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.simpleButton1_MouseMove);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(488, 282)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			FillTable(dataTable1)
			SetUpGrid(gridControl1)
		End Sub

		Public Sub FillTable(ByVal table As DataTable)
			For i As Integer = 1 To 5
				table.Rows.Add(New Object() {"Item " & i.ToString()})
			Next i
		End Sub


		Public Sub SetUpGrid(ByVal grid As GridControl)
			grid.AllowDrop = True
			AddHandler grid.DragOver, AddressOf grid_DragOver
			AddHandler grid.DragDrop, AddressOf grid_DragDrop
			AddHandler grid.DragLeave, AddressOf grid_DragLeave
			AddHandler grid.Paint, AddressOf grid_Paint
			Dim view As GridView = TryCast(grid.MainView, GridView)
			view.OptionsBehavior.Editable = False
		End Sub

		Private dropTargetRowHandle_Renamed As Integer = -1
		Private Property DropTargetRowHandle() As Integer
			Get
				Return dropTargetRowHandle_Renamed
			End Get
			Set(ByVal value As Integer)
				dropTargetRowHandle_Renamed = value
				gridControl1.Invalidate()
			End Set
		End Property

		Private Sub grid_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
			Dim grid As GridControl = CType(sender, GridControl)

			Dim pt As New Point(e.X, e.Y)
			pt = grid.PointToClient(pt)
			Dim view As GridView = TryCast(grid.GetViewAt(pt), GridView)
			If view Is Nothing Then
				Return
			End If

			Dim hitInfo As GridHitInfo = view.CalcHitInfo(pt)
			If hitInfo.HitTest = GridHitTest.EmptyRow Then
				DropTargetRowHandle = view.DataRowCount
			Else
				DropTargetRowHandle = hitInfo.RowHandle
			End If

			If DropTargetRowHandle >= 0 AndAlso e.Data.GetDataPresent(GetType(String)) Then
				e.Effect = DragDropEffects.Move
			Else
				e.Effect = DragDropEffects.None
			End If
		End Sub

		Private Sub grid_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
			If DropTargetRowHandle < 0 Then
				Return
			End If
			Dim grid As GridControl = CType(sender, GridControl)
			Dim view As GridView = CType(grid.MainView, GridView)

			Dim isBottomLine As Boolean = DropTargetRowHandle = view.DataRowCount

			Dim viewInfo As GridViewInfo = TryCast(view.GetViewInfo(), GridViewInfo)
			Dim rowInfo As GridRowInfo
			If isBottomLine Then
				rowInfo = viewInfo.GetGridRowInfo(DropTargetRowHandle - 1)
			Else
				rowInfo = viewInfo.GetGridRowInfo(DropTargetRowHandle)
			End If

			If rowInfo Is Nothing Then
				Return
			End If

			Dim p1, p2 As Point
			If isBottomLine Then
				p1 = New Point(rowInfo.Bounds.Left, rowInfo.Bounds.Bottom - 1)
				p2 = New Point(rowInfo.Bounds.Right, rowInfo.Bounds.Bottom - 1)
			Else
				p1 = New Point(rowInfo.Bounds.Left, rowInfo.Bounds.Top - 1)
				p2 = New Point(rowInfo.Bounds.Right, rowInfo.Bounds.Top - 1)
			End If
			e.Graphics.DrawLine(Pens.Blue, p1, p2)
		End Sub

		Private Sub grid_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
			' TODO: implement drag-and-drop functionality here
			DropTargetRowHandle = -1
		End Sub

		Private Sub grid_DragLeave(ByVal sender As Object, ByVal e As EventArgs)
			DropTargetRowHandle = -1
		End Sub

		Private Sub simpleButton1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles simpleButton1.MouseMove
			If e.Button = MouseButtons.Left Then
				simpleButton1.DoDragDrop("test", DragDropEffects.Move)
			End If
		End Sub
	End Class
End Namespace
