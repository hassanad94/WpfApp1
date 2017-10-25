using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class PlanguageViewModel : BaseModel
    {
        public Planguage Planguage { get; set; }
        public bool IsNew { get; set; }

       
        public PlanguageViewModel(Planguage Planguage) {

            this.Planguage = Planguage;
            if (!IsNew)
                Save();


        }

        public void Save() {
            if(!IsNew)
            Planguage = new Planguage { Name = Planguage.Name, Territory = Planguage.Territory, Status = Planguage.Status }; 
        }

        public bool Valid() {
            return !string.IsNullOrEmpty(Planguage.Name) && Planguage.Status >= 0 && Planguage.Status <= 100;

        }

    }
}
