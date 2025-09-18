int hero = 10;
int monster = 10;

Random damage = new Random();

do
{
    int damageDone = damage.Next(1, 11);
    monster -= damageDone;
    Console.WriteLine($"Monster was damaged and lost {damageDone} health and now has {monster} health.");

    if (monster <= 0) continue;

    damageDone = damage.Next(1, 11);
    hero -= damageDone;
    Console.WriteLine($"Hero was damaged and lost {damageDone} health and has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins...");