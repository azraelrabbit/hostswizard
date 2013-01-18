using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using HWUtility.Utilit;

namespace HWUtility.Utilit
{
    [Serializable]
    public class HostsItem : INotifyPropertyChanged
    {
        string _enabled;

        private Guid _ID;
        public Guid ID
        {
            get { return _ID; }
            set
            {
                if (_ID == value)
                {
                    return;
                }
                _ID = value;
                RaisePropertyChanged("ID");
            }
        }

        private Guid _parentID;
        public Guid ParentID
        {
            get { return _parentID; }
            set
            {
                if (_parentID == value)
                {
                    return;
                }
                _parentID = value;
                RaisePropertyChanged("ParentID");
            }
        }

        private string _IP;
        public string IP
        {
            get { return _IP; }
            set
            {
                if (_IP == value)
                {
                    return;
                }
                _IP = value;
                RaisePropertyChanged("IP");
            }
        }

        private string _Domain;
        public string Domain
        {
            get { return _Domain; }
            set
            {
                if (_Domain == value)
                {
                    return;
                }
                _Domain = value;
                RaisePropertyChanged("Domain");
            }
        }


        public bool Enable
        {
            get
            {
                return string.IsNullOrEmpty(_enabled) ? true : false;
            }
            set
            {
                if (value && _enabled == null)
                {
                    return;
                }
                if (!value && _enabled == "#")
                {
                    return;
                }
                if (value)
                {
                    _enabled = null;
                }
                else
                {
                    _enabled = "#";
                }
                RaisePropertyChanged("Enable");
            }
        }

        private bool _Expended;
        public bool Expended
        {
            get { return _Expended; }
            set
            {
                if (_Expended == value)
                {
                    return;
                }
                _Expended = value;
                RaisePropertyChanged("Expended");
            }
        }

        private string _Group;
        public string Group
        {
            get { return _Group; }
            set
            {
                if (_Group == value)
                {
                    return;
                }
                _Group = value;
                RaisePropertyChanged("Group");
            }
        }

        public EnumItemType Type
        {
            get;
            set;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
