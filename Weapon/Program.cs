namespace Weapon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AK47 ak47 = new AK47();
            AWP awp = new AWP();
            UZI uzi = new UZI();
            Deagle deagle = new Deagle();

            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(ak47);
            weapons.Add(awp);
            weapons.Add(uzi);
            weapons.Add(deagle);
            

            string choice1;
            string choice2;
            bool check = false;
            bool checkAk = false;
            bool checkAwp = false;
            bool checkUzi = false;
            bool checkDeagle = false;

            do
            {
                Console.WriteLine("Silahi secin:\n" +
                    "AK47 ucun - 1\n" +
                    "AWP ucun - 2\n" +
                    "UZI ucun - 3\n" +
                    "Deagle ucun - 4");
                choice1 = Console.ReadLine();
                switch (choice1)
                {
                    case "1":
                        Console.Write("Bullet capacity : ");
                        ak47.BulletCapacity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Bullet count : ");
                        ak47.BulletCount = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Auto mode :");
                        ak47.IsAuto = Convert.ToBoolean(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("0 - İnformasiya almaq üçün\n" +
                            "1 - Shoot metodu üçün\n" +
                            "2 - Fire metodu üçün\n" +
                            "3 - GetRemainBulletCount metodu üçün\n" +
                            "4 - Reload metodu üçün\n" +
                            "5 - ChangeFireMode metodu üçün\n" +
                            "6 - Edit :\n" +
                            "7 - Proqrami dayandir");
                            choice2 = Console.ReadLine();
                            switch (choice2)
                            {
                                case "0":
                                    ak47.ShowInfo();
                                    break;
                                case "1":
                                    ak47.Shoot();
                                    break;
                                case "2":
                                    ak47.Fire();
                                    break;
                                case "3":
                                    Console.WriteLine("Bullet count : " + ak47.GetRemainBulletCount());
                                    break;
                                case "4":
                                    ak47.Reload();
                                    break;
                                case "5":
                                    ak47.ChangeFireMode();
                                    break;
                                case "6":
                                    Console.WriteLine("Secim edin:\n" +
                                        "1-Capacityni deyisin\n" +
                                        "2-Countunu deyisin\n" +
                                        "3-Silahi deyisin");
                                    string choice3 = Console.ReadLine();
                                    switch (choice3)
                                    {
                                        case "1":
                                            Console.Write("Yeni capacityni daxil edin :");
                                            int newCapacity = Convert.ToInt32(Console.ReadLine());
                                            awp.EditCapacity(newCapacity);
                                            break;
                                        case "2":
                                            Console.Write("Yeni countu daxil edin :");
                                            int newCount = Convert.ToInt32(Console.ReadLine());
                                            awp.EditCount(newCount);
                                            break;
                                        case "3":
                                            checkAk = true;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "7":
                                    check = true;
                                    break;
                                default:
                                    break;
                            }
                           
                        } while (!checkAk);
                        break;
                    case "2":
                        Console.Write("Bullet capacity : ");
                        awp.BulletCapacity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Bullet count : ");
                        awp.BulletCount = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("0 - İnformasiya almaq üçün\n" +
                            "1 - Shoot metodu üçün\n" +
                            "2 - GetRemainBulletCount metodu üçün\n" +
                            "3 - Reload metodu üçün\n" +
                            "4 - Edit :\n" +
                            "5 - Proqrami dayandir");
                            choice2 = Console.ReadLine();
                            switch (choice2)
                            {
                                case "0":
                                    awp.ShowInfo();
                                    break;
                                case "1":
                                    awp.Shoot();
                                    break;
                                case "2":
                                    Console.WriteLine("Bullet count : " + awp.GetRemainBulletCount());
                                    break;
                                case "3":
                                    awp.Reload();
                                    break;
                                case "4":
                                    Console.WriteLine("Secim edin:\n" +
                                        "1-Capacityni deyisin\n" +
                                        "2-Countunu deyisin\n" +
                                        "3-Silahi deyisin");
                                    string choice3 = Console.ReadLine();
                                    switch (choice3)
                                    {
                                        case "1":
                                            Console.Write("Yeni capacityni daxil edin :");
                                            int newCapacity = Convert.ToInt32(Console.ReadLine());
                                            awp.EditCapacity(newCapacity);
                                            break;
                                        case "2":
                                            Console.Write("Yeni countu daxil edin :");
                                            int newCount = Convert.ToInt32(Console.ReadLine());
                                            awp.EditCount(newCount);
                                            break;
                                        case "3":
                                            checkAwp = true;
                                            break;

                                        default:
                                            break;
                                    }

                                    break;
                                case "5":
                                    check = true;
                                    break;
                                default:
                                    break;
                            }
                        } while (!checkAwp);
                        break;
                    case "3":
                        Console.Write("Bullet capacity : ");
                        uzi.BulletCapacity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Bullet count : ");
                        uzi.BulletCount = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("0 - İnformasiya almaq üçün\n" +
                            "1 - Fire metodu üçün\n" +
                            "2 - GetRemainBulletCount metodu üçün\n" +
                            "3 - Reload metodu üçün\n" +
                            "4 - Edit :\n" +
                            "5 - Proqrami dayandir");
                            choice2 = Console.ReadLine();
                            switch (choice2)
                            {
                                case "0":
                                    uzi.ShowInfo();
                                    break;
                                case "1":
                                    uzi.Fire();
                                    break;
                                case "2":
                                    Console.WriteLine("Bullet count : " + uzi.GetRemainBulletCount());
                                    break;
                                case "3":
                                    uzi.Reload();
                                    break;
                                case "4":
                                    Console.WriteLine("Secim edin:\n" +
                                        "1-Capacityni deyisin\n" +
                                        "2-Countunu deyisin\n" +
                                        "3-Silahi deyisin");
                                    string choice3 = Console.ReadLine();
                                    switch (choice3)
                                    {
                                        case "1":
                                            Console.Write("Yeni capacityni daxil edin :");
                                            int newCapacity = Convert.ToInt32(Console.ReadLine());
                                            uzi.EditCapacity(newCapacity);
                                            break;
                                        case "2":
                                            Console.Write("Yeni countu daxil edin :");
                                            int newCount = Convert.ToInt32(Console.ReadLine());
                                            uzi.EditCount(newCount);
                                            break;
                                        case "3":
                                            checkUzi = true;
                                            break;

                                        default:
                                            break;
                                    }
                                    break;
                                case "5":
                                    check = true;
                                    break;
                                default:
                                    break;
                            }
                        } while (!checkUzi);
                        break;
                    case "4":
                        Console.Write("Bullet capacity : ");
                        deagle.BulletCapacity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Bullet count : ");
                        deagle.BulletCount = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("0 - İnformasiya almaq üçün\n" +
                            "1 - Shoot metodu üçün\n" +
                            "2 - GetRemainBulletCount metodu üçün\n" +
                            "3 - Reload metodu üçün\n" +
                            "4 - Edit :\n" +
                            "5 - Proqrami dayandir");
                            choice2 = Console.ReadLine();
                            switch (choice2)
                            {
                                case "0":
                                    deagle.ShowInfo();
                                    break;
                                case "1":
                                    deagle.Shoot();
                                    break;
                                case "2":
                                    Console.WriteLine("Bullet count : " +deagle.GetRemainBulletCount());
                                    break;
                                case "3":
                                    deagle.Reload();
                                    break;
                                case "4":
                                    Console.WriteLine("Secim edin:\n" +
                                        "1-Capacityni deyisin\n" +
                                        "2-Countunu deyisin\n" +
                                        "3-Silahi deyisin");
                                    string choice3 = Console.ReadLine();
                                    switch (choice3)
                                    {
                                        case "1":
                                            Console.Write("Yeni capacityni daxil edin :");
                                            int newCapacity = Convert.ToInt32(Console.ReadLine());
                                            deagle.EditCapacity(newCapacity);
                                            break;
                                        case "2":
                                            Console.Write("Yeni countu daxil edin :");
                                            int newCount = Convert.ToInt32(Console.ReadLine());
                                            deagle.EditCount(newCount);
                                            break;
                                        case "3":
                                            checkDeagle = true;
                                            break;

                                        default:
                                            break;
                                    }
                                    break;
                                case "5":
                                    check = true;
                                    break;
                                default:
                                    break;
                            }
                        } while (!checkDeagle);
                        break;

                    default:
                        break;
                }
            } while (!check);
        }
    }
}