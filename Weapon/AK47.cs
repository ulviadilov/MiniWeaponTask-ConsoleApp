using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Interfaces;

namespace Weapon
{
    internal class AK47 :Weapon , IChangeFireMode, IWeapon, ISingle, IAuto
    {
        public bool IsAuto { get; set; }
        public int BulletCapacity { get; set; }
        public int BulletCount { get; set; }


        public void ChangeFireMode()
        {
            if(IsAuto)
            {
                IsAuto = false;
            }
            else
            {
                IsAuto = true;
            }
        }

        public void Fire()
        {
            if(IsAuto)
            {
                Console.WriteLine("Fired");
                BulletCount = 0;
            }
            else
            {
                Console.WriteLine("Fired one time");
                BulletCount--;
            }
        }

        public int GetRemainBulletCount()
        {
            return BulletCount;
        }

        public void Reload()
        {
            Console.WriteLine("Reloaded");
            BulletCount = BulletCapacity;
        }

        public void Shoot()
        {
            if (BulletCount > 0)
            {
                Console.WriteLine("Shooted");
                BulletCount--;
            }
            else
            {
                Console.WriteLine("Reload edin");
            }
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
