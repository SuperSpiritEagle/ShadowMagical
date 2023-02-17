using System;

namespace Boss_Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            int shadowMagicianHP;
            int abertoDamage;
            int bombardoHealth;
            int descendoDamage;
            int imperiusDamage;
            int bossHP;
            int avisDamage;
            int baubilliusHealth;
            int skimmerDamage;
            int defodioDamage;
            int maxHP = 1000;
            int minHP = 300;
            int minSpellOne = 30;
            int maxSpellOne = 100;
            int minSpellTwo = 50;
            int maxSpellTwo = 250;
            int minSpellThree = 10;
            int maxSpellThree = 50;
            int minSpellFour = 250;
            int maxSpellFour = 500;

            Random random = new Random();

            shadowMagicianHP = random.Next(minHP, maxHP);
            bossHP = random.Next(minHP, maxHP);
            int fightOne = 1;
            int fightTwo = 2;
            int fightThree = 3;
            int fightFour = 4;
            int fightCombinarium = 14;
            int fight;
            abertoDamage = random.Next(minSpellOne, maxSpellOne);
            bombardoHealth = random.Next(minSpellTwo, maxSpellTwo);
            descendoDamage = random.Next(minSpellThree, maxSpellThree);
            imperiusDamage = random.Next(minSpellFour, maxSpellFour);
            avisDamage = random.Next(minSpellOne, maxSpellOne);
            baubilliusHealth = random.Next(minSpellTwo, maxSpellTwo);
            skimmerDamage = random.Next(minSpellThree, maxSpellThree);
            defodioDamage = random.Next(minSpellFour, maxSpellFour);

            Console.WriteLine($"{fightOne} ShadowWagician, Boss  avis");
            Console.WriteLine($"{fightTwo} ShadowMagician bombardo, Boss  baubillius");
            Console.WriteLine($"{fightThree} ShadowMagician descendo, Boss  skimer");
            Console.WriteLine($"{fightFour} ShadowMagician imperius, Boss  defidio");
            Console.WriteLine($"{fightCombinarium} Combinarium");
            Console.WriteLine();
            Console.WriteLine($"Hp Boss = { bossHP}");
            Console.WriteLine($"Hp ShadowMagician = {shadowMagicianHP}");
            Console.WriteLine();

            while (shadowMagicianHP > 0 && bossHP > 0)
            {
                Console.WriteLine("Выберите заклинание");
                fight = Convert.ToInt32(Console.ReadLine());

                if (fight == fightOne)
                {
                    shadowMagicianHP -= avisDamage;
                    bossHP -= abertoDamage;
                    Console.WriteLine($"avis Hp Boss = { bossHP}");
                    Console.WriteLine($"aberdo Hp ShadowMagician = {shadowMagicianHP}");
                }
                else if (fight == fightTwo)
                {
                    shadowMagicianHP += bombardoHealth;
                    bossHP += baubilliusHealth;
                    Console.WriteLine($"baubillius Hp Boss = { bossHP}");
                    Console.WriteLine($"bombardo Hp ShadowMagician = {shadowMagicianHP}");
                }
                else if (fight == fightThree)
                {
                    shadowMagicianHP -= skimmerDamage;
                    bossHP -= descendoDamage;
                    Console.WriteLine($"descendo Hp Boss = { bossHP}");
                    Console.WriteLine($"skimmer Hp ShadowMagician = {shadowMagicianHP}");
                }
                else if (fight == fightFour)
                {
                    shadowMagicianHP -= defodioDamage;
                    bossHP -= imperiusDamage;
                    Console.WriteLine($"imperius Hp Boss = { bossHP}");
                    Console.WriteLine($"defodio Hp ShadowMagician = {shadowMagicianHP}");
                }
                else if (fight == fightCombinarium)
                {
                    shadowMagicianHP += random.Next(minSpellFour, maxSpellFour);
                    bossHP += random.Next(minSpellFour, maxSpellFour);
                    shadowMagicianHP -= random.Next(minHP, maxHP);
                    bossHP -= random.Next(minHP, maxHP);
                    Console.WriteLine($"Combinarium Hp Boss = {bossHP}");
                    Console.WriteLine($"Combinarium Hp ShadowMagician = {shadowMagicianHP}");
                }
                else if (fight < fightOne || fight > fightFour)
                {
                    if (fight == fightCombinarium) continue;

                    Console.WriteLine("Данные не верны");
                }
            }

            Console.WriteLine();

            if (shadowMagicianHP > bossHP)
            {
                Console.WriteLine($"Победил shadowMagician Hp = {shadowMagicianHP}");
            }
            else if (shadowMagicianHP <= 0 && bossHP <= 0)
            {
                Console.WriteLine("Оба убиты");
            }
            else
            {
                Console.WriteLine($"Победил Boss Hp = {bossHP}");
            }
        }
    }
}
