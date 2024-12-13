using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Master.Models
{
    public class Student
    {
        private const string MODULE = "Master";

        [TVP]
        public int GRId { get; set; }
        [TVP]
        public int Grno { get; set; }
        [TVP]
        public string StudentName { get; set; }
        [TVP]
        public string  Int { get; set; }
        [TVP]
        public string FatherName { get; set; }
        [TVP]
        public string SurName { get; set; }
        [TVP]
        public string RAdd { get; set; }
        [TVP]
        public string Religion { get; set; }
        [TVP]
        public string CellNo { get; set; }

        [TVP]
        public string PhoneNo { get; set; }
        [TVP]
        public string DOBrith { get; set; }
        [TVP]
        public string Shift { get; set; }
        [TVP]
        public string AdDate { get; set; }

        [TVP]
        public string Sec { get; set; }
        [TVP]
        public string RollNo { get; set; }
        [TVP]
        public int  PanelId { get; set; }
        [TVP]
        public int  LevelId { get; set; }
        [TVP]
        public decimal OpenAmt { get; set; }
        [TVP]
        public decimal MDisAmt { get; set; }
        [TVP]
        public string DateLeaving { get; set; }
        [TVP]
        public decimal TransportAmt { get; set; }


        [TVP]
        public int LeaveF { get; set; }


        
        [TVP]
        public int  MonthId { get; set; }

        [TVP]
        public decimal OpeningAmt { get; set; }

        [TVP]
        public decimal CloseingAmt { get; set; }

           [TVP]
        public int  SessionId { get; set; }

        



        [TVP]
        public string   email_add { get; set; }

        [TVP]
        public string Qulification{ get; set; }
        [TVP]
        public string Profession { get; set; }
        [TVP]
        public int   group_id { get; set; }
        [TVP]
        public string group_name { get; set; }
        [TVP]
        public string Remarks { get; set; }


         [TVP]
        public int RefId { get; set; }

        [TVP]
        public int PlanId { get; set; }

        [TVP]
        public string  SeatNo { get; set; }

         [TVP]
        public string  PhotoPath { get; set; }







        //properties for model
        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }



        public string SName { get; set; }

        public string LevelName { get; set; }



        public decimal AdmissionFee { get; set; }

        public decimal AnnualFee { get; set; }

        public decimal MonthlyFee { get; set; }

        public string PanelN { get; set; }


        public int  ChallanNo { get; set; }


        public string MonthName { get; set; }


        public decimal Amount { get; set; }


        public string  GroupName  { get; set; }


        public string VMode { get; set; }
        //View only properties

        public int TotalCount { get; set; }


        public string PlanName { get; set; }




        public decimal Enrollmentfee { get; set; }


        public decimal ExamFee { get; set; }


        public decimal MisFee { get; set; }



        public decimal PenaltyFee { get; set; }





        public string ReturnMessage { get; set; }

        public string Master_StudentSave(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; CreatedBy = bv.UserId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public string Master_StudentUpdate(BValues bv, string ip, string cInfo)
        {
            var parameters = new { x = this };

            try
            {
                TenantId = bv.TenantId; AppId = bv.AppId; ModifiedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }

        public Student Master_StudentGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                Student record = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public List<Student> Master_StudentGetAll(BValues bv, string ip, string cInfo, int length, int offset, string searchtext, int status)
        {


            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, offset, length, searchtext, status };



            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }




        public List<Student> Master_CCStudentGetAll(BValues bv, string ip, string cInfo, int length, int offset, string searchtext, int status)
        {


            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, offset, length, searchtext, status };



            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }




        public List<Student> Master_StudentGetAllSAI(BValues bv, string ip, string cInfo, int length, int offset, string searchtext, int status)
        {


            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, offset, length, searchtext, status };



            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }



        public DataTable Master_StudentGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Master_StudentGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Master_StudentDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }



        public List<Student> Master_StudentGetLevelId(int Id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, id = Id };

            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


          public List<Student> Master_StudentGetVouStudent(int Id,int SId,int LeaveF,int  MonthId , BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, id = Id,sid = SId, leaveF = LeaveF, monthId  = MonthId };

            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                 Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

         public List<Student> StudentGetVouSem(int Id,int SId,int StuId, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, id = Id,sid = SId, stuId  = StuId };

            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                 Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


        public List<Student> Master_StudentGetVouPen(int Id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, id = Id};

            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                 Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


        public List<Student> Master_StudentGetGrId(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id};

            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                 Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


           public List<Student> StudentlistPanelGrId(int MonthId, int  PanelId,int StudentId ,BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, monthId  = MonthId,panelId  = PanelId, studentId = StudentId };

            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                 Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


          public List<Student> Master_StudentGetPanelId(int  PanelId, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, panelId  = PanelId };

            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                 Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }





          public List<Student> StudentGetReceipt( BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId};

            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                 Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


          public List<Student> StudentGetVoucher(int GRId, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId,GRId};

            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                 Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }



            public List<Student> StudentGetReportLedger(int GRId, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId,GRId};

            try
            {
                List<Student> records = DataBase.ExecuteQuery<Student>(parameters, Connection.GetConnection());

                 Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }














    }
}