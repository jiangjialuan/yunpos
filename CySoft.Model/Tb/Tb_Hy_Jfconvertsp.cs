﻿#region Imports
using System;
using System.Diagnostics;
using CySoft.Model.Mapping;
#endregion

#region
#endregion

namespace CySoft.Model.Tb
{
    [Serializable]
    [Table("tb_hy_jfconvertsp", "Tb_Hy_Jfconvertsp")]
    [DebuggerDisplay("id = {id}")]
    public class Tb_Hy_Jfconvertsp
    {

        #region public method

        public Tb_Hy_Jfconvertsp Clone()
        {
            return (Tb_Hy_Jfconvertsp)this.MemberwiseClone();
        }

        #endregion

        #region private field

        private string _id_masteruser = String.Empty;
        private string _id = String.Empty;
        private string _id_shop = String.Empty;
        private int _sort_id = 0;
        private DateTime _day_b = new DateTime(1900, 1, 1);
        private DateTime _day_e = new DateTime(1900, 1, 1);
        private string _id_hyfl = String.Empty;
        private string _weeks = String.Empty;
        private string _id_sp = String.Empty;
        private decimal _je = 0m;
        private decimal _jf = 0m;
        private decimal _dj_ls = 0m;
        private byte _flag_delete = 0;
        private string _id_create = String.Empty;
        private DateTime _rq_create = new DateTime(1900, 1, 1);
        private byte[] _nlast = null;

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

        public string id_shop
        {
            get
            {
                return _id_shop;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _id_shop = value;
                }
                else
                {
                    _id_shop = String.Empty;
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

        public Nullable<DateTime> day_b
        {
            get
            {
                return _day_b;
            }
            set
            {
                if (value.HasValue)
                {
                    _day_b = value.Value;
                }
                else
                {
                    _day_b = new DateTime(1900, 1, 1);
                }
            }
        }

        public Nullable<DateTime> day_e
        {
            get
            {
                return _day_e;
            }
            set
            {
                if (value.HasValue)
                {
                    _day_e = value.Value;
                }
                else
                {
                    _day_e = new DateTime(1900, 1, 1);
                }
            }
        }

        public string id_hyfl
        {
            get
            {
                return _id_hyfl;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _id_hyfl = value;
                }
                else
                {
                    _id_hyfl = String.Empty;
                }
            }
        }

        public string weeks
        {
            get
            {
                return _weeks;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _weeks = value;
                }
                else
                {
                    _weeks = String.Empty;
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

        public Nullable<decimal> jf
        {
            get
            {
                return _jf;
            }
            set
            {
                if (value.HasValue)
                {
                    _jf = value.Value;
                }
                else
                {
                    _jf = 0m;
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

        public Nullable<byte> flag_delete
        {
            get
            {
                return _flag_delete;
            }
            set
            {
                if (value.HasValue)
                {
                    _flag_delete = value.Value;
                }
                else
                {
                    _flag_delete = 0;
                }
            }
        }

        [Column(Update = false)]
        public string id_create
        {
            get
            {
                return _id_create;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _id_create = value;
                }
                else
                {
                    _id_create = String.Empty;
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

        public Byte[] nlast { get; set; }

        #endregion

    }


    public class Tb_Hy_Jfconvertsp_Query : Tb_Hy_Jfconvertsp
    {
        public string spmc { set; get; }
    }




}
