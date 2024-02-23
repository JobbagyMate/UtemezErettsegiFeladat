using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtemezErettsegiFeladat
{
    internal class Taborok
    {
        public int KezdHo { get; set; }
        public int KezdNap { get; set; }
        public int VegHo { get; set; }
        public int VegNap { get; set; }
        public string DiakBetujel { get; set; }
        public string TaborTema { get; set; }

        public Taborok(string r)
        {
            var v = r.Split('\t');
            KezdHo = int.Parse(v[0]);
            KezdNap = int.Parse(v[1]);
            VegHo = int.Parse(v[2]);
            VegNap = int.Parse(v[3]);
            DiakBetujel = v[4];
            TaborTema = v[5];
        }
    }
}
