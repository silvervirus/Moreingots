using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using BepInEx;
using MoreIngots.Buildable;
using MoreIngots.Packed;
using MoreIngots.Unpacked;
using Nautilus.Crafting;
using Nautilus.Handlers;
using Nautilus.Utility;

using UnityEngine;

namespace MoreIngots.craftable
{
	// Token: 0x02000002 RID: 2
	[BepInPlugin("SN.MoreIngots", "MoreIngotsSN", "1.2.1")]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]

    public class Qpatch : BaseUnityPlugin
	{
        public static TechGroup group;
        public static TechCategory category;
        
        public void Awake()
		{
            CreateGroupandCatagory();

            MIGold.Patch();
			PIGold.Patch();
			MISGold.Patch();
			PISGold.Patch();
			MIDiamond.Patch();
            PIDiamond.Patch();
            MISDiamond.Patch();
			PISDiamond.Patch();
			MILithium.Patch();
			PILithium.Patch();
			MISLithium.Patch();
			PISLithium.Patch();
            MICopper.Patch();
            PICopper.Patch();
            MISCopper.Patch();
            PISCopper.Patch();
            MILead.Patch();
            PILead.Patch();
            MISLead.Patch();
            PISLead.Patch();
            MISilver.Patch();
            PISilver.Patch();
            MISSilver.Patch();
            PISSilver.Patch();
            MIMagnetite.Patch();
           PIMagnetite.Patch();
           MISMagnetite.Patch();
           PISMagnetite.Patch();
            MINickel.Patch();
            PINickel.Patch();
            MISNickel.Patch();
            PISNickel.Patch();
            MIKyanite.Patch();
            PIKyanite.Patch();
            MISKyanite.Patch();
            PISKyanite.Patch();
            MIRuby.Patch();
            PIRuby.Patch();
           MISRuby.Patch();
            PISRuby.Patch();
            MIUraninite.Patch();
            PIUraninite.Patch();
            MISUraninite.Patch();
            PISUraninite.Patch();
            MIIon.Patch();
            PIIon.Patch();
            MISIon.Patch();
            PISIon.Patch();
			MIFibermesh.Patch();
            PIFibermesh.Patch();
            MISFibermesh.Patch();
            PISFibermesh.Patch();
            MIQuartz.Patch();
			MISQuartz.Patch();
            PIQuartz.Patch();
            PISQuartz.Patch();
			MISalt.Patch();
            MISSalt.Patch();
            PISalt.Patch();
            PISSalt.Patch();
			MISulphur.Patch();
			MISSulphur.Patch();
            PISulphur.Patch();
            PISSulphur.Patch();
            MICrash.Patch();
            MISCrash.Patch();
            PICrash.Patch();
            PISCrash.Patch();
            MIComputerchip.Patch();
            MISComputerchip.Patch();
            PIComputerchip.Patch();
            PISComputerchip.Patch();
            MICopperwire.Patch();
            PICopperwire.Patch();
            MISCopperwire.Patch();
            PISCopperwire.Patch();
           MIWirekit.Patch();
            PIWirekit.Patch();
            MISWirekit.Patch();
            PISWirekit.Patch();
           MIAdvwirekit.Patch();
            PIAdvwirekit.Patch();
            MISAdvwirekit.Patch();
            PISAdvwirekit.Patch();
            MIBleachjug.Patch();
            PIBleach.Patch();
            MISBleach.Patch();
            PISBleach.Patch();
            MILubricantjug.Patch();
            PILubricant.Patch();
            MISLubricant.Patch();
            PISLubricant.Patch();
            MIPjug.Patch();
            PIP.Patch();
            MISP.Patch();
            PISP.Patch();
            MIAcidjug.Patch();
            PIAcid.Patch();
            MISAcid.Patch();
            PISAcid.Patch();
          MIBenzenejug.Patch();
            PIBenzene.Patch();
            MISBenzene.Patch();
            PISBenzene.Patch();
            MIGallonWater.Patch();
            PIWaterFrom5Gallon.Patch();
            MIS5GallonWater.Patch();
            PISWaterFrom5Gallon.Patch();
            MIAerosheet.Patch();
            PIAerosheet.Patch();
            MISAerosheet.Patch();
            PISAerosheet.Patch();
            MIArmidfiber.Patch();
            PIArmidfiber.Patch();
            MISArmidfiber.Patch();
            PISArmidfiber.Patch();
            MISilicone.Patch();
            PISilicone.Patch();
            MISSilicone.Patch();
            PISSilicone.Patch();
            MIEnameled.Patch();
            PIEnameled.Patch();
            MISEnameled.Patch();
            PISEnameled.Patch();
            MIGlass.Patch();
            PIGlass.Patch();
            MISGlass.Patch();
            PISGlass.Patch();
           MIStalker.Patch();
            PIStalker.Patch();
            MISStalker.Patch();
            PISStalker.Patch();
           MIAmush.Patch();
           PIAmush.Patch();
           MISAmush.Patch();
            PISAmush.Patch();
            MICoral.Patch();
            PICoral.Patch();
            MISCoral.Patch();
           PISCoral.Patch();
            MITable.Patch();
            PITable.Patch();
            MISTable.Patch();
            PISTable.Patch();
            MICreepp.Patch();
            PICreepp.Patch();
           MISCreepp.Patch();
           PISCreepp.Patch();
            MISeed.Patch();
            PISeed.Patch();
            MISSeed.Patch();
            PISSeed.Patch();
            MIWhite.Patch();
            PIWhite.Patch();
            MISWhite.Patch();
            PISWhite.Patch();
            MIJelly.Patch();
            PIJelly.Patch();
            MISJelly.Patch();
            PISJelly.Patch();
            MIGallonDisWater.Patch();
            PIGallonDisWater.Patch();
            MISGallonDisWater.Patch();
           PISGallonDisWater.Patch();
           MIPod.Patch();
            PIPod.Patch();
            MISPod.Patch();
            PISPod.Patch();
            MIbigfilteredwater.Patch();
            PIbigfilteredwater.Patch();
            MISbigfilteredwater.Patch();
            PISbigfilteredwater.Patch();
            MIBlood.Patch();
            PIBlood.Patch();
            MISBlood.Patch();
            PISBlood.Patch();
            PITitanium.Patch();
            MISTitanium.Patch();
            PISTitanium.Patch();
            MIPlasteel.Patch();
            PIPlasteel.Patch();
            PIRPlasteel.Patch();
            MISPlasteel.Patch();
            PISPlasteel.Patch();
            DeCompress_Chip.Patch();
            Compress_Chip.Patch();
            Buildable.PackedLocker.Patch();
            Buildable.UnpackedLocker.Patch();
            Buildable.StackedLocker.Patch();
            UnStackedLocker.Patch();
            
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MI", "MoreIngots", Qpatch.GetSprite("MI"), new string[] { "Resources" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "BI", "Hoarder", Qpatch.GetSprite("BI"), new string[] { "Resources" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SI", "Stacked", Qpatch.GetSprite("SI"), new string[] { "Resources", "BI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIStacked", "Metal Stacked", SpriteManager.Get(TechType.TitaniumIngot), new string[] { "Resources", "BI", "SI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIStacked", "Food Stacked", SpriteManager.Get(TechType.Bladderfish), new string[] { "Resources", "BI", "SI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIStacked", "Nature Stacked", SpriteManager.Get(TechType.Sulphur), new string[] { "Resources", "BI", "SI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIStacked", "Energy Stacked", SpriteManager.Get(TechType.Battery), new string[] { "Resources", "BI", "SI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIStacked", "Chemical Stacked", SpriteManager.Get(TechType.Bleach), new string[] { "Resources", "BI", "SI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIStacked", "synthetic Stacked", SpriteManager.Get(TechType.Silicone), new string[] { "Resources", "BI", "SI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "USI", "Unstacked", Qpatch.GetSprite("USI"), new string[] { "Resources", "BI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnstacked", "Metal Unstacked", SpriteManager.Get(TechType.TitaniumIngot), new string[] { "Resources", "BI", "USI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIUnstacked", "Food Unstacked", SpriteManager.Get(TechType.Bladderfish), new string[] { "Resources", "BI", "USI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIUnstacked", "Nature Unstacked", SpriteManager.Get(TechType.Sulphur), new string[] { "Resources", "BI", "USI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIUnstacked", "Energy Unstacked", SpriteManager.Get(TechType.Battery), new string[] { "Resources", "BI", "USI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIUnstacked", "Chemical Unstacked", SpriteManager.Get(TechType.Bleach), new string[] { "Resources", "BI", "USI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIUnstacked", "synthetic Unstacked", SpriteManager.Get(TechType.Silicone), new string[] { "Resources", "BI", "USI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "PI", "Packed", Qpatch.GetSprite("PI"), new string[] { "Resources", "MI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SICraft", "synthetic Pack", SpriteManager.Get(TechType.Silicone), new string[] { "Resources", "MI", "PI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CICraft", "Chemical Pack", SpriteManager.Get(TechType.Bleach), new string[] { "Resources", "MI", "PI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MICraft", "Metal Pack", SpriteManager.Get(TechType.TitaniumIngot), new string[] { "Resources", "MI", "PI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NICraft", "Nature Pack", SpriteManager.Get(TechType.Sulphur), new string[] { "Resources", "MI", "PI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FICraft", "Food Pack", SpriteManager.Get(TechType.Peeper), new string[] { "Resources", "MI", "PI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EICraft", "Energy Pack", SpriteManager.Get(TechType.Battery), new string[] { "Resources", "MI", "PI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "UI", "Unpacked", Qpatch.GetSprite("UI"), new string[] { "Resources", "MI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SICraft", "synthetic Pack", SpriteManager.Get(TechType.Silicone), new string[] { "Resources", "MI", "UI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIUnpack", "Food Unpack", SpriteManager.Get(TechType.Peeper), new string[] { "Resources", "MI", "UI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnpack", "Metal Unpack", SpriteManager.Get(TechType.TitaniumIngot), new string[] { "Resources", "MI", "UI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIUnpack", "Nature Unpack", SpriteManager.Get(TechType.Sulphur), new string[] { "Resources", "MI", "UI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIUnpack", "Enegry Unpack", SpriteManager.Get(TechType.Battery), new string[] { "Resources", "MI", "UI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIUnpack", "Chemical Unpack", SpriteManager.Get(TechType.Bleach), new string[] { "Resources", "MI", "UI" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIUnpack", "synthetic Unpack", SpriteManager.Get(TechType.Silicone), new string[] { "Resources", "MI", "UI" });
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, TechType.TitaniumIngot, new string[] { "Resources", "MI", "PI", "MICraft" });
            Console.WriteLine("Loaded Fabricator");
			Console.WriteLine("MoreIngots Loaded");
		}

		public void CreateGroupandCatagory()
        {
            var groupName = "MoreIngots";
            var categoryName = "MoreIngots";

            if (!EnumHandler.TryGetValue(groupName, out group))
            {
                group = EnumHandler.AddEntry<TechGroup>(groupName).WithPdaInfo("MoreIngots");
            }
            if (!EnumHandler.TryGetValue<TechCategory>(categoryName, out category))
            {

                // Create and register the category
                category = EnumHandler.AddEntry<TechCategory>(categoryName).WithPdaInfo($"MoreIngots").RegisterToTechGroup(group);
            }
        }
		public static Atlas.Sprite GetSprite(string name)
		{
			return Nautilus.Utility.ImageUtils.LoadSpriteFromFile(Path.Combine(new string[] { Qpatch.ModPath + "/Assets/" + name + ".png" }), TextureFormat.BC7);
		}

		// Token: 0x04000001 RID: 1
		public const string PLUGIN_GUID = "SN.MoreIngots";

		// Token: 0x04000002 RID: 2
		public const string PLUGIN_NAME = "MoreIngotsSN";

		// Token: 0x04000003 RID: 3
		public const string PLUGIN_VERSION = "1.2.1";

		// Token: 0x04000004 RID: 4
		public static string ModPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
	}
}
