using System.Collections.Generic;
using System.Linq;
using Tourist.Core;
using Tourist.Dto;
using Tourist.Model;
using Tourist.Repository;

namespace Tourist.Service
{
    public class IteamService : IIteamService
    {
        private readonly IItemRepository itemRepository;
        int countKG = 0;
        int countMaxValue = 0;
        List<Item> knapsack = new List<Item>();
        List<Item> itemsthatExceedMaxKg = new List<Item>();

        public IteamService(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }
        public IteamService(List<Item> knapsack)
        {
            this.knapsack = knapsack;
        }
        public ItemDto MaximumkValidNapsackDetails()
        {
            var Items = itemRepository.Getitems().OrderBy(p=>p.Value).Reverse().ToList();
            foreach (var item in Items)
            {
                if (countKG + item.Weight < CoreConstant.MaximumGrams)
                {
                    knapsack.Add(item);
                    countKG += item.Weight;
                    countMaxValue += item.Value;
                }
                else
                {
                    itemsthatExceedMaxKg.Add(item);
                }

            }
            var TotalWeightKG = TotalWeight(knapsack);

            return new ItemDto { Items = knapsack, TotalWeightKG = TotalWeightKG, TotalValue = countMaxValue };
        }
        public double TotalWeight(List<Item> items)
        {
            return ((double)items.Sum(p => p.Weight))/1000d;
        }
    }
}
