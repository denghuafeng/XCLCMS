﻿using System.Collections.Generic;

namespace XCLCMS.Data.BLL
{
    /// <summary>
    /// 商户应用表
    /// </summary>
    public partial class MerchantApp
    {
        private readonly XCLCMS.Data.DAL.MerchantApp dal = new XCLCMS.Data.DAL.MerchantApp();

        public MerchantApp()
        { }

        #region BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XCLCMS.Data.Model.MerchantApp model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XCLCMS.Data.Model.MerchantApp model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XCLCMS.Data.Model.MerchantApp GetModel(long MerchantAppID)
        {
            return dal.GetModel(MerchantAppID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XCLCMS.Data.Model.MerchantApp> GetModelList(string strWhere)
        {
            return dal.GetModelList(strWhere);
        }

        #endregion BasicMethod
    }
}