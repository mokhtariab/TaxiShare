namespace TaxiSharePrj
{
    partial class RecPayFrm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panel_RetDate = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_YearRD = new System.Windows.Forms.ComboBox();
            this.comboBox_DayRD = new System.Windows.Forms.ComboBox();
            this.comboBox_MonthRD = new System.Windows.Forms.ComboBox();
            this.panel_BeginDate = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_YearBD = new System.Windows.Forms.ComboBox();
            this.comboBox_DayBD = new System.Windows.Forms.ComboBox();
            this.comboBox_MonthBD = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.GridRecPay = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecPayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecPayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecPayCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetCostType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DscRecPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceRecPay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceRecPay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLRecPayBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.btn_Charche = new DevComponents.DotNetBar.ButtonX();
            this.lblDsc = new DevComponents.DotNetBar.LabelX();
            this.tBLUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLRecPayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recPayCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqCMCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retCostTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sepCostCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceRecPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscRecPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recPayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recPayTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            this.groupPanel.SuspendLayout();
            this.panel_RetDate.SuspendLayout();
            this.panel_BeginDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRecPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRecPayBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRecPayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(676, 459);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupPanel
            // 
            this.groupPanel.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel.CanvasColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel.Controls.Add(this.panel_RetDate);
            this.groupPanel.Controls.Add(this.panel_BeginDate);
            this.groupPanel.Controls.Add(this.labelX3);
            this.groupPanel.Controls.Add(this.labelX2);
            this.groupPanel.Controls.Add(this.GridRecPay);
            this.groupPanel.Controls.Add(this.cancelButton);
            this.groupPanel.Controls.Add(this.btn_Charche);
            this.groupPanel.Controls.Add(this.lblDsc);
            this.groupPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel.Location = new System.Drawing.Point(0, 1);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupPanel.Size = new System.Drawing.Size(673, 461);
            // 
            // 
            // 
            this.groupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel.Style.BackColorGradientAngle = 90;
            this.groupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderBottomWidth = 1;
            this.groupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderLeftWidth = 1;
            this.groupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderRightWidth = 1;
            this.groupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderTopWidth = 1;
            this.groupPanel.Style.CornerDiameter = 4;
            this.groupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel.TabIndex = 33;
            this.groupPanel.Text = "وضعیت دریافت و پرداخت";
            // 
            // panel_RetDate
            // 
            this.panel_RetDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_RetDate.BackColor = System.Drawing.Color.Transparent;
            this.panel_RetDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_RetDate.Controls.Add(this.label1);
            this.panel_RetDate.Controls.Add(this.label4);
            this.panel_RetDate.Controls.Add(this.comboBox_YearRD);
            this.panel_RetDate.Controls.Add(this.comboBox_DayRD);
            this.panel_RetDate.Controls.Add(this.comboBox_MonthRD);
            this.panel_RetDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel_RetDate.Location = new System.Drawing.Point(53, 319);
            this.panel_RetDate.Name = "panel_RetDate";
            this.panel_RetDate.Size = new System.Drawing.Size(173, 28);
            this.panel_RetDate.TabIndex = 36;
            this.panel_RetDate.Leave += new System.EventHandler(this.panel_RetDate_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(115, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "/";
            // 
            // comboBox_YearRD
            // 
            this.comboBox_YearRD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_YearRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_YearRD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_YearRD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_YearRD.IntegralHeight = false;
            this.comboBox_YearRD.Items.AddRange(new object[] {
            "1320",
            "1321",
            "1322",
            "1323",
            "1324",
            "1325",
            "1326",
            "1327",
            "1328",
            "1329",
            "1330",
            "1331",
            "1332",
            "1333",
            "1334",
            "1335",
            "1336",
            "1337",
            "1338",
            "1339",
            "1340",
            "1341",
            "1342",
            "1343",
            "1344",
            "1345",
            "1346",
            "1347",
            "1348",
            "1349",
            "1350",
            "1351",
            "1352",
            "1353",
            "1354",
            "1355",
            "1356",
            "1357",
            "1358",
            "1359",
            "1360",
            "1361",
            "1362",
            "1363",
            "1364",
            "1365",
            "1366",
            "1367",
            "1368",
            "1369",
            "1370",
            "1371",
            "1372",
            "1373",
            "1374",
            "1375",
            "1376",
            "1377",
            "1378",
            "1379",
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
            "1387",
            "1388",
            "1389",
            "1390",
            "1391"});
            this.comboBox_YearRD.Location = new System.Drawing.Point(3, 3);
            this.comboBox_YearRD.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_YearRD.Name = "comboBox_YearRD";
            this.comboBox_YearRD.Size = new System.Drawing.Size(60, 21);
            this.comboBox_YearRD.TabIndex = 2;
            // 
            // comboBox_DayRD
            // 
            this.comboBox_DayRD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DayRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_DayRD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_DayRD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_DayRD.IntegralHeight = false;
            this.comboBox_DayRD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_DayRD.Location = new System.Drawing.Point(128, 3);
            this.comboBox_DayRD.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_DayRD.Name = "comboBox_DayRD";
            this.comboBox_DayRD.Size = new System.Drawing.Size(39, 21);
            this.comboBox_DayRD.TabIndex = 0;
            // 
            // comboBox_MonthRD
            // 
            this.comboBox_MonthRD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MonthRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_MonthRD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_MonthRD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_MonthRD.IntegralHeight = false;
            this.comboBox_MonthRD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_MonthRD.Location = new System.Drawing.Point(74, 3);
            this.comboBox_MonthRD.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_MonthRD.Name = "comboBox_MonthRD";
            this.comboBox_MonthRD.Size = new System.Drawing.Size(40, 21);
            this.comboBox_MonthRD.TabIndex = 1;
            // 
            // panel_BeginDate
            // 
            this.panel_BeginDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_BeginDate.BackColor = System.Drawing.Color.Transparent;
            this.panel_BeginDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_BeginDate.Controls.Add(this.label2);
            this.panel_BeginDate.Controls.Add(this.label3);
            this.panel_BeginDate.Controls.Add(this.comboBox_YearBD);
            this.panel_BeginDate.Controls.Add(this.comboBox_DayBD);
            this.panel_BeginDate.Controls.Add(this.comboBox_MonthBD);
            this.panel_BeginDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel_BeginDate.Location = new System.Drawing.Point(366, 319);
            this.panel_BeginDate.Name = "panel_BeginDate";
            this.panel_BeginDate.Size = new System.Drawing.Size(173, 28);
            this.panel_BeginDate.TabIndex = 35;
            this.panel_BeginDate.Leave += new System.EventHandler(this.panel_BeginDate_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(115, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "/";
            // 
            // comboBox_YearBD
            // 
            this.comboBox_YearBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_YearBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_YearBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_YearBD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_YearBD.IntegralHeight = false;
            this.comboBox_YearBD.Items.AddRange(new object[] {
            "1320",
            "1321",
            "1322",
            "1323",
            "1324",
            "1325",
            "1326",
            "1327",
            "1328",
            "1329",
            "1330",
            "1331",
            "1332",
            "1333",
            "1334",
            "1335",
            "1336",
            "1337",
            "1338",
            "1339",
            "1340",
            "1341",
            "1342",
            "1343",
            "1344",
            "1345",
            "1346",
            "1347",
            "1348",
            "1349",
            "1350",
            "1351",
            "1352",
            "1353",
            "1354",
            "1355",
            "1356",
            "1357",
            "1358",
            "1359",
            "1360",
            "1361",
            "1362",
            "1363",
            "1364",
            "1365",
            "1366",
            "1367",
            "1368",
            "1369",
            "1370",
            "1371",
            "1372",
            "1373",
            "1374",
            "1375",
            "1376",
            "1377",
            "1378",
            "1379",
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
            "1387",
            "1388",
            "1389",
            "1390",
            "1391"});
            this.comboBox_YearBD.Location = new System.Drawing.Point(3, 3);
            this.comboBox_YearBD.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_YearBD.Name = "comboBox_YearBD";
            this.comboBox_YearBD.Size = new System.Drawing.Size(60, 21);
            this.comboBox_YearBD.TabIndex = 2;
            // 
            // comboBox_DayBD
            // 
            this.comboBox_DayBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DayBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_DayBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_DayBD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_DayBD.IntegralHeight = false;
            this.comboBox_DayBD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_DayBD.Location = new System.Drawing.Point(128, 3);
            this.comboBox_DayBD.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_DayBD.Name = "comboBox_DayBD";
            this.comboBox_DayBD.Size = new System.Drawing.Size(39, 21);
            this.comboBox_DayBD.TabIndex = 0;
            // 
            // comboBox_MonthBD
            // 
            this.comboBox_MonthBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MonthBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_MonthBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_MonthBD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_MonthBD.IntegralHeight = false;
            this.comboBox_MonthBD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_MonthBD.Location = new System.Drawing.Point(74, 3);
            this.comboBox_MonthBD.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_MonthBD.Name = "comboBox_MonthBD";
            this.comboBox_MonthBD.Size = new System.Drawing.Size(40, 21);
            this.comboBox_MonthBD.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(228, 325);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(65, 20);
            this.labelX3.TabIndex = 34;
            this.labelX3.Text = "تا تاریخ:";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(545, 325);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(51, 20);
            this.labelX2.TabIndex = 34;
            this.labelX2.Text = "از تاریخ:";
            // 
            // GridRecPay
            // 
            this.GridRecPay.AllowUserToAddRows = false;
            this.GridRecPay.AllowUserToDeleteRows = false;
            this.GridRecPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GridRecPay.AutoGenerateColumns = false;
            this.GridRecPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRecPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Row,
            this.RecPayDate,
            this.RecPayTime,
            this.RecPayCode,
            this.RetCostType,
            this.DscRecPay,
            this.PriceRecPay1,
            this.PriceRecPay2,
            this.ModAccount,
            this.userCodeDataGridViewTextBoxColumn,
            this.recPayCodeDataGridViewTextBoxColumn,
            this.reqCMCodeDataGridViewTextBoxColumn,
            this.reqTypeDataGridViewTextBoxColumn,
            this.retCostTypeDataGridViewTextBoxColumn,
            this.sepCostCodeDataGridViewTextBoxColumn,
            this.priceRecPayDataGridViewTextBoxColumn,
            this.modAccountDataGridViewTextBoxColumn,
            this.dscRecPayDataGridViewTextBoxColumn,
            this.recPayDateDataGridViewTextBoxColumn,
            this.recPayTimeDataGridViewTextBoxColumn});
            this.GridRecPay.DataSource = this.tBLRecPayBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridRecPay.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridRecPay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.GridRecPay.Location = new System.Drawing.Point(3, 0);
            this.GridRecPay.Name = "GridRecPay";
            this.GridRecPay.ReadOnly = true;
            this.GridRecPay.Size = new System.Drawing.Size(661, 311);
            this.GridRecPay.TabIndex = 33;
            // 
            // Row
            // 
            this.Row.FillWeight = 10F;
            this.Row.HeaderText = "ردیف";
            this.Row.Name = "Row";
            this.Row.ReadOnly = true;
            // 
            // RecPayDate
            // 
            this.RecPayDate.DataPropertyName = "RecPayDate";
            this.RecPayDate.HeaderText = "تاریخ ثبت";
            this.RecPayDate.Name = "RecPayDate";
            this.RecPayDate.ReadOnly = true;
            // 
            // RecPayTime
            // 
            this.RecPayTime.DataPropertyName = "RecPayTime";
            this.RecPayTime.HeaderText = "ساعت ثبت";
            this.RecPayTime.Name = "RecPayTime";
            this.RecPayTime.ReadOnly = true;
            // 
            // RecPayCode
            // 
            this.RecPayCode.DataPropertyName = "RecPayCode";
            this.RecPayCode.HeaderText = "کد دریافت و پرداخت";
            this.RecPayCode.Name = "RecPayCode";
            this.RecPayCode.ReadOnly = true;
            // 
            // RetCostType
            // 
            this.RetCostType.DataPropertyName = "RetCostType";
            this.RetCostType.HeaderText = "نوع تقسیم هزینه";
            this.RetCostType.Name = "RetCostType";
            this.RetCostType.ReadOnly = true;
            // 
            // DscRecPay
            // 
            this.DscRecPay.DataPropertyName = "DscRecPay";
            this.DscRecPay.HeaderText = "شرح";
            this.DscRecPay.Name = "DscRecPay";
            this.DscRecPay.ReadOnly = true;
            // 
            // PriceRecPay1
            // 
            this.PriceRecPay1.DataPropertyName = "PriceRecPay";
            this.PriceRecPay1.HeaderText = "مبلغ بدهکاری";
            this.PriceRecPay1.Name = "PriceRecPay1";
            this.PriceRecPay1.ReadOnly = true;
            // 
            // PriceRecPay2
            // 
            this.PriceRecPay2.DataPropertyName = "PriceRecPay";
            this.PriceRecPay2.HeaderText = "مبلغ بستانکاری";
            this.PriceRecPay2.Name = "PriceRecPay2";
            this.PriceRecPay2.ReadOnly = true;
            // 
            // ModAccount
            // 
            this.ModAccount.DataPropertyName = "ModAccount";
            this.ModAccount.HeaderText = "مانده";
            this.ModAccount.Name = "ModAccount";
            this.ModAccount.ReadOnly = true;
            // 
            // tBLRecPayBindingSource1
            // 
            this.tBLRecPayBindingSource1.DataSource = typeof(TaxiSharePrj.DataLinq.TBL_RecPay);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Image = global::TaxiSharePrj.Properties.Resources.Delete;
            this.cancelButton.Location = new System.Drawing.Point(57, 393);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 29);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 32;
            this.cancelButton.Text = "خروج";
            // 
            // btn_Charche
            // 
            this.btn_Charche.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Charche.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Charche.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Charche.Image = global::TaxiSharePrj.Properties.Resources.NewInvoice;
            this.btn_Charche.Location = new System.Drawing.Point(249, 393);
            this.btn_Charche.Name = "btn_Charche";
            this.btn_Charche.Size = new System.Drawing.Size(389, 29);
            this.btn_Charche.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Charche.TabIndex = 3;
            this.btn_Charche.Text = "شارژ حساب";
            this.btn_Charche.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lblDsc
            // 
            this.lblDsc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDsc.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDsc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDsc.Location = new System.Drawing.Point(145, 364);
            this.lblDsc.Name = "lblDsc";
            this.lblDsc.Size = new System.Drawing.Size(389, 23);
            this.lblDsc.TabIndex = 1;
            this.lblDsc.Text = "درج شماره حساب ها جهت واریز";
            // 
            // tBLUserBindingSource
            // 
            this.tBLUserBindingSource.DataSource = typeof(TaxiSharePrj.DataLinq.TBL_User);
            // 
            // tBLRecPayBindingSource
            // 
            this.tBLRecPayBindingSource.DataSource = typeof(TaxiSharePrj.DataLinq.TBL_RecPay);
            // 
            // userCodeDataGridViewTextBoxColumn
            // 
            this.userCodeDataGridViewTextBoxColumn.DataPropertyName = "UserCode";
            this.userCodeDataGridViewTextBoxColumn.HeaderText = "UserCode";
            this.userCodeDataGridViewTextBoxColumn.Name = "userCodeDataGridViewTextBoxColumn";
            this.userCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recPayCodeDataGridViewTextBoxColumn
            // 
            this.recPayCodeDataGridViewTextBoxColumn.DataPropertyName = "RecPayCode";
            this.recPayCodeDataGridViewTextBoxColumn.HeaderText = "RecPayCode";
            this.recPayCodeDataGridViewTextBoxColumn.Name = "recPayCodeDataGridViewTextBoxColumn";
            this.recPayCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reqCMCodeDataGridViewTextBoxColumn
            // 
            this.reqCMCodeDataGridViewTextBoxColumn.DataPropertyName = "ReqCMCode";
            this.reqCMCodeDataGridViewTextBoxColumn.HeaderText = "ReqCMCode";
            this.reqCMCodeDataGridViewTextBoxColumn.Name = "reqCMCodeDataGridViewTextBoxColumn";
            this.reqCMCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reqTypeDataGridViewTextBoxColumn
            // 
            this.reqTypeDataGridViewTextBoxColumn.DataPropertyName = "ReqType";
            this.reqTypeDataGridViewTextBoxColumn.HeaderText = "ReqType";
            this.reqTypeDataGridViewTextBoxColumn.Name = "reqTypeDataGridViewTextBoxColumn";
            this.reqTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // retCostTypeDataGridViewTextBoxColumn
            // 
            this.retCostTypeDataGridViewTextBoxColumn.DataPropertyName = "RetCostType";
            this.retCostTypeDataGridViewTextBoxColumn.HeaderText = "RetCostType";
            this.retCostTypeDataGridViewTextBoxColumn.Name = "retCostTypeDataGridViewTextBoxColumn";
            this.retCostTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sepCostCodeDataGridViewTextBoxColumn
            // 
            this.sepCostCodeDataGridViewTextBoxColumn.DataPropertyName = "SepCostCode";
            this.sepCostCodeDataGridViewTextBoxColumn.HeaderText = "SepCostCode";
            this.sepCostCodeDataGridViewTextBoxColumn.Name = "sepCostCodeDataGridViewTextBoxColumn";
            this.sepCostCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceRecPayDataGridViewTextBoxColumn
            // 
            this.priceRecPayDataGridViewTextBoxColumn.DataPropertyName = "PriceRecPay";
            this.priceRecPayDataGridViewTextBoxColumn.HeaderText = "PriceRecPay";
            this.priceRecPayDataGridViewTextBoxColumn.Name = "priceRecPayDataGridViewTextBoxColumn";
            this.priceRecPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modAccountDataGridViewTextBoxColumn
            // 
            this.modAccountDataGridViewTextBoxColumn.DataPropertyName = "ModAccount";
            this.modAccountDataGridViewTextBoxColumn.HeaderText = "ModAccount";
            this.modAccountDataGridViewTextBoxColumn.Name = "modAccountDataGridViewTextBoxColumn";
            this.modAccountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dscRecPayDataGridViewTextBoxColumn
            // 
            this.dscRecPayDataGridViewTextBoxColumn.DataPropertyName = "DscRecPay";
            this.dscRecPayDataGridViewTextBoxColumn.HeaderText = "DscRecPay";
            this.dscRecPayDataGridViewTextBoxColumn.Name = "dscRecPayDataGridViewTextBoxColumn";
            this.dscRecPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recPayDateDataGridViewTextBoxColumn
            // 
            this.recPayDateDataGridViewTextBoxColumn.DataPropertyName = "RecPayDate";
            this.recPayDateDataGridViewTextBoxColumn.HeaderText = "RecPayDate";
            this.recPayDateDataGridViewTextBoxColumn.Name = "recPayDateDataGridViewTextBoxColumn";
            this.recPayDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recPayTimeDataGridViewTextBoxColumn
            // 
            this.recPayTimeDataGridViewTextBoxColumn.DataPropertyName = "RecPayTime";
            this.recPayTimeDataGridViewTextBoxColumn.HeaderText = "RecPayTime";
            this.recPayTimeDataGridViewTextBoxColumn.Name = "recPayTimeDataGridViewTextBoxColumn";
            this.recPayTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RecPayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "RecPayFrm";
            this.Size = new System.Drawing.Size(676, 459);
            this.Load += new System.EventHandler(this.RecPayFrm_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel.ResumeLayout(false);
            this.panel_RetDate.ResumeLayout(false);
            this.panel_RetDate.PerformLayout();
            this.panel_BeginDate.ResumeLayout(false);
            this.panel_BeginDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRecPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRecPayBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRecPayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbl_ReqCDate;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel;
        private DevComponents.DotNetBar.Controls.DataGridViewX GridRecPay;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX btn_Charche;
        private System.Windows.Forms.Panel panel_RetDate;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_YearRD;
        private System.Windows.Forms.ComboBox comboBox_DayRD;
        private System.Windows.Forms.ComboBox comboBox_MonthRD;
        private System.Windows.Forms.Panel panel_BeginDate;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_YearBD;
        private System.Windows.Forms.ComboBox comboBox_DayBD;
        private System.Windows.Forms.ComboBox comboBox_MonthBD;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblDsc;
        private System.Windows.Forms.BindingSource tBLRecPayBindingSource1;
        private System.Windows.Forms.BindingSource tBLUserBindingSource;
        private System.Windows.Forms.BindingSource tBLRecPayBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecPayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecPayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecPayCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetCostType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DscRecPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceRecPay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceRecPay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recPayCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqCMCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retCostTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sepCostCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceRecPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscRecPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recPayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recPayTimeDataGridViewTextBoxColumn;

        //public DevComponents.DotNetBar.LabelX lblCreateDate { get; set; }
    }
}
