using DatabaseTVP_Core;
using Logger_Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class FeeVoucher
    {
        private const string MODULE = "Transaction";

        [TVP]
        public int FeeId { get; set; }

        [TVP]
        public int  FeeCode { get; set; }




        [TVP]
        public string VouDate { get; set; }
        [TVP]
        public string DueDate { get; set; }

        [TVP]
        public int MonthId { get; set; }

        [TVP]
        public int PanelId { get; set; }

        [TVP]
        public int LeaveF { get; set; }


        
        
        
        [TVP]
        public int LevelId { get; set; }
        [TVP]
        public decimal AdAmt { get; set; }
        [TVP]
        public decimal AnnAmt { get; set; }
        [TVP]
        public decimal MontlyAmt { get; set; }
    
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        [TVP]
        public decimal OtherAmt { get; set; }
      
        
        
        
        
        [TVP]
        public decimal MDisAmt { get; set; }

        [TVP]
        public decimal EnrollAmt { get; set; }

        [TVP]
        public decimal ExamAmt { get; set; }

        [TVP]
        public decimal MisAmt { get; set; }

        [TVP]
        public decimal PenaltySAmt { get; set; }









        [TVP]
        public decimal TAmount { get; set; }
        [TVP]
        public int RefId { get; set; }
        [TVP]
        public int VouMode { get; set; }
        [TVP]
        public int BankId { get; set; }

        [TVP]
        public int ServicesId { get; set; }
         [TVP]
        public decimal penaltyAmt { get; set; }







        public string MonthName { get; set; }
        public string LevelName { get; set; }









        //properties for model
        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }




        public decimal VoucherAmt { get; set; }

        public int ChallanNo { get; set; }

        public int SalesId { get; set; }


        public string RefNo { get; set; }

        // public int MyProperty { get; set; }
        public List<FeeVoucherDetail> FeeVoucherDetail { get; set; }









        //View only properties
        public string ReturnMessage { get; set; }

        public string Transaction_FeeVoucherSave(BValues bv, string ip, string cInfo, FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail)
        {


            var parameters = new { x = FeeVoucher, FeeVoucherDetail };

            try
            {

                foreach (var item in FeeVoucherDetail)
            {



                item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
            }


            FeeVoucher.TenantId = bv.TenantId; FeeVoucher.AppId = bv.AppId; FeeVoucher.CreatedBy = bv.UserId;

            string message = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

            Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

            return message;
        }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }
        public string Transaction_CusFeeVoucherSave(BValues bv, string ip, string cInfo, FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail)
        {


            var parameters = new { x = FeeVoucher, FeeVoucherDetail };

            try
            {

                foreach (var item in FeeVoucherDetail)
            {



                item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
            }



            FeeVoucher.TenantId = bv.TenantId; FeeVoucher.AppId = bv.AppId; FeeVoucher.CreatedBy = bv.UserId;

            string message = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

            Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

            return message;
        }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }





        public string SaveSaleInvoiveFeeVoucher(BValues bv, string ip, string cInfo, FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail,int SaleId)
        {


            var parameters = new { x = FeeVoucher, FeeVoucherDetail,SaleId };

            try
            {

                foreach (var item in FeeVoucherDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }



                FeeVoucher.TenantId = bv.TenantId; FeeVoucher.AppId = bv.AppId; FeeVoucher.CreatedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }
























        public string Transaction_FeeVoucherUpdate(BValues bv, string ip, string cInfo, FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail)
        {
            var parameters = new { x = FeeVoucher, FeeVoucherDetail };

            try
            {

                foreach (var item in FeeVoucherDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }


                FeeVoucher.TenantId = bv.TenantId; FeeVoucher.AppId = bv.AppId; FeeVoucher.CreatedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }








           public string Transaction_CusFeeVoucherUpdate(BValues bv, string ip, string cInfo, FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail)
        {
            var parameters = new { x = FeeVoucher, FeeVoucherDetail };

            try
            {

                foreach (var item in FeeVoucherDetail)
                {



                    item.TenantId = bv.TenantId; item.AppId = bv.AppId; item.CreatedBy = bv.UserId;
                }


                FeeVoucher.TenantId = bv.TenantId; FeeVoucher.AppId = bv.AppId; FeeVoucher.CreatedBy = bv.UserId;

                string message = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }






















        public FeeVoucher Transaction_FeeVoucherGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                FeeVoucher record = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }




        //public FeeVoucher Transaction_FeeVoucherGetById(int id, BValues bv, string ip, string cInfo)
        //{
        //    var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

        //    try
        //    {
        //        FeeVoucher record = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection()).FirstOrDefault();

        //        Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

        //        return record;
        //    }
        //    catch (Exception ex)
        //    {
        //        Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

        //        return null;
        //    }
        //}

        public FeeVoucher Transaction_FeeVoucherSaleIdGetById(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                FeeVoucher record = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection()).FirstOrDefault();

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return record;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }





        
        public List<FeeVoucher> Transaction_FeeVoucherGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<FeeVoucher> records = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

           public List<FeeVoucher> GetFeeVoucherNo(int VoucherId, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, voucherId = VoucherId };

            try
            {
                List<FeeVoucher> records = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }


          public List<FeeVoucher> Transaction_CustomizedFeeVoucherGetAll(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                List<FeeVoucher> records = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection());

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return records;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }















        public DataTable Transaction_FeeVoucherGetAllTable(BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId };

            try
            {
                DataTable dataTable = DataBase.ExecuteforReport(parameters, Connection.GetConnection(), "Transaction_FeeVoucherGetAllTable");

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return dataTable;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return null;
            }
        }

        public string Transaction_FeeVoucherDelete(int id, BValues bv, string ip, string cInfo)
        {
            var parameters = new { bv.UserId, bv.TenantId, bv.AppId, Id = id };

            try
            {
                string message = DataBase.ExecuteQuery<FeeVoucher>(parameters, Connection.GetConnection()).FirstOrDefault().ReturnMessage;

                Loging.DB_Log(eLogType.Log_Posetive, "", parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return message;
            }
            catch (Exception ex)
            {
                Loging.DB_Log(eLogType.Log_Negative, ex.Message, parameters, "", MODULE, Connection.GetLogConnection(), cInfo, ip, bv.UserId);

                return ex.Message;
            }
        }
    }
}