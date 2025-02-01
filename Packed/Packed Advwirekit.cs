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
    public class MIAdvwirekit
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMIAdvwirekit.Register();
        }
    }

    public static class PMIAdvwirekit
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MIAdvwirekit", " Packed Advanced Wiring Kit", "kitadvwire. Compressed Advanced Wiring Kit.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MIAdvwirekit"));
        
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.AdvancedWiringKit);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.AdvancedWiringKit, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "EICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MIAdvwirekit", "Kit de cableado avanzado empaquetado", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "kitadvwire. Kit de cableado avanzado comprimido.", "Spanish");
            LanguageHandler.SetLanguageLine("MIAdvwirekit", "Verpacktes erweitertes Verkabelungsset", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "kitadvwire. Komprimierter erweiterter Verkabelungssatz.", "German");
            LanguageHandler.SetLanguageLine("MIAdvwirekit", " Упакованный расширенный комплект проводки", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "kitadvwire. Сжатый расширенный комплект проводки.", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
