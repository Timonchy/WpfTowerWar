using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfTowerWar
{
    class LevelMaker
    {
        public LevelMaker()
        {
            
        }

        public void MakeLvl(Canvas cnvs, double widht, double height, int bpSyze, List<BuildPlase> bpList)
        {
            for (var i = 0; i < widht / bpSyze -1; i++)
            for (var j = 0; j < height / bpSyze - 1; j++)
            {
                bpList.Add(new BuildPlase(i * bpSyze, j * bpSyze, true));
            }

            foreach (var bp in bpList)
            {
                bp.Draw(cnvs);
            }
        }
    }
}
