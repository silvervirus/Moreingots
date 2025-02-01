﻿using System.Collections.Generic;
using MoreIngots.craftable;



using MoreIngots.Packed;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Assets.PrefabTemplates;
using Nautilus.Crafting;
using Nautilus.Handlers;

namespace MoreIngots.Unpacked
{

    public class PIComputerchip
    {
        public static TechType techType;
        public static void Patch()
        {
            PIComputerchips.Register();
        }
    }

    public static class PIComputerchips
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("PIComputerchip", " Unpacked Computer chips", "CPU. Uncompressed Computer chips.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("PICopper"));

        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);

            // copy the model of a vanilla wreck piece (which looks like a taller locker):
            CloneTemplate lockerClone = new CloneTemplate(Info, TechType.ComputerChip);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 0,
                Ingredients = new List<CraftData.Ingredient>
                {
                    new CraftData.Ingredient(PMIComputerchip.techType ,1)
                },
                LinkedItems = new List<TechType> { TechType.ComputerChip, TechType.ComputerChip, TechType.ComputerChip, TechType.ComputerChip, TechType.ComputerChip, TechType.ComputerChip, TechType.ComputerChip, TechType.ComputerChip, TechType.ComputerChip, TechType.ComputerChip }
            });
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "UI", "EIUnpack" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);

            // finally, register it into the game:
            prefab.Register();

            TechType techType = prefab.Info.TechType;

        }
    }
}
