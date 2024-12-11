using DatabaseTVP;
using Microsoft.Reporting.WebForms;
using Report.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Report.Controllers
{
    public class ReportsController : Controller
    {
        public ActionResult ViewPDF(BasicValues bv)
        {


            try
            {
                 List<ReportMapping> report = DataBase.ExecuteQuery<ReportMapping>(new { a = 1, b = bv.TenantId, x = bv.AppId, y = Convert.ToInt32(bv.reportValues.Name )},
                Connection.GetConnection(), "Report_ReportsMappingGetByName");

                 List<ReportStoredProcedure> procedure = DataBase.ExecuteQuery<ReportStoredProcedure>(new { a = bv.UserId, b = bv.TenantId, x = bv.AppId, y = report[0].ReportId }, Connection.GetConnection(),
                    "Report_ReportStoredProcedureGetByReportId");

                List<Models.ReportParameter> parameters = DataBase.ExecuteQuery<Models.ReportParameter>(new { a = bv.UserId, b = bv.TenantId, x = bv.AppId, y =Convert.ToInt32(report[0].ReportId) }, Connection.GetConnection(),
                    "Report_ReportParameterGetByReportId");

                LocalReport lr = new LocalReport();
                string path = Server.MapPath(report[0].ReportPath);

                if (System.IO.File.Exists(path))
                {
                    lr.ReportPath = path;
                }

                foreach (var item in procedure)
                {
                    ReportDataSource rd = new ReportDataSource(item.Datasetname, DataBase.ExecuteforReport(new { a = bv.UserId, b = bv.TenantId, x = bv.AppId, y = bv.reportValues.Value[0], z = bv.reportValues.Value[1], d = bv.reportValues.Value[2], ab = bv.reportValues.Value[3], ac = bv.reportValues.Value[4], ad = bv.reportValues.Value[5], ae = bv.reportValues.Value[6] },
                       Connection.GetConnection(), item.StoreProcedureName));
                    Logger.Logging.DB_Log(Logger.eLogType.Log_Positive, "", new { a = 1, b = bv.TenantId, x = bv.AppId, y = bv.reportValues.Value[0], z = bv.reportValues.Value[1], d = bv.reportValues.Value[2], ab = bv.UserId }, "ViewPDF", "Reporting", Connection.GetLogConnection(), bv.CInfo, bv.IP, bv.UserId);

                    lr.DataSources.Add(rd);

                }

                DataTable dataTable = DataBase.ExecuteforReport(new { A = bv.UserId, B = bv.TenantId, C = bv.AppId, D = report[0].ReportName, F = bv.reportValues.Value[1], G = bv.reportValues.Value[2], H = bv.reportValues.Value[3], i = bv.reportValues.Value[4],J  = bv.reportValues.Value[5],I = bv.reportValues.Value[6]}, Connection.GetConnection(), "Report_ReportGetParameters");
                Logger.Logging.DB_Log(Logger.eLogType.Log_Positive, "", new { A = bv.UserId, B = bv.TenantId, C = bv.AppId, D = report[0].ReportName, F = bv.reportValues.Value[1], G = bv.reportValues.Value[2] },"", "", Connection.GetLogConnection(), bv.CInfo, bv.IP, bv.UserId);

                foreach (var item in parameters)
                {
                    lr.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter(item.ParameterName, dataTable.Rows[0][item.ColumnName].ToString()));
                }

                string reportType = "PDF";
                string mimeType, encoding, fileNameExtension;

                string deviceinfo = "";
                //      "<DeviceInfo>" +
                //"  <OutputFormat>Report</OutputFormat>" +
                //"  <PageWidth>8.27in</PageWidth>" +
                //"  <PageHeight>5.845in</PageHeight>" +
                //"  <MarginTop>0.19in</MarginTop>" +
                //"  <MarginLeft>0.19in</MarginLeft>" +
                //"  <MarginRight>0.19in</MarginRight>" +
                //"  <MarginBottom>0.19in</MarginBottom>" +
                //"</DeviceInfo>";

                lr.EnableExternalImages = true;
                Warning[] warnings;
                string[] streams;
                byte[] renderedBytes = lr.Render(reportType, deviceinfo, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);
                return File(renderedBytes, mimeType);

            }

            catch (Exception ex)
            {
                Logger.Logging.DB_Log(Logger.eLogType.Log_Negative, ex.Message + " + " + ex.InnerException, new { a = 1, b = bv.TenantId, x = bv.AppId, y = bv.reportValues.Value[0], z = bv.reportValues.Value[1], d = bv.reportValues.Value[2], ab = bv.UserId }, "ViewPDF", "Reporting", Connection.GetLogConnection(), bv.CInfo, bv.IP, bv.UserId);


                ex.ToString();
                return null;
            }
        }





        public FileResult DownloadReport(string ReportName, BValues BV, string IP, string CInfo, int Id)
        {
            try
            {
                List<ReportMapping> report = DataBase.ExecuteQuery<ReportMapping>(new { a = 1, b = 1, x = "FOERP", y = ReportName },
                Connection.GetConnection(), "URM_ReportsMappingGetByName");

                List<ReportStoredProcedure> procedure = DataBase.ExecuteQuery<ReportStoredProcedure>(new { a = 1, b = 1, x = "FOERP", y = report[0].ReportId }, Connection.GetConnection(),
                    "URM_ReportStoredProcedureGetByReportId");

                LocalReport lr = new LocalReport();
                string path = Server.MapPath(report[0].ReportPath);

                if (System.IO.File.Exists(path))
                {
                    lr.ReportPath = path;
                }

                foreach (var item in procedure)
                {
                    ReportDataSource rd = new ReportDataSource(item.Datasetname, DataBase.ExecuteforReport(new { a = 1, b = 1, x = "FOERP", y = Id },
                       Connection.GetConnection(), item.StoreProcedureName));

                    lr.DataSources.Add(rd);

                }

                string reportType = "PDF";
                string mimeType, encoding, fileNameExtension;


                string deviceinfo =
                     "<DeviceInfo>" +
              "  <OutputFormat>EMF</OutputFormat>" +
              "  <PageWidth>10in</PageWidth>" +
              "  <PageHeight>11in</PageHeight>" +
              "  <MarginTop>0.25in</MarginTop>" +
              "  <MarginLeft>0.25in</MarginLeft>" +
              "  <MarginRight>0.25in</MarginRight>" +
              "  <MarginBottom>0.25in</MarginBottom>" +
              "</DeviceInfo>";

                Warning[] warnings;
                string[] streams;
                byte[] renderedBytes;
                renderedBytes = lr.Render(reportType, deviceinfo, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);



                using (FileStream fs = System.IO.File.Create(Server.MapPath("~/download/") + ReportName))
                {
                    fs.Write(renderedBytes, 0, renderedBytes.Length);
                }

                Response.ClearHeaders();
                Response.ClearContent();
                Response.Buffer = true;
                Response.Clear();
                Response.ContentType = reportType;
                Response.AddHeader("Content-Disposition", "attachment; filename=" + ReportName);
                Response.WriteFile(Server.MapPath("~/download/" + ReportName));
                Response.Flush();
                Response.Close();
                Response.End();

                //return File(renderedBytes, mimeType);
                return File(renderedBytes, mimeType);
            }

            catch (Exception ex)
            {
                Logger.Logging.DB_Log(Logger.eLogType.Log_Negative, ex.Message, new { x = Id }, "DownloadReport", "Reporting", Connection.GetLogConnection(), CInfo, IP, BV.UserId);
                return null;
            }
        }

        //public ActionResult GenerateChequeForm(int voucherId, int bankId, int userId, int tenantId, string appId, string ip, string cInfo)
        //{
        //    try
        //    {
        //        var reportPath = DataBase.ExecuteQuery<ChequeReport>(new { userId, tenantId, appId, bankId }, Connection.GetConnection(), "Reporting_GetChequeFormPath").FirstOrDefault().ChequeFormPath;

        //        LocalReport localReport = new LocalReport { ReportPath = Server.MapPath(reportPath) };

        //        ReportDataSource reportDataSource = new ReportDataSource("DataSet1", DataBase.ExecuteforReport(new { userId, tenantId, appId, voucherId }, Connection.GetConnection(), "Reporting_ChequeForm"));

        //        localReport.DataSources.Add(reportDataSource);

        //        var bytes = localReport.Render("PDF");

        //        return File(bytes, "application/pdf");

        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Logging.DB_Log(Logger.eLogType.Log_Negative, ex.Message + " + " + ex.InnerException, new { userId, tenantId, appId, bankId }, "GenerateChequeForm", "Reporting", Connection.GetLogConnection(), cInfo, ip, userId);

        //        return null;
        //    }
        //}
    }
}