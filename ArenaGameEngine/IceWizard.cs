using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class IceWizard:Hero
    {
        public IceWizard(string name, int health, int strenght) : base(name, health, strenght)
        {

        }

        public IceWizard(string typeOfMagic, int polsion ,string yearsOfNolage)
        {
            this.typeOfMagic = typeOfMagic;
            this.polsion = polsion;
            this.yearsOfNolage = yearsOfNolage;
        }
        public string typeOfMagic { get; set; }
        public int polsion { get; set; }
        public double yearsOfNolage { get; set; }


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
            if (hitCount == 4)
            {
                baseAttack = baseAttack * 2;
                hitCount = 0;
            }
            return baseAttack;
        }
        public override void TakeDamage(int incomingDamage)
        {
            int coef = Random.Shared.Next(23, 70);
            incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
            base.TakeDamage(incomingDamage);
        }

    }
}
