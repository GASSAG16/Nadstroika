namespace Analysis_of_urban_passenger_transport.Forms
{
    partial class frmEnterAndEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnterAndEdit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.MarshBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboSelectEditTransport = new System.Windows.Forms.ToolStripComboBox();
            this.tbSearchStart = new System.Windows.Forms.ToolStripTextBox();
            this.tbFindTheRoute = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.txtFeaturesOfRoute = new MetroFramework.Controls.MetroTextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtSwitchingToRoutes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEndC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEndB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEndA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cboSelectTransport = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtTypeOfFlight = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRouteNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.switchMode = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.requestRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarshBindingNavigator)).BeginInit();
            this.MarshBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            this.Panel5.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestRouteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.MarshBindingNavigator);
            this.groupBox1.Controls.Add(this.Panel5);
            this.groupBox1.Controls.Add(this.metroPanel3);
            this.groupBox1.Controls.Add(this.metroPanel2);
            this.groupBox1.Controls.Add(this.metroPanel1);
            this.groupBox1.Controls.Add(this.shapeContainer2);
            this.groupBox1.Location = new System.Drawing.Point(23, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.DisplayFocus = true;
            this.btnSave.Location = new System.Drawing.Point(728, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 52);
            this.btnSave.TabIndex = 61;
            this.metroToolTip1.SetToolTip(this.btnSave, "Нажмите для сохранения");
            this.btnSave.UseSelectable = true;
            // 
            // MarshBindingNavigator
            // 
            this.MarshBindingNavigator.AddNewItem = null;
            this.MarshBindingNavigator.AutoSize = false;
            this.MarshBindingNavigator.BindingSource = this.routeBindingSource;
            this.MarshBindingNavigator.CountItem = this.toolStripLabel1;
            this.MarshBindingNavigator.DeleteItem = null;
            this.MarshBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboSelectEditTransport,
            this.tbSearchStart,
            this.tbFindTheRoute,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripButton3,
            this.toolStripButton4});
            this.MarshBindingNavigator.Location = new System.Drawing.Point(3, 18);
            this.MarshBindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.MarshBindingNavigator.MoveLastItem = this.toolStripButton3;
            this.MarshBindingNavigator.MoveNextItem = this.toolStripButton4;
            this.MarshBindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.MarshBindingNavigator.Name = "MarshBindingNavigator";
            this.MarshBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.MarshBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MarshBindingNavigator.Size = new System.Drawing.Size(816, 48);
            this.MarshBindingNavigator.TabIndex = 30;
            this.MarshBindingNavigator.Text = "BindingNavigator1";
            this.metroToolTip1.SetToolTip(this.MarshBindingNavigator, "Активна только в режиме редактирования");
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataSource = typeof(Analysis_of_urban_passenger_transport.Route);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 45);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // cboSelectEditTransport
            // 
            this.cboSelectEditTransport.Items.AddRange(new object[] {
            "Автобус",
            "Троллейбус",
            "Трамвай"});
            this.cboSelectEditTransport.Name = "cboSelectEditTransport";
            this.cboSelectEditTransport.Size = new System.Drawing.Size(121, 48);
            // 
            // tbSearchStart
            // 
            this.tbSearchStart.Name = "tbSearchStart";
            this.tbSearchStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSearchStart.Size = new System.Drawing.Size(100, 48);
            // 
            // tbFindTheRoute
            // 
            this.tbFindTheRoute.BackColor = System.Drawing.Color.Transparent;
            this.tbFindTheRoute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbFindTheRoute.BackgroundImage")));
            this.tbFindTheRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tbFindTheRoute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbFindTheRoute.Image = ((System.Drawing.Image)(resources.GetObject("tbFindTheRoute.Image")));
            this.tbFindTheRoute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFindTheRoute.Name = "tbFindTheRoute";
            this.tbFindTheRoute.Size = new System.Drawing.Size(23, 45);
            this.tbFindTheRoute.ToolTipText = "Поиск";
            this.tbFindTheRoute.Click += new System.EventHandler(this.tbFindTheRoute_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 45);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 45);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 45);
            this.toolStripButton3.Text = "Move last";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 45);
            this.toolStripButton4.Text = "Move next";
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.White;
            this.Panel5.Controls.Add(this.txtFeaturesOfRoute);
            this.Panel5.Controls.Add(this.Label13);
            this.Panel5.Location = new System.Drawing.Point(504, 79);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(299, 382);
            this.Panel5.TabIndex = 60;
            // 
            // txtFeaturesOfRoute
            // 
            // 
            // 
            // 
            this.txtFeaturesOfRoute.CustomButton.Image = null;
            this.txtFeaturesOfRoute.CustomButton.Location = new System.Drawing.Point(-53, 1);
            this.txtFeaturesOfRoute.CustomButton.Name = "";
            this.txtFeaturesOfRoute.CustomButton.Size = new System.Drawing.Size(323, 323);
            this.txtFeaturesOfRoute.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFeaturesOfRoute.CustomButton.TabIndex = 1;
            this.txtFeaturesOfRoute.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFeaturesOfRoute.CustomButton.UseSelectable = true;
            this.txtFeaturesOfRoute.CustomButton.Visible = false;
            this.txtFeaturesOfRoute.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "FeaturesOfRoute", true));
            this.txtFeaturesOfRoute.Lines = new string[0];
            this.txtFeaturesOfRoute.Location = new System.Drawing.Point(15, 39);
            this.txtFeaturesOfRoute.MaxLength = 32767;
            this.txtFeaturesOfRoute.Multiline = true;
            this.txtFeaturesOfRoute.Name = "txtFeaturesOfRoute";
            this.txtFeaturesOfRoute.PasswordChar = '\0';
            this.txtFeaturesOfRoute.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFeaturesOfRoute.SelectedText = "";
            this.txtFeaturesOfRoute.SelectionLength = 0;
            this.txtFeaturesOfRoute.SelectionStart = 0;
            this.txtFeaturesOfRoute.ShortcutsEnabled = true;
            this.txtFeaturesOfRoute.Size = new System.Drawing.Size(271, 325);
            this.txtFeaturesOfRoute.TabIndex = 62;
            this.txtFeaturesOfRoute.UseSelectable = true;
            this.txtFeaturesOfRoute.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFeaturesOfRoute.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label13.Location = new System.Drawing.Point(45, 16);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(209, 20);
            this.Label13.TabIndex = 50;
            this.Label13.Text = "Особенности маршрута";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.Label12);
            this.metroPanel3.Controls.Add(this.txtSwitchingToRoutes);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(22, 447);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(446, 86);
            this.metroPanel3.TabIndex = 59;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label12.Location = new System.Drawing.Point(82, 17);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(250, 20);
            this.Label12.TabIndex = 48;
            this.Label12.Text = "Переключение на маршруты";
            // 
            // txtSwitchingToRoutes
            // 
            this.txtSwitchingToRoutes.BackColor = System.Drawing.Color.White;
            this.txtSwitchingToRoutes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "SwitchingToRoutes", true));
            this.txtSwitchingToRoutes.Depth = 0;
            this.txtSwitchingToRoutes.Hint = "Например 5";
            this.txtSwitchingToRoutes.Location = new System.Drawing.Point(68, 40);
            this.txtSwitchingToRoutes.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSwitchingToRoutes.Name = "txtSwitchingToRoutes";
            this.txtSwitchingToRoutes.PasswordChar = '\0';
            this.txtSwitchingToRoutes.SelectedText = "";
            this.txtSwitchingToRoutes.SelectionLength = 0;
            this.txtSwitchingToRoutes.SelectionStart = 0;
            this.txtSwitchingToRoutes.Size = new System.Drawing.Size(326, 28);
            this.txtSwitchingToRoutes.TabIndex = 55;
            this.txtSwitchingToRoutes.UseSystemPasswordChar = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Controls.Add(this.materialLabel3);
            this.metroPanel2.Controls.Add(this.materialLabel1);
            this.metroPanel2.Controls.Add(this.materialLabel2);
            this.metroPanel2.Controls.Add(this.txtEndC);
            this.metroPanel2.Controls.Add(this.txtEndB);
            this.metroPanel2.Controls.Add(this.txtEndA);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(22, 245);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(446, 164);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Укажите направления маршрута";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(31, 130);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(22, 24);
            this.materialLabel3.TabIndex = 63;
            this.materialLabel3.Text = "C";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(31, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(22, 24);
            this.materialLabel1.TabIndex = 64;
            this.materialLabel1.Text = "B";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(32, 62);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(22, 24);
            this.materialLabel2.TabIndex = 62;
            this.materialLabel2.Text = "A";
            // 
            // txtEndC
            // 
            this.txtEndC.BackColor = System.Drawing.Color.White;
            this.txtEndC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "EndC", true));
            this.txtEndC.Depth = 0;
            this.txtEndC.Hint = "Например Трубная площадь";
            this.txtEndC.Location = new System.Drawing.Point(68, 122);
            this.txtEndC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndC.Name = "txtEndC";
            this.txtEndC.PasswordChar = '\0';
            this.txtEndC.SelectedText = "";
            this.txtEndC.SelectionLength = 0;
            this.txtEndC.SelectionStart = 0;
            this.txtEndC.Size = new System.Drawing.Size(326, 28);
            this.txtEndC.TabIndex = 59;
            this.txtEndC.UseSystemPasswordChar = false;
            // 
            // txtEndB
            // 
            this.txtEndB.BackColor = System.Drawing.Color.White;
            this.txtEndB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "EndB", true));
            this.txtEndB.Depth = 0;
            this.txtEndB.Hint = "Например улица Фонвизина";
            this.txtEndB.Location = new System.Drawing.Point(68, 88);
            this.txtEndB.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndB.Name = "txtEndB";
            this.txtEndB.PasswordChar = '\0';
            this.txtEndB.SelectedText = "";
            this.txtEndB.SelectionLength = 0;
            this.txtEndB.SelectionStart = 0;
            this.txtEndB.Size = new System.Drawing.Size(326, 28);
            this.txtEndB.TabIndex = 60;
            this.txtEndB.UseSystemPasswordChar = false;
            // 
            // txtEndA
            // 
            this.txtEndA.BackColor = System.Drawing.Color.White;
            this.txtEndA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "EndA", true));
            this.txtEndA.Depth = 0;
            this.txtEndA.Hint = "Например ул. Милашенкова";
            this.txtEndA.Location = new System.Drawing.Point(68, 54);
            this.txtEndA.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndA.Name = "txtEndA";
            this.txtEndA.PasswordChar = '\0';
            this.txtEndA.SelectedText = "";
            this.txtEndA.SelectionLength = 0;
            this.txtEndA.SelectionStart = 0;
            this.txtEndA.Size = new System.Drawing.Size(326, 28);
            this.txtEndA.TabIndex = 61;
            this.txtEndA.UseSystemPasswordChar = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.cboSelectTransport);
            this.metroPanel1.Controls.Add(this.label6);
            this.metroPanel1.Controls.Add(this.label23);
            this.metroPanel1.Controls.Add(this.Label8);
            this.metroPanel1.Controls.Add(this.txtTypeOfFlight);
            this.metroPanel1.Controls.Add(this.txtRouteNumber);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(22, 79);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(446, 136);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cboSelectTransport
            // 
            this.cboSelectTransport.FormattingEnabled = true;
            this.cboSelectTransport.ItemHeight = 24;
            this.cboSelectTransport.Items.AddRange(new object[] {
            "Автобус",
            "Троллейбус",
            "Трамвай"});
            this.cboSelectTransport.Location = new System.Drawing.Point(256, 7);
            this.cboSelectTransport.Name = "cboSelectTransport";
            this.cboSelectTransport.Size = new System.Drawing.Size(121, 30);
            this.cboSelectTransport.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.cboSelectTransport, "Выберите вид транспорта");
            this.cboSelectTransport.UseSelectable = true;
            this.cboSelectTransport.SelectedIndexChanged += new System.EventHandler(this.cboSelectTransport_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(15, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Тип рейса";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(14, 55);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(227, 20);
            this.label23.TabIndex = 30;
            this.label23.Text = "Укажите номер маршрута";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label8.Location = new System.Drawing.Point(14, 17);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(222, 20);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Укажите вид транспорта";
            // 
            // txtTypeOfFlight
            // 
            this.txtTypeOfFlight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "TypeOfFlight", true));
            this.txtTypeOfFlight.Depth = 0;
            this.txtTypeOfFlight.Hint = "Например 00";
            this.txtTypeOfFlight.Location = new System.Drawing.Point(256, 85);
            this.txtTypeOfFlight.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTypeOfFlight.Name = "txtTypeOfFlight";
            this.txtTypeOfFlight.PasswordChar = '\0';
            this.txtTypeOfFlight.SelectedText = "";
            this.txtTypeOfFlight.SelectionLength = 0;
            this.txtTypeOfFlight.SelectionStart = 0;
            this.txtTypeOfFlight.Size = new System.Drawing.Size(138, 28);
            this.txtTypeOfFlight.TabIndex = 2;
            this.txtTypeOfFlight.UseSystemPasswordChar = false;
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "RouteNumber", true));
            this.txtRouteNumber.Depth = 0;
            this.txtRouteNumber.Hint = "Например 1";
            this.txtRouteNumber.Location = new System.Drawing.Point(256, 47);
            this.txtRouteNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.PasswordChar = '\0';
            this.txtRouteNumber.SelectedText = "";
            this.txtRouteNumber.SelectionLength = 0;
            this.txtRouteNumber.SelectionStart = 0;
            this.txtRouteNumber.Size = new System.Drawing.Size(138, 28);
            this.txtRouteNumber.TabIndex = 2;
            this.txtRouteNumber.UseSystemPasswordChar = false;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(816, 530);
            this.shapeContainer2.TabIndex = 1;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 19;
            this.lineShape3.X2 = 474;
            this.lineShape3.Y1 = 410;
            this.lineShape3.Y2 = 410;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 19;
            this.lineShape2.X2 = 474;
            this.lineShape2.Y1 = 210;
            this.lineShape2.Y2 = 210;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 455;
            this.lineShape1.Y1 = 18;
            this.lineShape1.Y2 = 18;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(825, 616);
            this.shapeContainer1.TabIndex = 24;
            this.shapeContainer1.TabStop = false;
            // 
            // switchMode
            // 
            this.switchMode.AutoSize = true;
            this.switchMode.Checked = true;
            this.switchMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.switchMode.Location = new System.Drawing.Point(396, 97);
            this.switchMode.Name = "switchMode";
            this.switchMode.Size = new System.Drawing.Size(80, 21);
            this.switchMode.TabIndex = 3;
            this.switchMode.Text = "On";
            this.switchMode.UseSelectable = true;
            this.switchMode.CheckedChanged += new System.EventHandler(this.switchMode_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(51, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(327, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Для редактирования, отключите добавление =>";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // requestRouteBindingSource
            // 
            this.requestRouteBindingSource.DataSource = typeof(Analysis_of_urban_passenger_transport.requestRoute);
            // 
            // frmEnterAndEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(865, 696);
            this.Controls.Add(this.switchMode);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEnterAndEdit";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Программа AOUPT => режим добавления / редактирования";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEnterAndEdit_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarshBindingNavigator)).EndInit();
            this.MarshBindingNavigator.ResumeLayout(false);
            this.MarshBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestRouteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource routeBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroToggle switchMode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRouteNumber;
        private MetroFramework.Controls.MetroComboBox cboSelectTransport;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTypeOfFlight;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEndC;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEndB;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEndA;
        internal System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        internal System.Windows.Forms.Label Label12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSwitchingToRoutes;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.BindingNavigator MarshBindingNavigator;
        internal System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboSelectEditTransport;
        internal System.Windows.Forms.ToolStripTextBox tbSearchStart;
        internal System.Windows.Forms.ToolStripButton tbFindTheRoute;
        internal System.Windows.Forms.ToolStripButton toolStripButton1;
        internal System.Windows.Forms.ToolStripButton toolStripButton2;
        internal System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        internal System.Windows.Forms.ToolStripButton toolStripButton3;
        internal System.Windows.Forms.ToolStripButton toolStripButton4;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtFeaturesOfRoute;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.BindingSource requestRouteBindingSource;
    }
}