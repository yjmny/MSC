using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace DoMeasureMSC.Data
{
    internal class ReqMemberClass : INotifyPropertyChanged, IEditableObject
    {
        // ** fields
        public string _reqmbno = null;
        public string _id = null;
        public string _regdate = null;
        public string _outdate = null;
        public string _out10 = null;
        public string _divlevel = null;
        public string _comname = null;
        public string _teamname = null;
        public string _tel1 = null;
        public string _tel2 = null;
        public string _use10 = null;
        public string _name = null;
        public string _contact = null;
        public string _updatedate = null;

        // ** data generators
        private static string[] _names = "Andy|Ben|Charlie|Dan|Ed|Fred|Gil|Herb|Jack|Karl|Larry|Mark|Noah|Oprah|Paul|Quince|Rich|Steve|Ted|Ulrich|Vic|Xavier|Zeb".Split('|');
        // ** ctors
        public ReqMemberClass()// : this(_rnd.Next())
        {
        }
        public ReqMemberClass(string name)// : this(_rnd.Next())
        {
            this.Name = name;
        }


        [Display(Name = "name")]
        public string Name
        {
  
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(_name);
            }

        }
        // ** static list provider
        public static ObservableCollection<ReqMemberClass> GetCustomerList(int count)
        {
            var list = new ObservableCollection<ReqMemberClass>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new ReqMemberClass(i.ToString()));
            }
            return list;
        }

        // ** static value providers
        public static string[] GetNames() { return _names; }
        public static void SetNames(DataSet ds, string colName)
        {
            _names = null;

            string str1 = "";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                str1 += row[colName].ToString() + "|";
            }

            _names = str1.Split('|');
        }

        //-----------------------------------------------------------------------------------
        #region ** INotifyPropertyChanged Members

        // this interface allows bounds controls to react to changes in the data objects.

        private void RaisePropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
#pragma warning disable IDE1005
            if (PropertyChanged != null)
                PropertyChanged(this, e);
#pragma warning restore IDE1005
        }

        #endregion

        //-----------------------------------------------------------------------------------
        #region IEditableObject Members

        // this interface allows transacted edits (user can press escape to restore previous values).

        private ReqMemberClass _clone;
        public void BeginEdit()
        {
            _clone = (ReqMemberClass)MemberwiseClone();
        }
        public void EndEdit()
        {
            _clone = null;
        }
        public void CancelEdit()
        {
            if (_clone != null)
            {
                foreach (var p in GetType().GetProperties())
                {
                    if (p.CanRead && p.CanWrite)
                    {
                        p.SetValue(this, p.GetValue(_clone, null), null);
                    }
                }
            }
        }
        #endregion
    }
}
