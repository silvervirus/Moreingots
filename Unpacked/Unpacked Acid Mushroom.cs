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

    public class PIAmush
    {
        public static TechType techType;
        public static void Patch()
        {
            PIAmushs.Register();
        }
    }

    public static class PIAmushs
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("PIAmush", " Unpacked Acid Mushroom", "AM. Unpacked Acid Mushroom.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("PIAmush"));

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
                craftAmount = 0,
                Ingredients = new List<CraftData.Ingredient>
                {
                    new CraftData.Ingredient(PMIAmush.techType ,1)
                },
                LinkedItems = new List<TechType> { TechType.AcidMushroom, TechType.AcidMushroom, TechType.AcidMushroom, TechType.AcidMushroom, TechType.AcidMushroom, TechType.AcidMushroom, TechType.AcidMushroom, TechType.AcidMushroom, TechType.AcidMushroom, TechType.AcidMushroom }
            });
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "UI", "NIUnpack" });

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
