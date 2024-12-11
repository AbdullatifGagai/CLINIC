using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Transaction_ReceiptController : Controller
    {
        public List<Transaction_Receipt> Transaction_ReceiptGetAll(BValues bv, string ip, string cInfo)
        {
            return new Transaction_Receipt().Transaction_ReceiptGetAll(bv, ip, cInfo);
        }

        public Transaction_Receipt Transaction_ReceiptGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_Receipt().Transaction_ReceiptGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Transaction_ReceiptSave(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_Receipt)objList[0]).Transaction_ReceiptSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_ReceiptUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_Receipt)objList[0]).Transaction_ReceiptUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_ReceiptDelete(int id,int Refid, BValues bv, string ip, string cInfo)
        {
            return new Transaction_Receipt().Transaction_ReceiptDelete(id, Refid, bv, ip, cInfo);
        }

        [HttpGet]
        public List<Transaction_Receipt> Transaction_ReceiptGetAllWithPagination(BValues bv, string ip, string cinfo, int length, int offset, string search, int status)
        {
            return new Transaction_Receipt().Transaction_ReceiptGetAllWithPagination(bv, ip, cinfo, length, offset, search, status);
        }










    }
}