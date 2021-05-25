using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponDamage_Part_1
{
    class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;
        private int roll;
        private bool flaming;
        private bool magic;

        public ArrowDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }

        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value; CalculateDamage();
            }
        }

        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value; CalculateDamage();
            }
        }

        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value; CalculateDamage();
            }

        }

        public int Damage { get; private set; }

        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic)
            {
                baseDamage = Roll * BASE_MULTIPLIER;
            }           

            if (Flaming)
            {
                Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            }
            else
            {
                Damage = (int)Math.Ceiling(baseDamage);
            }

        }
    }
}
