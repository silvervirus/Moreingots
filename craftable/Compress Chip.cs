using System.Collections.Generic;
using MoreIngots.craftable;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Assets.PrefabTemplates;
using Nautilus.Crafting;
using Nautilus.Handlers;

namespace MoreIngots.craftable;

public class Compress_Chip
{
    
       public static TechType techType;
        
        public static void Patch()
        {
            UICompress_Chip.Register();
        }
    }

public static class UICompress_Chip
{


    public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("UICompress_Chip", "Compress Chips",
            "This Chip is specially made to Decompress Compressed items.")
        // set the icon to that of the vanilla locker:
        .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("UICompress_Chip"));

    public static void Register()
    {
        // create prefab:
        CustomPrefab prefab = new CustomPrefab(Info);

        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.ComputerChip);

        // modify the cloned model:
        lockerClone.ModifyPrefab += go => { };
        // set recipe:
        _ = prefab.SetRecipe(new RecipeData()
        {
            craftAmount = 1,
            Ingredients = new List<CraftData.Ingredient>
            {
                new CraftData.Ingredient(TechType.ComputerChip, 1),
                new CraftData.Ingredient(TechType.TitaniumIngot, 1)


            },


        });

        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType,
            new string[] { "Resources" ,"Electronics" });

        prefab.SetUnlock(TechType.Peeper);
        // assign the created clone model to the prefab itself:
        prefab.SetGameObject(lockerClone);

        // assign it to the correct tab in the builder tool:
        prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);

        // finally, register it into the game:
        prefab.Register();
    }




    public static TechType techType = Info.TechType;

}
