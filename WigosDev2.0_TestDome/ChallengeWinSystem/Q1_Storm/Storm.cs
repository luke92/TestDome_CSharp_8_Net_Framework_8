using System;

namespace ChallengeWinSystem.Q1_Storm
{
    /*
     * RainStorm and SnowStorm inherit from Storm
     * Properties are reused
     * Methods are declared in appropiate classes
     * Duplicated code in constructors is reused
     */
    public class Storm
    {
        public double EyeRadius { get; protected set; }
        public Tuple<double, double> EyePosition { get; protected set; }

        public Storm(double eyeRadius, Tuple<double, double> eyePosition)
        {
            this.EyeRadius = eyeRadius;
            this.EyePosition = eyePosition;
        }

        public bool IsInEyeOfTheStorm(Tuple<double, double> position)
        {
            double distance = Math.Sqrt(Math.Pow(position.Item1 - EyePosition.Item1, 2) +
                                        Math.Pow(position.Item2 - EyePosition.Item2, 2));
            return distance < EyeRadius;
        }
    }

    public class RainStorm : Storm
    {
        public RainStorm(double eyeRadius, Tuple<double, double> eyePosition) : base(eyeRadius, eyePosition)
        {
        }

        public double AmountOfRain()
        {
            return EyeRadius * 20;
        }
    }

    public class SnowStorm : Storm
    {
        public double AmountOfSnow { get; private set; }

        public SnowStorm(double eyeRadius, Tuple<double, double> eyePosition, double amountOfSnow) : base(eyeRadius, eyePosition)
        {
            this.EyeRadius = eyeRadius;
            this.EyePosition = eyePosition;
            this.AmountOfSnow = amountOfSnow;
        }

    }

}
