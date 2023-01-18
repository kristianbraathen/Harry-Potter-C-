using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class Voldemort 
    {
        public int HP { get; private set; }
        public int Damage { get; private set; }
        public Voldemort(int hP ,int damage)
        {
            HP = hP;
            Damage= damage;
        }

        public int RandDamage()
        {
            Random random = new Random();
            Damage = random.Next(30,51);
            return Damage;
             
        }
        public void AttackCharacter(Character character)
        {
            character.TakeDamage(this);
           
        }
        public void TakeDamage(Character character)
        {
            var EnemyWand = character.WandAttack();
            HP -= EnemyWand.Damage;
            Console.WriteLine($" {character.CharacterName} did {EnemyWand.Damage} damage to Voldemort ({HP} HP left)");
            
        }
    }
}
