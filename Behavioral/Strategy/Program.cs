namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Cloud");
            hero.DoAttack();

            hero.EquipWeapon(new Sword());
            hero.DoAttack();

            hero.EquipWeapon(new Club());
            hero.DoAttack();
        }
    }
}
