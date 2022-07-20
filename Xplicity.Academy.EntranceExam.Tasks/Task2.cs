using System;
using System.ComponentModel.DataAnnotations;

namespace Xplicity.Academy.EntranceExam.Tasks
{
    //Task #2 (Points: 35)
    //Greta drinks only pure water, and water’s temperature must be x.
    //There is a water cooler in her school which serves exactly alpha milliliters of 100°C water by pressing the red button and beta milliliters of 0°C water by pressing the blue button.
    //Cooler has no thermometer, however Greta figured out if she mixes n milliliter of 100°C water and m milliliters of 0°C water,
    //then the temperature of resulted(n+m) milliliters of water is 100n / (n+m)
    //Greta is an eco-activist; therefore, she does not want to waste any single drop of water and she wants to use only her 1000 milliliters eco-bottle.
    //Which maximal amount of water(in milliliters) of temperature x she can pour using unlimited number of buttons presses?
    //The input data are integer values 1 <= alpha <= 1000, 1 <= beta <= 1000, 0 <= x <= 100.
    //The output data is an integer representing the amount of water in milliliters.
    public class Task2
    {
        [Range(1, 1000)]
        private int alpha;
        [Range(1, 1000)]
        private int beta;
        [Range(0, 100)]
        private int x = 100;

        public Task2(int alpha, int beta, int x)
        {
            this.alpha = alpha;
            this.beta = beta;
            this.x = x;
        }


        public int MaxWaterAmount(int alpha, int beta, int x)
        {
            throw new NotImplementedException();
        }
        public int CallcultatorWater(int x)
        {
            return 
        }
    }
}