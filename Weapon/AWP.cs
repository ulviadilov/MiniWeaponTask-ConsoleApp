using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Interfaces;

namespace Weapon
{
    internal class AWP : Weapon , ISingle, IWeapon
    {
        public int BulletCapacity { get; set; }
        public int BulletCount { get; set; }

        

        public void Reload()
        {
            BulletCount = BulletCapacity;
        }

        public void Shoot()
        {
            if (BulletCount != 0)
            {
                Console.WriteLine("Shooted");
                BulletCount--;
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

        public void EditCount(int newBulletCount)
        {
            BulletCount = newBulletCount;
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
