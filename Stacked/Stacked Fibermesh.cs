using System.Collections.Generic;
using MoreIngots.craftable;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Assets.PrefabTemplates;
using Nautilus.Crafting;
using Nautilus.Handlers;


namespace MoreIngots.Packed
{

    public class MISFibermesh
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMISFibermesh.Register();
        }
    }

    public static class PMISFibermesh
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MISFibermesh", " Stacked Fiber Mesh", "Fibermesh. Compressed x2 Fiber Mesh.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MISFibermesh"));
        
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
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(PMIFibermesh.techType, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "BI", "SI", "SIStacked" });

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
}
