using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class PredictViewModel : BaseModel
    {

        bool _technology;
        int _level;
        public int PredictedValue { get; set; }

        public bool Technology { get => _technology; set { _technology = value;OnPropertyChange(); } }
        public int Level { get => _level;set { _level = value;OnPropertyChange(); } }



        PredictViewModel() {

            

        }

        public int Predict(int x , int y, int z ) {

            return 100 * x * (2 - y / 100) * (2 - z / 100);

        }


    }
}
