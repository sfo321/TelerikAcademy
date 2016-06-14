namespace DefiningClasses1
{
    using System;
    class GSMTest
    {
        public static void GSMTester()
        {
            MobilePhone[] phones = new MobilePhone[]
        {
            new MobilePhone("Galaxy", "Samsung", 800, "Ivanka", new Battery(BatteryType.LiIon, 12, 6), new Display(6, 1000000)),
            new MobilePhone("P600", "Lenovo", 500, "Ivan", new Battery(BatteryType.NiMH, 16, 2), new Display(5, 100000)),
            new MobilePhone("G5SE", "LG", 700, "Maria", new Battery(BatteryType.ChineseDog, 18, 4), new Display(5, 120000)),
            new MobilePhone("XL", "Nokia", 200, "Pesho", new Battery(BatteryType.NiCd, 14, 5), new Display(4, 80000)),
        };

            for(int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i]);
            }
            Console.WriteLine(MobilePhone.IPhone4S);
        }
    }
}
