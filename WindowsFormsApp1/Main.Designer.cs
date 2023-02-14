namespace WindowsFormsApp1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.copy = new DevExpress.XtraBars.BarButtonItem();
            this.paste = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.view = new DevExpress.XtraBars.BarButtonItem();
            this.import = new DevExpress.XtraBars.BarButtonItem();
            this.export = new DevExpress.XtraBars.BarButtonItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbExpression = new DevExpress.XtraEditors.LabelControl();
            this.tbAnswer = new DevExpress.XtraEditors.TextEdit();
            this.clearEntry = new DevExpress.XtraEditors.SimpleButton();
            this.clear = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.squareRoot = new DevExpress.XtraEditors.SimpleButton();
            this.one = new DevExpress.XtraEditors.SimpleButton();
            this.two = new DevExpress.XtraEditors.SimpleButton();
            this.three = new DevExpress.XtraEditors.SimpleButton();
            this.four = new DevExpress.XtraEditors.SimpleButton();
            this.five = new DevExpress.XtraEditors.SimpleButton();
            this.six = new DevExpress.XtraEditors.SimpleButton();
            this.seven = new DevExpress.XtraEditors.SimpleButton();
            this.eight = new DevExpress.XtraEditors.SimpleButton();
            this.nine = new DevExpress.XtraEditors.SimpleButton();
            this.lbSign = new DevExpress.XtraEditors.SimpleButton();
            this.zero = new DevExpress.XtraEditors.SimpleButton();
            this.dot = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.equals = new DevExpress.XtraEditors.SimpleButton();
            this.plus = new DevExpress.XtraEditors.SimpleButton();
            this.minus = new DevExpress.XtraEditors.SimpleButton();
            this.multiply = new DevExpress.XtraEditors.SimpleButton();
            this.divide = new DevExpress.XtraEditors.SimpleButton();
            this.backspace = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.mrc = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.mClear = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbMemory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnswer.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(452, 31);
            this.toolbarFormControl1.TabIndex = 0;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.TitleItemLinks.Add(this.barSubItem1);
            this.toolbarFormControl1.TitleItemLinks.Add(this.barSubItem2);
            this.toolbarFormControl1.TitleItemLinks.Add(this.barSubItem3);
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            this.toolbarFormManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barSubItem2,
            this.barSubItem3,
            this.import,
            this.export,
            this.view,
            this.copy,
            this.paste});
            this.toolbarFormManager1.MaxItemId = 12;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(452, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 576);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(452, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 545);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(452, 31);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 545);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "File";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Clear";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clear_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Exit";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exit_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Edit";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "History";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Edit";
            this.barSubItem2.Id = 5;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.copy),
            new DevExpress.XtraBars.LinkPersistInfo(this.paste)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // copy
            // 
            this.copy.Caption = "Copy";
            this.copy.Id = 10;
            this.copy.Name = "copy";
            this.copy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.copy_ItemClick);
            // 
            // paste
            // 
            this.paste.Caption = "Paste";
            this.paste.Id = 11;
            this.paste.Name = "paste";
            this.paste.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.paste_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "History";
            this.barSubItem3.Id = 6;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.view),
            new DevExpress.XtraBars.LinkPersistInfo(this.import),
            new DevExpress.XtraBars.LinkPersistInfo(this.export)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // view
            // 
            this.view.Caption = "View";
            this.view.Id = 9;
            this.view.Name = "view";
            this.view.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.view_ItemClick);
            // 
            // import
            // 
            this.import.Caption = "Import";
            this.import.Id = 7;
            this.import.Name = "import";
            this.import.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.import_ItemClick);
            // 
            // export
            // 
            this.export.Caption = "Export";
            this.export.Id = 8;
            this.export.Name = "export";
            this.export.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.export_ItemClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbExpression, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbAnswer, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(142, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(310, 106);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lbExpression
            // 
            this.lbExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExpression.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpression.Appearance.Options.UseFont = true;
            this.lbExpression.Location = new System.Drawing.Point(263, 11);
            this.lbExpression.Name = "lbExpression";
            this.lbExpression.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lbExpression.Size = new System.Drawing.Size(44, 21);
            this.lbExpression.TabIndex = 0;
            this.lbExpression.Text = "blank";
            // 
            // tbAnswer
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbAnswer, 2);
            this.tbAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAnswer.Enabled = false;
            this.tbAnswer.Location = new System.Drawing.Point(3, 38);
            this.tbAnswer.MenuManager = this.toolbarFormManager1;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.tbAnswer.Properties.AllowFocused = false;
            this.tbAnswer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.tbAnswer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tbAnswer.Properties.Appearance.Options.UseBackColor = true;
            this.tbAnswer.Properties.Appearance.Options.UseFont = true;
            this.tbAnswer.Properties.Appearance.Options.UseForeColor = true;
            this.tbAnswer.Properties.Appearance.Options.UseTextOptions = true;
            this.tbAnswer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbAnswer.Properties.ReadOnly = true;
            this.tbAnswer.Properties.UseReadOnlyAppearance = false;
            this.tbAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAnswer.Size = new System.Drawing.Size(304, 54);
            this.tbAnswer.TabIndex = 1;
            this.tbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnswer_KeyDown);
            this.tbAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnswer_KeyPress);
            // 
            // clearEntry
            // 
            this.clearEntry.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.clearEntry.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntry.Appearance.ForeColor = System.Drawing.Color.White;
            this.clearEntry.Appearance.Options.UseBackColor = true;
            this.clearEntry.Appearance.Options.UseFont = true;
            this.clearEntry.Appearance.Options.UseForeColor = true;
            this.clearEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearEntry.Location = new System.Drawing.Point(76, 7);
            this.clearEntry.Margin = new System.Windows.Forms.Padding(7);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(53, 43);
            this.clearEntry.TabIndex = 1;
            this.clearEntry.Text = "CE";
            this.clearEntry.Click += new System.EventHandler(this.operator_Click);
            // 
            // clear
            // 
            this.clear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.clear.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Appearance.ForeColor = System.Drawing.Color.White;
            this.clear.Appearance.Options.UseBackColor = true;
            this.clear.Appearance.Options.UseFont = true;
            this.clear.Appearance.Options.UseForeColor = true;
            this.clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear.Location = new System.Drawing.Point(143, 7);
            this.clear.Margin = new System.Windows.Forms.Padding(7);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(78, 43);
            this.clear.TabIndex = 2;
            this.clear.Text = "C";
            this.clear.Click += new System.EventHandler(this.operator_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton5.Location = new System.Drawing.Point(7, 117);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(7);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(55, 36);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "1/x";
            this.simpleButton5.Click += new System.EventHandler(this.operator_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Appearance.Options.UseForeColor = true;
            this.simpleButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton6.Location = new System.Drawing.Point(76, 117);
            this.simpleButton6.Margin = new System.Windows.Forms.Padding(7);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(53, 36);
            this.simpleButton6.TabIndex = 5;
            this.simpleButton6.Text = "x²";
            this.simpleButton6.Click += new System.EventHandler(this.operator_Click);
            // 
            // squareRoot
            // 
            this.squareRoot.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.squareRoot.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareRoot.Appearance.ForeColor = System.Drawing.Color.White;
            this.squareRoot.Appearance.Options.UseBackColor = true;
            this.squareRoot.Appearance.Options.UseFont = true;
            this.squareRoot.Appearance.Options.UseForeColor = true;
            this.squareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squareRoot.Location = new System.Drawing.Point(143, 117);
            this.squareRoot.Margin = new System.Windows.Forms.Padding(7);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(78, 36);
            this.squareRoot.TabIndex = 6;
            this.squareRoot.Text = "²√x";
            this.squareRoot.Click += new System.EventHandler(this.operator_Click);
            // 
            // one
            // 
            this.one.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.one.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Appearance.ForeColor = System.Drawing.Color.White;
            this.one.Appearance.Options.UseBackColor = true;
            this.one.Appearance.Options.UseFont = true;
            this.one.Appearance.Options.UseForeColor = true;
            this.one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.one.Location = new System.Drawing.Point(7, 167);
            this.one.Margin = new System.Windows.Forms.Padding(7);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(55, 55);
            this.one.TabIndex = 8;
            this.one.Text = "1";
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.two.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Appearance.ForeColor = System.Drawing.Color.White;
            this.two.Appearance.Options.UseBackColor = true;
            this.two.Appearance.Options.UseFont = true;
            this.two.Appearance.Options.UseForeColor = true;
            this.two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.two.Location = new System.Drawing.Point(76, 167);
            this.two.Margin = new System.Windows.Forms.Padding(7);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(53, 55);
            this.two.TabIndex = 9;
            this.two.Text = "2";
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // three
            // 
            this.three.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.three.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Appearance.ForeColor = System.Drawing.Color.White;
            this.three.Appearance.Options.UseBackColor = true;
            this.three.Appearance.Options.UseFont = true;
            this.three.Appearance.Options.UseForeColor = true;
            this.three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.three.Location = new System.Drawing.Point(143, 167);
            this.three.Margin = new System.Windows.Forms.Padding(7);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(78, 55);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.four.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Appearance.ForeColor = System.Drawing.Color.White;
            this.four.Appearance.Options.UseBackColor = true;
            this.four.Appearance.Options.UseFont = true;
            this.four.Appearance.Options.UseForeColor = true;
            this.four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.four.Location = new System.Drawing.Point(7, 236);
            this.four.Margin = new System.Windows.Forms.Padding(7);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(55, 51);
            this.four.TabIndex = 12;
            this.four.Text = "4";
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.five.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Appearance.ForeColor = System.Drawing.Color.White;
            this.five.Appearance.Options.UseBackColor = true;
            this.five.Appearance.Options.UseFont = true;
            this.five.Appearance.Options.UseForeColor = true;
            this.five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.five.Location = new System.Drawing.Point(76, 236);
            this.five.Margin = new System.Windows.Forms.Padding(7);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(53, 51);
            this.five.TabIndex = 13;
            this.five.Text = "5";
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // six
            // 
            this.six.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.six.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Appearance.ForeColor = System.Drawing.Color.White;
            this.six.Appearance.Options.UseBackColor = true;
            this.six.Appearance.Options.UseFont = true;
            this.six.Appearance.Options.UseForeColor = true;
            this.six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.six.Location = new System.Drawing.Point(143, 236);
            this.six.Margin = new System.Windows.Forms.Padding(7);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(78, 51);
            this.six.TabIndex = 14;
            this.six.Text = "6";
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // seven
            // 
            this.seven.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.seven.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Appearance.ForeColor = System.Drawing.Color.White;
            this.seven.Appearance.Options.UseBackColor = true;
            this.seven.Appearance.Options.UseFont = true;
            this.seven.Appearance.Options.UseForeColor = true;
            this.seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seven.Location = new System.Drawing.Point(7, 301);
            this.seven.Margin = new System.Windows.Forms.Padding(7);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(55, 51);
            this.seven.TabIndex = 16;
            this.seven.Text = "7";
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.eight.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Appearance.ForeColor = System.Drawing.Color.White;
            this.eight.Appearance.Options.UseBackColor = true;
            this.eight.Appearance.Options.UseFont = true;
            this.eight.Appearance.Options.UseForeColor = true;
            this.eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eight.Location = new System.Drawing.Point(76, 301);
            this.eight.Margin = new System.Windows.Forms.Padding(7);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(53, 51);
            this.eight.TabIndex = 17;
            this.eight.Text = "8";
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // nine
            // 
            this.nine.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.nine.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Appearance.ForeColor = System.Drawing.Color.White;
            this.nine.Appearance.Options.UseBackColor = true;
            this.nine.Appearance.Options.UseFont = true;
            this.nine.Appearance.Options.UseForeColor = true;
            this.nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nine.Location = new System.Drawing.Point(143, 301);
            this.nine.Margin = new System.Windows.Forms.Padding(7);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(78, 51);
            this.nine.TabIndex = 18;
            this.nine.Text = "9";
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // lbSign
            // 
            this.lbSign.AllowFocus = false;
            this.lbSign.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.lbSign.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSign.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbSign.Appearance.Options.UseBackColor = true;
            this.lbSign.Appearance.Options.UseFont = true;
            this.lbSign.Appearance.Options.UseForeColor = true;
            this.lbSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSign.Location = new System.Drawing.Point(7, 366);
            this.lbSign.Margin = new System.Windows.Forms.Padding(7);
            this.lbSign.Name = "lbSign";
            this.lbSign.Size = new System.Drawing.Size(55, 54);
            this.lbSign.TabIndex = 20;
            this.lbSign.Text = "+/-";
            this.lbSign.Click += new System.EventHandler(this.button_Click);
            // 
            // zero
            // 
            this.zero.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.zero.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Appearance.ForeColor = System.Drawing.Color.White;
            this.zero.Appearance.Options.UseBackColor = true;
            this.zero.Appearance.Options.UseFont = true;
            this.zero.Appearance.Options.UseForeColor = true;
            this.zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zero.Location = new System.Drawing.Point(76, 366);
            this.zero.Margin = new System.Windows.Forms.Padding(7);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(53, 54);
            this.zero.TabIndex = 21;
            this.zero.Text = "0";
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // dot
            // 
            this.dot.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.dot.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Appearance.ForeColor = System.Drawing.Color.White;
            this.dot.Appearance.Options.UseBackColor = true;
            this.dot.Appearance.Options.UseFont = true;
            this.dot.Appearance.Options.UseForeColor = true;
            this.dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dot.Location = new System.Drawing.Point(143, 366);
            this.dot.Margin = new System.Windows.Forms.Padding(7);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(78, 54);
            this.dot.TabIndex = 22;
            this.dot.Text = ".";
            this.dot.Click += new System.EventHandler(this.button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Controls.Add(this.equals, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.dot, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.zero, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbSign, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.plus, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.nine, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.eight, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.seven, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.minus, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.six, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.five, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.four, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.multiply, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.three, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.two, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.one, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.divide, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.squareRoot, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.backspace, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.clear, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearEntry, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mrc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.mClear, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(142, 143);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 427);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // equals
            // 
            this.equals.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.equals.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Appearance.ForeColor = System.Drawing.Color.White;
            this.equals.Appearance.Options.UseBackColor = true;
            this.equals.Appearance.Options.UseFont = true;
            this.equals.Appearance.Options.UseForeColor = true;
            this.equals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equals.Location = new System.Drawing.Point(235, 366);
            this.equals.Margin = new System.Windows.Forms.Padding(7);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(68, 54);
            this.equals.TabIndex = 23;
            this.equals.Text = "=";
            this.equals.Click += new System.EventHandler(this.operator_Click);
            this.equals.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnswer_KeyDown);
            this.equals.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnswer_KeyPress);
            // 
            // plus
            // 
            this.plus.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.plus.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Appearance.ForeColor = System.Drawing.Color.White;
            this.plus.Appearance.Options.UseBackColor = true;
            this.plus.Appearance.Options.UseFont = true;
            this.plus.Appearance.Options.UseForeColor = true;
            this.plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus.Location = new System.Drawing.Point(235, 301);
            this.plus.Margin = new System.Windows.Forms.Padding(7);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(68, 51);
            this.plus.TabIndex = 19;
            this.plus.Text = "+";
            this.plus.Click += new System.EventHandler(this.operator_Click);
            // 
            // minus
            // 
            this.minus.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.minus.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Appearance.ForeColor = System.Drawing.Color.White;
            this.minus.Appearance.Options.UseBackColor = true;
            this.minus.Appearance.Options.UseFont = true;
            this.minus.Appearance.Options.UseForeColor = true;
            this.minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minus.Location = new System.Drawing.Point(235, 236);
            this.minus.Margin = new System.Windows.Forms.Padding(7);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(68, 51);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.Click += new System.EventHandler(this.operator_Click);
            // 
            // multiply
            // 
            this.multiply.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.multiply.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Appearance.ForeColor = System.Drawing.Color.White;
            this.multiply.Appearance.Options.UseBackColor = true;
            this.multiply.Appearance.Options.UseFont = true;
            this.multiply.Appearance.Options.UseForeColor = true;
            this.multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiply.Location = new System.Drawing.Point(235, 167);
            this.multiply.Margin = new System.Windows.Forms.Padding(7);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(68, 55);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "x";
            this.multiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // divide
            // 
            this.divide.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.divide.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Appearance.ForeColor = System.Drawing.Color.White;
            this.divide.Appearance.Options.UseBackColor = true;
            this.divide.Appearance.Options.UseFont = true;
            this.divide.Appearance.Options.UseForeColor = true;
            this.divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divide.Location = new System.Drawing.Point(235, 117);
            this.divide.Margin = new System.Windows.Forms.Padding(7);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(68, 36);
            this.divide.TabIndex = 7;
            this.divide.Text = "÷";
            this.divide.Click += new System.EventHandler(this.operator_Click);
            // 
            // backspace
            // 
            this.backspace.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.backspace.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Appearance.ForeColor = System.Drawing.Color.White;
            this.backspace.Appearance.Options.UseBackColor = true;
            this.backspace.Appearance.Options.UseFont = true;
            this.backspace.Appearance.Options.UseForeColor = true;
            this.backspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backspace.Location = new System.Drawing.Point(235, 7);
            this.backspace.Margin = new System.Windows.Forms.Padding(7);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(68, 43);
            this.backspace.TabIndex = 3;
            this.backspace.Text = "←";
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton2.Location = new System.Drawing.Point(7, 7);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(55, 43);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Ans";
            this.simpleButton2.Click += new System.EventHandler(this.button_Click);
            // 
            // mrc
            // 
            this.mrc.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.mrc.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrc.Appearance.ForeColor = System.Drawing.Color.White;
            this.mrc.Appearance.Options.UseBackColor = true;
            this.mrc.Appearance.Options.UseFont = true;
            this.mrc.Appearance.Options.UseForeColor = true;
            this.mrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mrc.Location = new System.Drawing.Point(7, 64);
            this.mrc.Margin = new System.Windows.Forms.Padding(7);
            this.mrc.Name = "mrc";
            this.mrc.Size = new System.Drawing.Size(55, 39);
            this.mrc.TabIndex = 0;
            this.mrc.Text = "MCR";
            this.mrc.Click += new System.EventHandler(this.mrc_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton4.Location = new System.Drawing.Point(76, 64);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(7);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(53, 39);
            this.simpleButton4.TabIndex = 0;
            this.simpleButton4.Text = "M+";
            this.simpleButton4.Click += new System.EventHandler(this.MPlus_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Appearance.Options.UseForeColor = true;
            this.simpleButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton7.Location = new System.Drawing.Point(143, 64);
            this.simpleButton7.Margin = new System.Windows.Forms.Padding(7);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(78, 39);
            this.simpleButton7.TabIndex = 0;
            this.simpleButton7.Text = "M-";
            this.simpleButton7.Click += new System.EventHandler(this.MLess_Click);
            // 
            // mClear
            // 
            this.mClear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.mClear.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mClear.Appearance.ForeColor = System.Drawing.Color.White;
            this.mClear.Appearance.Options.UseBackColor = true;
            this.mClear.Appearance.Options.UseFont = true;
            this.mClear.Appearance.Options.UseForeColor = true;
            this.mClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mClear.Location = new System.Drawing.Point(235, 64);
            this.mClear.Margin = new System.Windows.Forms.Padding(7);
            this.mClear.Name = "mClear";
            this.mClear.Size = new System.Drawing.Size(68, 39);
            this.mClear.TabIndex = 0;
            this.mClear.Text = "MC";
            this.mClear.Click += new System.EventHandler(this.mClear_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel3.Controls.Add(this.lbMemory, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(139, 545);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // lbMemory
            // 
            this.lbMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.lbMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemory.Enabled = false;
            this.lbMemory.ForeColor = System.Drawing.Color.White;
            this.lbMemory.FormattingEnabled = true;
            this.lbMemory.Location = new System.Drawing.Point(3, 3);
            this.lbMemory.Name = "lbMemory";
            this.lbMemory.Size = new System.Drawing.Size(133, 539);
            this.lbMemory.TabIndex = 26;
            // 
            // Main
            // 
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 576);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Calc";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnswer_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnswer_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnswer.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraEditors.LabelControl lbExpression;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton dot;
        private DevExpress.XtraEditors.SimpleButton zero;
        private DevExpress.XtraEditors.SimpleButton lbSign;
        private DevExpress.XtraEditors.SimpleButton nine;
        private DevExpress.XtraEditors.SimpleButton eight;
        private DevExpress.XtraEditors.SimpleButton seven;
        private DevExpress.XtraEditors.SimpleButton six;
        private DevExpress.XtraEditors.SimpleButton five;
        private DevExpress.XtraEditors.SimpleButton four;
        private DevExpress.XtraEditors.SimpleButton three;
        private DevExpress.XtraEditors.SimpleButton two;
        private DevExpress.XtraEditors.SimpleButton one;
        private DevExpress.XtraEditors.SimpleButton squareRoot;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton clear;
        private DevExpress.XtraEditors.SimpleButton clearEntry;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton mrc;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.TextEdit tbAnswer;
        private DevExpress.XtraEditors.SimpleButton equals;
        private DevExpress.XtraEditors.SimpleButton plus;
        private DevExpress.XtraEditors.SimpleButton minus;
        private DevExpress.XtraEditors.SimpleButton multiply;
        private DevExpress.XtraEditors.SimpleButton divide;
        private DevExpress.XtraEditors.SimpleButton backspace;
        private DevExpress.XtraEditors.SimpleButton mClear;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem import;
        private DevExpress.XtraBars.BarButtonItem export;
        private DevExpress.XtraBars.BarButtonItem view;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox lbMemory;
        private DevExpress.XtraBars.BarButtonItem copy;
        private DevExpress.XtraBars.BarButtonItem paste;
    }
}

