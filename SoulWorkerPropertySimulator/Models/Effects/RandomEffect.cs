using System;

namespace SoulWorkerPropertySimulator.Models.Effects
{
    public record RandomEffect
    {
        public RandomEffect(EffectContext context, decimal min, decimal max)
        {
#if DEBUG
            if (min > max) { throw new InvalidOperationException(); }
#endif

            Context = context;
            Min     = min;
            Max     = max;
        }

        public EffectContext Context { get; init; }
        public decimal       Min     { get; init; }
        public decimal       Max     { get; init; }


        public int DisplayMinValue => (int) (Context.Property.ToString("G").Contains("Rate") ? Min * 100 : Min);
        public int DisplayMaxValue => (int) (Context.Property.ToString("G").Contains("Rate") ? Max * 100 : Max);

        public Effect CreateEffect(decimal value)
        {
            if (value < Min || value > Max) { throw new IndexOutOfRangeException(); }

            return new(Context, value);
        }
    }
}