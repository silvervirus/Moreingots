using System;
using System.Collections.Generic;
using MoreIngots.craftable;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Assets.PrefabTemplates;
using Nautilus.Crafting;
using Nautilus.Handlers;
using UnityEngine;


namespace MoreIngots.Packed
{
//*
    public class MISilicone
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMISilicone.Register();
        }
    }

    public static class PMISilicone
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MISilicone", " Packed Silicone Ingot", "Au. Compressed Silicone Ingot.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MISilicone"));
        
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.TitaniumIngot);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


                var renderer = go.FindChild("model")?.FindChild("Mesh")?.GetComponent<MeshRenderer>();
                if (renderer != null)
                {
                    renderer.materials[0].mainTexture = RamuneLib.Utils.ImageUtils.GetTexture("SICText");
                    renderer.materials[0].SetTexture("_SpecTex", RamuneLib.Utils.ImageUtils.GetTexture("SICText"));
                }
                else
                {
                    Console.WriteLine("Renderer not found");
                }
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.Silicone, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "SICraft" });

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
