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
    public class MICrash
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMICrash.Register();
        }
    }

    public static class PMICrash
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MICrash", " Packed CrashPowder Ingot", "S. Compressed CrashPowder Ingot.")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MICrash"));
        
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
                    renderer.materials[0].mainTexture = RamuneLib.Utils.ImageUtils.GetTexture("SFText");
                    renderer.materials[0].SetTexture("_SpecTex", RamuneLib.Utils.ImageUtils.GetTexture("SFText"));
                    
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
                { new CraftData.Ingredient(TechType.CrashPowder, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "NICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category); 
            LanguageHandler.SetLanguageLine("MICrash", "Lingote de Crash Powder empaquetado", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "S. Lingote de CrashPowder comprimido.", "Spanish");
            LanguageHandler.SetLanguageLine("MICrash", "Verpackter Crash-Pulver-Ingot", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "S. Komprimierter Crash-Pulver-Ingot.", "German");
            LanguageHandler.SetLanguageLine("MICrash", "Упакованный слиток краш-порошка", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "S. Сжатый слиток краш-порошка.", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
