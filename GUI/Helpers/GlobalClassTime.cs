using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Helpers
{
    public sealed class GlobalClassTime
    {
        private static readonly GlobalClassTime _instance = new GlobalClassTime();

        public static GlobalClassTime Instance => _instance;

        public ClassTime TimeLesson { get; set; } = new ClassTime();

        private GlobalClassTime() { }
    }

}
