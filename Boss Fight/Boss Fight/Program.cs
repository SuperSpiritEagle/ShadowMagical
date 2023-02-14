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
            int fightCombinarium = 14;
            int fight;
            bool isLive = true;
            aberto = random.Next(minSpellOne, maxSpellOne);
            bombardo = random.Next(minSpellTwo, maxSpellTwo);
            descendo = random.Next(minSpellThree, maxSpellThree);
            imperius = random.Next(minSpellFour, maxSpellFour);
            avis = random.Next(minSpellOne, maxSpellOne);
            baubillius = random.Next(minSpellTwo, maxSpellTwo);
            skimmer = random.Next(minSpellThree, maxSpellThree);
            defodio = random.Next(minSpellFour, maxSpellFour);

            Console.WriteLine("1 ShadowMagician aberto, Boss  avis");
            Console.WriteLine("2 ShadowMagician bombardo, Boss  baubillius");
            Console.WriteLine("3 ShadowMagician descendo, Boss  skimer");
            Console.WriteLine("4 ShadowMagician imperius, Boss  defidio");
            Console.WriteLine("14 Combinarium");
            Console.WriteLine();
            Console.WriteLine($"Hp Boss = { boss}");
            Console.WriteLine($"Hp ShadowMagician = {shadowMagician}");
            Console.WriteLine();

            while (isLive)
            {
                Console.WriteLine("Выберите заклинание");
                fight = Convert.ToInt32(Console.ReadLine());

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
                else if (fight == fightFour)
                {
                    shadowMagician -= defodio;
                    boss -= imperius;
                    Console.WriteLine($"imperius Hp Boss = { boss}");
                    Console.WriteLine($"defodio Hp ShadowMagician = {shadowMagician}");
                }
                else if (fight == fightCombinarium)
                {
                    shadowMagician += random.Next(minSpellFour, maxSpellFour);
                    boss += random.Next(minSpellFour, maxSpellFour);
                    shadowMagician -= random.Next(minHP, maxHP);
                    boss -= random.Next(minHP, maxHP);
                    Console.WriteLine($"Combinarium Hp Boss = { boss}");
                    Console.WriteLine($"Combinarium Hp ShadowMagician = {shadowMagician}");
                }
                else if (fight < fightOne || fight > fightFour)
                {
                    if (fight == fightCombinarium) continue;

                    Console.WriteLine("Данные не верны");
                }

                if (shadowMagician <= 0 || boss <= 0)
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
