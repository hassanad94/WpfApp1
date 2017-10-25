using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class Tesztelesre
    {
        public static int Predict(int x, int y, int z)
        {

            return 100 * x * (2 - y / 100) * (2 - z / 100);

        }

    }
}
