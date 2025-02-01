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
    public class MIArmidfiber
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMIArmidfiber.Register();
        }
    }

    public static class PMIArmidfiber
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MIArmidfiber", " Packed Armid Fiber Mesh Ingot", "Au. Compressed Armid Fiber Ingot.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MIArmidfiber"));
        
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
                    renderer.materials[0].mainTexture = RamuneLib.Utils.ImageUtils.GetTexture("AFText");
                    renderer.materials[0].SetTexture("_SpecTex", RamuneLib.Utils.ImageUtils.GetTexture("AFText"));
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
                { new CraftData.Ingredient(TechType.AramidFibers, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "SICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MIArmidfiber", "Lingote de malla de fibra de Armid empaquetado", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Au. Lingote de fibra de Armid comprimido.", "Spanish");
            LanguageHandler.SetLanguageLine("MIArmidfiber", "Verpackter Armid-Faser-Mesh-Ingot", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Au. Komprimierter Armid-Faser-Ingot.", "German");
            LanguageHandler.SetLanguageLine("MIArmidfiber", " Слиток сетки из упакованного армидного волокна", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Слиток из сжатого армидного волокна.", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
