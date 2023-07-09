namespace AirCon
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room("bedroom", 31.4f);
            Airconunit AC = new Airconunit();
            AC.StartStop();

            Console.WriteLine("Cooling the Room from 31.4C to 25C");
            Thread.Sleep(1000);

            while (room.Temp > AC.Targettemp)
            {
                Thread.Sleep(50);
                room.Temp += AC.ConditionRoom(room.Temp);
                Console.WriteLine(room.Temp);
            }

            Console.WriteLine("Heating the Room from 25C to 28C");
            Thread.Sleep(1000);

            AC.CoolHeat();
            AC.Targettemp = 28;
            while (room.Temp < AC.Targettemp)
            {
                Thread.Sleep(50);
                room.Temp += AC.ConditionRoom(room.Temp);
                Console.WriteLine(room.Temp);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
