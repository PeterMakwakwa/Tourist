using System.Collections.Generic;
using Tourist.Dto;
using Tourist.Model;

namespace Tourist.Service
{
    public interface IIteamService
    {
        //List<Item> MaximumkValidNapsack();
        ItemDto MaximumkValidNapsackDetails();
        double TotalWeight(List<Item> items);
    }
}
