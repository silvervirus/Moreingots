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

    public class PISAcid
    {
        public static TechType techType;
        public static void Patch()
        {
            PPISAcids.Register();
        }
    }

    public static class PPISAcids
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("PISAcidbarrel", " Unstacked Acid", "Acid. Uncompressed x2 Stacked Acid.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MISAcidbarrel"));

        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);

            // copy the model of a vanilla wreck piece (which looks like a taller locker):
            CloneTemplate lockerClone = new CloneTemplate(Info, TechType.HullReinforcementModule3);

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
                    new CraftData.Ingredient(PMISAcid.techType ,1)
                },
                LinkedItems = new List<TechType> { PMIAcidjug.techType, PMIAcidjug.techType, PMIAcidjug.techType, PMIAcidjug.techType, PMIAcidjug.techType, PMIAcidjug.techType, PMIAcidjug.techType, PMIAcidjug.techType, PMIAcidjug.techType, PMIAcidjug.techType }
            });
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "BI", "USI", "CIUnstacked" });

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
