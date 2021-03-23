namespace ClientUI
{
    partial class FrmMain
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.tileNavSubItem1 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.tileNavSubItem2 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.Chat_box = new System.Windows.Forms.ListBox();
            this.InputTable = new DevExpress.Utils.Layout.TablePanel();
            this.InputEdit = new System.Windows.Forms.RichTextBox();
            this.SendButton = new DevExpress.XtraEditors.SimpleButton();
            this.tileNavCategory1 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.AddImgButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.AddFileButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.IconButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.FunctileNav = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputTable)).BeginInit();
            this.InputTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FunctileNav)).BeginInit();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(556, 450);
            this.fluentDesignFormContainer1.TabIndex = 1;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Chat program";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // tileNavSubItem1
            // 
            this.tileNavSubItem1.Caption = "tileNavSubItem1";
            this.tileNavSubItem1.Name = "tileNavSubItem1";
            // 
            // 
            // 
            this.tileNavSubItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "tileNavSubItem1";
            this.tileNavSubItem1.Tile.Elements.Add(tileItemElement1);
            this.tileNavSubItem1.Tile.Name = "tileBarItem2";
            // 
            // tileNavSubItem2
            // 
            this.tileNavSubItem2.Caption = "tileNavSubItem2";
            this.tileNavSubItem2.Name = "tileNavSubItem2";
            // 
            // 
            // 
            this.tileNavSubItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "tileNavSubItem2";
            this.tileNavSubItem2.Tile.Elements.Add(tileItemElement2);
            this.tileNavSubItem2.Tile.Name = "tileBarItem3";
            // 
            // Chat_box
            // 
            this.Chat_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chat_box.FormattingEnabled = true;
            this.Chat_box.Location = new System.Drawing.Point(0, 0);
            this.Chat_box.Margin = new System.Windows.Forms.Padding(0);
            this.Chat_box.Name = "Chat_box";
            this.Chat_box.Size = new System.Drawing.Size(556, 378);
            this.Chat_box.TabIndex = 8;
            // 
            // InputTable
            // 
            this.InputTable.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 46.12F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 13.88F)});
            this.InputTable.Controls.Add(this.FunctileNav);
            this.InputTable.Controls.Add(this.SendButton);
            this.InputTable.Controls.Add(this.InputEdit);
            this.InputTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTable.Location = new System.Drawing.Point(0, 378);
            this.InputTable.Margin = new System.Windows.Forms.Padding(0);
            this.InputTable.Name = "InputTable";
            this.InputTable.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.InputTable.Size = new System.Drawing.Size(556, 72);
            this.InputTable.TabIndex = 2;
            // 
            // InputEdit
            // 
            this.InputTable.SetColumn(this.InputEdit, 0);
            this.InputEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputEdit.Location = new System.Drawing.Point(1, 27);
            this.InputEdit.Margin = new System.Windows.Forms.Padding(1);
            this.InputEdit.Name = "InputEdit";
            this.InputTable.SetRow(this.InputEdit, 1);
            this.InputEdit.Size = new System.Drawing.Size(425, 44);
            this.InputEdit.TabIndex = 0;
            this.InputEdit.Text = "";
            // 
            // SendButton
            // 
            this.InputTable.SetColumn(this.SendButton, 1);
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendButton.Location = new System.Drawing.Point(428, 27);
            this.SendButton.Margin = new System.Windows.Forms.Padding(1);
            this.SendButton.Name = "SendButton";
            this.InputTable.SetRow(this.SendButton, 1);
            this.SendButton.Size = new System.Drawing.Size(127, 44);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            // 
            // tileNavCategory1
            // 
            this.tileNavCategory1.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavCategory1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            // 
            // AddImgButton
            // 
            this.AddImgButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.AddImgButton.Caption = "Attach Image";
            this.AddImgButton.Name = "AddImgButton";
            // 
            // AddFileButton
            // 
            this.AddFileButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.AddFileButton.Caption = "Attach File";
            this.AddFileButton.Name = "AddFileButton";
            // 
            // IconButton
            // 
            this.IconButton.Caption = "Icon";
            this.IconButton.IsMain = true;
            this.IconButton.Name = "IconButton";
            // 
            // FunctileNav
            // 
            this.InputTable.SetColumn(this.FunctileNav, 0);
            this.InputTable.SetColumnSpan(this.FunctileNav, 2);
            // 
            // tileNavCategory2
            // 
            this.FunctileNav.DefaultCategory.Name = "tileNavCategory2";
            // 
            // 
            // 
            this.FunctileNav.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.FunctileNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctileNav.Location = new System.Drawing.Point(1, 1);
            this.FunctileNav.Margin = new System.Windows.Forms.Padding(1);
            this.FunctileNav.Name = "FunctileNav";
            this.InputTable.SetRow(this.FunctileNav, 0);
            this.FunctileNav.Size = new System.Drawing.Size(554, 24);
            this.FunctileNav.TabIndex = 2;
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.InputTable, 0, 1);
            this.MainTable.Controls.Add(this.Chat_box, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Size = new System.Drawing.Size(556, 450);
            this.MainTable.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.MainTable);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputTable)).EndInit();
            this.InputTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FunctileNav)).EndInit();
            this.MainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;

        private DevExpress.XtraBars.Navigation.NavButton MainSearchButton;
        private DevExpress.XtraBars.Navigation.NavButton MainExitButton;
        private DevExpress.XtraBars.Navigation.NavButton MainEditButton;
        private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem1;
        private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.ListBox Chat_box;
        private DevExpress.Utils.Layout.TablePanel InputTable;
        private DevExpress.XtraBars.Navigation.TileNavPane FunctileNav;
        private DevExpress.XtraEditors.SimpleButton SendButton;
        private System.Windows.Forms.RichTextBox InputEdit;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory1;
        private DevExpress.XtraBars.Navigation.NavButton AddImgButton;
        private DevExpress.XtraBars.Navigation.NavButton AddFileButton;
        private DevExpress.XtraBars.Navigation.NavButton IconButton;
        private System.Windows.Forms.TableLayoutPanel MainTable;
    }
}