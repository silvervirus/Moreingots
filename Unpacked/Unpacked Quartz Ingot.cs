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

    public class PIQuartz
    {
        public static TechType techType;
        public static void Patch()
        {
            PIQuartzs.Register();
        }
    }

    public static class PIQuartzs
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("PIQuartz", " Unpacked Quartz Ingot", "Si04. Uncompressed Quartz Ingot.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("PIQuartz"));

        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);

            // copy the model of a vanilla wreck piece (which looks like a taller locker):
            CloneTemplate lockerClone = new CloneTemplate(Info, TechType.Quartz);

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
                    new CraftData.Ingredient(PMIQuartz.techType ,1)
                },
                LinkedItems = new List<TechType> { TechType.Quartz, TechType.Quartz, TechType.Quartz, TechType.Quartz, TechType.Quartz, TechType.Quartz, TechType.Quartz, TechType.Quartz, TechType.Quartz, TechType.Quartz }
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
