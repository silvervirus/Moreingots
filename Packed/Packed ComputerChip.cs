using System.Collections.Generic;
using MoreIngots.craftable;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Assets.PrefabTemplates;
using Nautilus.Crafting;
using Nautilus.Handlers;


namespace MoreIngots.Packed
{
//*
    public class MIComputerchip
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMIComputerchip.Register();
        }
    }

    public static class PMIComputerchip
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MIComputerchip", "Packed Computer chips", "CPU. Compressed Computer chips.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MIComputerchip"));
        
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
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.ComputerChip, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "EICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MIComputerchip", "Chips de computadora empaquetados", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "CPU. Chips de computadora comprimidos.", "Spanish");
            LanguageHandler.SetLanguageLine("MIComputerchip", "Verpackte Computerchips", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "CPU. Komprimierte Computerchips.", "German");
            LanguageHandler.SetLanguageLine("MIComputerchip", "Упакованные компьютерные чипы", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "ЦП. Сжатые компьютерные чипы.", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
