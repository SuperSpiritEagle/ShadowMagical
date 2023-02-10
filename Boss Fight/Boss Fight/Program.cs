using System;

namespace Boss_Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            int shadowMagician;
            int aberto;
            int bombardo;
            int descendo;
            int imperius;
            int boss;
            int avis;
            int baubillius;
            int skimmer;
            int defodio;
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

            shadowMagician = random.Next(minHP, maxHP);
            boss = random.Next(minHP, maxHP);
            int fightOne = 1;
            int fightTwo = 2;
            int fightThree = 3;
            int fightFour = 4;
            int fight;
            int minfight = 1;
            int maxfight = 5;
            bool isLive = true;
            aberto = random.Next(minSpellOne, maxSpellOne);
            bombardo = random.Next(minSpellTwo, maxSpellTwo);
            descendo = random.Next(minSpellThree, maxSpellThree);
            imperius = random.Next(minSpellFour, maxSpellFour);
            avis = random.Next(minSpellOne, maxSpellOne);
            baubillius = random.Next(minSpellTwo, maxSpellTwo);
            skimmer = random.Next(minSpellThree, maxSpellThree);
            defodio = random.Next(minSpellFour, maxSpellFour);

            Console.WriteLine($"Hp Boss = { boss}");
            Console.WriteLine($"Hp ShadowMagician = {shadowMagician}");
            Console.WriteLine();

            while (isLive)
            {
             
                fight = random.Next(minfight, maxfight);

                if (fight == fightOne)
                {
                    shadowMagician -= avis;
                    boss -= aberto;
                    Console.WriteLine($"avis Hp Boss = { boss}");
                    Console.WriteLine($"aberdo Hp ShadowMagician = {shadowMagician}");
                }
                else if (fight == fightTwo)
                {
                    shadowMagician += bombardo;
                    boss += baubillius;
                    Console.WriteLine($"baubillius Hp Boss = { boss}");
                    Console.WriteLine($"bombardo Hp ShadowMagician = {shadowMagician}");
                }
                else if (fight == fightThree)
                {
                    shadowMagician -= skimmer;
                    boss -= descendo;
                    Console.WriteLine($"descendo Hp Boss = { boss}");
                    Console.WriteLine($"skimmer Hp ShadowMagician = {shadowMagician}");
                }
                else if(fight == fightFour)
                {
                    shadowMagician -= defodio;
                    boss -= imperius;
                    Console.WriteLine($"imperius Hp Boss = { boss}");
                    Console.WriteLine($"defodio Hp ShadowMagician = {shadowMagician}");
                }
                if (shadowMagician <= 0||boss<=0)
                {
                    isLive = false;
                }
            }

            Console.WriteLine();

            if (shadowMagician > boss)
            {
                Console.WriteLine($"Победил shadowMagician Hp = {shadowMagician}");
            }
            else if (shadowMagician <= 0 && boss <= 0)
            {
                Console.WriteLine("Оба убиты");
            }
            else
            {
                Console.WriteLine($"Победил Boss Hp = {boss}");
            }
        }
    }
}
