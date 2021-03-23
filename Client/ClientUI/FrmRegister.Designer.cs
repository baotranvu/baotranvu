namespace ClientUI
{
    partial class FrmRegister
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.User_txt = new DevExpress.XtraEditors.TextEdit();
            this.Pass_txt = new DevExpress.XtraEditors.TextEdit();
            this.Confirm_txt = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Register_btn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Confirm_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.User_txt);
            this.layoutControl1.Controls.Add(this.Pass_txt);
            this.layoutControl1.Controls.Add(this.Confirm_txt);
            this.layoutControl1.Controls.Add(this.Register_btn);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(343, 17, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(292, 271);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(292, 271);
            this.Root.TextVisible = false;
            // 
            // User_txt
            // 
            this.User_txt.Location = new System.Drawing.Point(12, 28);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(268, 20);
            this.User_txt.StyleController = this.layoutControl1;
            this.User_txt.TabIndex = 4;
            // 
            // Pass_txt
            // 
            this.Pass_txt.Location = new System.Drawing.Point(12, 78);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.Properties.UseSystemPasswordChar = true;
            this.Pass_txt.Size = new System.Drawing.Size(268, 20);
            this.Pass_txt.StyleController = this.layoutControl1;
            this.Pass_txt.TabIndex = 5;
            // 
            // Confirm_txt
            // 
            this.Confirm_txt.Location = new System.Drawing.Point(12, 128);
            this.Confirm_txt.Name = "Confirm_txt";
            this.Confirm_txt.Properties.Mask.EditMask = "[a-zA-Z]+";
            this.Confirm_txt.Properties.UseSystemPasswordChar = true;
            this.Confirm_txt.Size = new System.Drawing.Size(268, 20);
            this.Confirm_txt.StyleController = this.layoutControl1;
            this.Confirm_txt.TabIndex = 6;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.User_txt;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "Address line 1:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(404, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(272, 50);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "User Name:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(90, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Pass_txt;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "Address line 2:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(404, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(272, 50);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Password:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(90, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Confirm_txt;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "City:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(404, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(272, 125);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Confirm password:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(90, 13);
            // 
            // Register_btn
            // 
            this.Register_btn.Location = new System.Drawing.Point(12, 237);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(268, 22);
            this.Register_btn.StyleController = this.layoutControl1;
            this.Register_btn.TabIndex = 7;
            this.Register_btn.Text = "Register";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Register_btn;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 225);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(272, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 271);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Confirm_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit User_txt;
        private DevExpress.XtraEditors.TextEdit Pass_txt;
        private DevExpress.XtraEditors.TextEdit Confirm_txt;
        private DevExpress.XtraEditors.SimpleButton Register_btn;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}