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
    public class MIBleachjug
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMIBleachjug.Register();
        }
    }

    public static class PMIBleachjug
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MIBleachjug", "Packed Bleach Container", "Bleach. Packed Bleach Containers.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MIBleachjug"));
        
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.Bleach);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.Bleach, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "CICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MIBleachjug", "Contenedores de lejía envasados", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Lejía. Contenedores de lejía envasados", "Spanish");
            LanguageHandler.SetLanguageLine("MIBleachjug", "Verpackter Bleichmittelbehälter", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Bleichmittel. Verpackte Bleichmittelbehälter.", "German");
            LanguageHandler.SetLanguageLine("MIBleachjug", "Упакованный контейнер с отбеливателем", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Отбеливатель. Упакованные контейнеры с отбеливателем.", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
