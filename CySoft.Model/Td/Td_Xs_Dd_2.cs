﻿#region Imports
using System;
using System.Diagnostics;
using CySoft.Model.Mapping;
#endregion

#region
#endregion

namespace CySoft.Model.Td
{
    [Serializable]
    [Table("td_xs_dd_2", "Td_Xs_Dd_2")]
    [DebuggerDisplay("id = {id}")]
    public class Td_Xs_Dd_2
    {
        #region public method

        public Td_Xs_Dd_2 Clone()
        {
            return (Td_Xs_Dd_2)this.MemberwiseClone();
        }

        #endregion

        #region private field

        private string _id_masteruser = String.Empty;
        private string _id = String.Empty;
        private string _id_bill = String.Empty;
        private int _sort_id = 0;
        private string _id_shopsp = String.Empty;
        private string _id_sp = String.Empty;
        private string _id_kcsp = String.Empty;
        private decimal _zhl = 0m;
        private decimal _sl = 0m;
        private decimal _sl_total = 0m;
        private string _barcode = String.Empty;
        private string _dw = String.Empty;
        private decimal _dj = 0m;
        private decimal _je = 0m;
        private decimal _sl_kc = 0m;
        private decimal _dj_jh_last = 0m;
        private decimal _dj_ls = 0m;
        private string _bz = String.Empty;
        private DateTime _rq_create = new DateTime(1900, 1, 1);


        #endregion

        #region public property

        public string id_masteruser
        {
            get
            {
                return _id_masteruser;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _id_masteruser = value;
                }
                else
                {
                    _id_masteruser = String.Empty;
                }
            }
        }

        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _id = value;
                }
                else
                {
                    _id = String.Empty;
                }
            }
        }

        public string id_bill
        {
            get
            {
                return _id_bill;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _id_bill = value;
                }
                else
                {
                    _id_bill = String.Empty;
                }
            }
        }

        public Nullable<int> sort_id
        {
            get
            {
                return _sort_id;
            }
            set
            {
                if (value.HasValue)
                {
                    _sort_id = value.Value;
                }
                else
                {
                    _sort_id = 0;
                }
            }
        }

        public string id_shopsp
        {
            get
            {
                return _id_shopsp;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _id_shopsp = value;
                }
                else
                {
                    _id_shopsp = String.Empty;
                }
            }
        }

        public string id_sp
        {
            get
            {
                return _id_sp;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _id_sp = value;
                }
                else
                {
                    _id_sp = String.Empty;
                }
            }
        }

        public string id_kcsp
        {
            get
            {
                return _id_kcsp;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _id_kcsp = value;
                }
                else
                {
                    _id_kcsp = String.Empty;
                }
            }
        }

        public Nullable<decimal> zhl
        {
            get
            {
                return _zhl;
            }
            set
            {
                if (value.HasValue)
                {
                    _zhl = value.Value;
                }
                else
                {
                    _zhl = 0m;
                }
            }
        }

        public Nullable<decimal> sl
        {
            get
            {
                return _sl;
            }
            set
            {
                if (value.HasValue)
                {
                    _sl = value.Value;
                }
                else
                {
                    _sl = 0m;
                }
            }
        }

        public Nullable<decimal> sl_total
        {
            get
            {
                return _sl_total;
            }
            set
            {
                if (value.HasValue)
                {
                    _sl_total = value.Value;
                }
                else
                {
                    _sl_total = 0m;
                }
            }
        }

        public string barcode
        {
            get
            {
                return _barcode;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _barcode = value;
                }
                else
                {
                    _barcode = String.Empty;
                }
            }
        }

        public string dw
        {
            get
            {
                return _dw;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _dw = value;
                }
                else
                {
                    _dw = String.Empty;
                }
            }
        }

        public Nullable<decimal> dj
        {
            get
            {
                return _dj;
            }
            set
            {
                if (value.HasValue)
                {
                    _dj = value.Value;
                }
                else
                {
                    _dj = 0m;
                }
            }
        }

        public Nullable<decimal> je
        {
            get
            {
                return _je;
            }
            set
            {
                if (value.HasValue)
                {
                    _je = value.Value;
                }
                else
                {
                    _je = 0m;
                }
            }
        }

        public Nullable<decimal> sl_kc
        {
            get
            {
                return _sl_kc;
            }
            set
            {
                if (value.HasValue)
                {
                    _sl_kc = value.Value;
                }
                else
                {
                    _sl_kc = 0m;
                }
            }
        }

        public Nullable<decimal> dj_jh_last
        {
            get
            {
                return _dj_jh_last;
            }
            set
            {
                if (value.HasValue)
                {
                    _dj_jh_last = value.Value;
                }
                else
                {
                    _dj_jh_last = 0m;
                }
            }
        }

        public Nullable<decimal> dj_ls
        {
            get
            {
                return _dj_ls;
            }
            set
            {
                if (value.HasValue)
                {
                    _dj_ls = value.Value;
                }
                else
                {
                    _dj_ls = 0m;
                }
            }
        }

        public string bz
        {
            get
            {
                return _bz;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _bz = value;
                }
                else
                {
                    _bz = String.Empty;
                }
            }
        }

        [Column(Update = false, Insert = false)]
        public Nullable<DateTime> rq_create
        {
            get
            {
                return _rq_create;
            }
            set
            {
                if (value.HasValue)
                {
                    _rq_create = value.Value;
                }
                else
                {
                    _rq_create = new DateTime(1900, 1, 1);
                }
            }
        }

        public byte[] nlast { set; get; }


        #endregion

    }



    public class Td_Xs_Dd_2_QueryModel : Td_Xs_Dd_2
    {

        #region public method

        public Td_Xs_Dd_2_ApiModel CloneApiModel()
        {
            var model = (Td_Xs_Dd_2_QueryModel)this.MemberwiseClone();
            Td_Xs_Dd_2_ApiModel rModel = new Td_Xs_Dd_2_ApiModel();
            rModel.id_bill = model.id_bill;
            rModel.sort_id = model.sort_id;
            rModel.id_shopsp = model.id_shopsp;
            rModel.dj = model.dj;
            rModel.sl = model.sl;
            rModel.je = model.je;
            return rModel;
        }

        #endregion


        public decimal? dj_jh_last { set; get; }
        public decimal? dj_jh { set; get; }
        public decimal? dj_ls { set; get; }
        public string shopsp_name { set; get; }

    }



}