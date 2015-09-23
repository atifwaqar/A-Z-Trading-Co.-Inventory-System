﻿using Starcounter;
using System;

namespace ThePrimeBaby.Database.Base
{
    public class Item : Concept
    {
        public int QTY_BOX;
        public decimal COSTPRICE;
        public decimal PRICE;
        public string IMAGE;
        public string MODEL;
        public string CODE;
        public int T_QUANTITY 
        {
            get 
            {
                QueryResultRows<ThePrimeBaby.Database.ShipmentDetail> shipments = Db.SQL<ThePrimeBaby.Database.ShipmentDetail>("SELECT s FROM ThePrimeBaby.Database.ShipmentDetail s WHERE s.Item = ?", this);
                int ItemShipmentCount = 0;
                foreach (ShipmentDetail BoughtItem in shipments)
                {
                    ItemShipmentCount += BoughtItem.T_QUANTITY;
                }

                QueryResultRows<ThePrimeBaby.Database.BillDetail> bills = Db.SQL<ThePrimeBaby.Database.BillDetail>("SELECT s FROM ThePrimeBaby.Database.BillDetail s WHERE s.Item = ?", this);
                int ItemBillCount = 0;
                foreach (BillDetail SoldItem in bills)
                {
                    ItemBillCount += SoldItem.T_QUANTITY;
                }

                return (ItemShipmentCount  - ItemBillCount);
            }
        }
        public Category Category;
        internal static bool AddItem(string Code, string Model, int QTY_Box, decimal Price,decimal CostPrice, string ImagePath, Category ItemCategory)
        {
            try
            {
                Db.Transact(() => {
                    Item item = new Item();
                    item.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Base.Item b").First) + 1; 
                    item.CODE = Code.Trim();
                    item.MODEL = Model.Trim();
                    item.QTY_BOX = QTY_Box;
                    item.PRICE = Price;
                    item.COSTPRICE = CostPrice;
                    item.IMAGE = ImagePath.Trim();
                    item.Category = ItemCategory;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool DeleteItem(string Name)
        {
            try
            {
                Db.Transact(() => 
                {
                    Db.SlowSQL("DELETE FROM Item Where i.Name = ?", Name.Trim());
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool ModifyItems(string FindName, string ReplaceName, Database.Base.Item item)
        {
            try
            {
                //Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Name = ?", FindName).First;
                Db.Transact(() => 
                {
                    item.NAME = ReplaceName.Trim();
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool ModifyItems(string FindID, string ReplaceCode, string ReplaceModel, string ReplacePrice, string ReplaceCostPrice, string ReplaceImage, string ItemCategory, int T_Quantity, Database.Base.Item item)
        {
            try
            {
                //Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Id = ?", Convert.ToInt32(FindID)).First;
                Db.Transact(() =>
                {
                    item.ID = Convert.ToInt32(FindID);
                    item.CODE = ReplaceCode.Trim();
                    item.MODEL = ReplaceModel.Trim();
                    item.PRICE= Convert.ToDecimal(ReplacePrice);
                    item.COSTPRICE = Convert.ToDecimal(ReplaceCostPrice);
                    item.IMAGE = ReplaceImage.Trim();
                    item.Category = Db.SQL<Database.Base.Category>("SELECT c FROM ThePrimeBaby.Database.Base.Category c WHERE c.Name = ?", ItemCategory).First;
                    if (item.Category == null)
                    {
                        item.Category = new Category();
                        item.Category.NAME = ItemCategory;
                    }
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool ModifyItemPriceByName(string ItemName, decimal ItemPrice, Database.Base.Item item)
        {
            try
            {
                //Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Name = ?", ItemName).First;
                Db.Transact(() =>
                {
                    item.PRICE = ItemPrice;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool ModifyItemPriceByCode(decimal ItemCostPrice, decimal ItemPrice, Database.Base.Item item)
        {
            try
            {
                Db.Transact(() =>
                {
                    item.COSTPRICE = ItemCostPrice;
                    item.PRICE = ItemPrice;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
