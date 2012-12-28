using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HWUtility.Utilit;

namespace HWUtility.Utilit
{
    [Serializable]
    public class HostsItem
    {
        string _enabled;

        public Guid ID
        {
            get;
            set;
        }

        public Guid ParentID
        {
            get;
            set;
        }

        public string IP
        {
            get;
            set;
        }

        public string Domain
        {
            get;
            set;
        }

        public bool Enable
        {
            get
            {
                return string.IsNullOrEmpty(_enabled) ? true : false;
            }
            set
            {
                if (value)
                {
                    _enabled = null;
                }
                else
                {
                    _enabled = "#";
                }
            }
        }

        public bool Expended
        {
            get;
            set;
        }

        public string Group
        {
            get;
            set;
        }

        public EnumItemType Type
        {
            get;
            set;
        }
    }
}
