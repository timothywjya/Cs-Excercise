
namespace Azuraline
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NavMainMenu = new System.Windows.Forms.MenuStrip();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokoIndogrosirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabangIndogrosirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDataTokoOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pershoOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSBiayaOperasionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dFeeOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penetapanItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalPBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembatasanPeriodeBiayaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virtualAccountOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mutasiOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versiPOSOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bKLOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBKLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutupHarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ePPOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataFromCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTargetFixTableOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCabangIGRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTokoOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dCPOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplikasiRKMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplikasiRKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promosiOMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promosiIndogrosirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promosiMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promosiMarketingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NavMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NavMainMenu
            // 
            this.NavMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementToolStripMenuItem,
            this.tokoIndogrosirToolStripMenuItem,
            this.dataMonitoringToolStripMenuItem,
            this.importDataFromCSVToolStripMenuItem,
            this.downloadAplikasiToolStripMenuItem,
            this.promosiOMIToolStripMenuItem,
            this.cleanMenuToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.NavMainMenu.Location = new System.Drawing.Point(0, 0);
            this.NavMainMenu.Name = "NavMainMenu";
            this.NavMainMenu.Size = new System.Drawing.Size(844, 24);
            this.NavMainMenu.TabIndex = 1;
            this.NavMainMenu.Text = "menuStrip2";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // tokoIndogrosirToolStripMenuItem
            // 
            this.tokoIndogrosirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cabangIndogrosirToolStripMenuItem,
            this.updateDataTokoOMIToolStripMenuItem,
            this.pershoOMIToolStripMenuItem,
            this.pOSBiayaOperasionalToolStripMenuItem,
            this.dFeeOMIToolStripMenuItem,
            this.pembatasanPeriodeBiayaToolStripMenuItem,
            this.virtualAccountOMIToolStripMenuItem,
            this.mutasiOMIToolStripMenuItem});
            this.tokoIndogrosirToolStripMenuItem.Name = "tokoIndogrosirToolStripMenuItem";
            this.tokoIndogrosirToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.tokoIndogrosirToolStripMenuItem.Text = "Data Master";
            // 
            // cabangIndogrosirToolStripMenuItem
            // 
            this.cabangIndogrosirToolStripMenuItem.Name = "cabangIndogrosirToolStripMenuItem";
            this.cabangIndogrosirToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cabangIndogrosirToolStripMenuItem.Text = "Toko Indogrosir";
            this.cabangIndogrosirToolStripMenuItem.Click += new System.EventHandler(this.updateDataCabangToolStripMenuItem_Click);
            // 
            // updateDataTokoOMIToolStripMenuItem
            // 
            this.updateDataTokoOMIToolStripMenuItem.Name = "updateDataTokoOMIToolStripMenuItem";
            this.updateDataTokoOMIToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.updateDataTokoOMIToolStripMenuItem.Text = "Toko Outlet OMI";
            // 
            // pershoOMIToolStripMenuItem
            // 
            this.pershoOMIToolStripMenuItem.Name = "pershoOMIToolStripMenuItem";
            this.pershoOMIToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.pershoOMIToolStripMenuItem.Text = "Persho OMI";
            // 
            // pOSBiayaOperasionalToolStripMenuItem
            // 
            this.pOSBiayaOperasionalToolStripMenuItem.Name = "pOSBiayaOperasionalToolStripMenuItem";
            this.pOSBiayaOperasionalToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.pOSBiayaOperasionalToolStripMenuItem.Text = "POS Biaya Operasional";
            // 
            // dFeeOMIToolStripMenuItem
            // 
            this.dFeeOMIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penetapanItemToolStripMenuItem,
            this.jadwalPBToolStripMenuItem});
            this.dFeeOMIToolStripMenuItem.Name = "dFeeOMIToolStripMenuItem";
            this.dFeeOMIToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.dFeeOMIToolStripMenuItem.Text = "DFee OMI";
            // 
            // penetapanItemToolStripMenuItem
            // 
            this.penetapanItemToolStripMenuItem.Name = "penetapanItemToolStripMenuItem";
            this.penetapanItemToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.penetapanItemToolStripMenuItem.Text = "Penetapan Item";
            // 
            // jadwalPBToolStripMenuItem
            // 
            this.jadwalPBToolStripMenuItem.Name = "jadwalPBToolStripMenuItem";
            this.jadwalPBToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.jadwalPBToolStripMenuItem.Text = "Jadwal PB";
            // 
            // pembatasanPeriodeBiayaToolStripMenuItem
            // 
            this.pembatasanPeriodeBiayaToolStripMenuItem.Name = "pembatasanPeriodeBiayaToolStripMenuItem";
            this.pembatasanPeriodeBiayaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.pembatasanPeriodeBiayaToolStripMenuItem.Text = "Pembatasan Periode Biaya ";
            // 
            // virtualAccountOMIToolStripMenuItem
            // 
            this.virtualAccountOMIToolStripMenuItem.Name = "virtualAccountOMIToolStripMenuItem";
            this.virtualAccountOMIToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.virtualAccountOMIToolStripMenuItem.Text = "Virtual Account OMI";
            // 
            // mutasiOMIToolStripMenuItem
            // 
            this.mutasiOMIToolStripMenuItem.Name = "mutasiOMIToolStripMenuItem";
            this.mutasiOMIToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.mutasiOMIToolStripMenuItem.Text = "Mutasi OMI";
            // 
            // dataMonitoringToolStripMenuItem
            // 
            this.dataMonitoringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versiPOSOMIToolStripMenuItem,
            this.bKLOMIToolStripMenuItem,
            this.ePPOMIToolStripMenuItem});
            this.dataMonitoringToolStripMenuItem.Name = "dataMonitoringToolStripMenuItem";
            this.dataMonitoringToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.dataMonitoringToolStripMenuItem.Text = "Data Monitoring";
            // 
            // versiPOSOMIToolStripMenuItem
            // 
            this.versiPOSOMIToolStripMenuItem.Name = "versiPOSOMIToolStripMenuItem";
            this.versiPOSOMIToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.versiPOSOMIToolStripMenuItem.Text = "Versi POS OMI";
            // 
            // bKLOMIToolStripMenuItem
            // 
            this.bKLOMIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBKLToolStripMenuItem,
            this.tutupHarianToolStripMenuItem});
            this.bKLOMIToolStripMenuItem.Name = "bKLOMIToolStripMenuItem";
            this.bKLOMIToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.bKLOMIToolStripMenuItem.Text = "BKL OMI";
            // 
            // statusBKLToolStripMenuItem
            // 
            this.statusBKLToolStripMenuItem.Name = "statusBKLToolStripMenuItem";
            this.statusBKLToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.statusBKLToolStripMenuItem.Text = "Status BKL";
            // 
            // tutupHarianToolStripMenuItem
            // 
            this.tutupHarianToolStripMenuItem.Name = "tutupHarianToolStripMenuItem";
            this.tutupHarianToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.tutupHarianToolStripMenuItem.Text = "Tutup Harian";
            // 
            // ePPOMIToolStripMenuItem
            // 
            this.ePPOMIToolStripMenuItem.Name = "ePPOMIToolStripMenuItem";
            this.ePPOMIToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ePPOMIToolStripMenuItem.Text = "EPP OMI";
            // 
            // importDataFromCSVToolStripMenuItem
            // 
            this.importDataFromCSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataTargetFixTableOMIToolStripMenuItem,
            this.updateCabangIGRToolStripMenuItem,
            this.updateTokoOMIToolStripMenuItem});
            this.importDataFromCSVToolStripMenuItem.Name = "importDataFromCSVToolStripMenuItem";
            this.importDataFromCSVToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.importDataFromCSVToolStripMenuItem.Text = "Import Data From CSV";
            // 
            // dataTargetFixTableOMIToolStripMenuItem
            // 
            this.dataTargetFixTableOMIToolStripMenuItem.Name = "dataTargetFixTableOMIToolStripMenuItem";
            this.dataTargetFixTableOMIToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.dataTargetFixTableOMIToolStripMenuItem.Text = "Data Target Fix Table OMI";
            // 
            // updateCabangIGRToolStripMenuItem
            // 
            this.updateCabangIGRToolStripMenuItem.Name = "updateCabangIGRToolStripMenuItem";
            this.updateCabangIGRToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.updateCabangIGRToolStripMenuItem.Text = "Data JTD OMI";
            // 
            // updateTokoOMIToolStripMenuItem
            // 
            this.updateTokoOMIToolStripMenuItem.Name = "updateTokoOMIToolStripMenuItem";
            this.updateTokoOMIToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.updateTokoOMIToolStripMenuItem.Text = "Data Rekapan Mypoincs";
            // 
            // downloadAplikasiToolStripMenuItem
            // 
            this.downloadAplikasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dCPOMIToolStripMenuItem,
            this.aplikasiRKMToolStripMenuItem,
            this.aplikasiRKHToolStripMenuItem});
            this.downloadAplikasiToolStripMenuItem.Name = "downloadAplikasiToolStripMenuItem";
            this.downloadAplikasiToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.downloadAplikasiToolStripMenuItem.Text = "Download Aplikasi";
            // 
            // dCPOMIToolStripMenuItem
            // 
            this.dCPOMIToolStripMenuItem.Name = "dCPOMIToolStripMenuItem";
            this.dCPOMIToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.dCPOMIToolStripMenuItem.Text = "Aplikasi DCP OMI";
            // 
            // aplikasiRKMToolStripMenuItem
            // 
            this.aplikasiRKMToolStripMenuItem.Name = "aplikasiRKMToolStripMenuItem";
            this.aplikasiRKMToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aplikasiRKMToolStripMenuItem.Text = "Aplikasi RKM";
            // 
            // aplikasiRKHToolStripMenuItem
            // 
            this.aplikasiRKHToolStripMenuItem.Name = "aplikasiRKHToolStripMenuItem";
            this.aplikasiRKHToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aplikasiRKHToolStripMenuItem.Text = "Aplikasi RKH";
            // 
            // promosiOMIToolStripMenuItem
            // 
            this.promosiOMIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promosiIndogrosirToolStripMenuItem,
            this.promosiMDToolStripMenuItem,
            this.promosiMarketingToolStripMenuItem});
            this.promosiOMIToolStripMenuItem.Name = "promosiOMIToolStripMenuItem";
            this.promosiOMIToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.promosiOMIToolStripMenuItem.Text = "Promosi OMI";
            // 
            // promosiIndogrosirToolStripMenuItem
            // 
            this.promosiIndogrosirToolStripMenuItem.Name = "promosiIndogrosirToolStripMenuItem";
            this.promosiIndogrosirToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.promosiIndogrosirToolStripMenuItem.Text = "Promosi Indogrosir";
            // 
            // promosiMDToolStripMenuItem
            // 
            this.promosiMDToolStripMenuItem.Name = "promosiMDToolStripMenuItem";
            this.promosiMDToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.promosiMDToolStripMenuItem.Text = "Promosi MD";
            // 
            // promosiMarketingToolStripMenuItem
            // 
            this.promosiMarketingToolStripMenuItem.Name = "promosiMarketingToolStripMenuItem";
            this.promosiMarketingToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.promosiMarketingToolStripMenuItem.Text = "Promosi Marketing";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // cleanMenuToolStripMenuItem
            // 
            this.cleanMenuToolStripMenuItem.Name = "cleanMenuToolStripMenuItem";
            this.cleanMenuToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.cleanMenuToolStripMenuItem.Text = "Clean Menu";
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(844, 601);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.NavMainMenu);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Azuraline.Properties.Settings.Default, "MainMenu", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MainMenuStrip = this.NavMainMenu;
            this.Name = "MainMenu";
            this.Text = global::Azuraline.Properties.Settings.Default.MainMenu;
            this.NavMainMenu.ResumeLayout(false);
            this.NavMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip NavMainMenu;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tokoIndogrosirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabangIndogrosirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDataTokoOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pershoOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSBiayaOperasionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dFeeOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penetapanItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jadwalPBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembatasanPeriodeBiayaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virtualAccountOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mutasiOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versiPOSOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bKLOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBKLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutupHarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ePPOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataFromCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTargetFixTableOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCabangIGRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTokoOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadAplikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dCPOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplikasiRKMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplikasiRKHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promosiOMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promosiIndogrosirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promosiMDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promosiMarketingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanMenuToolStripMenuItem;
    }
}