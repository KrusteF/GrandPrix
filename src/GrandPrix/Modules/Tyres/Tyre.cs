namespace GrandPrix
{
    using System;

    public abstract class Tyre
    {
        private double degradation;

        protected Tyre(double hardness)
        {
            this.Hardness = hardness;
            this.Degradation = 100;
        }

        public abstract string Name { get; }

        public double Hardness { get; }

        public virtual double Degradation
        {
            get => this.degradation;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Blown Tyre");
                }
                this.degradation = value;
            }
        }

        public virtual void ReduceDegradation()
        {
            this.Degradation -= this.Hardness;
        }
    }
}