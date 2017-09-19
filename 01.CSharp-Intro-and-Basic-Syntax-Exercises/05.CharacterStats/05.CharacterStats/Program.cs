using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int residualHealth = maxHealth - health;
            int residualEnergy = maxEnergy - energy;

            string healtStr = new String('|', health);
            string resHealthStr = new String('.', residualHealth);

            string energyStr = new String('|', energy);
            string resEnergyStr = new String('.', residualEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{healtStr}{resHealthStr}|");
            Console.WriteLine($"Energy: |{energyStr}{resEnergyStr}|");

        }
    }
}
