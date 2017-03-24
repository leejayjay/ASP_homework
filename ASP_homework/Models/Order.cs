using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_homework.Models
{
    public class Order
    {
        ///<summary>
        ///訂單編號
        /// </summary>
        public int OrderId { get; set; }

        ///<summary>
        ///客戶代號
        /// </summary>
        public String CustId { get; set; }

        ///<summary>
        ///客戶名稱
        /// </summary>
        public String CustName { get; set; }

        ///<summary>
        ///業務(員工)代號
        /// </summary>
        public int EmpId { get; set; }

        ///<summary>
        ///業務(員工姓名)
        /// </summary>
        public String EmpName { get; set; }

        ///<summary>
        ///訂單日期
        /// </summary>
        public DateTime ?OrderDate  { get; set; }

        ///<summary>
        ///需要日期
        /// </summary>
        public DateTime? RequireDate { get; set; }

        ///<summary>
        ///出貨日期
        /// </summary>
        public DateTime? ShippedDate { get; set; }

        ///<summary>
        ///出貨公司代號
        /// </summary>
        public int ShipperId { get; set; }

        ///<summary>
        ///出貨公司名稱
        /// </summary>
        public String ShippedName { get; set; }

        ///<summary>
        ///運費
        /// </summary>
        public double Freight { get; set; }

        ///<summary>
        ///出貨說明
        /// </summary>
        public String ShipName { get; set; }

        ///<summary>
        ///出貨地址
        /// </summary>
        public String ShipAddress { get; set; }

        ///<summary>
        ///出貨地區
        /// </summary>
        public String ShipRegion { get; set; }

        ///<summary>
        ///郵遞區號
        /// </summary>
        public String ShipPostalCode { get; set; }

        ///<summary>
        ///出貨國家
        /// </summary>
        public String ShipCountry  { get; set; }
    }
}