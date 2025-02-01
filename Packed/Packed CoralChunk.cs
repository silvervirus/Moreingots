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
    public class MICoral
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMICoral.Register();
        }
    }

    public static class PMICoral
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MICoral", "Packed Coral Chunk", "CC. Packed Coral Chunk .")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MICoral"));
        
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.CoralChunk);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.CoralChunk, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "NICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MICoral", "Trozo de coral empaquetado", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "CC. Trozo de coral empaquetado.", "Spanish");
            LanguageHandler.SetLanguageLine("MICoral", "Verpackter Korallenbrocken", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "CC. Verpackter Korallenbrocken.", "German");
            LanguageHandler.SetLanguageLine("MICoral", "Упакованный кусок коралла", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "CC. Упакованный кусок коралла.", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
