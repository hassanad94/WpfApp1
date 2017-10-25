using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Planguage : BaseModel
    {
        string _name;
        string _territory;
        int _status;

        public string Name { get => _name;set { _name = value;OnPropertyChange(); } }
        public string Territory { get => _territory; set {_territory= value; OnPropertyChange(); } }
        public int Status { get => _status;set { _status = value;OnPropertyChange(); } }


    }
}
