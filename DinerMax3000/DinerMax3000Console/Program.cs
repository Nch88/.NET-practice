using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian fish", 25.50);
            summerMenu.AddMenuItem("Taco", "Mexican taco", 12.50);
            summerMenu.HospitalDirections = "Right around the corner";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and drive!";
            outsideDrinks.AddMenuItem("Pan galactic gargle blaster", "Will knock your socks off!", 20.00);
            outsideDrinks.AddMenuItem("Mohito", "A classic", 13.00);

            Order hungryGuestOrder = new Order();
            for (int i = 0; i < summerMenu.items.Count; i++)
            {
                hungryGuestOrder.items.Add(summerMenu.items[i]);
            }

            foreach (MenuItem item in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(item);
            }
        }
    }
}
