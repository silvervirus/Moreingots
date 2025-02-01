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

    public class PISFibermesh
    {
        public static TechType techType;
        public static void Patch()
        {
            PPISFibermeshs.Register();
        }
    }

    public static class PPISFibermeshs
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("PISFibermesh", " Unstacked Fiber Mesh", "Fibermesh. Uncompressed x2 Stacked Fiber Mesh.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MIFibermesh"));

        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);

            // copy the model of a vanilla wreck piece (which looks like a taller locker):
            CloneTemplate lockerClone = new CloneTemplate(Info, TechType.FiberMesh);

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
                    new CraftData.Ingredient(PMISFibermesh.techType ,1)
                },
                LinkedItems = new List<TechType> { PMIFibermesh.techType, PMIFibermesh.techType, PMIFibermesh.techType, PMIFibermesh.techType, PMIFibermesh.techType, PMIFibermesh.techType, PMIFibermesh.techType, PMIFibermesh.techType, PMIFibermesh.techType, PMIFibermesh.techType }
            });
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "BI", "USI", "SIUnstacked" });

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
