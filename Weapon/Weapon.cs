using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class Weapon
    {
        public int BulletCount { get; set; }
        public int BulletCapacity { get; set; }
        public bool IsAuto { get; set; }
        List<Weapon> weapons = new List<Weapon>();
    }
}
