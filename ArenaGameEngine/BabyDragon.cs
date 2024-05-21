using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class BabyDragon:Hero
    {
        public BabyDragon(string name, int health, int strenght) : base(name, health, strenght)
        {

        }
        public BabyDragon(string typeOfDragon, int wings,string fyreTipe)
        {
            this.typeOfDragon = typeOfDragon;
            this.wings = wings;
            this.fyreTipe = fyreTipe;
            
        }

        public string typeOfDragon { get; set; }
        public int wings { get; set; }
        public string fyreTipe { get; set; }

        public override bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public override bool IsDead
        {
            get { return !IsAlive; }
        }
        public override int Attack()
        {
            hitCount = hitCount + 2;
            int baseAttack = base.Attack();
            if (hitCount == 7)
            {
                baseAttack = baseAttack * 2;
                hitCount = 0;
            }
            return baseAttack;
        }
        public override void TakeDamage(int incomingDamage)
        {
            int coef = Random.Shared.Next(50, 60);
            incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
            base.TakeDamage(incomingDamage);
        }

    }
}
