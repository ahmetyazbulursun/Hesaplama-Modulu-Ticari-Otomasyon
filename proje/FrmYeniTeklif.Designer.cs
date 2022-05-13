namespace proje
{
    partial class FrmYeniTeklif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniTeklif));
            this.txtFirmaMusteriAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.mskTarih = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaMusteriAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mskTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mskTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirmaMusteriAd
            // 
            this.txtFirmaMusteriAd.Location = new System.Drawing.Point(168, 46);
            this.txtFirmaMusteriAd.Name = "txtFirmaMusteriAd";
            this.txtFirmaMusteriAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.txtFirmaMusteriAd.Properties.Appearance.Options.UseFont = true;
            this.txtFirmaMusteriAd.Size = new System.Drawing.Size(174, 26);
            this.txtFirmaMusteriAd.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Firma/Müşteri Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(119, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 19);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Tarih:";
            // 
            // mskTarih
            // 
            this.mskTarih.EditValue = null;
            this.mskTarih.Location = new System.Drawing.Point(168, 78);
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.mskTarih.Properties.Appearance.Options.UseFont = true;
            this.mskTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mskTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mskTarih.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.mskTarih.Properties.DisplayFormat.FormatString = "";
            this.mskTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.mskTarih.Properties.EditFormat.FormatString = "";
            this.mskTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.mskTarih.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.mskTarih.Size = new System.Drawing.Size(174, 26);
            this.mskTarih.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(168, 110);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(174, 45);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "TEKLİF OLUŞTUR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmYeniTeklif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(378, 188);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtFirmaMusteriAd);
            this.Controls.Add(this.mskTarih);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmYeniTeklif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YENİ TEKLİF OLUŞTUR";
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaMusteriAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mskTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mskTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFirmaMusteriAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit mskTarih;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}