﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CySoft.Model.Td;
using CySoft.Utility;

namespace CySoft.Model.CxModel
{
    public class DZZKModel:BaseCx
    {

        public override void CheckParam()
        {
            Handle();
            base.CheckParam();
            #region
            if (condition_1 == 0 || result_1 == 0)
            {
                Errors.Add("请按顺序一、二、三设置打折条件!");
                return;
            }
            if ((condition_2 == 0 && condition_3 != 0) || (result_2 == 0 && result_3 != 0))
            {
                Errors.Add("请按顺序一、二、三设置打折条件!");
                return;
            }
            if ((condition_2 == 0 && result_2 != 0) || (condition_2 != 0 && result_2 == 0))
            {
                Errors.Add("规则二设置不完整!");
                return;
            }
            if ((condition_3 == 0 &&result_3 != 0) || (condition_3 != 0 && result_3 == 0))
            {
                Errors.Add("规则三设置不完整!");
                return;
            }
            if (condition_2 != 0 && condition_2 <= condition_1)
            {
                Errors.Add("规则二的条件必需大于规则一的条件!");
                return;
            }
            if (condition_3 != 0 && condition_3 <= condition_2)
            {
                Errors.Add("规则三的条件必需大于规则二的条件!");
                return;
            }
            if (result_2 > 0 && result_2 >= result_1)
            {
                Errors.Add("规则二的折扣必需小于规则一的折扣!");
                return;
            }
            if (result_3 > 0 && result_3 >= result_2)
            {
                Errors.Add("规则三的折扣必需小于规则二的折扣!");
                return;
            }
            if (string.IsNullOrEmpty(jsgz))
            {
                Errors.Add("请选择结算规则!");
                return;
            }
            if (result_1 > 1 || result_1 < 0)
            {
                Errors.Add("折扣1只能设置0-1的数!");
                return;
            }
            if (result_2 > 1 || result_2 < 0)
            {
                Errors.Add("折扣2只能设置0-1的数!");
                return;
            }
            if (result_3 > 1 || result_3 < 0)
            {
                Errors.Add("折扣3只能设置0-1的数!");
                return;
            }
            if (string.IsNullOrEmpty(sp)||!sp.Contains("id_object"))
            {
                Errors.Add("请选择商品!");
                return;
            }
            #endregion


            if (!PromoteShopList.Any())
            {
                Errors.Add("请选择促销门店!");
            }
        }

        public override void HandlePromote1()
        {
            base.HandlePromote1();
            Promote1.style = "dzsp";
            Promote1.bm_djlx = "CX130";
            Promote1.preferential = "zk";
            Promote1.condition_1 = condition_1;
            Promote1.condition_2 = condition_2;
            Promote1.condition_3 = condition_3;
            Promote1.result_1 = result_1;
            Promote1.result_2 = result_2;
            Promote1.result_3 = result_3;
        }

        public override void HandlePromote2List()
        {
            var list = JSON.Deserialize<List<Td_Promote_2>>(sp);
            var date = DateTime.Now;
            if (list.Any())
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var p = list[i];
                    p.id = Guid.NewGuid().ToString();
                    p.zh_group = "A";
                    p.id_masteruser = id_masteruser;
                    p.rq_create = date;
                    p.sort_id = i + 1;
                    p.id_bill = id;
                }
                Promote2List.AddRange(list);
            }
        }

    }
}
