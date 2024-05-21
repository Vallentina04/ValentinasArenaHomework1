using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class RoyalHog:Hero
    {
        public RoyalHog(string name, int health, int strenght) : base(name, health, strenght)
        {

        }
        public RoyalHog(string typeOfHelmet,int numberOfLegs, string typeOfFight)
        {
            this.typeOfHelmet = typeOfHelmet;
            this.numberOfLegs = numberOfLegs;
            this.typeOfFight = typeOfFight;
        }
        public string typeOfHelmet { get; set; }
        public int numberOflegs { get; set; }
        public string typeOfFight { get; set; }


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
            hitCount = hitCount + 1;
            int baseAttack = base.Attack();
            if (hitCount == 3)
            {
                baseAttack = baseAttack * 2;
                hitCount = 0;
            }
            return baseAttack;
        }
        public override void TakeDamage(int incomingDamage)
        {
            int coef = Random.Shared.Next(12, 45);
            incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
            base.TakeDamage(incomingDamage);
        }
    }
}
