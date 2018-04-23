using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;

namespace LineBetweenRows
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Data.DataSet dataSet1;
		private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn1;
        private IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(488, 282);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Table1";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colColumn1
            // 
            this.colColumn1.Caption = "Column1";
            this.colColumn1.FieldName = "Column1";
            this.colColumn1.Name = "colColumn1";
            this.colColumn1.Visible = true;
            this.colColumn1.VisibleIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 282);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(349, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(120, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Drag Me";
            this.simpleButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simpleButton1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(488, 282);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{            
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			FillTable(dataTable1);
			SetUpGrid(gridControl1);
		}
		
		public void FillTable(DataTable table) {
			for(int i = 1; i <= 5 ; i++)
				table.Rows.Add(new object[] {"Item " + i.ToString()});
		}


		public void SetUpGrid(GridControl grid) {
			grid.AllowDrop = true;
			grid.DragOver += new DragEventHandler(grid_DragOver);
			grid.DragDrop += new DragEventHandler(grid_DragDrop);
            grid.DragLeave += new EventHandler(grid_DragLeave);
            //grid.Paint += new PaintEventHandler(grid_Paint);
            grid.PaintEx += Grid_PaintEx;
			GridView view = grid.MainView as GridView;
			view.OptionsBehavior.Editable = false;
		}

        private void Grid_PaintEx(object sender, PaintExEventArgs e) {
            if(DropTargetRowHandle < 0) return;
            GridControl grid = (GridControl)sender;
            GridView view = (GridView)grid.MainView;

            bool isBottomLine = DropTargetRowHandle == view.DataRowCount;

            GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
            GridRowInfo rowInfo = viewInfo.GetGridRowInfo(isBottomLine ? DropTargetRowHandle - 1 : DropTargetRowHandle);

            if(rowInfo == null) return;

            Point p1, p2;
            if(isBottomLine) {
                p1 = new Point(rowInfo.Bounds.Left, rowInfo.Bounds.Bottom - 1);
                p2 = new Point(rowInfo.Bounds.Right, rowInfo.Bounds.Bottom - 1);
            } else {
                p1 = new Point(rowInfo.Bounds.Left, rowInfo.Bounds.Top - 1);
                p2 = new Point(rowInfo.Bounds.Right, rowInfo.Bounds.Top - 1);
            }
            e.Cache.DrawLine(Pens.Blue, p1, p2);
        }

        int dropTargetRowHandle = -1;
        int DropTargetRowHandle {
            get { return dropTargetRowHandle; }
            set {
                dropTargetRowHandle = value;
                gridControl1.Invalidate();
            }
        }
        
        private void grid_DragOver(object sender, System.Windows.Forms.DragEventArgs e) {
            GridControl grid = (GridControl)sender;

            Point pt = new Point(e.X, e.Y);
            pt = grid.PointToClient(pt);
            GridView view = grid.GetViewAt(pt) as GridView;
            if(view == null) return;
            
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if(hitInfo.HitTest == GridHitTest.EmptyRow)
                DropTargetRowHandle = view.DataRowCount;
            else
                DropTargetRowHandle = hitInfo.RowHandle;

			if(DropTargetRowHandle >= 0 && e.Data.GetDataPresent(typeof(string)))
				e.Effect = DragDropEffects.Move;
			else
				e.Effect = DragDropEffects.None;            
		}

        private void grid_Paint(object sender, PaintEventArgs e) {
            
        }

        private void grid_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            // TODO: implement drag-and-drop functionality here
            DropTargetRowHandle = -1;
        }

        private void grid_DragLeave(object sender, EventArgs e) {
            DropTargetRowHandle = -1;
        }

        private void simpleButton1_MouseMove(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left)
                simpleButton1.DoDragDrop("test", DragDropEffects.Move);
        }
    }
}
