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
    public class MIAerosheet
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMIAerosheet.Register();
        }
    }

    public static class PMIAerosheet
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MIAerosheet", " Packed Aerosheet", "Au. Compressed Aerosheet.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MIAerosheet"));
        
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.Aerogel);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.Aerogel, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "SICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MIAerosheet", "Aerosheet empaquetado", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Au. Aerosheet comprimido.", "Spanish");
            LanguageHandler.SetLanguageLine("MIAerosheet", "Verpacktes Aerosheet", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Au. Komprimiertes Aerosheet.", "German");
            LanguageHandler.SetLanguageLine("MIAerosheet", " Упакованный Aerosheet", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Au. Сжатый Aerosheet.", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
