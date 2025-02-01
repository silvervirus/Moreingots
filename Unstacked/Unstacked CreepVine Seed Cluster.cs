using System.Collections.Generic;
using MoreIngots.craftable;



using MoreIngots.Packed;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Assets.PrefabTemplates;
using Nautilus.Crafting;
using Nautilus.Handlers;

namespace MoreIngots.Unpacked
{

    public class PISSeed
    {
        public static TechType techType;
        public static void Patch()
        {
            PPISSeeds.Register();
        }
    }

    public static class PPISSeeds
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("PISSeed", " Unstacked Creepvine Seed Cluster", "AM. Uncompressed x2 Stacked Creepvine Seed Cluster.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MISSeed"));

        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);

            // copy the model of a vanilla wreck Seed Cluster (which looks like a taller locker):
            CloneTemplate lockerClone = new CloneTemplate(Info, TechType.CreepvineSeedCluster);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 0,
                Ingredients = new List<CraftData.Ingredient>
                {
                    new CraftData.Ingredient(PMISSeed.techType ,1)
                },
                LinkedItems = new List<TechType> { PMISeed.techType, PMISeed.techType, PMISeed.techType, PMISeed.techType, PMISeed.techType, PMISeed.techType, PMISeed.techType, PMISeed.techType, PMISeed.techType, PMISeed.techType }
            });
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "BI", "USI", "NIUnstacked" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);

            // finally, register it into the game:
            prefab.Register();

            TechType techType = prefab.Info.TechType;

        }
    }
}
