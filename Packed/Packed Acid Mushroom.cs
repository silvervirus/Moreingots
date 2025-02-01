using System.Collections.Generic;
using MoreIngots.craftable;
using mset;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Assets.PrefabTemplates;
using Nautilus.Crafting;
using Nautilus.Handlers;


namespace MoreIngots.Packed
{
//*
    public class MIAmush
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMIAmush.Register();
        }
    }

    public static class PMIAmush
    {

       
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MIAmush", "Packed Acid Mushroom", "AM. Packed Acid Mushroom.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MIAmush"));
       
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.AcidMushroom);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.AcidMushroom, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "NICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MIAmush", "Hongo ácido empaquetado", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "AM. Hongo ácido empaquetado.","Spanish");
            LanguageHandler.SetLanguageLine("MIAmush", "Verpackter saurer Pilz", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "AM. Verpackter saurer Pilz.", "German");
            LanguageHandler.SetLanguageLine("MIAmush", "Упакованный кислотный гриб", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "AM. Упакованный кислотный гриб.", "Russian");

            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
