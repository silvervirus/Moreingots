namespace MoreIngots
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using SMLHelper.V2.Assets;

    using SMLHelper.V2.Utility;
    using SMLHelper.V2.Crafting;
    using SMLHelper.V2.Handlers;
    using UnityEngine;
    using Harmony;

    using QModManager.API.ModLoading;

    [QModCore]
    public class Qpatch
    {
        [QModPatch]
        public static void Patch()
        {


            var MIGold = TechTypeHandler.AddTechType("MIGold", "Gold Ingot", "Au. Compressed gold. Added by the MoreIngots mod", GetSprite("MIGold"));
            var techDataG = new TechData();
            var MIDiamond = TechTypeHandler.AddTechType("MIDiamond", "Compressed Diamond", "C. Compressed diamond. Added by the MoreIngots mod", GetSprite("MIDiamond"));
            var techDataD = new TechData();
            var MILithium = TechTypeHandler.AddTechType("MILithium", "Lithium Ingot", "Li. Compressed lithium. Added by the MoreIngots mod", GetSprite("MILithum"));
            var techDataL = new TechData();
            var MICopper = TechTypeHandler.AddTechType("MICopper", "Copper Ingot", "Cu. Compressed copper. Added by the MoreIngots mod", GetSprite("MICopper"));
            var techDataC = new TechData();
            var MILead = TechTypeHandler.AddTechType("MILead", "Lead Ingot", "Pb. Compressed lead. Added by the MoreIngots mod", GetSprite("MILead"));
            var techDataLi = new TechData();
            var MISilver = TechTypeHandler.AddTechType("MISilver", "Silver Ingot", "Ag. Compressed silver. Added by the MoreIngots mod", GetSprite("MISilver"));
            var techDataSi = new TechData();
            var MIMagnetite = TechTypeHandler.AddTechType("MIMagnetite", "Compressed Magnetite", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", GetSprite("MIMagnetite"));
            var techDataM = new TechData();
            var MINickel = TechTypeHandler.AddTechType("MINickel", "Nickel Ingot", "Ni. Compressed nickel. Added by the MoreIngots mod", GetSprite("MINickel"));
            var techDataN = new TechData();
            var MIKyanite = TechTypeHandler.AddTechType("MIKyanite", "Compressed Kyanite", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", GetSprite("MIKyanite"));
            var techDataK = new TechData();
            var MIRuby = TechTypeHandler.AddTechType("MIRuby", "Compressed Ruby", "Al2O3. Compressed ruby. Added by the MoreIngots mod", GetSprite("MIRuby"));
            var techDataR = new TechData();
            var MIUraninite = TechTypeHandler.AddTechType("MIUraninite", "Compressed Uraninite", "U3O8. Compressed uraninite. Added by the MoreIngots mod", GetSprite("MIUrninite"));
            var techDataU = new TechData();
            var MIIon = TechTypeHandler.AddTechType("MIIon", "Ion Ingot ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", GetSprite("MIIon"));
            var techDataI = new TechData();
            var MIQuartz = TechTypeHandler.AddTechType("MIQuartz", "Compressed Quartz", "SiO4. Compressed quartz. Added by the MoreIngots mod", GetSprite("MIQuartz"));
            var techDataQ = new TechData();
            var MISalt = TechTypeHandler.AddTechType("MISalt", "Salt Lick", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", GetSprite("MISalt"));
            var techDataS = new TechData();
            var MISulphur = TechTypeHandler.AddTechType("MISulphur", "Compressed Sulphur", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISulphur"));
            var techDataSu = new TechData();
            var MICrash = TechTypeHandler.AddTechType("MICrash", "Compressed Crashpowder", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MICrash"));
            var techDataCa = new TechData();
            var MIComputerchip = TechTypeHandler.AddTechType("MIComputerchip", "Packed Computer Chip", "S. Packeded Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIComputerchip"));
            var techDataCca = new TechData();
            var MICopperwire = TechTypeHandler.AddTechType("MICopperwire", "Packed Copperwire", "S. Packed Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MICopperwire"));
            var techDataCWa = new TechData();
            var MIWirekit = TechTypeHandler.AddTechType("MIWirekit", "Packed Wire Kit", "S. Packed Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIWirekit"));
            var techDataKCa = new TechData();
            var MIAdvwirekit = TechTypeHandler.AddTechType("MIAdvwirekit", "Packed Advanced Wiring Kit", "S. Packed Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIAdvwirekit"));
            var techDataAWK = new TechData();
            var MISGold = TechTypeHandler.AddTechType("MISGold", "Gold Ingot Stacked ", "Au. Compressed gold. Added by the MoreIngots mod", GetSprite("MISGold"));
            var techDataGs = new TechData();
            var MISDiamond = TechTypeHandler.AddTechType("MISDiamond", "Compressed Diamond Stacked", "C. Compressed diamond. Added by the MoreIngots mod", GetSprite("MISDiamond"));
            var techDataDs = new TechData();
            var MISLithium = TechTypeHandler.AddTechType("MISLithium", "Lithium Ingot Stacked", "Li. Compressed lithium. Added by the MoreIngots mod", GetSprite("MISLithium"));
            var techDataLs = new TechData();
            var MISCopper = TechTypeHandler.AddTechType("MISCopper", "Copper Ingot Stacked", "Cu. Compressed copper. Added by the MoreIngots mod", GetSprite("MISCopper"));
            var techDataCs = new TechData();
            var MISLead = TechTypeHandler.AddTechType("MISLead", "Lead Ingot Stacked", "Pb. Compressed lead. Added by the MoreIngots mod", GetSprite("MISLead"));
            var techDataLis = new TechData();
            var MISSilver = TechTypeHandler.AddTechType("MISSilver", "Silver Ingot Stacked", "Ag. Compressed silver. Added by the MoreIngots mod", GetSprite("MISSilver"));
            var techDataSis = new TechData();
            var MISMagnetite = TechTypeHandler.AddTechType("MISMagnetite", "Compressed Magnetite Stacked", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", GetSprite("MISMagnetite"));
            var techDataMs = new TechData();
            var MISNickel = TechTypeHandler.AddTechType("MISNickel", "Nickel Ingot Stacked", "Ni. Compressed nickel. Added by the MoreIngots mod", GetSprite("MISNickel"));
            var techDataNs = new TechData();
            var MISKyanite = TechTypeHandler.AddTechType("MISKyanite", "Compressed Kyanite Stacked", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", GetSprite("MISKyanite"));
            var techDataKs = new TechData();
            var MISRuby = TechTypeHandler.AddTechType("MISRuby", "Compressed Ruby Stacked", "Al2O3. Compressed ruby. Added by the MoreIngots mod", GetSprite("MISRuby"));
            var techDataRs = new TechData();
            var MISUraninite = TechTypeHandler.AddTechType("MISUraninite", "Compressed Uraninite Stacked", "U3O8. Compressed uraninite. Added by the MoreIngots mod", GetSprite("MISUraninite"));
            var techDataUs = new TechData();
            var MISIon = TechTypeHandler.AddTechType("MISIon", "Ion Ingot Stacked ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", GetSprite("MISIon"));
            var techDataIs = new TechData();
            var MISQuartz = TechTypeHandler.AddTechType("MISQuartz", "Compressed Quartz Stacked", "SiO4. Compressed quartz. Added by the MoreIngots mod", GetSprite("MISQuartz"));
            var techDataQs = new TechData();
            var MISSalt = TechTypeHandler.AddTechType("MISSalt", "Salt Lick Stacked", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", GetSprite("MISSalt"));
            var techDataSs = new TechData();
            var MISSulphur = TechTypeHandler.AddTechType("MISSulphur", "Compressed Sulphur Stacked", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISSulphur"));
            var techDataSus = new TechData();
            var MISCrash = TechTypeHandler.AddTechType("MISCrash", "Compressed Crashpowder Stacked", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISCrash"));
            var techDataCas = new TechData();
            var MISTitanim = TechTypeHandler.AddTechType("MISTitanim", "Stacked Titanium", "SAu. Stacked Titanium. Added by the MoreIngotsplus mod. (Suggested by Cookie)", GetSprite("MISTitanium"));
            var techDataSt = new TechData();
            var MISComputerchip = TechTypeHandler.AddTechType("MISComputerchip", "Stacked Computer Chip", "S. Stacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISComputerchip"));
            var techDataCcas = new TechData();
            var MISCopperwire = TechTypeHandler.AddTechType("MISCopperwire", "stacked Copperwire", "S. Stacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISCopperwire"));
            var techDataCWas = new TechData();
            var MISWirekit = TechTypeHandler.AddTechType("MISWirekit", "Stacked Wire Kit", "S. Stacked Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISWirekit"));
            var techDataKCs = new TechData();
            var MISAdvwirekit = TechTypeHandler.AddTechType("MISAdvwirekit", "Stacked Advanced Wiring Kit", "S. Stacked Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISAdvwirekit"));
            var techDataAWKs = new TechData();
            var PIGold = TechTypeHandler.AddTechType("PIGold", "Unpacked Gold Ingot", "Au. Compressed gold. Added by the MoreIngots mod", GetSprite("PIGold"));
            var techDataPg = new TechData();
            var PIDiamond = TechTypeHandler.AddTechType("PIDiamond", "Unpacked Compressed Diamond", "C. Compressed diamond. Added by the MoreIngots mod", GetSprite("PIDiamond"));
            var techDataDp = new TechData();
            var PILithium = TechTypeHandler.AddTechType("PILithium", "Unpacked Lithium Ingot", "Li. Compressed lithium. Added by the MoreIngots mod", GetSprite("PILithium"));
            var techDataLp = new TechData();
            var PICopper = TechTypeHandler.AddTechType("PICopper", "Unpacked Copper Ingot", "Cu. Compressed copper. Added by the MoreIngots mod", GetSprite("PICopper"));
            var techDataCP = new TechData();
            var PILead = TechTypeHandler.AddTechType("PILead", "Unpacked Lead Ingot", "Pb. Compressed lead. Added by the MoreIngots mod", GetSprite("PILead"));
            var techDataLip = new TechData();
            var PISilver = TechTypeHandler.AddTechType("PISilver", "Unpacked Silver Ingot", "Ag. Compressed silver. Added by the MoreIngots mod", GetSprite("PISilver"));
            var techDataSip = new TechData();
            var PIMagnetite = TechTypeHandler.AddTechType("PIMagnetite", "Unpacked Compressed Magnetite", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", GetSprite("PIMagnetite"));
            var techDataMp = new TechData();
            var PINickel = TechTypeHandler.AddTechType("PINickel", "Unpacked Nickel Ingot", "Ni. Compressed nickel. Added by the MoreIngots mod", GetSprite("PINickel"));
            var techDataNp = new TechData();
            var PIKyanite = TechTypeHandler.AddTechType("PIKyanite", "Unpacked Compressed Kyanite", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", GetSprite("PIKyanite"));
            var techDataKp = new TechData();
            var PIRuby = TechTypeHandler.AddTechType("PIRuby", "Unpacked Compressed Ruby", "Al2O3. Compressed ruby. Added by the MoreIngots mod", GetSprite("PIRuby"));
            var techDataRp = new TechData();
            var PIUraninite = TechTypeHandler.AddTechType("PIUraninite", "Unpacked Compressed Uraninite", "U3O8. Compressed uraninite. Added by the MoreIngots mod", GetSprite("PIUrninite"));
            var techDataUp = new TechData();
            var PIIon = TechTypeHandler.AddTechType("PIIon", "Unpacked Ion Ingot ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", GetSprite("PIIon"));
            var techDataIp = new TechData();
            var PIQuartz = TechTypeHandler.AddTechType("PIQuartz", "Unpacked Compressed Quartz", "SiO4. Compressed quartz. Added by the MoreIngots mod", GetSprite("PIQuartz"));
            var techDataQp = new TechData();
            var PISalt = TechTypeHandler.AddTechType("PISalt", "Unpacked Salt Lick", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", GetSprite("PISalt"));
            var techDataSp = new TechData();
            var PISulphur = TechTypeHandler.AddTechType("PISulphur", "Unpacked Compressed Sulphur", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PISulphur"));
            var techDataSup = new TechData();
            var PICrash = TechTypeHandler.AddTechType("PICrash", "Unpacked Compressed Crashpowder", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PICrash"));
            var techDataCap = new TechData();
            var PITitanim = TechTypeHandler.AddTechType("PITitanim", "Unpacked Titanium", "SAu. Unpacked Titanium. Added by the MoreIngotsplus mod. (Suggested by Cookie)", GetSprite("PITitanium"));
            var techDataStp = new TechData();
            var PIComputerchip = TechTypeHandler.AddTechType("PIComputerchip", "Unpacked Computer Chip", "S. Unpackeded Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIComputerchip"));
            var techDataCcp = new TechData();
            var PICopperwire = TechTypeHandler.AddTechType("PICopperwire", "Unpacked Copperwire", "S. Unpacked Copperwire Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PICopperwire"));
            var techDataCWap = new TechData();
            var PIWirekit = TechTypeHandler.AddTechType("PIWirekit", "Unpacked Wire Kit", "S. Unpacked Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIWirekit"));
            var techDataKCp = new TechData();
            var PIAdvwirekit = TechTypeHandler.AddTechType("PIAdvwirekit", "Unpacked Advanced Wiring Kit", "S. Unpacked Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIAdvwirekit"));
            var techDataAWKp = new TechData();
            var PISGold = TechTypeHandler.AddTechType("PISGold", "Unstacked Gold Ingot", "Au. Compressed gold. Added by the MoreIngots mod", GetSprite("MIGold"));
            var techDataPgs = new TechData();
            var PISDiamond = TechTypeHandler.AddTechType("PISDiamond", "Unstacked Compressed Diamond", "C. Compressed diamond. Added by the MoreIngots mod", GetSprite("MIDiamond"));
            var techDataDps = new TechData();
            var PISLithium = TechTypeHandler.AddTechType("PISLithium", "Unstacked Lithium Ingot", "Li. Compressed lithium. Added by the MoreIngots mod", GetSprite("MILithum"));
            var techDataLps = new TechData();
            var PISCopper = TechTypeHandler.AddTechType("PISCopper", "Unstacked Copper Ingot", "Cu. Compressed copper. Added by the MoreIngots mod", GetSprite("MICopper"));
            var techDataCPs = new TechData();
            var PISLead = TechTypeHandler.AddTechType("PISLead", "Unstacked Lead Ingot", "Pb. Compressed lead. Added by the MoreIngots mod", GetSprite("MILead"));
            var techDataLips = new TechData();
            var PISSilver = TechTypeHandler.AddTechType("PISSilver", "Unstacked Silver Ingot", "Ag. Compressed silver. Added by the MoreIngots mod", GetSprite("MISilver"));
            var techDataSips = new TechData();
            var PISMagnetite = TechTypeHandler.AddTechType("PISMagnetite", "Unstacked Compressed Magnetite", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", GetSprite("MIMagnetite"));
            var techDataMps = new TechData();
            var PISNickel = TechTypeHandler.AddTechType("PISNickel", "Unstacked Nickel Ingot", "Ni. Compressed nickel. Added by the MoreIngots mod", GetSprite("MINickel"));
            var techDataNps = new TechData();
            var PISKyanite = TechTypeHandler.AddTechType("PISKyanite", "Unstacked Compressed Kyanite", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", GetSprite("MIKyanite"));
            var techDataKps = new TechData();
            var PISRuby = TechTypeHandler.AddTechType("PISRuby", "Unstacked Compressed Ruby", "Al2O3. Compressed ruby. Added by the MoreIngots mod", GetSprite("MIRuby"));
            var techDataRps = new TechData();
            var PISUraninite = TechTypeHandler.AddTechType("PISUraninite", "Unstacked Compressed Uraninite", "U3O8. Compressed uraninite. Added by the MoreIngots mod", GetSprite("MIUrninite"));
            var techDataUps = new TechData();
            var PISIon = TechTypeHandler.AddTechType("PISIon", "Unstacked Ion Ingot ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", GetSprite("MIIon"));
            var techDataIps = new TechData();
            var PISQuartz = TechTypeHandler.AddTechType("PISQuartz", "Unstacked Compressed Quartz", "SiO4. Compressed quartz. Added by the MoreIngots mod", GetSprite("MIQuartz"));
            var techDataQps = new TechData();
            var PISSalt = TechTypeHandler.AddTechType("PISSalt", "Unstacked Salt Lick", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", GetSprite("MISalt"));
            var techDataSps = new TechData();
            var PISSulphur = TechTypeHandler.AddTechType("PISSulphur", "Unstacked Compressed Sulphur", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISulphur"));
            var techDataSups = new TechData();
            var PISCrash = TechTypeHandler.AddTechType("PISCrash", "Unstacked Compressed Crashpowder", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MICrash"));
            var techDataCaps = new TechData();
            var PISTitanim = TechTypeHandler.AddTechType("PISTitanim", "UnStacked Titanium", "SAu. UnStacked Titanium. Added by the MoreIngotsplus mod. (Suggested by Cookie)", GetSprite("MITitanim"));
            var techDataSts = new TechData();
            var PISComputerchip = TechTypeHandler.AddTechType("PISComputerchip", "Unstacked Computer Chip", "S. Unstacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIComputerchip"));
            var techDataCcps = new TechData();
            var PISCopperwire = TechTypeHandler.AddTechType("PISCopperwire", "Unstacked Copperwire", "S. Unstacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MICopperwire"));
            var techDataCWp = new TechData();
            var PISWirekit = TechTypeHandler.AddTechType("PISWirekit", "Unstacked Wire Kit", "S. Unstacked Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIWirekit"));
            var techDataKCps = new TechData();
            var PISAdvwirekit = TechTypeHandler.AddTechType("PISAdvwirekit", "Unstacked Advanced Wiring Kit", "S. Unstacked Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIAdvwirekit"));
            var techDataAWKps = new TechData();





            Console.WriteLine("Loading Moreingots");
            Console.WriteLine("Loading Fabricator");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MI", "MoreIngots", SpriteManager.Get(TechType.TitaniumIngot));
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "BI", "Hoarder", SpriteManager.Get(TechType.TitaniumIngot));
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Stacked", "Stacked", SpriteManager.Get(TechType.TitaniumIngot),"BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIStacked", "Metal Stacked", SpriteManager.Get(TechType.TitaniumIngot), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIStacked", "Nature Stacked", SpriteManager.Get(TechType.Sulphur), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIStacked", "Energy Stacked", SpriteManager.Get(TechType.Battery), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIStacked", "Chemical Stacked", SpriteManager.Get(TechType.Bleach), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Unstacked", "Unstacked", SpriteManager.Get(TechType.TitaniumIngot), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnstacked", "Metal Unstacked", SpriteManager.Get(TechType.TitaniumIngot), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIUnstacked", "Nature Unstacked", SpriteManager.Get(TechType.Sulphur), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIUnstacked", "Energy Unstacked", SpriteManager.Get(TechType.Battery), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIUnstacked", "Chemical Unstacked", SpriteManager.Get(TechType.Bleach), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Craft", "Pack", SpriteManager.Get(TechType.TitaniumIngot), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MICraft", "Metal Pack", SpriteManager.Get(TechType.TitaniumIngot), "MI","Craft");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NICraft", "Nature Pack", SpriteManager.Get(TechType.Sulphur), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EICraft", "Energy Pack", SpriteManager.Get(TechType.Battery), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CICraft", "Chemical Pack", SpriteManager.Get(TechType.Bleach), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Unpack", "Unpack", SpriteManager.Get(TechType.TitaniumIngot), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnpack", "Metal Unpack", SpriteManager.Get(TechType.TitaniumIngot), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIUnpack", "Nature Unpack", SpriteManager.Get(TechType.Sulphur), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIUnpack", "Enegry Unpack", SpriteManager.Get(TechType.Battery), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIUnpack", "Chemical Unpack", SpriteManager.Get(TechType.Bleach), "MI");
            Console.WriteLine("Loaded Fabricator");
            Console.WriteLine("Loading Ingots");
            techDataG = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Gold, 10)

    }
            };
            CraftDataHandler.SetTechData(MIGold, techDataG);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIGold, "MI","EICraft" );

            techDataD = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Diamond, 10)

    }
            };
            CraftDataHandler.SetTechData(MIDiamond, techDataD);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIDiamond, "MI", "NICraft");

            techDataL = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Lithium, 10)

    }
            };
            CraftDataHandler.SetTechData(MILithium, techDataL);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MILithium, "MI", "MICraft");

            techDataC = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Copper , 10)

    }
            };
            CraftDataHandler.SetTechData(MICopper, techDataC);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MICopper, "MI", "EICraft");

            techDataLi = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Lead, 10)

    }
            };
            CraftDataHandler.SetTechData(MILead, techDataLi);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MILead, "MI", "MICraft");

            techDataSi = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Silver, 10)

    }
            };
            CraftDataHandler.SetTechData(MISilver, techDataSi);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISilver, "MI", "EICraft");

            techDataM = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Magnetite, 10)

    }
            };
            CraftDataHandler.SetTechData(MIMagnetite, techDataM);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIMagnetite, "MI", "EICraft");
            techDataN = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Nickel, 10)

    }
            };
            CraftDataHandler.SetTechData(MINickel, techDataN);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MINickel, "MI", "MICraft");
            techDataK = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Kyanite, 10)

    }
            };
            CraftDataHandler.SetTechData(MIKyanite, techDataK);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIKyanite, "MI", "NICraft");
            techDataR = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.AluminumOxide, 10)

    }
            };
            CraftDataHandler.SetTechData(MIRuby, techDataR);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIRuby, "MI", "NICraft");
            techDataU = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.UraniniteCrystal, 10)

    }
            };
            CraftDataHandler.SetTechData(MIUraninite, techDataU);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIUraninite, "MI", "EICraft");
            techDataQ = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Quartz, 10)

    }
            };
            CraftDataHandler.SetTechData(MIQuartz, techDataQ);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIQuartz, "MI", "NICraft");
            techDataS = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Salt, 10)

    }
            };
            CraftDataHandler.SetTechData(MISalt, techDataS);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISalt, "MI", "NICraft");
            techDataSu = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Sulphur, 10)

    }
            };
            CraftDataHandler.SetTechData(MISulphur, techDataSu);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISulphur, "MI", "NICraft");
            techDataCa = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.CrashPowder, 10)

    }
            };
            CraftDataHandler.SetTechData(MICrash, techDataCa);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MICrash, "MI", "NICraft");
            techDataI = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.PrecursorIonCrystal, 10)

    }
            };
            CraftDataHandler.SetTechData(MIIon, techDataI);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIIon, "MI", "EICraft");
            techDataCca = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.ComputerChip, 10)

    }
            };
            CraftDataHandler.SetTechData(MIComputerchip, techDataCca);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIComputerchip, "MI", "EICraft");
            techDataCWa = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.CopperWire, 10)

    }
            };
            CraftDataHandler.SetTechData(MICopperwire, techDataCWa);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MICopperwire, "MI", "EICraft");
            techDataKCa = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.WiringKit, 10)

    }
            };
            CraftDataHandler.SetTechData(MIWirekit, techDataKCa);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIWirekit, "MI", "EICraft");
            techDataAWK = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.AdvancedWiringKit, 10)

    }
            };
            CraftDataHandler.SetTechData(MIAdvwirekit, techDataAWK);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIAdvwirekit, "MI", "EICraft");
            Console.WriteLine("Ingots Loaded");
            Console.WriteLine("Stacked Loading");
            techDataGs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIGold, 10)

    }
            };
            CraftDataHandler.SetTechData(MISGold, techDataGs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISGold, "BI", "EIStacked");

            techDataDs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIDiamond, 10)

    }
            };
            CraftDataHandler.SetTechData(MISDiamond, techDataDs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISDiamond, "BI", "NIStacked");

            techDataLs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MILithium, 10)

    }
            };
            CraftDataHandler.SetTechData(MISLithium, techDataLs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISLithium, "BI", "MIStacked");

            techDataCs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MICopper , 10)

    }
            };
            CraftDataHandler.SetTechData(MISCopper, techDataCs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISCopper, "BI", "EIStacked");

            techDataLis = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MILead, 10)

    }
            };
            CraftDataHandler.SetTechData(MISLead, techDataLis);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISLead, "BI", "MIStacked");

            techDataSis = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MISilver, 10)

    }
            };
            CraftDataHandler.SetTechData(MISSilver, techDataSis);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISSilver, "BI", "EIStacked");

            techDataMs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIMagnetite, 10)

    }
            };
            CraftDataHandler.SetTechData(MISMagnetite, techDataMs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISMagnetite, "BI", "EIStacked");
            techDataNs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MINickel, 10)

    }
            };
            CraftDataHandler.SetTechData(MISNickel, techDataNs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISNickel, "BI", "MIStacked");
            techDataKs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIKyanite, 10)

    }
            };
            CraftDataHandler.SetTechData(MISKyanite, techDataKs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISKyanite, "BI", "NIStacked");
            techDataRs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MISRuby, 10)

    }
            };
            CraftDataHandler.SetTechData(MISRuby, techDataR);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISRuby, "BI", "NIStacked");
            techDataUs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIUraninite, 10)

    }
            };
            CraftDataHandler.SetTechData(MISUraninite, techDataUs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISUraninite, "BI", "EIStacked");
            techDataQs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIQuartz, 10)

    }
            };
            CraftDataHandler.SetTechData(MISQuartz, techDataQs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISQuartz, "BI", "NIStacked");
            techDataSs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MISalt, 10)

    }
            };
            CraftDataHandler.SetTechData(MISSalt, techDataSs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISSalt, "BI", "NIStacked");
            techDataSus = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MISulphur, 10)

    }
            };
            CraftDataHandler.SetTechData(MISSulphur, techDataSus);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISSulphur, "BI", "NIStacked");
            techDataCas = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MICrash, 10)

    }
            };
            CraftDataHandler.SetTechData(MISCrash, techDataCas);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISCrash, "BI", "NIStacked");
            techDataIs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIIon, 10)

    }
            };
            CraftDataHandler.SetTechData(MISIon, techDataIs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISIon, "BI", "EIStacked");
            techDataSt = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.TitaniumIngot, 10)

    }
            };
            CraftDataHandler.SetTechData(MISTitanim, techDataSt);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISTitanim, "BI", "MIStacked");
            techDataCcas = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIComputerchip, 10)

    }
            };
            CraftDataHandler.SetTechData(MISComputerchip, techDataCcas);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISComputerchip, "BI", "EIStacked");
            techDataCWas = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MICopperwire, 10)

    }
            };
            CraftDataHandler.SetTechData(MISCopperwire, techDataCcas);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISCopperwire, "BI", "EIStacked");
            techDataKCs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIWirekit, 10)

    }
            };
            CraftDataHandler.SetTechData(MISWirekit, techDataKCs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISWirekit, "BI", "EIStacked");
            techDataAWKs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIAdvwirekit, 10)

    }
            };
            CraftDataHandler.SetTechData(MISAdvwirekit, techDataAWKs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISAdvwirekit, "BI", "EIStacked");
            Console.WriteLine("Stacked Loaded");
            Console.WriteLine("Unpacked Loading");

            techDataPg = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIGold, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Gold,
                    TechType.Gold,
                    TechType.Gold,
                    TechType.Gold,
                    TechType.Gold,
                    TechType.Gold,
                    TechType.Gold,
                    TechType.Gold,
                    TechType.Gold,
                    TechType.Gold

                }
            };
            CraftDataHandler.SetTechData(PIGold, techDataPg);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIGold, "MI", "EIUnpack");

            techDataDp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIDiamond, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Diamond,
                    TechType.Diamond,
                    TechType.Diamond,
                    TechType.Diamond,
                    TechType.Diamond,
                    TechType.Diamond,
                    TechType.Diamond,
                    TechType.Diamond,
                    TechType.Diamond,
                    TechType.Diamond

                }
            };
            CraftDataHandler.SetTechData(PIDiamond, techDataDp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIDiamond, "MI", "NIUnpack");
            techDataLp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MILithium, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Lithium,
                    TechType.Lithium,
                    TechType.Lithium,
                    TechType.Lithium,
                    TechType.Lithium,
                    TechType.Lithium,
                    TechType.Lithium,
                    TechType.Lithium,
                    TechType.Lithium,
                    TechType.Lithium

                }
            };
            CraftDataHandler.SetTechData(PILithium, techDataLp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PILithium, "MI", "MIUnpack");
            techDataCP = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MICopper, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Copper,
                    TechType.Copper,
                    TechType.Copper,
                    TechType.Copper,
                    TechType.Copper,
                    TechType.Copper,
                    TechType.Copper,
                    TechType.Copper,
                    TechType.Copper,
                    TechType.Copper

                }
            };
            CraftDataHandler.SetTechData(PICopper, techDataCP);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PICopper, "MI", "EIUnpack");
            techDataLip = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MILead, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Lead,
                    TechType.Lead,
                    TechType.Lead,
                    TechType.Lead,
                    TechType.Lead,
                    TechType.Lead,
                    TechType.Lead,
                    TechType.Lead,
                    TechType.Lead,
                    TechType.Lead

                }
            };
            CraftDataHandler.SetTechData(PILead, techDataLip);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PILead, "MI", "MIUnpack");
            techDataSip = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISilver, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Silver,
                    TechType.Silver,
                    TechType.Silver,
                    TechType.Silver,
                    TechType.Silver,
                    TechType.Silver,
                    TechType.Silver,
                    TechType.Silver,
                    TechType.Silver,
                    TechType.Silver

                }
            };
            CraftDataHandler.SetTechData(PISilver, techDataSip);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISilver, "MI", "EIUnpack");
            techDataMp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIMagnetite , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Magnetite ,
                    TechType.Magnetite ,
                    TechType.Magnetite ,
                    TechType.Magnetite ,
                    TechType.Magnetite ,
                    TechType.Magnetite ,
                    TechType.Magnetite ,
                    TechType.Magnetite ,
                    TechType.Magnetite ,
                    TechType.Magnetite

                }
            };
            CraftDataHandler.SetTechData(PIMagnetite, techDataMp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIMagnetite, "MI", "EIUnpack");
            techDataNp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MINickel , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Nickel ,
                    TechType.Nickel ,
                    TechType.Nickel ,
                    TechType.Nickel ,
                    TechType.Nickel ,
                    TechType.Nickel ,
                    TechType.Nickel ,
                    TechType.Nickel ,
                    TechType.Nickel ,
                    TechType.Nickel

                }
            };
            CraftDataHandler.SetTechData(PINickel, techDataNp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PINickel, "MI", "MIUnpack");
            techDataKp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIKyanite , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Kyanite,
                    TechType.Kyanite ,
                    TechType.Kyanite ,
                    TechType.Kyanite ,
                    TechType.Kyanite ,
                    TechType.Kyanite ,
                    TechType.Kyanite ,
                    TechType.Kyanite ,
                    TechType.Kyanite ,
                    TechType.Kyanite

                }
            };
            CraftDataHandler.SetTechData(PIKyanite, techDataKp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIKyanite, "MI", "NIUnpack");
            techDataKp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIRuby , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.AluminumOxide,
                    TechType.AluminumOxide ,
                    TechType.AluminumOxide,
                    TechType.AluminumOxide ,
                    TechType.AluminumOxide,
                    TechType.AluminumOxide,
                    TechType.AluminumOxide,
                    TechType.AluminumOxide ,
                    TechType.AluminumOxide ,
                    TechType.AluminumOxide

                }
            };
            CraftDataHandler.SetTechData(PIRuby, techDataKp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIRuby, "MI", "NIUnpack");
            techDataUp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIUraninite , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.UraniniteCrystal,
                    TechType.UraniniteCrystal ,
                    TechType.UraniniteCrystal,
                    TechType.UraniniteCrystal ,
                    TechType.UraniniteCrystal,
                    TechType.UraniniteCrystal,
                    TechType.UraniniteCrystal,
                    TechType.UraniniteCrystal ,
                    TechType.UraniniteCrystal ,
                    TechType.UraniniteCrystal

                }
            };
            CraftDataHandler.SetTechData(PIUraninite, techDataUp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIUraninite, "MI", "EIUnpack");
            techDataIp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIIon , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.PrecursorIonCrystal,
                    TechType.PrecursorIonCrystal ,
                    TechType.PrecursorIonCrystal,
                    TechType.PrecursorIonCrystal ,
                    TechType.PrecursorIonCrystal,
                    TechType.PrecursorIonCrystal,
                    TechType.PrecursorIonCrystal,
                    TechType.PrecursorIonCrystal ,
                    TechType.PrecursorIonCrystal ,
                    TechType.PrecursorIonCrystal

                }
            };
            CraftDataHandler.SetTechData(PIIon, techDataIp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIIon, "MI", "EIUnpack");
            techDataQp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIQuartz , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Quartz,
                    TechType.Quartz ,
                    TechType.Quartz,
                    TechType.Quartz ,
                    TechType.Quartz,
                    TechType.Quartz,
                    TechType.Quartz,
                    TechType.Quartz ,
                    TechType.Quartz,
                    TechType.Quartz

                }
            };
            CraftDataHandler.SetTechData(PIQuartz, techDataQp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIQuartz, "MI", "NIUnpack");
            techDataSp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISalt , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Salt,
                    TechType.Salt ,
                    TechType.Salt,
                    TechType.Salt ,
                    TechType.Salt,
                    TechType.Salt,
                    TechType.Salt,
                    TechType.Salt ,
                    TechType.Salt,
                    TechType.Salt

                }
            };
            CraftDataHandler.SetTechData(PISalt, techDataSp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISalt, "MI", "NIUnpack");
            techDataSup = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISulphur , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Sulphur,
                    TechType.Sulphur ,
                    TechType.Sulphur,
                    TechType.Sulphur ,
                    TechType.Sulphur,
                    TechType.Sulphur,
                    TechType.Sulphur,
                    TechType.Sulphur ,
                    TechType.Sulphur,
                    TechType.Sulphur

                }
            };
            CraftDataHandler.SetTechData(PISulphur, techDataSup);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISulphur, "MI", "NIUnpack");
            techDataCap = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MICrash , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.CrashPowder,
                    TechType.CrashPowder ,
                    TechType.CrashPowder,
                    TechType.CrashPowder ,
                    TechType.CrashPowder,
                    TechType.CrashPowder,
                    TechType.CrashPowder,
                    TechType.CrashPowder ,
                    TechType.CrashPowder,
                    TechType.CrashPowder

                }
            };
            CraftDataHandler.SetTechData(PICrash, techDataCap);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PICrash, "MI", "NIUnpack");
            techDataStp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(TechType.TitaniumIngot , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Titanium,
                    TechType.Titanium,
                    TechType.Titanium,
                    TechType.Titanium,
                    TechType.Titanium,
                    TechType.Titanium,
                    TechType.Titanium,
                    TechType.Titanium,
                    TechType.Titanium,
                    TechType.Titanium

                }
            };
            CraftDataHandler.SetTechData(PITitanim, techDataStp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PITitanim, "MI", "MIUnpack");
            techDataCcp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIComputerchip , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.ComputerChip,
                    TechType.ComputerChip,
                    TechType.ComputerChip,
                    TechType.ComputerChip,
                    TechType.ComputerChip,
                    TechType.ComputerChip,
                    TechType.ComputerChip,
                    TechType.ComputerChip,
                    TechType.ComputerChip,
                    TechType.ComputerChip

                }
            };
            CraftDataHandler.SetTechData(PIComputerchip, techDataCcp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIComputerchip, "MI", "EIUnpack");
            techDataCWap = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MICopperwire , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.CopperWire,
                    TechType.CopperWire,
                    TechType.CopperWire,
                    TechType.CopperWire,
                    TechType.CopperWire,
                    TechType.CopperWire,
                    TechType.CopperWire,
                    TechType.CopperWire,
                    TechType.CopperWire,
                    TechType.CopperWire

                }
            };
            CraftDataHandler.SetTechData(PICopperwire, techDataCWap);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PICopperwire, "MI", "EIUnpack");
            techDataKCp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIWirekit , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.WiringKit,
                    TechType.WiringKit,
                    TechType.WiringKit,
                    TechType.WiringKit,
                    TechType.WiringKit,
                    TechType.WiringKit,
                    TechType.WiringKit,
                    TechType.WiringKit,
                    TechType.WiringKit,
                    TechType.WiringKit

                }
            };
            CraftDataHandler.SetTechData(PIWirekit, techDataCWap);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIWirekit, "MI", "EIUnpack");
           
            techDataAWKp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIAdvwirekit , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.AdvancedWiringKit,
                    TechType.AdvancedWiringKit,
                    TechType.AdvancedWiringKit,
                    TechType.AdvancedWiringKit,
                    TechType.AdvancedWiringKit,
                    TechType.AdvancedWiringKit,
                    TechType.AdvancedWiringKit,
                    TechType.AdvancedWiringKit,
                    TechType.AdvancedWiringKit,
                    TechType.AdvancedWiringKit

                }
            };
            CraftDataHandler.SetTechData(PIAdvwirekit ,techDataAWKp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIAdvwirekit, "MI", "EIUnpack");
            Console.WriteLine("Unpacked Loaded");
            Console.WriteLine("Unstacked Loading");
            techDataPgs = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISGold, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIGold,
                    MIGold,
                    MIGold,
                    MIGold,
                    MIGold,
                    MIGold,
                    MIGold,
                    MIGold,
                    MIGold,
                    MIGold

                }
            };
            CraftDataHandler.SetTechData(PISGold, techDataPgs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISGold, "BI", "MIUnstacked");

            techDataDps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISDiamond, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIDiamond,
                    MIDiamond,
                    MIDiamond,
                    MIDiamond,
                    MIDiamond,
                    MIDiamond,
                    MIDiamond,
                    MIDiamond,
                    MIDiamond,
                    MIDiamond

                }
            };
            CraftDataHandler.SetTechData(PISDiamond, techDataDps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISDiamond, "BI", "NIUnstacked");
            techDataLps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISLithium, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MILithium,
                    MILithium,
                    MILithium,
                    MILithium,
                    MILithium,
                    MILithium,
                    MILithium,
                    MILithium,
                    MILithium,
                    MILithium

                }
            };
            CraftDataHandler.SetTechData(PISLithium, techDataLps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISLithium, "BI", "MIUnstacked");
            techDataCPs = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISCopper, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MICopper,
                    MICopper,
                    MICopper,
                    MICopper,
                    MICopper,
                    MICopper,
                    MICopper,
                    MICopper,
                    MICopper,
                    MICopper

                }
            };
            CraftDataHandler.SetTechData(PISCopper, techDataCPs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISCopper, "BI", "EIUnstacked");
            techDataLips = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISLead, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MILead,
                    MILead,
                    MILead,
                    MILead,
                    MILead,
                    MILead,
                    MILead,
                    MILead,
                    MILead,
                    MILead

                }
            };
            CraftDataHandler.SetTechData(PISLead, techDataLips);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISLead, "BI", "MIUnstacked");
            techDataSips = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISilver, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MISilver,
                    MISilver,
                    MISilver,
                    MISilver,
                    MISilver,
                    MISilver,
                    MISilver,
                    MISilver,
                    MISilver,
                    MISilver

                }
            };
            CraftDataHandler.SetTechData(PISSilver, techDataSips);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISSilver, "BI", "EIUnstacked");
            techDataMps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISMagnetite , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIMagnetite,
                    MIMagnetite,
                    MIMagnetite,
                    MIMagnetite,
                    MIMagnetite,
                    MIMagnetite,
                    MIMagnetite,
                    MIMagnetite,
                    MIMagnetite,
                    MIMagnetite

                }
            };
            CraftDataHandler.SetTechData(PISMagnetite, techDataMps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISMagnetite, "BI", "EIUnstacked");
            techDataNps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISNickel , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MINickel,
                    MINickel,
                    MINickel,
                    MINickel,
                    MINickel,
                    MINickel,
                    MINickel,
                    MINickel,
                    MINickel,
                    MINickel




                }
            };
            CraftDataHandler.SetTechData(PISNickel, techDataNps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISNickel, "BI", "MIUnstacked");
            techDataKps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISKyanite , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIKyanite,
                    MIKyanite,
                    MIKyanite,
                    MIKyanite,
                    MIKyanite,
                    MIKyanite,
                    MIKyanite,
                    MIKyanite,
                    MIKyanite,
                    MIKyanite

                }
            };
            CraftDataHandler.SetTechData(PISKyanite, techDataKps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISKyanite, "BI", "NIUnstacked");
            techDataKps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISRuby , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIRuby,
                    MIRuby,
                    MIRuby,
                    MIRuby,
                    MIRuby,
                    MIRuby,
                    MIRuby,
                    MIRuby,
                    MIRuby,
                    MIRuby


                }
            };
            CraftDataHandler.SetTechData(PISRuby, techDataKps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISRuby, "BI", "NIUnstacked");
            techDataUps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISUraninite , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIUraninite,
                    MIUraninite,
                    MIUraninite,
                    MIUraninite,
                    MIUraninite,
                    MIUraninite,
                    MIUraninite,
                    MIUraninite,
                    MIUraninite,
                    MIUraninite

                }
            };
            CraftDataHandler.SetTechData(PISUraninite, techDataUps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISUraninite, "BI", "EIUnstacked");
            techDataIps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISIon , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIIon,
                    MIIon,
                    MIIon,
                    MIIon,
                    MIIon,
                    MIIon,
                    MIIon,
                    MIIon,
                    MIIon,
                    MIIon

                }
            };
            CraftDataHandler.SetTechData(PISIon, techDataIps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISIon, "BI", "EIUnstacked");
            techDataQps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISQuartz , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIQuartz,
                    MIQuartz,
                    MIQuartz,
                    MIQuartz,
                    MIQuartz,
                    MIQuartz,
                    MIQuartz,
                    MIQuartz,
                    MIQuartz,
                    MIQuartz

                }
            };
            CraftDataHandler.SetTechData(PISQuartz, techDataQps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISQuartz, "BI", "NIUnstacked");
            techDataSps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISSalt , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MISalt,
                    MISalt ,
                    MISalt,
                    MISalt ,
                    MISalt,
                    MISalt,
                    MISalt,
                    MISalt ,
                    MISalt,
                    MISalt

                }
            };
            CraftDataHandler.SetTechData(PISSalt, techDataSps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISSalt, "BI", "NIUnstacked");
            techDataSups = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISSulphur , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MISulphur,
                    MISulphur ,
                    MISulphur,
                    MISulphur ,
                    MISulphur,
                    MISulphur,
                    MISulphur,
                    MISulphur ,
                    MISulphur,
                    MISulphur

                }
            };
            CraftDataHandler.SetTechData(PISSulphur, techDataSups);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISSulphur, "BI", "NIUnstacked");
            techDataCaps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISCrash , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MICrash,
                    MICrash,
                    MICrash,
                    MICrash,
                    MICrash,
                    MICrash,
                    MICrash,
                    MICrash,
                    MICrash,
                    MICrash

                }
            };
            CraftDataHandler.SetTechData(PISCrash, techDataCaps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISCrash, "BI", "NIUnstacked");
            techDataSts = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISTitanim , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.TitaniumIngot,
                    TechType.TitaniumIngot,
                    TechType.TitaniumIngot,
                    TechType.TitaniumIngot,
                    TechType.TitaniumIngot,
                    TechType.TitaniumIngot,
                    TechType.TitaniumIngot,
                    TechType.TitaniumIngot,
                    TechType.TitaniumIngot,
                    TechType.TitaniumIngot

                }
            };
            CraftDataHandler.SetTechData(PISTitanim, techDataSts);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISTitanim, "BI", "MIUnstacked");
            techDataCcps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISComputerchip , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIComputerchip,
                    MIComputerchip,
                    MIComputerchip,
                    MIComputerchip,
                    MIComputerchip,
                    MIComputerchip,
                    MIComputerchip,
                    MIComputerchip,
                    MIComputerchip,
                    MIComputerchip

                }
            };
            CraftDataHandler.SetTechData(PISComputerchip, techDataCcps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISComputerchip, "BI", "EIUnstacked");
            techDataCWp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISCopperwire , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    MICopperwire,
                    MICopperwire,
                    MICopperwire,
                    MICopperwire,
                    MICopperwire,
                    MICopperwire,
                    MICopperwire,
                    MICopperwire,
                    MICopperwire,
                    MICopperwire

                }
            };
            CraftDataHandler.SetTechData(PISCopperwire, techDataCWp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISCopperwire, "BI", "EIUnstacked");
            techDataKCps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISWirekit , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIWirekit,
                    MIWirekit,
                    MIWirekit,
                    MIWirekit,
                    MIWirekit,
                    MIWirekit,
                    MIWirekit,
                    MIWirekit,
                    MIWirekit,
                    MIWirekit

                }
            };
            CraftDataHandler.SetTechData(PISWirekit, techDataKCps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISWirekit, "BI", "EIUnstacked");
            techDataAWKps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISAdvwirekit , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIAdvwirekit,
                    MIAdvwirekit,
                    MIAdvwirekit,
                    MIAdvwirekit,
                    MIAdvwirekit,
                    MIAdvwirekit,
                    MIAdvwirekit,
                    MIAdvwirekit,
                    MIAdvwirekit,
                    MIAdvwirekit

                }
            };
            CraftDataHandler.SetTechData(PISAdvwirekit, techDataAWKps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISAdvwirekit, "BI", "EIUnstacked");
            Console.WriteLine("Unstacked Loaded");
            Console.WriteLine("MoreIngots Loaded");
        }
        

        public static Atlas.Sprite GetSprite(string name)
        {
            return ImageUtils.LoadSpriteFromFile(@"./QMods/" + "MoreIngots" + "/Assets/" + name + ".png");
        
        }

    }
}
