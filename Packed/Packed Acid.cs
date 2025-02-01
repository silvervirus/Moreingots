using System.Collections.Generic;
using MoreIngots.craftable;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Assets.PrefabTemplates;
using Nautilus.Crafting;
using Nautilus.Handlers;


namespace MoreIngots.Packed
{

    public class MIAcidjug
    {
       public static TechType techType;
        
        public static void Patch()
        {
            PMIAcidjug.Register();
        }
    }

    public static class PMIAcidjug
    {
        
        
        public static PrefabInfo Info { get; } = PrefabInfo.WithTechType("MIAcidjug", " Packed Acid Container", "Acid. Packed Acid Containers .")
            // set the icon to that of the vanilla locker:
            .WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MIAcidjug"));
        
        public static void Register()
        {
            // create prefab:
            CustomPrefab prefab = new CustomPrefab(Info);
            
        // copy the model of a vanilla wreck piece (which looks like a taller locker):
        CloneTemplate lockerClone = new CloneTemplate(Info, TechType.HydrochloricAcid);

            // modify the cloned model:
            lockerClone.ModifyPrefab += go =>
            {


               
            };
            // set recipe:
            _ = prefab.SetRecipe(new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>
                { new CraftData.Ingredient(TechType.HydrochloricAcid, 10),


                },


            });
            
        CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, Info.TechType, new string[] { "Resources", "MI", "PI", "CICraft" });

            prefab.SetUnlock(TechType.Peeper);
            // assign the created clone model to the prefab itself:
            prefab.SetGameObject(lockerClone);

            // assign it to the correct tab in the builder tool:
            prefab.SetPdaGroupCategory(Qpatch.group, Qpatch.category);
            LanguageHandler.SetLanguageLine("MIAcidjug", "Contenedor de ácido empaquetado", "Spanish");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Ácido. Contenedores de ácido empaquetados", "Spanish");
            LanguageHandler.SetLanguageLine("MIAcidjug", "Verpackte Säurebehälter", "German");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Säure. Verpackte Säurebehälter.", "German");
            LanguageHandler.SetLanguageLine("MIAcidjug", " Упакованные контейнеры для кислоты", "Russian");
            LanguageHandler.SetTechTypeTooltip(Info.TechType, "Кислота. Упакованные контейнеры для кислоты", "Russian");
            // finally, register it into the game:
            prefab.Register();
            


    }
        public static TechType techType = Info.TechType;
    }
}
