namespace PerfektImporter
{
    partial class Form1
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGenerateXML = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAcc = new DevExpress.XtraBars.BarButtonItem();
            this.clearFormattingItem1 = new DevExpress.XtraRichEdit.UI.ClearFormattingItem();
            this.fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            this.bbiOpenTxt = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            this.recTxt = new DevExpress.XtraRichEdit.RichEditControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tbLoadedTxtFilename = new System.Windows.Forms.TextBox();
            this.cbEncodingTxt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.recXML = new DevExpress.XtraRichEdit.RichEditControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbEncodings = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbDateFormats = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gcXmlTags = new DevExpress.XtraGrid.GridControl();
            this.gvXmlTags = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nudStartNum = new System.Windows.Forms.NumericUpDown();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rgrBuySell = new DevExpress.XtraEditors.RadioGroup();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.recDescription = new DevExpress.XtraRichEdit.RichEditControl();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            this.bwOpenTxt = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bwXml = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEncodingTxt.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEncodings.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDateFormats.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcXmlTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXmlTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgrBuySell.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiGenerateXML,
            this.bbiSaveAcc,
            this.clearFormattingItem1,
            this.fileSaveItem1,
            this.bbiOpenTxt});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemRichEditFontSizeEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(908, 144);
            // 
            // bbiGenerateXML
            // 
            this.bbiGenerateXML.Caption = "Генерирай XML";
            this.bbiGenerateXML.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiGenerateXML.Glyph = global::PerfektImporter.Properties.Resources.xml_file;
            this.bbiGenerateXML.Id = 2;
            this.bbiGenerateXML.LargeGlyph = global::PerfektImporter.Properties.Resources.xml_file;
            this.bbiGenerateXML.Name = "bbiGenerateXML";
            this.bbiGenerateXML.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGenerateXML.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGenerateXML_ItemClick);
            // 
            // bbiSaveAcc
            // 
            this.bbiSaveAcc.Caption = "Запис в ACC";
            this.bbiSaveAcc.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiSaveAcc.Id = 3;
            this.bbiSaveAcc.Name = "bbiSaveAcc";
            // 
            // clearFormattingItem1
            // 
            this.clearFormattingItem1.Id = 47;
            this.clearFormattingItem1.Name = "clearFormattingItem1";
            // 
            // fileSaveItem1
            // 
            this.fileSaveItem1.Caption = "Запис в ACC";
            this.fileSaveItem1.Id = 75;
            this.fileSaveItem1.Name = "fileSaveItem1";
            // 
            // bbiOpenTxt
            // 
            this.bbiOpenTxt.Caption = "Зареди txt";
            this.bbiOpenTxt.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiOpenTxt.Id = 1;
            this.bbiOpenTxt.LargeGlyph = global::PerfektImporter.Properties.Resources.open_file_icon;
            this.bbiOpenTxt.Name = "bbiOpenTxt";
            this.bbiOpenTxt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiOpenTxt_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Меню";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiOpenTxt);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGenerateXML);
            this.ribbonPageGroup1.ItemLinks.Add(this.fileSaveItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // repositoryItemRichEditFontSizeEdit1
            // 
            this.repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
            this.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditFontSizeEdit1.Control = this.recTxt;
            this.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
            // 
            // recTxt
            // 
            this.recTxt.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.recTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recTxt.EnableToolTips = true;
            this.recTxt.Location = new System.Drawing.Point(0, 32);
            this.recTxt.MenuManager = this.ribbonControl1;
            this.recTxt.Name = "recTxt";
            this.recTxt.ReadOnly = true;
            this.recTxt.Size = new System.Drawing.Size(902, 351);
            this.recTxt.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 144);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(908, 411);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.recTxt);
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(902, 383);
            this.xtraTabPage1.Text = "Входящ ТХТ файл";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tbLoadedTxtFilename);
            this.panelControl1.Controls.Add(this.cbEncodingTxt);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(902, 32);
            this.panelControl1.TabIndex = 1;
            // 
            // tbLoadedTxtFilename
            // 
            this.tbLoadedTxtFilename.Location = new System.Drawing.Point(253, 6);
            this.tbLoadedTxtFilename.Name = "tbLoadedTxtFilename";
            this.tbLoadedTxtFilename.ReadOnly = true;
            this.tbLoadedTxtFilename.Size = new System.Drawing.Size(631, 21);
            this.tbLoadedTxtFilename.TabIndex = 2;
            // 
            // cbEncodingTxt
            // 
            this.cbEncodingTxt.Location = new System.Drawing.Point(55, 5);
            this.cbEncodingTxt.MenuManager = this.ribbonControl1;
            this.cbEncodingTxt.Name = "cbEncodingTxt";
            this.cbEncodingTxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEncodingTxt.Size = new System.Drawing.Size(100, 20);
            this.cbEncodingTxt.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(174, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Име на файла:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Encoding";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.recXML);
            this.xtraTabPage2.Controls.Add(this.groupControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(902, 383);
            this.xtraTabPage2.Text = "Генериранe на  XML";
            // 
            // recXML
            // 
            this.recXML.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.recXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recXML.EnableToolTips = true;
            this.recXML.Location = new System.Drawing.Point(0, 175);
            this.recXML.MenuManager = this.ribbonControl1;
            this.recXML.Name = "recXML";
            this.recXML.ReadOnly = true;
            this.recXML.Size = new System.Drawing.Size(902, 208);
            this.recXML.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbEncodings);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cbDateFormats);
            this.groupControl1.Controls.Add(this.gcXmlTags);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.nudStartNum);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(902, 175);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Конфигуриране";
            // 
            // cbEncodings
            // 
            this.cbEncodings.Location = new System.Drawing.Point(248, 149);
            this.cbEncodings.MenuManager = this.ribbonControl1;
            this.cbEncodings.Name = "cbEncodings";
            this.cbEncodings.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEncodings.Size = new System.Drawing.Size(100, 20);
            this.cbEncodings.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(199, 152);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Encoding";
            // 
            // cbDateFormats
            // 
            this.cbDateFormats.EditValue = "dd/MM/yyyy";
            this.cbDateFormats.Location = new System.Drawing.Point(248, 51);
            this.cbDateFormats.MenuManager = this.ribbonControl1;
            this.cbDateFormats.Name = "cbDateFormats";
            this.cbDateFormats.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDateFormats.Properties.Items.AddRange(new object[] {
            "dd.MM.yyyy",
            "dd/MM/yyyy",
            "dd-MM-yyyy",
            "ddMMyyyy",
            "yyyy/MM/dd",
            "yyyy.MM.dd",
            "yyyy-MM-dd",
            "yyyyMMdd",
            "MM-dd-yyyy",
            "MM/dd/yyyy"});
            this.cbDateFormats.Size = new System.Drawing.Size(100, 20);
            this.cbDateFormats.TabIndex = 5;
            // 
            // gcXmlTags
            // 
            this.gcXmlTags.Location = new System.Drawing.Point(400, 24);
            this.gcXmlTags.MainView = this.gvXmlTags;
            this.gcXmlTags.MenuManager = this.ribbonControl1;
            this.gcXmlTags.Name = "gcXmlTags";
            this.gcXmlTags.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2});
            this.gcXmlTags.Size = new System.Drawing.Size(400, 145);
            this.gcXmlTags.TabIndex = 4;
            this.gcXmlTags.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvXmlTags});
            // 
            // gvXmlTags
            // 
            this.gvXmlTags.ActiveFilterEnabled = false;
            this.gvXmlTags.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvXmlTags.GridControl = this.gcXmlTags;
            this.gvXmlTags.Name = "gvXmlTags";
            this.gvXmlTags.OptionsCustomization.AllowColumnMoving = false;
            this.gvXmlTags.OptionsCustomization.AllowFilter = false;
            this.gvXmlTags.OptionsCustomization.AllowGroup = false;
            this.gvXmlTags.OptionsDetail.EnableMasterViewMode = false;
            this.gvXmlTags.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "XML таг";
            this.gridColumn1.ColumnEdit = this.repositoryItemComboBox1;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "начален индекс";
            this.gridColumn2.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "дължина";
            this.gridColumn3.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.IsFloatValue = false;
            this.repositoryItemSpinEdit2.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(161, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "формат на дата";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(161, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Начален №";
            // 
            // nudStartNum
            // 
            this.nudStartNum.Location = new System.Drawing.Point(248, 24);
            this.nudStartNum.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudStartNum.Name = "nudStartNum";
            this.nudStartNum.Size = new System.Drawing.Size(100, 21);
            this.nudStartNum.TabIndex = 1;
            this.nudStartNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudStartNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rgrBuySell);
            this.groupControl2.Location = new System.Drawing.Point(11, 24);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(121, 79);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Вид";
            // 
            // rgrBuySell
            // 
            this.rgrBuySell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgrBuySell.Location = new System.Drawing.Point(2, 21);
            this.rgrBuySell.MenuManager = this.ribbonControl1;
            this.rgrBuySell.Name = "rgrBuySell";
            this.rgrBuySell.Size = new System.Drawing.Size(117, 56);
            this.rgrBuySell.TabIndex = 3;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.recDescription);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(902, 383);
            this.xtraTabPage3.Text = "Описание";
            // 
            // recDescription
            // 
            this.recDescription.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.recDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recDescription.EnableToolTips = true;
            this.recDescription.Location = new System.Drawing.Point(0, 0);
            this.recDescription.MenuManager = this.ribbonControl1;
            this.recDescription.Name = "recDescription";
            this.recDescription.ReadOnly = true;
            this.recDescription.Size = new System.Drawing.Size(902, 383);
            this.recDescription.TabIndex = 1;
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.clearFormattingItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveItem1);
            this.richEditBarController1.Control = this.recTxt;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 555);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Perfekt Importer";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEncodingTxt.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEncodings.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDateFormats.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcXmlTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXmlTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgrBuySell.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiGenerateXML;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAcc;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraRichEdit.RichEditControl recTxt;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraRichEdit.UI.ClearFormattingItem clearFormattingItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;
        private DevExpress.XtraRichEdit.RichEditControl recXML;
        private DevExpress.XtraRichEdit.RichEditControl recDescription;
        private DevExpress.XtraEditors.RadioGroup rgrBuySell;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.NumericUpDown nudStartNum;
        private DevExpress.XtraGrid.GridControl gcXmlTags;
        private DevExpress.XtraGrid.Views.Grid.GridView gvXmlTags;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbDateFormats;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox tbLoadedTxtFilename;
        private DevExpress.XtraEditors.ComboBoxEdit cbEncodingTxt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbEncodings;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraBars.BarButtonItem bbiOpenTxt;
        private System.ComponentModel.BackgroundWorker bwOpenTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker bwXml;
    }
}

