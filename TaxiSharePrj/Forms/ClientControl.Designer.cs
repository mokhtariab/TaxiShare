namespace TaxiSharePrj
{
    partial class ClientControl
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
            this.saveButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.TxtTelCust = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.TxtMobileCost = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.ReqMachine_panel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.nupdownMaxTime = new System.Windows.Forms.NumericUpDown();
            this.ComboCarName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_Samand = new DevComponents.Editors.ComboItem();
            this.comboItem_GLX = new DevComponents.Editors.ComboItem();
            this.comboItem_RD = new DevComponents.Editors.ComboItem();
            this.comboItem_Pride = new DevComponents.Editors.ComboItem();
            this.ComboPartDest = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_Dest1 = new DevComponents.Editors.ComboItem();
            this.comboItem_Dest2 = new DevComponents.Editors.ComboItem();
            this.ComboPartBeggining = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_Begin1 = new DevComponents.Editors.ComboItem();
            this.comboItem_Begin2 = new DevComponents.Editors.ComboItem();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lbl_ReqMTime = new DevComponents.DotNetBar.LabelX();
            this.lbl_ReqMDate = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.TxtReqMDSC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtServicePrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ReqMachine_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownMaxTime)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.saveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.saveButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.saveButton.Image = global::TaxiSharePrj.Properties.Resources.CheckMark;
            this.saveButton.Location = new System.Drawing.Point(118, 365);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 29);
            this.saveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "ذخیره";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cancelButton.Image = global::TaxiSharePrj.Properties.Resources.Delete;
            this.cancelButton.Location = new System.Drawing.Point(9, 365);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 29);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "انصراف";
            // 
            // TxtTelCust
            // 
            this.TxtTelCust.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtTelCust.Border.Class = "TextBoxBorder";
            this.TxtTelCust.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtTelCust.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTelCust.ForeColor = System.Drawing.Color.Black;
            this.TxtTelCust.Location = new System.Drawing.Point(34, 123);
            this.TxtTelCust.Name = "TxtTelCust";
            this.TxtTelCust.Size = new System.Drawing.Size(147, 22);
            this.TxtTelCust.TabIndex = 4;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(188, 123);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(122, 17);
            this.labelX6.TabIndex = 18;
            this.labelX6.Text = "*  شماره تلفن مشتری:";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // TxtMobileCost
            // 
            this.TxtMobileCost.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtMobileCost.Border.Class = "TextBoxBorder";
            this.TxtMobileCost.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtMobileCost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtMobileCost.ForeColor = System.Drawing.Color.Black;
            this.TxtMobileCost.Location = new System.Drawing.Point(34, 153);
            this.TxtMobileCost.Name = "TxtMobileCost";
            this.TxtMobileCost.Size = new System.Drawing.Size(147, 22);
            this.TxtMobileCost.TabIndex = 5;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(188, 153);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(130, 17);
            this.labelX7.TabIndex = 18;
            this.labelX7.Text = "*  شماره موبایل مشتری:";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(188, 183);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(96, 17);
            this.labelX8.TabIndex = 18;
            this.labelX8.Text = "*   هزینه سرویس:";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // ReqMachine_panel
            // 
            this.ReqMachine_panel.BackColor = System.Drawing.Color.Silver;
            this.ReqMachine_panel.CanvasColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReqMachine_panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.ReqMachine_panel.Controls.Add(this.nupdownMaxTime);
            this.ReqMachine_panel.Controls.Add(this.ComboCarName);
            this.ReqMachine_panel.Controls.Add(this.ComboPartDest);
            this.ReqMachine_panel.Controls.Add(this.ComboPartBeggining);
            this.ReqMachine_panel.Controls.Add(this.labelX4);
            this.ReqMachine_panel.Controls.Add(this.labelX3);
            this.ReqMachine_panel.Controls.Add(this.labelX2);
            this.ReqMachine_panel.Controls.Add(this.lbl_ReqMTime);
            this.ReqMachine_panel.Controls.Add(this.lbl_ReqMDate);
            this.ReqMachine_panel.Controls.Add(this.labelX1);
            this.ReqMachine_panel.Controls.Add(this.cancelButton);
            this.ReqMachine_panel.Controls.Add(this.labelX9);
            this.ReqMachine_panel.Controls.Add(this.labelX5);
            this.ReqMachine_panel.Controls.Add(this.labelX10);
            this.ReqMachine_panel.Controls.Add(this.labelX8);
            this.ReqMachine_panel.Controls.Add(this.labelX7);
            this.ReqMachine_panel.Controls.Add(this.labelX6);
            this.ReqMachine_panel.Controls.Add(this.TxtReqMDSC);
            this.ReqMachine_panel.Controls.Add(this.TxtServicePrice);
            this.ReqMachine_panel.Controls.Add(this.TxtMobileCost);
            this.ReqMachine_panel.Controls.Add(this.TxtTelCust);
            this.ReqMachine_panel.Controls.Add(this.saveButton);
            this.ReqMachine_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReqMachine_panel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqMachine_panel.Location = new System.Drawing.Point(0, 0);
            this.ReqMachine_panel.Name = "ReqMachine_panel";
            this.ReqMachine_panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReqMachine_panel.Size = new System.Drawing.Size(333, 429);
            // 
            // 
            // 
            this.ReqMachine_panel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.ReqMachine_panel.Style.BackColorGradientAngle = 90;
            this.ReqMachine_panel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ReqMachine_panel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ReqMachine_panel.Style.BorderBottomWidth = 1;
            this.ReqMachine_panel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ReqMachine_panel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ReqMachine_panel.Style.BorderLeftWidth = 1;
            this.ReqMachine_panel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ReqMachine_panel.Style.BorderRightWidth = 1;
            this.ReqMachine_panel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ReqMachine_panel.Style.BorderTopWidth = 1;
            this.ReqMachine_panel.Style.CornerDiameter = 4;
            this.ReqMachine_panel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ReqMachine_panel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ReqMachine_panel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.ReqMachine_panel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.ReqMachine_panel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ReqMachine_panel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ReqMachine_panel.TabIndex = 22;
            this.ReqMachine_panel.Text = "ثبت درخواست ماشین جهت مشتری";
            // 
            // nupdownMaxTime
            // 
            this.nupdownMaxTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nupdownMaxTime.Location = new System.Drawing.Point(34, 213);
            this.nupdownMaxTime.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupdownMaxTime.Name = "nupdownMaxTime";
            this.nupdownMaxTime.Size = new System.Drawing.Size(147, 22);
            this.nupdownMaxTime.TabIndex = 31;
            // 
            // ComboCarName
            // 
            this.ComboCarName.DisplayMember = "Text";
            this.ComboCarName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboCarName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ComboCarName.FormattingEnabled = true;
            this.ComboCarName.ItemHeight = 16;
            this.ComboCarName.Items.AddRange(new object[] {
            this.comboItem_Samand,
            this.comboItem_GLX,
            this.comboItem_RD,
            this.comboItem_Pride});
            this.ComboCarName.Location = new System.Drawing.Point(34, 243);
            this.ComboCarName.Name = "ComboCarName";
            this.ComboCarName.Size = new System.Drawing.Size(147, 22);
            this.ComboCarName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboCarName.TabIndex = 30;
            // 
            // comboItem_Samand
            // 
            this.comboItem_Samand.Text = "سمند";
            // 
            // comboItem_GLX
            // 
            this.comboItem_GLX.Text = "پژو GLX";
            // 
            // comboItem_RD
            // 
            this.comboItem_RD.Text = "آردی";
            // 
            // comboItem_Pride
            // 
            this.comboItem_Pride.Text = "پراید";
            // 
            // ComboPartDest
            // 
            this.ComboPartDest.DisplayMember = "Text";
            this.ComboPartDest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboPartDest.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ComboPartDest.FormattingEnabled = true;
            this.ComboPartDest.ItemHeight = 16;
            this.ComboPartDest.Items.AddRange(new object[] {
            this.comboItem_Dest1,
            this.comboItem_Dest2});
            this.ComboPartDest.Location = new System.Drawing.Point(34, 93);
            this.ComboPartDest.Name = "ComboPartDest";
            this.ComboPartDest.Size = new System.Drawing.Size(147, 22);
            this.ComboPartDest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboPartDest.TabIndex = 30;
            // 
            // comboItem_Dest1
            // 
            this.comboItem_Dest1.Text = "منطقه1";
            // 
            // comboItem_Dest2
            // 
            this.comboItem_Dest2.Text = "منطقه2";
            // 
            // ComboPartBeggining
            // 
            this.ComboPartBeggining.DisplayMember = "Text";
            this.ComboPartBeggining.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboPartBeggining.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ComboPartBeggining.ForeColor = System.Drawing.Color.Maroon;
            this.ComboPartBeggining.FormattingEnabled = true;
            this.ComboPartBeggining.ItemHeight = 16;
            this.ComboPartBeggining.Items.AddRange(new object[] {
            this.comboItem_Begin1,
            this.comboItem_Begin2});
            this.ComboPartBeggining.Location = new System.Drawing.Point(34, 63);
            this.ComboPartBeggining.Name = "ComboPartBeggining";
            this.ComboPartBeggining.Size = new System.Drawing.Size(147, 22);
            this.ComboPartBeggining.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboPartBeggining.TabIndex = 30;
            // 
            // comboItem_Begin1
            // 
            this.comboItem_Begin1.Text = "منطقه1";
            // 
            // comboItem_Begin2
            // 
            this.comboItem_Begin2.Text = "منطقه2";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(188, 93);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(49, 17);
            this.labelX4.TabIndex = 29;
            this.labelX4.Text = "*  مقصد:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(188, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(77, 17);
            this.labelX3.TabIndex = 27;
            this.labelX3.Text = "*  محل حرکت:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(188, 34);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 17);
            this.labelX2.TabIndex = 25;
            this.labelX2.Text = "ساعت:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lbl_ReqMTime
            // 
            this.lbl_ReqMTime.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_ReqMTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ReqMTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ReqMTime.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_ReqMTime.Location = new System.Drawing.Point(34, 33);
            this.lbl_ReqMTime.Name = "lbl_ReqMTime";
            this.lbl_ReqMTime.Size = new System.Drawing.Size(147, 20);
            this.lbl_ReqMTime.TabIndex = 23;
            this.lbl_ReqMTime.Text = "22:10";
            this.lbl_ReqMTime.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lbl_ReqMDate
            // 
            this.lbl_ReqMDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_ReqMDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ReqMDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ReqMDate.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_ReqMDate.Location = new System.Drawing.Point(34, 8);
            this.lbl_ReqMDate.Name = "lbl_ReqMDate";
            this.lbl_ReqMDate.Size = new System.Drawing.Size(147, 20);
            this.lbl_ReqMDate.TabIndex = 23;
            this.lbl_ReqMDate.Text = "1391/10/10";
            this.lbl_ReqMDate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(188, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(34, 17);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "تاریخ:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(188, 273);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(31, 17);
            this.labelX9.TabIndex = 18;
            this.labelX9.Text = "شرح:";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(188, 243);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(123, 17);
            this.labelX5.TabIndex = 18;
            this.labelX5.Text = "نوع خودروی درخواستی:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(188, 208);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(130, 31);
            this.labelX10.TabIndex = 18;
            this.labelX10.Text = "حداکثر زمان تا اتمام مهلت تماس با مشتری:";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX10.WordWrap = true;
            // 
            // TxtReqMDSC
            // 
            this.TxtReqMDSC.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtReqMDSC.Border.Class = "TextBoxBorder";
            this.TxtReqMDSC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtReqMDSC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtReqMDSC.ForeColor = System.Drawing.Color.Black;
            this.TxtReqMDSC.Location = new System.Drawing.Point(3, 273);
            this.TxtReqMDSC.Multiline = true;
            this.TxtReqMDSC.Name = "TxtReqMDSC";
            this.TxtReqMDSC.Size = new System.Drawing.Size(178, 73);
            this.TxtReqMDSC.TabIndex = 5;
            // 
            // TxtServicePrice
            // 
            this.TxtServicePrice.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtServicePrice.Border.Class = "TextBoxBorder";
            this.TxtServicePrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtServicePrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtServicePrice.ForeColor = System.Drawing.Color.Black;
            this.TxtServicePrice.Location = new System.Drawing.Point(34, 183);
            this.TxtServicePrice.Name = "TxtServicePrice";
            this.TxtServicePrice.Size = new System.Drawing.Size(147, 22);
            this.TxtServicePrice.TabIndex = 5;
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReqMachine_panel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ClientControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(333, 429);
            this.ReqMachine_panel.ResumeLayout(false);
            this.ReqMachine_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownMaxTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX saveButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtTelCust;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtMobileCost;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.GroupPanel ReqMachine_panel;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboPartDest;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboPartBeggining;
        private DevComponents.DotNetBar.LabelX lbl_ReqMTime;
        private DevComponents.DotNetBar.LabelX lbl_ReqMDate;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.NumericUpDown nupdownMaxTime;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboCarName;
        private DevComponents.Editors.ComboItem comboItem_Samand;
        private DevComponents.Editors.ComboItem comboItem_GLX;
        private DevComponents.Editors.ComboItem comboItem_RD;
        private DevComponents.Editors.ComboItem comboItem_Pride;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtReqMDSC;
        private DevComponents.Editors.ComboItem comboItem_Dest1;
        private DevComponents.Editors.ComboItem comboItem_Dest2;
        private DevComponents.Editors.ComboItem comboItem_Begin1;
        private DevComponents.Editors.ComboItem comboItem_Begin2;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtServicePrice;


    }
}
