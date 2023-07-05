using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;


namespace DoMeasureMSC.Data
{
    internal class RcpSetting : INotifyPropertyChanged, IEditableObject
    {

        // ** fields
        public string _reqmbno =null;
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
        public RcpSetting()
        {

        }
        //public RcpSetting(string name)
        //{
        //    // this.NO = "1";
        //    // this.name = "";

        //}

        public string _no;
        public string _recipename;
        public string _method;
        public string _stdname;
        public string _reqmbname;

        [Display(Name = "NO")]
        public string NO
        {
            get { return _no; }
            set
            {
                _no = value;
                //RaisePropertyChanged(_no);
            }
        }
        [Display(Name = "레시피명")]
        public string RecipeName
        {
            get { return _recipename; }
            set
            {
                _recipename = value;
                //RaisePropertyChanged(_recipename);
            }
        }
        [Display(Name = "시험방법")]
        public string Method
        {
            get { return _method; }
            set
            {
                _method = value;
                //RaisePropertyChanged(_method);
            }
        }
        [Display(Name = "표준시편명")]
        public string StdName
        {
            get { return _stdname; }
            set
            {
                _stdname = value;
                //RaisePropertyChanged(_stdname);
            }
        }
        [Display(Name = "의뢰자명")]
        public string ReqmbName
        {
            get { return _reqmbname; }
            set
            {
                _reqmbname = value;
                ReqmbNamePropertyChanged(_reqmbname);
            }
        }

        [Display(Name = "name")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                ReqmbNamePropertyChanged(_name);
            }

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

        private void ReqmbNamePropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            //if (PropertyChanged != null)
            //    PropertyChanged(this, e);
            PropertyChanged?.Invoke(this, e);
        }

        #endregion

        //-----------------------------------------------------------------------------------
        #region IEditableObject Members

        // this interface allows transacted edits (user can press escape to restore previous values).

        private RcpSetting _clone;


        public void BeginEdit()
        {
            _clone = (RcpSetting)MemberwiseClone();
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

        // ** static list provider
        public static ObservableCollection<RcpSetting> GetRcpSettingList(int count)
        {
            var list = new ObservableCollection<RcpSetting>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new RcpSetting());// i.ToString()));
            }
            return list;
        }
        #endregion
    }
}
