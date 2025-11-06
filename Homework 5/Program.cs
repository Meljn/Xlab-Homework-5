using System;

public interface IDamageable<in T>
{
    void TakeDamage(T monster);
}

public class FireDamage : IDamageable<Monster>
{
    public void TakeDamage(Monster monster)
    {
        Console.WriteLine($"{monster.GetType().Name} получил урон!");
    }
}

public class Program
{
    public static void Main()
    {
        IDamageable<Monster> fire = new FireDamage();
        
        TakeDamageToMonsters(fire, new Zombie());
        TakeDamageToMonsters(fire, new Skillet());
    }
    public static void TakeDamageToMonsters(IDamageable<Zombie> damage, Zombie zombie)
    {
        damage.TakeDamage(zombie);
    }
    public static void TakeDamageToMonsters(IDamageable<Skillet> damage, Skillet skillet)
    {
        damage.TakeDamage(skillet);
    }
}

public class Monster { }
public class Zombie : Monster { }
public class Skillet : Monster { }
