﻿using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class BillDetail
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetSaleByBillId/{?}", (string BillId, Request r) =>
            {
                QueryResultRows<Database.BillDetail> billDetail = Db.SQL<Database.BillDetail>("SELECT bd FROM Database.BillDetail bd WHERE bd.Bill.Id = ?",BillId);
                BillDetailJson billDetailJson = new BillDetailJson();
                billDetailJson.BillDetails.Data = billDetail;
                return billDetailJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetBillDetailsByBillNumber/{?}", (string BillNumber, Request r) =>
            {
                QueryResultRows<Database.BillDetail> billDetail = Db.SQL<Database.BillDetail>("SELECT bd FROM Database.BillDetail bd WHERE bd.Bill.BillNumber = ?", BillNumber);
                BillDetailJson billDetailJson = new BillDetailJson();
                billDetailJson.BillDetails.Data = billDetail;
                return billDetailJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/ModifyBillAmmountByBillNumber", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.BillDetail billDetail = Db.SQL<Database.BillDetail>("SELECT i FROM Database.BillDetail i WHERE i.Id = ?", Convert.ToInt32(Attributes[0])).First;
                if (billDetail != null)
                {
                    bool Result = Database.Bill.ModifyBillAmmount(Convert.ToInt32(Attributes[0]), Convert.ToDecimal(Attributes[1]));
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Db.SlowSQL("DELETE FROM Database.BillDetail v WHERE v.Bill.BillNumber = ?", Attributes[0]);
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddSale/9", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.BillDetail billDetail = Db.SQL<Database.BillDetail>("SELECT c FROM Database.BillDetail c WHERE c.Name = ?", Attributes[0]).First;
                if (billDetail == null)
                {
                    Database.Bill bill = Db.SQL<Database.Bill>("SELECT b FROM Database.Bill b WHERE b.Id = ?", Attributes[2]).First;
                    Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT b FROM Database.Base.Item b WHERE b.Code = ?", Attributes[4]).First;
                    Database.Customer customer = Db.SQL<Database.Customer>("SELECT b FROM Database.Customer b WHERE b.Id = ?", Attributes[8]).First;
                    bool Result = ThePrimeBaby.Database.BillDetail.AddSale(Convert.ToDecimal(Attributes[0]), Convert.ToInt32(Attributes[1]), bill,Convert.ToDecimal(Attributes[3]),item, Convert.ToInt32(Attributes[6]), Convert.ToInt32(Attributes[7]),customer);
                    if (Result == true )
                        return 200;
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

        }
    }
}