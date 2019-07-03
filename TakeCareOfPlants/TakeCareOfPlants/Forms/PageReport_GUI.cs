using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DAL;

namespace TakeCareOfPlants.Forms
{
    public partial class PageReport_GUI : Form
    {
        private static PageReport_GUI pageReport;
        private CayCanh_BUS cayCanhBUS = new CayCanh_BUS();

        public static PageReport_GUI Instance
        {
            get {
                if (pageReport == null) {
                    pageReport = new PageReport_GUI();
                }
                return pageReport;
            }
        }

        public PageReport_GUI()
        {
            InitializeComponent();
        }

        private void PageReport_GUI_Load(object sender, EventArgs e)
        {
            try {
                ReportDataSource report = new ReportDataSource(
                    "ListPlant", 
                    cayCanhBUS.GetAllValueCayCanh());

                Custom_ReportViewer.ProcessingMode = ProcessingMode.Local;

                Custom_ReportViewer.LocalReport.ReportPath = "Reports/ListPlant_Report.rdlc";
                Custom_ReportViewer.LocalReport.DataSources.Clear();
                Custom_ReportViewer.LocalReport.DataSources.Add(report);
                Custom_ReportViewer.LocalReport.Refresh();
                Custom_ReportViewer.RefreshReport();
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }
    }
}
