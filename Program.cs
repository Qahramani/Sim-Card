using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCard
{
    public class SimCard
    {
        public string CarrierName;
        public string Number;
        public decimal Balance;
        public decimal Tarif;

        public void IncreaseBalnce(decimal amount)
        {
            if (Balance > 0)
            {
                Balance += amount;
            }
            else return;
        }
        public void Call()
        {
            if(Tarif > Balance)
            {
                Console.WriteLine("not enough balance");
            }
            else
            {
                Balance-= Tarif;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            SimCard simCard = new SimCard
            {
                CarrierName = "Bakcell",
                Number = "+994551209089",
                Balance = 0.15m,
                Tarif = 0.5m
            };
            simCard.IncreaseBalnce(1m);
            Console.WriteLine($"Balansiniz {simCard.Balance}");
            simCard.Call();

        }
    }
}
