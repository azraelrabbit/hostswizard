using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HostsWizard.Utilit;

namespace HostsWizard
{
	public class HostsItem
	{
        string _enabled=string.Empty;

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

        public string Group
        {
            get;
            set;
        }

        public bool Enable
        {
            get
            {
                return (string.IsNullOrEmpty(_enabled));
            }
            set
            {
                if (value)
                {
                    _enabled = string.Empty;
                }
                else
                {
                    _enabled = "#";
                }
            }
        }

        public EnumItemType Type
        {
            get;
            set;
        }

	}
}
