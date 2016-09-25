namespace Analysis_of_urban_passenger_transport
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.lbName = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.trPerexod = new System.Windows.Forms.Timer(this.components);
            this.lbName2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(15, 22);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(254, 88);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Надстройка программы для анализа данных";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(308, 144);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(76, 17);
            this.lbAutor.TabIndex = 7;
            this.lbAutor.Text = "made GAS";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(399, 144);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(68, 17);
            this.lbAge.TabIndex = 8;
            this.lbAge.Text = "2012 age";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(375, 29);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(92, 17);
            this.lbVersion.TabIndex = 9;
            this.lbVersion.Text = "Версия 1.0.2";
            // 
            // trPerexod
            // 
            this.trPerexod.Enabled = true;
            this.trPerexod.Interval = 3000;
            this.trPerexod.Tick += new System.EventHandler(this.trPerexod_Tick);
            // 
            // lbName2
            // 
            this.lbName2.AutoSize = true;
            this.lbName2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName2.Location = new System.Drawing.Point(129, 110);
            this.lbName2.Name = "lbName2";
            this.lbName2.Size = new System.Drawing.Size(338, 22);
            this.lbName2.TabIndex = 10;
            this.lbName2.Text = "городского пассажирского транспорта";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(479, 170);
            this.ControlBox = false;
            this.Controls.Add(this.lbName2);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа - справочник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Timer trPerexod;
        private System.Windows.Forms.Label lbName2;

    }
}