namespace Analysis_of_urban_passenger_transport.Forms
{
    partial class frmViewmode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewmode));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnInformation = new MetroFramework.Controls.MetroButton();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtTypeOfFlight = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRouteNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEndC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEndB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEndA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Label6 = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.BindingNavigator(this.components);
            this.cboSelectModeTransport = new System.Windows.Forms.ToolStripComboBox();
            this.tbSearchStart = new System.Windows.Forms.ToolStripTextBox();
            this.tbFindTheRoute = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtFeaturesOfRoute = new System.Windows.Forms.TextBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtSwitchingToRoutes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MarshBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).BeginInit();
            this.Panel5.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarshBindingNavigator)).BeginInit();
            this.MarshBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(794, 499);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 455;
            this.lineShape1.Y1 = 18;
            this.lineShape1.Y2 = 18;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Location = new System.Drawing.Point(10, 109);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 56);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.btnEdit, "Внесение и редактирование");
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrint.Location = new System.Drawing.Point(10, 171);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(66, 63);
            this.btnPrint.TabIndex = 9;
            this.metroToolTip1.SetToolTip(this.btnPrint, "Напечатать?");
            this.btnPrint.UseSelectable = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.Transparent;
            this.btnInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInformation.BackgroundImage")));
            this.btnInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInformation.ForeColor = System.Drawing.Color.Transparent;
            this.btnInformation.Location = new System.Drawing.Point(10, 435);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(66, 63);
            this.btnInformation.TabIndex = 9;
            this.metroToolTip1.SetToolTip(this.btnInformation, "Информация");
            this.btnInformation.UseSelectable = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSend.ForeColor = System.Drawing.Color.Transparent;
            this.btnSend.Location = new System.Drawing.Point(10, 504);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 63);
            this.btnSend.TabIndex = 9;
            this.metroToolTip1.SetToolTip(this.btnSend, "Отправить вопрос");
            this.btnSend.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Label5);
            this.metroPanel1.Controls.Add(this.Label7);
            this.metroPanel1.Controls.Add(this.txtTypeOfFlight);
            this.metroPanel1.Controls.Add(this.txtRouteNumber);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(6, 78);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(401, 86);
            this.metroPanel1.TabIndex = 56;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label5.Location = new System.Drawing.Point(8, 49);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(265, 20);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Тип рейса искомого маршрута";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label7.Location = new System.Drawing.Point(8, 16);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(228, 20);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Искомый номер маршрута";
            // 
            // txtTypeOfFlight
            // 
            this.txtTypeOfFlight.BackColor = System.Drawing.SystemColors.Control;
            this.txtTypeOfFlight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "TypeOfFlight", true));
            this.txtTypeOfFlight.Depth = 0;
            this.txtTypeOfFlight.Enabled = false;
            this.txtTypeOfFlight.Hint = "";
            this.txtTypeOfFlight.Location = new System.Drawing.Point(279, 42);
            this.txtTypeOfFlight.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTypeOfFlight.Name = "txtTypeOfFlight";
            this.txtTypeOfFlight.PasswordChar = '\0';
            this.txtTypeOfFlight.SelectedText = "";
            this.txtTypeOfFlight.SelectionLength = 0;
            this.txtTypeOfFlight.SelectionStart = 0;
            this.txtTypeOfFlight.Size = new System.Drawing.Size(97, 28);
            this.txtTypeOfFlight.TabIndex = 53;
            this.txtTypeOfFlight.UseSystemPasswordChar = false;
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtRouteNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "RouteNumber", true));
            this.txtRouteNumber.Depth = 0;
            this.txtRouteNumber.Enabled = false;
            this.txtRouteNumber.Hint = "";
            this.txtRouteNumber.Location = new System.Drawing.Point(279, 8);
            this.txtRouteNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.PasswordChar = '\0';
            this.txtRouteNumber.SelectedText = "";
            this.txtRouteNumber.SelectionLength = 0;
            this.txtRouteNumber.SelectionStart = 0;
            this.txtRouteNumber.Size = new System.Drawing.Size(97, 28);
            this.txtRouteNumber.TabIndex = 53;
            this.txtRouteNumber.UseSystemPasswordChar = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.materialLabel3);
            this.metroPanel2.Controls.Add(this.materialLabel1);
            this.metroPanel2.Controls.Add(this.materialLabel2);
            this.metroPanel2.Controls.Add(this.txtEndC);
            this.metroPanel2.Controls.Add(this.txtEndB);
            this.metroPanel2.Controls.Add(this.txtEndA);
            this.metroPanel2.Controls.Add(this.Label6);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(6, 174);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(401, 169);
            this.metroPanel2.TabIndex = 56;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 125);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(23, 24);
            this.materialLabel3.TabIndex = 58;
            this.materialLabel3.Text = "C";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 91);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(22, 24);
            this.materialLabel1.TabIndex = 58;
            this.materialLabel1.Text = "B";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 57);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(23, 24);
            this.materialLabel2.TabIndex = 57;
            this.materialLabel2.Text = "A";
            // 
            // txtEndC
            // 
            this.txtEndC.BackColor = System.Drawing.SystemColors.Control;
            this.txtEndC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "EndC", true));
            this.txtEndC.Depth = 0;
            this.txtEndC.Enabled = false;
            this.txtEndC.Hint = "";
            this.txtEndC.Location = new System.Drawing.Point(50, 117);
            this.txtEndC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndC.Name = "txtEndC";
            this.txtEndC.PasswordChar = '\0';
            this.txtEndC.SelectedText = "";
            this.txtEndC.SelectionLength = 0;
            this.txtEndC.SelectionStart = 0;
            this.txtEndC.Size = new System.Drawing.Size(326, 28);
            this.txtEndC.TabIndex = 54;
            this.txtEndC.UseSystemPasswordChar = false;
            // 
            // txtEndB
            // 
            this.txtEndB.BackColor = System.Drawing.SystemColors.Control;
            this.txtEndB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "EndB", true));
            this.txtEndB.Depth = 0;
            this.txtEndB.Enabled = false;
            this.txtEndB.Hint = "";
            this.txtEndB.Location = new System.Drawing.Point(50, 83);
            this.txtEndB.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndB.Name = "txtEndB";
            this.txtEndB.PasswordChar = '\0';
            this.txtEndB.SelectedText = "";
            this.txtEndB.SelectionLength = 0;
            this.txtEndB.SelectionStart = 0;
            this.txtEndB.Size = new System.Drawing.Size(326, 28);
            this.txtEndB.TabIndex = 54;
            this.txtEndB.UseSystemPasswordChar = false;
            // 
            // txtEndA
            // 
            this.txtEndA.BackColor = System.Drawing.SystemColors.Control;
            this.txtEndA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "EndA", true));
            this.txtEndA.Depth = 0;
            this.txtEndA.Enabled = false;
            this.txtEndA.Hint = "";
            this.txtEndA.Location = new System.Drawing.Point(50, 49);
            this.txtEndA.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndA.Name = "txtEndA";
            this.txtEndA.PasswordChar = '\0';
            this.txtEndA.SelectedText = "";
            this.txtEndA.SelectionLength = 0;
            this.txtEndA.SelectionStart = 0;
            this.txtEndA.Size = new System.Drawing.Size(326, 28);
            this.txtEndA.TabIndex = 55;
            this.txtEndA.UseSystemPasswordChar = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label6.Location = new System.Drawing.Point(83, 26);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(245, 20);
            this.Label6.TabIndex = 44;
            this.Label6.Text = "Конечные пункты маршрута";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AddNewItem = null;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.CountItem = null;
            this.miniToolStrip.DeleteItem = null;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(456, 14);
            this.miniToolStrip.MoveFirstItem = null;
            this.miniToolStrip.MoveLastItem = null;
            this.miniToolStrip.MoveNextItem = null;
            this.miniToolStrip.MovePreviousItem = null;
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.PositionItem = null;
            this.miniToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.miniToolStrip.Size = new System.Drawing.Size(722, 48);
            this.miniToolStrip.TabIndex = 29;
            // 
            // cboSelectModeTransport
            // 
            this.cboSelectModeTransport.Items.AddRange(new object[] {
            "Автобус",
            "Троллейбус",
            "Трамвай"});
            this.cboSelectModeTransport.Name = "cboSelectModeTransport";
            this.cboSelectModeTransport.Size = new System.Drawing.Size(121, 48);
            this.cboSelectModeTransport.ToolTipText = "Выберите вид транспорта";
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
            this.tbFindTheRoute.Click += new System.EventHandler(this.tbFindTheRoute_Click);
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 45);
            this.BindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 45);
            this.BindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(55, 45);
            this.BindingNavigatorCountItem.Text = "для {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 45);
            this.BindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 45);
            this.BindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.White;
            this.Panel5.Controls.Add(this.Label13);
            this.Panel5.Controls.Add(this.txtFeaturesOfRoute);
            this.Panel5.Location = new System.Drawing.Point(423, 78);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(299, 382);
            this.Panel5.TabIndex = 49;
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
            // txtFeaturesOfRoute
            // 
            this.txtFeaturesOfRoute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFeaturesOfRoute.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "FeaturesOfRoute", true));
            this.txtFeaturesOfRoute.Location = new System.Drawing.Point(23, 42);
            this.txtFeaturesOfRoute.Multiline = true;
            this.txtFeaturesOfRoute.Name = "txtFeaturesOfRoute";
            this.txtFeaturesOfRoute.ReadOnly = true;
            this.txtFeaturesOfRoute.Size = new System.Drawing.Size(259, 316);
            this.txtFeaturesOfRoute.TabIndex = 27;
            this.txtFeaturesOfRoute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.Label12);
            this.metroPanel3.Controls.Add(this.txtSwitchingToRoutes);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(7, 357);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(401, 103);
            this.metroPanel3.TabIndex = 58;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label12.Location = new System.Drawing.Point(82, 26);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(250, 20);
            this.Label12.TabIndex = 48;
            this.Label12.Text = "Переключение на маршруты";
            // 
            // txtSwitchingToRoutes
            // 
            this.txtSwitchingToRoutes.BackColor = System.Drawing.SystemColors.Control;
            this.txtSwitchingToRoutes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "SwitchingToRoutes", true));
            this.txtSwitchingToRoutes.Depth = 0;
            this.txtSwitchingToRoutes.Enabled = false;
            this.txtSwitchingToRoutes.Hint = "";
            this.txtSwitchingToRoutes.Location = new System.Drawing.Point(50, 49);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Panel5);
            this.groupBox1.Controls.Add(this.metroPanel3);
            this.groupBox1.Controls.Add(this.MarshBindingNavigator);
            this.groupBox1.Controls.Add(this.metroPanel2);
            this.groupBox1.Controls.Add(this.metroPanel1);
            this.groupBox1.Controls.Add(this.shapeContainer2);
            this.groupBox1.Location = new System.Drawing.Point(94, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 471);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // MarshBindingNavigator
            // 
            this.MarshBindingNavigator.AddNewItem = null;
            this.MarshBindingNavigator.AutoSize = false;
            this.MarshBindingNavigator.BindingSource = this.routeBindingSource;
            this.MarshBindingNavigator.CountItem = this.BindingNavigatorCountItem;
            this.MarshBindingNavigator.DeleteItem = null;
            this.MarshBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboSelectModeTransport,
            this.tbSearchStart,
            this.tbFindTheRoute,
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorMoveNextItem});
            this.MarshBindingNavigator.Location = new System.Drawing.Point(3, 18);
            this.MarshBindingNavigator.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.MarshBindingNavigator.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.MarshBindingNavigator.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.MarshBindingNavigator.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.MarshBindingNavigator.Name = "MarshBindingNavigator";
            this.MarshBindingNavigator.PositionItem = this.BindingNavigatorPositionItem;
            this.MarshBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MarshBindingNavigator.Size = new System.Drawing.Size(722, 48);
            this.MarshBindingNavigator.TabIndex = 29;
            this.MarshBindingNavigator.Text = "BindingNavigator1";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(722, 450);
            this.shapeContainer2.TabIndex = 57;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 409;
            this.lineShape4.X2 = 409;
            this.lineShape4.Y1 = 62;
            this.lineShape4.Y2 = 424;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 3;
            this.lineShape3.X2 = 402;
            this.lineShape3.Y1 = 333;
            this.lineShape3.Y2 = 333;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 4;
            this.lineShape2.X2 = 403;
            this.lineShape2.Y1 = 150;
            this.lineShape2.Y2 = 150;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Transparent;
            this.materialDivider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("materialDivider1.BackgroundImage")));
            this.materialDivider1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(663, 23);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(75, 70);
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.Transparent;
            this.materialDivider2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("materialDivider2.BackgroundImage")));
            this.materialDivider2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(744, 23);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(75, 70);
            this.materialDivider2.TabIndex = 10;
            this.materialDivider2.Text = "materialDivider1";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.Transparent;
            this.materialDivider3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("materialDivider3.BackgroundImage")));
            this.materialDivider3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(582, 23);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(75, 70);
            this.materialDivider3.TabIndex = 10;
            this.materialDivider3.Text = "materialDivider1";
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataSource = typeof(Analysis_of_urban_passenger_transport.Route);
            // 
            // frmViewmode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(834, 579);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewmode";
            this.Resizable = false;
            this.Text = "Программа AOUPT => режим просмотра";
            this.Load += new System.EventHandler(this.frmViewmode_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).EndInit();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarshBindingNavigator)).EndInit();
            this.MarshBindingNavigator.ResumeLayout(false);
            this.MarshBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTypeOfFlight;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRouteNumber;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEndC;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEndB;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEndA;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.BindingNavigator miniToolStrip;
        private System.Windows.Forms.ToolStripComboBox cboSelectModeTransport;
        internal System.Windows.Forms.ToolStripTextBox tbSearchStart;
        internal System.Windows.Forms.ToolStripButton tbFindTheRoute;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtFeaturesOfRoute;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        internal System.Windows.Forms.Label Label12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSwitchingToRoutes;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.BindingNavigator MarshBindingNavigator;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MetroFramework.Controls.MetroButton btnInformation;
        private MetroFramework.Controls.MetroButton btnSend;
        private System.Windows.Forms.BindingSource routeBindingSource;










    }
}