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
    public class MIBenzenejug
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMIBenzenejug.Register();
        }
    }

    public static class PMIBenzenejug
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MIBenzenejug", "Packed Benzene Container", "Benzene. Packed Benzene Containers .")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MIBenzenejug"));
        
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.Benzene);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.Benzene, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "CICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MIBenzenejug", "Contenedor Embalado de Benceno", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Benceno. Contenedores Embalados de Benceno.", "Spanish");
            LanguageHandler.SetLanguageLine("MIBenzenejug", "Verpackter Benzolbehälter", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Benzol. Verpackte Benzolbehälter.", "German");
            LanguageHandler.SetLanguageLine("MIBenzenejug", " Бензол фасованный", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Бензол. Фасованные бензоловые контейнеры.", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
