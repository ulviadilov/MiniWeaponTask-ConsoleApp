using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Interfaces;

namespace Weapon
{
    internal class UZI :Weapon , IAuto, IWeapon
    {
        public int BulletCount { get; set; }
        public int BulletCapacity { get; set; }

        
        public void EditCount(int newBulletCount)
        {
            if (newBulletCount<=BulletCapacity)
            {
                BulletCount = newBulletCount;
            }
            else
            {
                Console.WriteLine("Bullet countu bullet capacitysinden cox ola bilmez");
            }
        }

        public void Fire()
        {
            if (BulletCount != 0)
            {
                Console.WriteLine("Fired");
                BulletCount = 0;
            }
            else
            {
                Console.WriteLine("Reload edin");
            }
        }

        public int GetRemainBulletCount()
        {
            return BulletCount;
        }

        public void Reload()
        {
            BulletCount = BulletCapacity;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Bullet capacity: {BulletCapacity} Bullet count {BulletCount} ");
        }


        public void EditCapacity(int newBulletCapacity)
        {
            BulletCapacity = newBulletCapacity;
        }
    }
}
