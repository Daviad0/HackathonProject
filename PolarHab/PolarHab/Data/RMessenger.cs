using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolarHab.Data
{
    public static class RMessenger
    {
        public static event Action<double> ChangeProgressBar;
        public static void OnChangeProgressBar(double progress) => ChangeProgressBar?.Invoke(progress);
    }
}
