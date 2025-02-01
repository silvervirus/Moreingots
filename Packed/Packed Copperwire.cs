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
    public class MICopperwire
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMICopperwire.Register();
        }
    }

    public static class PMICopperwire
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MICopperwire", "Packed Copper wire", "CPW. Compressed Copper wire.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MICopperwire"));
        
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.CopperWire);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.CopperWire, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "EICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MICopperwire", "Alambre de cobre empaquetado", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "CPW. Alambre de cobre comprimido", "Spanish");
            LanguageHandler.SetLanguageLine("MICopperwire", "Verpackter Kupferdraht", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "CPW. Komprimierter Kupferdraht.", "German");
            LanguageHandler.SetLanguageLine("MICopperwire", "Медная проволока набивная", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Медная проволока сжатая.", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
