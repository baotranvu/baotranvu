namespace ServerUI
{
    partial class serverUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverUI));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.client_grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FuncBar = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.ShutDown_btn = new DevExpress.XtraBars.Navigation.NavButton();
            this.Start_btn = new DevExpress.XtraBars.Navigation.NavButton();
            this.Close_btn = new DevExpress.XtraBars.Navigation.NavButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Status = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.log_box = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.31045F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.68955F));
            this.tableLayoutPanel1.Controls.Add(this.client_grid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.FuncBar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.log_box, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(641, 404);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // client_grid
            // 
            this.client_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.client_grid.Location = new System.Drawing.Point(392, 20);
            this.client_grid.MainView = this.gridView1;
            this.client_grid.Margin = new System.Windows.Forms.Padding(0);
            this.client_grid.Name = "client_grid";
            this.client_grid.Size = new System.Drawing.Size(249, 384);
            this.client_grid.TabIndex = 2;
            this.client_grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NameCol});
            this.gridView1.GridControl = this.client_grid;
            this.gridView1.Name = "gridView1";
            // 
            // NameCol
            // 
            this.NameCol.FieldName = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.Visible = true;
            this.NameCol.VisibleIndex = 0;
            this.NameCol.Width = 111;
            // 
            // FuncBar
            // 
            this.FuncBar.Buttons.Add(this.ShutDown_btn);
            this.FuncBar.Buttons.Add(this.Start_btn);
            this.FuncBar.Buttons.Add(this.Close_btn);
            // 
            // tileNavCategory1
            // 
            this.FuncBar.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.FuncBar.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.FuncBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FuncBar.Location = new System.Drawing.Point(392, 0);
            this.FuncBar.Margin = new System.Windows.Forms.Padding(0);
            this.FuncBar.Name = "FuncBar";
            this.FuncBar.Size = new System.Drawing.Size(249, 20);
            this.FuncBar.TabIndex = 0;
            // 
            // ShutDown_btn
            // 
            this.ShutDown_btn.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.ShutDown_btn.Caption = "Shut Down";
            this.ShutDown_btn.Name = "ShutDown_btn";
            // 
            // Start_btn
            // 
            this.Start_btn.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.Start_btn.Caption = "Start";
            this.Start_btn.Name = "Start_btn";
            // 
            // Close_btn
            // 
            this.Close_btn.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.Close_btn.Caption = null;
            this.Close_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Close_btn.ImageOptions.Image")));
            this.Close_btn.Name = "Close_btn";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Status);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(392, 20);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Status
            // 
            this.Status.Enabled = false;
            this.Status.Location = new System.Drawing.Point(38, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(354, 20);
            this.Status.StyleController = this.layoutControl1;
            this.Status.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(392, 20);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Status;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(392, 20);
            this.layoutControlItem1.Text = "Status:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(35, 13);
            // 
            // log_box
            // 
            this.log_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_box.Enabled = false;
            this.log_box.FormattingEnabled = true;
            this.log_box.Location = new System.Drawing.Point(0, 20);
            this.log_box.Margin = new System.Windows.Forms.Padding(0);
            this.log_box.Name = "log_box";
            this.log_box.Size = new System.Drawing.Size(392, 384);
            this.log_box.TabIndex = 4;
            // 
            // serverUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 404);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "serverUI";
            this.Text = "serverUI";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.client_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl client_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.TileNavPane FuncBar;
        private DevExpress.XtraBars.Navigation.NavButton ShutDown_btn;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit Status;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.Navigation.NavButton Start_btn;
        private System.Windows.Forms.ListBox log_box;
        private DevExpress.XtraBars.Navigation.NavButton Close_btn;
        private DevExpress.XtraGrid.Columns.GridColumn NameCol;
    }
}