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
    public class MIbigfilteredwater
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMIbigfilteredwater.Register();
        }
    }

    public static class PMIbigfilteredwater
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MIbigfilteredwater", " Packed big filtered water", "bigfilteredwater. Packed big filtered water.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MIbigfilteredwater"));
        
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.BigFilteredWater);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.BigFilteredWater, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "FICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MIbigfilteredwater", "Agua filtrada grande empaquetada", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "agua filtrada grande. Agua filtrada grande empaquetada.", "Spanish");
            LanguageHandler.SetLanguageLine("MIbigfilteredwater", "Gepacktes großes gefiltertes Wasser", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "bigfilteredwater. Gepacktes großes gefiltertes Wasser.", "German");
            LanguageHandler.SetLanguageLine("MIbigfilteredwater", "Упакованная большая фильтрованная вода", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Большая фильтрованная вода. Упакованная большая фильтрованная вода.", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
