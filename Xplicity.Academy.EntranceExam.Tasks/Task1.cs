using System;
using System.Collections.Generic;

namespace Xplicity.Academy.EntranceExam.Tasks
{
    //Task #1 (Points: 25)
    //Apparently, mages use money: Galleon, Sickle and Knut.
    //They are gold, silver, and bronze, respectively.
    //There are 17 Sickles in a Galleon, and 29 Knuts in a Sickle.
    //All the money data (prices, amount of cash etc.) is to be written in Galleons, Sickles and Knuts; the number of Sickles cannot be bigger than 16 and the number of Knuts cannot be bigger than 28.
    //Harry Potter needs to buy some magic stuff before coming to his school of wizardry.
    //Initially, he took some amount of cash from his bank account and then he went shopping.
    //How much money he will have after all his purchases?
    //The input data are the initial cash value and the list of prices.
    //Each string has a fixed format of three integer numbers – count of Galleons, Sickles and Knuts separated by spaces, for example: "5 16 10", "3 9 21", "0 4 0".
    //The count of purchases is 0 <= N <= 100000.
    //The number of Galleons for each string is less or equal to 100000 as well.
    //The output data is a string of the same format.
    //If the total sum of all the purchases exceeds the initial cash value, return "-1".
    public class Task1
    {
        public string Purchase(string initialCash, IEnumerable<string> prices)
        {
            throw new NotImplementedException();
        }
    }
    public class Currency
    { 
        public Currency(string currencyName, decimal Galleon, decimal Sickle, decimal Knut)
        {
            CurrencyName = currencyName;
            OneGalleon = Galleon;
            OneSickle = Sickle;
            OneKnut = Knut;
        }
        public string CurrencyName { get; set; }
        public decimal OneGalleon { get; set; }
        public decimal OneSickle { get; set; }
        public decimal OneKnut { get; set; }

        public MoneyRates 

        public decimal CalculateGalleon(decimal currencyPrice)
        {
            return Math.Round((currencyPrice * (decimal)5.00) , 2);
        }
        public decimal CalculateSickles(decimal currencyPrice)
        {
            return Math.Round(((currencyPrice * (decimal)5.00)/17), 2);
        }
        public decimal CalculateKnut(decimal currencyPrice)
        {
            return Math.Round(((currencyPrice * (decimal)5.00) / 17*27), 2);
        }

}