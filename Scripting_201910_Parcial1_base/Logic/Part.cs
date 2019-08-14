namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Part
    {
        protected float speedBonus;

        public int Level { get; protected set; }
        public abstract VehicleType Type { get; }

        public float SpeedBonus
        {
            get { return speedBonus * (1 + (Level * 0.03F)); }
            protected set { speedBonus = value; }
        }

        public Part()
        {
        }

        public Part(float speedBonus)
        {
            Level = 0;
            SpeedBonus = speedBonus > 0.5F ? 0.5F : speedBonus;
        }

        public void Upgrade()
        {
            Level += 1;
        }
    }
}