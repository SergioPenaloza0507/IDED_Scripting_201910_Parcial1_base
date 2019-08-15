namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Part
    {
        protected float speedBonus;
        protected float durability;

        public int Level { get; protected set; }
        public abstract VehicleType Type { get; }

        public float SpeedBonus
        {
            get { return SpeedBonus * Durability; }
            protected set { speedBonus = value; }
        }

        public float Durability
        {
            get
            {
                float d = 0;
                if (durability < 0)
                {
                    d = 0;
                }
                else if (durability > 1)
                {
                   d  = 1;
                }
                else
                {
                    d = durability;
                }
                return d;
            }
        }

        public Part()
        {
        }

        public Part(float speedBonus)
        {
            this.speedBonus = speedBonus;
            durability = 1;
        }

        public void Upgrade()
        {
            if(Level <= 3)
            {
                Level++;
            }
        }
    }
}