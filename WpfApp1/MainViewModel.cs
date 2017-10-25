using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public class MainViewModel : BaseModel
    {

        public ObservableCollection<Planguage> LanguageList { get; set; }
        public Planguage SelectedPlanguage { get; set; }

        public MainViewModel() {
            LanguageList = new ObservableCollection<Planguage>
            {
                new Planguage{ Name="Java",Territory="backend", Status=90 },
                new Planguage {Name="HTML",Territory="frontend",Status=60},
                new Planguage{Name="Android",Territory="Mobil",Status=80}

            };


        }


    }
}
