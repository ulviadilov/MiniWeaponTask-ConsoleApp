using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Interfaces;

namespace Weapon
{
    internal class Deagle : Weapon , ISingle, IWeapon
    {
        public int BulletCount { get; set; }
        public int BulletCapacity { get; set; }

        public void EditCapacity(int newBulletCapacity)
        {
            BulletCapacity = newBulletCapacity;
        }

        public void EditCount(int newBulletCount)
        {
            BulletCount = newBulletCount;
        }

        public int GetRemainBulletCount()
        {
            return BulletCount;
        }

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
        public void ShowInfo()
        {
            Console.WriteLine($"Bullet capacity: {BulletCapacity} Bullet count {BulletCount} ");
        }
    }
}
