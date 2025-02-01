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
    public class MISeed
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMISeed.Register();
        }
    }

    public static class PMISeed
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MISeed", " Packed Creepvine Seed Cluster", "CVp. Packed Creepvine Seed Cluster .")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MISeed"));
        
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.CreepvineSeedCluster);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.CreepvineSeedCluster, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "NICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MISeed", "Racimo de semillas de enredadera empacado", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "CVp. Racimo de semillas de enredadera empacado.", "Spanish");
            LanguageHandler.SetLanguageLine("MISeed", "Verpackter Creep-Vine-Samen-Cluster", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "CVp. Verpackter Creep-Vine-Samen-Cluster.", "German");
            LanguageHandler.SetLanguageLine("MISeed", "Упакованная гроздь семян крипвайна", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "CVp. Упакованная гроздь семян крипвайна", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
