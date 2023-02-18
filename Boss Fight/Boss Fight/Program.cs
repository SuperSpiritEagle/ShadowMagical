using System;

namespace Boss_Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            int shadowMagicianHealth;
            int abertoDamage;
            int bombardoHealth;
            int descendoSpell;
            int imperiusArmor;
            int bossHealth;
            int avisDamage;
            int baubilliusHealth;
            int skimmerSpell;
            int defodioArmor;
            int maxHP = 1000;
            int minHP = 300;
            int minSpellOneDamage = 30;
            int maxSpellOneDamage = 100;
            int minSpellTwoHealth = 50;
            int maxSpellTwoHealth = 250;
            int minSpellThree = 10;
            int maxSpellThree = 50;
            int minSpellFourArmor = 10;
            int maxSpellFourArmor = 50;
            int armorShadowMagician = 0;
            int armorBoss = 0;
            int maxlimitArmor = 3;
            string spelltext;
            string secretSpell = "123";

            Random random = new Random();

            shadowMagicianHealth = random.Next(minHP, maxHP);
            bossHealth = random.Next(minHP, maxHP);
            int fightOne = 1;
            int fightTwo = 2;
            int fightThree = 3;
            int fightFour = 4;
            int fightCombinarium = 5;
            int fight;
            abertoDamage = random.Next(minSpellOneDamage, maxSpellOneDamage);
            bombardoHealth = random.Next(minSpellTwoHealth, maxSpellTwoHealth);
            descendoSpell = random.Next(minSpellThree, maxSpellThree);
            imperiusArmor = random.Next(minSpellFourArmor, maxSpellFourArmor);
            avisDamage = random.Next(minSpellOneDamage, maxSpellOneDamage);
            baubilliusHealth = random.Next(minSpellTwoHealth, maxSpellTwoHealth);
            skimmerSpell = random.Next(minSpellThree, maxSpellThree);
            defodioArmor = random.Next(minSpellFourArmor, maxSpellFourArmor);
            int minArmor = 0;
            int minHealth = 0;
            int minLimitArmor = 0;
            int minCombinarium = 10;
            int maxCombinarium = 50;
            int averageCombinarium = 500;
            int averageMaxCombinarium = 600;

            Console.WriteLine($"{fightOne} ShadowWagician abertoDamage, Boss  avisDamage");
            Console.WriteLine($"{fightTwo} ShadowMagician bombardoHealth, Boss  baubilliusHealth");
            Console.WriteLine($"{fightThree} ShadowMagician descendoSpell, Boss  skimer");
            Console.WriteLine($"{fightFour} ShadowMagician imperiusArmor, Boss  defidioArmor");
            Console.WriteLine($"{fightCombinarium} Combinarium");
            Console.WriteLine();
            Console.WriteLine($"Hp Boss = { bossHealth}");
            Console.WriteLine($"Hp ShadowMagician = {shadowMagicianHealth}");
            Console.WriteLine();

            while (shadowMagicianHealth > minHealth && bossHealth > minHealth)
            {

                Console.WriteLine("Выберите заклинание");
                fight = Convert.ToInt32(Console.ReadLine());

                if (fight == fightOne)
                {
                    if (armorShadowMagician > minArmor && armorBoss > minArmor)
                    {
                        armorShadowMagician -= abertoDamage;
                        armorBoss -= avisDamage;
                        Console.WriteLine($"Armor ShadowMagician = {armorShadowMagician} Armor boss = {armorBoss}");
                    }
                    else
                    {
                        shadowMagicianHealth -= avisDamage;
                        bossHealth -= abertoDamage;
                        Console.WriteLine($"baubillius Hp Boss = { bossHealth}");
                        Console.WriteLine($"bombardo Hp ShadowMagician = {shadowMagicianHealth}");
                    }

                }
                else if (fight == fightTwo)
                {

                    shadowMagicianHealth += bombardoHealth;
                    bossHealth += baubilliusHealth;

                    if (shadowMagicianHealth > maxHP)
                    {
                        shadowMagicianHealth -= bombardoHealth;
                    }

                    if (bossHealth > maxHP)
                    {
                        bossHealth -= baubilliusHealth;
                    }

                    Console.WriteLine($"baubillius Hp Boss = { bossHealth}");
                    Console.WriteLine($"bombardo Hp ShadowMagician = {shadowMagicianHealth}");

                }
                else if (fight == fightThree)
                {

                    Console.WriteLine("Введите серкретное заклинание  что бы вызвать духа тьмы");
                    spelltext = Console.ReadLine();
                    if (secretSpell == spelltext)
                    {
                        shadowMagicianHealth -= skimmerSpell;
                    }
                    else
                    {
                        Console.WriteLine("Ты ввел не верное заклинание получай ответ от Босса");
                        bossHealth -= descendoSpell;
                    }

                    Console.WriteLine($"descendo Hp Boss = { bossHealth}");
                    Console.WriteLine($"skimmer Hp ShadowMagician = {shadowMagicianHealth}");
                }
                else if (fight == fightFour)
                {
                    if (maxlimitArmor <= minLimitArmor)
                    {
                        Console.WriteLine("Вы израсходовали всю броню");
                    }
                    else
                    {
                        armorShadowMagician += imperiusArmor;
                        armorBoss += defodioArmor;
                        Console.WriteLine($"Hp Boss = {bossHealth} Armor Boss {defodioArmor}");
                        Console.WriteLine($"Hp ShadowMagician = {shadowMagicianHealth} Armor ShadowMagician {armorShadowMagician}");
                    }

                    maxlimitArmor--;
                }
             
                else if (fight == fightCombinarium)
                {
                    if (shadowMagicianHealth > minCombinarium && shadowMagicianHealth < maxCombinarium)
                    {
                        Console.WriteLine("Пришло подкрепление к темному магу");
                        bossHealth -= random.Next(minHP, maxHP);
                        Console.WriteLine($"Hp Boss = { bossHealth}");
                        Console.WriteLine($"HP ShadowMagician = {shadowMagicianHealth}");
                    }
                    else if (bossHealth > minCombinarium && bossHealth < maxCombinarium)
                    {
                        Console.WriteLine("Пришло подкрепление к Босу");
                        shadowMagicianHealth -= random.Next(minHP, maxHP);
                        Console.WriteLine($"Hp Boss = { bossHealth}");
                        Console.WriteLine($"HP ShadowMagician = {shadowMagicianHealth}");
                    }
                    else if (shadowMagicianHealth > averageMaxCombinarium && bossHealth < averageCombinarium)
                    {
                        Console.WriteLine("Босс выпивает ликсир здоровья ");
                        bossHealth += random.Next(minHP, maxHP);
                        Console.WriteLine($"Hp Boss = { bossHealth}");
                        Console.WriteLine($"HP ShadowMagician = {shadowMagicianHealth}");
                    }
                    else if (shadowMagicianHealth < averageCombinarium && bossHealth > averageMaxCombinarium)
                    {
                        Console.WriteLine("Темный маг выпивает ликсир здоровья ");
                        shadowMagicianHealth += random.Next(minHP, maxHP);
                        Console.WriteLine($"Hp Boss = { bossHealth}");
                        Console.WriteLine($"HP ShadowMagician = {shadowMagicianHealth}");
                    }
                    else if (shadowMagicianHealth < maxCombinarium && bossHealth < maxCombinarium)
                    {
                        Console.WriteLine("Временное перемирие ");
                        Console.WriteLine($"Hp Boss = { bossHealth}");
                        Console.WriteLine($"HP ShadowMagician = {shadowMagicianHealth}");
                    }
                    else
                    {
                        Console.WriteLine("Подготовка к бою");
                    }
                }
                else if (fight < fightOne || fight > fightCombinarium)
                {
                    Console.WriteLine("Данные не верны");
                }
            }

            Console.WriteLine();

            if (shadowMagicianHealth <= minHealth && bossHealth <= minHealth)
            {
                Console.WriteLine("Оба убиты");
            }
            else if (shadowMagicianHealth > bossHealth)
            {
                Console.WriteLine($"Победил shadowMagician Hp = {shadowMagicianHealth}");
            }
            else
            {
                Console.WriteLine($"Победил Boss Hp = {bossHealth}");
            }
        }
    }
}
