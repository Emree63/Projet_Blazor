﻿using CraftSharp.Models;

namespace CraftSharp.Factories
{
    public static class ItemFactory
    {

        public static Item GetRandomItem(List<Item> items)
        {
            Random rnd = new Random();
            int idx = rnd.Next(items.Count());
            return items[idx];
        }

        public static ItemModel ToModel(Item item, byte[] imageContent)
        {
            return new ItemModel
            {
                Id = item.Id,
                DisplayName = item.DisplayName,
                Name = item.Name,
                RepairWith = item.RepairWith,
                EnchantCategories = item.EnchantCategories,
                MaxDurability = item.MaxDurability,
                StackSize = item.StackSize,
                ImageContent = imageContent,
                ImageBase64 = string.IsNullOrWhiteSpace(item.ImageBase64) ? Convert.ToBase64String(imageContent) : item.ImageBase64,
                //Rarity = item.Rarity
            };
        }

        public static Item Create(ItemModel model)
        {
            return new Item
            {
                Id = model.Id,
                DisplayName = model.DisplayName,
                Name = model.Name,
                RepairWith = model.RepairWith,
                EnchantCategories = model.EnchantCategories,
                MaxDurability = model.MaxDurability,
                StackSize = model.StackSize,
                CreatedDate = DateTime.Now,
                ImageBase64 = Convert.ToBase64String(model.ImageContent),
                //Rarity = model.Rarity
            };
        }

        public static void Update(Item item, ItemModel model)
        {
            item.DisplayName = model.DisplayName;
            item.Name = model.Name;
            item.RepairWith = model.RepairWith;
            item.EnchantCategories = model.EnchantCategories;
            item.MaxDurability = model.MaxDurability;
            item.StackSize = model.StackSize;
            item.UpdatedDate = DateTime.Now;
            item.ImageBase64 = Convert.ToBase64String(model.ImageContent);
            //item.Rarity = model.Rarity;

    }
}
}
