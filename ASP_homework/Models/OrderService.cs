using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_homework.Models
{
    /// <summary>
    /// 訂單的服務
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// 新增
        /// </summary>
        public void InsertOrder()
        {

        }
        /// <summary>
        /// 刪除
        /// </summary>
        public void DeleteOrderById()
        {

        }
        /// <summary>
        /// 更新
        /// </summary>
        public void UpdateOrder()
        {

        }
        /// <summary>
        /// 取得
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id)
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName="叡揚資訊";
            return result;
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrder()
        {
            return new List<Order>();
        }

        
    }
}