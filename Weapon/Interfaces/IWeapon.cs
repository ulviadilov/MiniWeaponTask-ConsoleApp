using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Interfaces
{
    internal interface IWeapon
    {
        public void EditCount(int newBulletCount);
        public void EditCapacity(int newBulletCapacity);
        public void Reload();
        public int GetRemainBulletCount();
        public void ShowInfo();
    }
}
