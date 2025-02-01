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
    public class MIBlood
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMIBlood.Register();
        }
    }

    public static class PMIBlood
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MIBlood", "Packed Blood Oil", "AM. Packed Blood Oil .")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite(TechType.BloodOil));
        
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.BloodOil);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.BloodOil, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "NICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MIBlood", "Aceite de sangre envasado", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "AM. Aceite de sangre envasado.", "Spanish");
            LanguageHandler.SetLanguageLine("MIBlood", "Verpacktes Blutöl", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "AM. Verpacktes Blutöl.", "German");
            LanguageHandler.SetLanguageLine("MIBlood", "Масло крови в упаковке", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "AM. Масло крови в упаковке.", "Russian");
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
