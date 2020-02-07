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
            var MIBleachjug = TechTypeHandler.AddTechType("MIBleachjug", "Jugged Bleach", "S. Jugged Bleach. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIBleachjug"));
            var techDataB = new TechData();
            var PIBleachjug = TechTypeHandler.AddTechType("PIBleachjug", "UnJugged Bleach", "S. Unjugged Bleach. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIBleachjug"));
            var techDataBp = new TechData();
            var MISBleachbarrel = TechTypeHandler.AddTechType("MISBleachbarrel", "Bleach Barreled", "S. Bleach Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISBleachbarrel"));
            var techDataBs = new TechData();

            var PISBleachbarrel = TechTypeHandler.AddTechType("PISBleachbarrel", "Bleach Unbarreled", "S. Bleach Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIBleachjug"));
            var techDataBps = new TechData();

            var MILubricantjug = TechTypeHandler.AddTechType("MILubricantjug", "Jugged Lubricant", "S. Jugged Lubricant. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MILubricantjug"));
            var techDataLu = new TechData();
            var PILubricantjug = TechTypeHandler.AddTechType("PILubricantjug", "UnJugged Lubricantjug", "S. Unjugged Lubricantjug. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PILubricantjug"));
            var techDataLup = new TechData();
            var MISLubricantbarrel = TechTypeHandler.AddTechType("MISLubricantbarrel", "Lubricant Barreled", "S. Lubricant Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISLubricantbarrel"));
            var techDataLus = new TechData();

            var PISLubricantbarrel = TechTypeHandler.AddTechType("PISLubricantbarrel", "Lubricant Unbarreled", "S. Lubricant Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MILubricantjug"));
            var techDataLups = new TechData();

            var MIPjug = TechTypeHandler.AddTechType("MIPjug", "Jugged Polyaniline", "S. Jugged Polyaniline. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIPjug"));
            var techDataP = new TechData();
            var PIPPjug = TechTypeHandler.AddTechType("PIPjug", "UnJugged Polyanilinetjug", "S. Unjugged Polyanilinejug. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIPPjug"));
            var techDataPp = new TechData();
            var MISPbarrel = TechTypeHandler.AddTechType("MISPbarrel", "Polyaniline Barreled", "S. Polyaniline Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISPbarrel"));
            var techDataPs = new TechData();

            var PISPbarrel = TechTypeHandler.AddTechType("PISPbarrel", "Polyaniline Unbarreled", "S. Polyaniline Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIPjug"));
            var techDataPps = new TechData();
            var MIAcidjug = TechTypeHandler.AddTechType("MIAcidjug", "Jugged Acid", "S. Jugged Acid. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIAcidjug"));
            var techDataA = new TechData();
            var PIAcidjug = TechTypeHandler.AddTechType("PIAcidjug", "UnJugged Acidjug", "S. Unjugged Acidjug. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIAcidjug"));
            var techDataAp = new TechData();
            var MISAcidbarrel = TechTypeHandler.AddTechType("MISAcidbarrel", "Acid Barreled", "S. Acid Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISAcidbarrel"));
            var techDataAs = new TechData();

            var PISAcidbarrel = TechTypeHandler.AddTechType("PISAcidbarrel", "Acid Unbarreled", "S. Acid Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIAcidjug"));
            var techDataAps = new TechData();

            var MIBenzenejug = TechTypeHandler.AddTechType("MIBenzenejug", "Jugged Benzene", "S. Jugged Benzene. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIBenzenejug"));
            var techDataBe = new TechData();
            var PIBenzenejug = TechTypeHandler.AddTechType("PIAcidjug", "UnJugged Benzenejug", "S. Unjugged Benzenejug. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIBenzenejug"));
            var techDataBep = new TechData();
            var MISBenzenebarrel = TechTypeHandler.AddTechType("MISAcidbarrel", "Benzene Barreled", "S. Benzene Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISBenzenebarrel"));
            var techDataBes = new TechData();

            var PISBenzenebarrel = TechTypeHandler.AddTechType("PISAcidbarrel", "Benzene Unbarreled", "S. Benzene Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIBenzenejug"));
            var techDataBeps = new TechData();
            var MIGallonWater = TechTypeHandler.AddTechType("MIGallonWater", "Jugged GallonWater", "S. Jugged GallonWater. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIGallonWater"));
            var techDataGw = new TechData();
            var PIWaterfromGallon = TechTypeHandler.AddTechType("PIWaterfromGallon", "UnJugged WaterfromGallon", "S.Unjugged WaterfromGallon. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIWaterfromGallon"));
            var techDataGwp = new TechData();
            var MIS5GallonWater = TechTypeHandler.AddTechType("MIS5GallonWater", "5 Gallon Water ", "S. 5 Gallon Water. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIS5GallonWater"));
            var techDataGws = new TechData();

            var PISWaterFrom5Gallon = TechTypeHandler.AddTechType("PISWaterFrom5Gallon", "Water From 5 Gallon", "S. WaterFrom5Gallon. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIGallonWater"));
            var techDataGwps = new TechData();
            var MIAerosheet = TechTypeHandler.AddTechType("MIAerosheet", "packed Aerosheet", "S. packed Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIAerosheet"));
            var techDataAe = new TechData();
            var PIAerosheet = TechTypeHandler.AddTechType("PIAerosheet", "Unpacked Aerosheet", "S.Unpacked Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIAerosheet"));
            var techDataAep = new TechData();
            var MISAerosheet = TechTypeHandler.AddTechType("MISAerosheet", " Stacked Aerosheet ", "S. Stacked Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISAerosheet"));
            var techDataAes = new TechData();

            var PISAerosheet = TechTypeHandler.AddTechType("PISAerosheet", "Unstacked Aerosheet", "S. Unstacked Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIAerosheet"));
            var techDataAeps = new TechData();
            var MIArmidfiber = TechTypeHandler.AddTechType("MIArmidfiber", "packed Armidfiber", "S. packed Armidfiber. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIArmidfiber"));
            var techDataAer = new TechData();
            var PIArmidfiber = TechTypeHandler.AddTechType("PIArmidfiber", "Unpacked Armidfiber", "S. Unpacked Armidfiber.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIArmidfiber"));
            
                        var techDataAerp = new TechData();
            var MISArmidfiber = TechTypeHandler.AddTechType("MISArmidfiber", " Stacked Armidfiber ", "S. Stacked Armidfiber. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISArmidfiber"));
            var techDataAers = new TechData();
            var PISArmidfiber = TechTypeHandler.AddTechType("PISArmidfiber", "Unstacked Armidfiber", "S. Unstacked Armidfiber. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIArmidfiber"));
            var techDataAerps = new TechData();

            var MISilicone = TechTypeHandler.AddTechType("MISilicone", "packed Silicone", "S. packed Silicone. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISilicone"));
            var techDataSl = new TechData();
            var PISilicone = TechTypeHandler.AddTechType("PISilicone", "Unpacked Silicone", "S. Unpacked Silicone.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PISilicone"));
            var techDataSlp = new TechData();
            var MISSilicone = TechTypeHandler.AddTechType("MISSilicone", " Stacked Silicone ", "S. Stacked Silicone. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISSilicone"));
            var techDataSls = new TechData();
            var PISSilicone = TechTypeHandler.AddTechType("PISSilicone", "Unstacked Silicone", "S. Unstacked Silicone. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISilicone"));
            var techDataSlps = new TechData();
            var MIFibermesh = TechTypeHandler.AddTechType("MIFibermesh", "packed Fibermesh", "S. packed Fibermesh. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIFibermesh"));
            var techDataFi = new TechData();
            var PIFibermesh = TechTypeHandler.AddTechType("PIFibermesh", "Unpacked Fibermesh", "S. Unpacked Fibermesh.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIFibermesh"));
            var techDataFp = new TechData();
            var MISFibermesh = TechTypeHandler.AddTechType("MISFibermesh", " Stacked Fibermesh ", "S. Stacked Fibermesh. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISFibermesh"));
            var techDataFs = new TechData();
            var PISFibermesh = TechTypeHandler.AddTechType("PISFibermesh", "Unstacked Fibermesh", "S. Unstacked Fibermesh. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIFibermesh"));
            var techDataFps = new TechData();


            var MIGlass = TechTypeHandler.AddTechType("MIGlass", "packed Glass", "S. packed Glass. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIGlass"));
            var techDataGe = new TechData();
            var PIGlass = TechTypeHandler.AddTechType("PIGlass", "Unpacked Glass", "S. Unpacked Glass.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIGlass"));
            
                        var techDataGep = new TechData();
            var MISGlass = TechTypeHandler.AddTechType("MISGlass", " Stacked Glass ", "S. Stacked Glass. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISGlass"));
            var techDataGes = new TechData();
            var PISGlass = TechTypeHandler.AddTechType("PISGlass", "Unstacked Glass", "S. Unstacked Glass. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIGlass"));
            var techDataGeps = new TechData();
            var MIEnameled = TechTypeHandler.AddTechType("MIEnameled", "packed Enameled Glass", "S. packed Enameled Glass. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIEnameled"));
            var techDataEg = new TechData();
            var PIEnameled = TechTypeHandler.AddTechType("PIEnameled", "Unpacked Enameled Glass", "S. Unpacked Enameled Glass.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIEnameled"));
            
                        var techDataEgp = new TechData();
            var MISEnameled = TechTypeHandler.AddTechType("MISEnameled", " Stacked Enameled Glass ", "S. Stacked Enameled Glass. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISEnameled"));
            var techDataEgs = new TechData();
            var PISEnameled = TechTypeHandler.AddTechType("PISEnameled", "Unstacked Enameled Glass", "S. Unstacked Enameled Glass. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIEnameled"));
            var techDataEgps = new TechData();
            var MIStaker = TechTypeHandler.AddTechType("MIStaker", "packed Staker Tooth", "S. packed Staker Tooth. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIStaker"));
            var techDataSa = new TechData();
            var PIStaker = TechTypeHandler.AddTechType("PIStaker", "Unpacked Staker Tooth", "S. Unpacked Staker Tooth.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIStaker"));
            
                        var techDataSap = new TechData();
            var MISStaker = TechTypeHandler.AddTechType("MISStaker", " Stacked Staker Tooth ", "S. Stacked Staker Tooth. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISStaker"));
            var techDataSas = new TechData();
            var PISStaker = TechTypeHandler.AddTechType("PISStaker", "Unstacked Staker Tooth", "S. Unstacked Staker Tooth. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIStaker"));
            var techDataSaps = new TechData();
            var MIAcid = TechTypeHandler.AddTechType("MIAcid", "packed Acid Mushroom", "S. packed Acid Mushroom. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIAcid"));
            var techDataAm = new TechData();
            var PIAcid = TechTypeHandler.AddTechType("PIAcid", "Unpacked Acid Mushroom", "S. Unpacked Acid Mushroom.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIAcid"));
            
                        var techDataAmp = new TechData();
            var MISAcid = TechTypeHandler.AddTechType("MISAcid", " Stacked Acid Mushroom ", "S. Stacked Acid Mushroom. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISAcid"));
            var techDataAms = new TechData();
            var PISAcid = TechTypeHandler.AddTechType("PISAcid", "Unstacked Acid Mushroom", "S. Unstacked Acid Mushroom. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIAcid"));
            var techDataAmps = new TechData();
            var MICoral = TechTypeHandler.AddTechType("MICoral", "packed CoralChunk", "S. packed CoralChunk . Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MICoral"));
            var techDataCh = new TechData();
            var PICoral = TechTypeHandler.AddTechType("PICoral", "Unpacked CoralChunk", "S. Unpacked CoralChunk.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PICoral"));
            
                        var techDataChp = new TechData();
            var MISCoral = TechTypeHandler.AddTechType("MISCoral", " Stacked CoralChunk ", "S. Stacked CoralChunk. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISCoral"));
            var techDataChs = new TechData();
            var PISCoral = TechTypeHandler.AddTechType("PISCoral", "Unstacked CoralChunk", "S. Unstacked CoralChunk. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MICoral"));
            var techDataChps = new TechData();
            var MITable = TechTypeHandler.AddTechType("MITable", "packed Table Coral", "S. packed Table Coral . Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MITable"));
            var techDataTc = new TechData();
            var PITable = TechTypeHandler.AddTechType("PITable", "Unpacked Table Coral", "S. Unpacked Table Coral .Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PITable"));
            var techDataTcp = new TechData();
            var MISTable = TechTypeHandler.AddTechType("MISTablel", " Stacked Table Coral ", "S. Stacked Table Coral. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISTable"));
            var techDataTcs = new TechData();
            var PISTable = TechTypeHandler.AddTechType("PISTable", "Unstacked Table Coral", "S. Unstacked Table Coral. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MITable"));
            var techDataTcps = new TechData();
            var MICreepp = TechTypeHandler.AddTechType("MICreepp", "packed CreepVinePiece"," S.packed CreepVinePiece.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MICreepp"));
            var techDataCv = new TechData();
            var PICreepp = TechTypeHandler.AddTechType("PICreepp", "Unpacked CreepVinePiece", "S. Unpacked CreepVinePiece.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PICreepp"));
            var techDataCvp = new TechData();            
            var MISCreepp = TechTypeHandler.AddTechType("MISCreepp", " Stacked CreepVinePiece ", "S. Stacked CreepVinePiece. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISCreepp"));
            var techDataCvs = new TechData();
            var PISCreepp = TechTypeHandler.AddTechType("PISCreepp", "Unstacked CreepVinePiece", "S. Unstacked CreepVinePiece. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MICreepp"));
            var techDataCvps = new TechData();
            var MISeed = TechTypeHandler.AddTechType("MISeed", "packed Creepvine Seed Cluster", "S.packed Creepvine Seed Cluster.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISeed"));
            var techDataSc = new TechData();
            var PISeed = TechTypeHandler.AddTechType("PISeed", "Unpacked Creepvine Seed Cluster", "S. Unpacked Creepvine Seed Cluster.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PISeed"));
            var techDataScp = new TechData();             
            var MISSeed = TechTypeHandler.AddTechType("MISSeed", " Stacked Creepvine Seed Cluster ", "S. Stacked Creepvine Seed Cluster. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISSeed"));
            var techDataScs = new TechData();
            var PISSeed = TechTypeHandler.AddTechType("PISSeed", "Unstacked Deep Shroom", "S. Unstacked Deep Shroom. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISeed"));
            var techDataScps = new TechData();
            var MIWhite = TechTypeHandler.AddTechType("MIWhite", "packed Deep Shroom", "S.packed Deep Shroom.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIWhite"));
            var techDataDm = new TechData();
            var PIWhite = TechTypeHandler.AddTechType("PIWhite", "Unpacked Deep Shroom", "S. Unpacked Deep Shroom.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIWhite"));
            var techDataDmp = new TechData();
            var MISWhite = TechTypeHandler.AddTechType("MISWhite", " Stacked Deep Shroom ", "S. Stacked Deep Shroom. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISWhite"));
            var techDataDms = new TechData();
            var PISWhite = TechTypeHandler.AddTechType("PISWhite", "Unstacked Deep Shroom", "S. Unstacked Deep Shroom. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIWhite"));
            var techDataDmps = new TechData();
            var MIJelly = TechTypeHandler.AddTechType("MIJelly", "packed Jellyshroom", "S.packed Jellyshroom.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIJelly"));
            var techDataJs = new TechData();
            var PIJelly = TechTypeHandler.AddTechType("PIJelly", "Unpacked Deep Shroom", "S. Unpacked Jellyshroom.Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("PIJelly"));
            var techDataJsp = new TechData();
            var MISJelly = TechTypeHandler.AddTechType("MISJelly", " Stacked Jellyshroom ", "S. Stacked Jellyshroom. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISJelly"));
            var techDataJss = new TechData();
            var PISJelly = TechTypeHandler.AddTechType("PISJelly", "Unstacked Jellyshroom", "S. Unstacked Jellyshroom. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MIJelly"));
            var techDataJsps = new TechData();

                      
           
                       
                
                       
                   
           
           


            Console.WriteLine("Loading Moreingots");
            Console.WriteLine("Loading Fabricator");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MI", "MoreIngots", SpriteManager.Get(TechType.TitaniumIngot));
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "BI", "Hoarder", SpriteManager.Get(TechType.TitaniumIngot));
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIStacked", "synthetic Stacked", SpriteManager.Get(TechType.Silicone),"BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIStacked", "Metal Stacked", SpriteManager.Get(TechType.TitaniumIngot), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIStacked", "Food Stacked", SpriteManager.Get(TechType.Bladderfish), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIStacked", "Nature Stacked", SpriteManager.Get(TechType.Sulphur), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIStacked", "Energy Stacked", SpriteManager.Get(TechType.Battery), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIStacked", "Chemical Stacked", SpriteManager.Get(TechType.Bleach), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnstacked", "Metal Unstacked", SpriteManager.Get(TechType.TitaniumIngot), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIUnstacked", "Food Unstacked", SpriteManager.Get(TechType.Bladderfish), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIUnstacked", "Nature Unstacked", SpriteManager.Get(TechType.Sulphur), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIUnstacked", "Energy Unstacked", SpriteManager.Get(TechType.Battery), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIUnstacked", "Chemical Unstacked", SpriteManager.Get(TechType.Bleach), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIUnstacked", "synthetic Unstacked", SpriteManager.Get(TechType.Silicone), "BI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SICraft", "synthetic Pack", SpriteManager.Get(TechType.Silicone), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MICraft", "Metal Pack", SpriteManager.Get(TechType.TitaniumIngot), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NICraft", "Nature Pack", SpriteManager.Get(TechType.Sulphur), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FICraft", "Food Pack", SpriteManager.Get(TechType.Peeper), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EICraft", "Energy Pack", SpriteManager.Get(TechType.Battery), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CICraft", "Chemical Pack", SpriteManager.Get(TechType.Bleach), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIUnpack", "Food Unpack", SpriteManager.Get(TechType.Peeper), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnpack", "Metal Unpack", SpriteManager.Get(TechType.TitaniumIngot), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIUnpack", "Nature Unpack", SpriteManager.Get(TechType.Sulphur), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIUnpack", "Enegry Unpack", SpriteManager.Get(TechType.Battery), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIUnpack", "Chemical Unpack", SpriteManager.Get(TechType.Bleach), "MI");
            CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIUnpack", "synthetic Unpack", SpriteManager.Get(TechType.Silicone), "MI");
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
            techDataGe = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Glass, 10)

    }
            };
            CraftDataHandler.SetTechData(MIGlass, techDataGe);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIGlass, "MI", "NICraft");
            techDataEg = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.EnameledGlass, 10)

    }
            };
            CraftDataHandler.SetTechData(MIEnameled, techDataEg);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIEnameled, "MI", "NICraft");
            techDataSa = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.StalkerTooth, 10)

    }
            };
            CraftDataHandler.SetTechData(MIStaker, techDataSa);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIStaker, "MI", "NICraft");
            techDataAm = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.AcidMushroom, 10)

    }
            };
            CraftDataHandler.SetTechData(MIAcid, techDataAm);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIAcid, "MI", "NICraft");
            techDataCh = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.CoralChunk, 10)

    }
            };
            CraftDataHandler.SetTechData(MICoral, techDataCh);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MICoral, "MI", "NICraft");
            techDataTc = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.JeweledDiskPiece, 10)

    }
            };
            CraftDataHandler.SetTechData(MITable, techDataTc);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MITable, "MI", "NICraft");
            techDataCv = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.CreepvinePiece, 10)

    }
            };
            CraftDataHandler.SetTechData(MICreepp, techDataCv);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MICreepp, "MI", "NICraft");
            techDataSc = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.CreepvineSeedCluster, 10)

    }
            };
            CraftDataHandler.SetTechData(MISeed, techDataSc);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISeed, "MI", "NICraft");
            techDataDm = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.WhiteMushroom, 10)

    }
            };
            CraftDataHandler.SetTechData(MIWhite, techDataDm);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIWhite, "MI", "NICraft");
            techDataJs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.JellyPlant, 10)

    }
            };
            CraftDataHandler.SetTechData(MIJelly, techDataJs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIJelly, "MI", "NICraft");

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
            techDataAe = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Aerogel, 10)

    }
            };
            CraftDataHandler.SetTechData(MIAerosheet, techDataAe);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIAerosheet, "MI", "SICraft");
            techDataAer = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.AramidFibers, 10)

    }
            };
            CraftDataHandler.SetTechData(MIArmidfiber, techDataAer);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIArmidfiber, "MI", "SICraft");
            techDataSl = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Silicone, 10)

    }
            };
            CraftDataHandler.SetTechData(MISilicone, techDataSl);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISilicone, "MI", "SICraft");
            techDataFi = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.FiberMesh, 10)

    }
            };
            CraftDataHandler.SetTechData(MIFibermesh, techDataFi);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIFibermesh, "MI", "SICraft");
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
            techDataB = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Bleach, 10)

    }
            };
            CraftDataHandler.SetTechData(MIBleachjug, techDataB);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIBleachjug, "MI", "CICraft");
            techDataLu = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Lubricant, 10)

    }
            };
            CraftDataHandler.SetTechData(MILubricantjug, techDataLu);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MILubricantjug, "MI", "CICraft");
            techDataP = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Lubricant, 10)

    }
            };
            CraftDataHandler.SetTechData(MIPjug, techDataP);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIPjug, "MI", "CICraft");
            techDataA = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.HydrochloricAcid, 10)

    }
            };
            CraftDataHandler.SetTechData(MIAcidjug, techDataA);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIAcidjug, "MI", "CICraft");
            techDataBe = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.HydrochloricAcid, 10)

    }
            };
            CraftDataHandler.SetTechData(MIBenzenejug, techDataBe);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIBenzenejug, "MI", "CICraft");
            techDataGw = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.FilteredWater, 10)

    }
            };
            CraftDataHandler.SetTechData(MIGallonWater, techDataGw);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIGallonWater, "MI", "FICraft");

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
            techDataAes = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIAerosheet, 10)

    }
            };
            CraftDataHandler.SetTechData(MISAerosheet, techDataAes);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISAerosheet, "BI", "SIStacked");
            techDataGes = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIGlass, 10)

    }
            };
            CraftDataHandler.SetTechData(MISGlass, techDataGes);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISGlass, "BI", "NIStacked");
            techDataEgs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIEnameled, 10)

    }
            };
            CraftDataHandler.SetTechData(MISEnameled, techDataEgs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISEnameled, "BI", "NIStacked");
            techDataSas = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIStaker, 10)

    }
            };
            CraftDataHandler.SetTechData(MISStaker, techDataSas);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISStaker, "BI", "NIStacked");
            techDataAms = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIAcid, 10)

    }
            };
            CraftDataHandler.SetTechData(MISAcid, techDataAms);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISAcid, "BI", "NIStacked");
            techDataChs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MICoral, 10)

    }
            };
            CraftDataHandler.SetTechData(MISCoral, techDataChs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISCoral, "BI", "NIStacked");
            techDataTcs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MITable, 10)

    }
            };
            CraftDataHandler.SetTechData(MISTable, techDataTcs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISTable, "BI", "NIStacked");
            techDataCvs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MICreepp, 10)

    }
            };
            CraftDataHandler.SetTechData(MISCreepp, techDataCvs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISCreepp, "BI", "NIStacked");
            techDataScs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MISeed, 10)

    }
            };
            CraftDataHandler.SetTechData(MISSeed, techDataScs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISSeed, "BI", "NIStacked");
            techDataDms = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIWhite, 10)

    }
            };
            CraftDataHandler.SetTechData(MISWhite, techDataDms);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISWhite, "BI", "NIStacked");
            techDataJss = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIJelly, 10)

    }
            };
            CraftDataHandler.SetTechData(MISJelly, techDataJss);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISJelly, "BI", "NIStacked");
            techDataAers = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIArmidfiber, 10)

    }
            };
            CraftDataHandler.SetTechData(MISArmidfiber, techDataAers);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISAerosheet, "BI", "SIStacked");
            techDataSis = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MISilicone, 10)

    }
            };
            CraftDataHandler.SetTechData(MISSilicone, techDataSis);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISSilicone, "BI", "SIStacked");
            techDataFs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIFibermesh, 10)

    }
            };
            CraftDataHandler.SetTechData(MISFibermesh, techDataFs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISFibermesh, "BI", "SIStacked");

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
            techDataGws = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIGallonWater, 10)

    }
            };
            CraftDataHandler.SetTechData(MIS5GallonWater, techDataGws);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIS5GallonWater, "BI", "FIStacked");
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
            techDataBs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIBleachjug, 10)

    }
            };
            CraftDataHandler.SetTechData(MISBleachbarrel, techDataBs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISBleachbarrel, "BI", "CIStacked");
            techDataPs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIPjug, 10)

    }
            };
            CraftDataHandler.SetTechData(MISPbarrel, techDataPs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISPbarrel, "BI", "CIStacked");
            techDataAs = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIAcidjug, 10)

    }
            };
            CraftDataHandler.SetTechData(MISAcidbarrel, techDataAs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISAcidbarrel, "BI", "CIStacked");
            techDataBes = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MIBenzenejug, 10)

    }
            };
            CraftDataHandler.SetTechData(MISBenzenebarrel, techDataBes);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISBenzenebarrel, "BI", "CIStacked");
            techDataBes = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(MILubricantjug, 10)

    }
            };
            CraftDataHandler.SetTechData(MISLubricantbarrel, techDataBes);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MISLubricantbarrel, "BI", "CIStacked");
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
            techDataGwp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIGallonWater, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.FilteredWater,
                    TechType.FilteredWater,
                    TechType.FilteredWater,
                    TechType.FilteredWater,
                    TechType.FilteredWater,
                    TechType.FilteredWater,
                    TechType.FilteredWater,
                    TechType.FilteredWater,
                    TechType.FilteredWater,
                    TechType.FilteredWater

                }
            };
            CraftDataHandler.SetTechData(PIWaterfromGallon, techDataGwp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIWaterfromGallon, "MI", "FIUnpack");
            techDataGep = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIGlass, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Glass,
                    TechType.Glass,
                    TechType.Glass,
                    TechType.Glass,
                    TechType.Glass,
                    TechType.Glass,
                    TechType.Glass,
                    TechType.Glass,
                    TechType.Glass,
                    TechType.Glass

                }
            };
            CraftDataHandler.SetTechData(PIGlass, techDataGep);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIGlass, "MI", "NIUnpack");
            techDataEgp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIEnameled, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.EnameledGlass,
                    TechType.EnameledGlass,
                    TechType.EnameledGlass,
                    TechType.EnameledGlass,
                    TechType.EnameledGlass,
                    TechType.EnameledGlass,
                    TechType.EnameledGlass,
                    TechType.EnameledGlass,
                    TechType.EnameledGlass,
                    TechType.EnameledGlass

                }
            };
            CraftDataHandler.SetTechData(PIEnameled, techDataEgp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIEnameled, "MI", "NIUnpack");
            techDataSap = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIStaker, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.StalkerTooth,
                    TechType.StalkerTooth,
                    TechType.StalkerTooth,
                    TechType.StalkerTooth,
                    TechType.StalkerTooth,
                    TechType.StalkerTooth,
                    TechType.StalkerTooth,
                    TechType.StalkerTooth,
                    TechType.StalkerTooth,
                    TechType.StalkerTooth

                }
            };
            CraftDataHandler.SetTechData(PIStaker, techDataSap);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIStaker, "MI", "NIUnpack");
            techDataAmp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIAcid, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.AcidMushroom,
                    TechType.AcidMushroom,
                    TechType.AcidMushroom,
                    TechType.AcidMushroom,
                    TechType.AcidMushroom,
                    TechType.AcidMushroom,
                    TechType.AcidMushroom,
                    TechType.AcidMushroom,
                    TechType.AcidMushroom,
                    TechType.AcidMushroom

                }
            };
            CraftDataHandler.SetTechData(PIAcid, techDataAmp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIAcid, "MI", "NIUnpack");
            techDataChp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MICoral, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.CoralChunk,
                    TechType.CoralChunk,
                    TechType.CoralChunk,
                    TechType.CoralChunk,
                    TechType.CoralChunk,
                    TechType.CoralChunk,
                    TechType.CoralChunk,
                    TechType.CoralChunk,
                    TechType.CoralChunk,
                    TechType.CoralChunk

                }
            };
            CraftDataHandler.SetTechData(PICoral, techDataChp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PICoral, "MI", "NIUnpack");
            techDataTcp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MITable, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.JeweledDiskPiece,
                    TechType.JeweledDiskPiece,
                    TechType.JeweledDiskPiece,
                    TechType.JeweledDiskPiece,
                    TechType.JeweledDiskPiece,
                    TechType.JeweledDiskPiece,
                    TechType.JeweledDiskPiece,
                    TechType.JeweledDiskPiece,
                    TechType.JeweledDiskPiece,
                    TechType.JeweledDiskPiece

                }
            };
            CraftDataHandler.SetTechData(PITable, techDataTcp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PITable, "MI", "NIUnpack");
            techDataCvp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MICreepp, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.CreepvinePiece,
                    TechType.CreepvinePiece,
                    TechType.CreepvinePiece,
                    TechType.CreepvinePiece,
                    TechType.CreepvinePiece,
                    TechType.CreepvinePiece,
                    TechType.CreepvinePiece,
                    TechType.CreepvinePiece,
                    TechType.CreepvinePiece,
                    TechType.CreepvinePiece

                }
            };
            CraftDataHandler.SetTechData(PICreepp, techDataCvp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PICreepp, "MI", "NIUnpack");
            techDataScp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISeed, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.CreepvineSeedCluster,
                    TechType.CreepvineSeedCluster,
                    TechType.CreepvineSeedCluster,
                    TechType.CreepvineSeedCluster,
                    TechType.CreepvineSeedCluster,
                    TechType.CreepvineSeedCluster,
                    TechType.CreepvineSeedCluster,
                    TechType.CreepvineSeedCluster,
                    TechType.CreepvineSeedCluster,
                    TechType.CreepvineSeedCluster

                }
            };
            CraftDataHandler.SetTechData(PISeed, techDataScp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISeed, "MI", "NIUnpack");
            techDataDmp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIWhite, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.WhiteMushroom,
                    TechType.WhiteMushroom,
                    TechType.WhiteMushroom,
                    TechType.WhiteMushroom,
                    TechType.WhiteMushroom,
                    TechType.WhiteMushroom,
                    TechType.WhiteMushroom,
                    TechType.WhiteMushroom,
                    TechType.WhiteMushroom,
                    TechType.WhiteMushroom

                }
            };
            CraftDataHandler.SetTechData(PIWhite, techDataDmp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIWhite, "MI", "NIUnpack");
            techDataJsp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIJelly, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.JellyPlant,
                    TechType.JellyPlant,
                    TechType.JellyPlant,
                    TechType.JellyPlant,
                    TechType.JellyPlant,
                    TechType.JellyPlant,
                    TechType.JellyPlant,
                    TechType.JellyPlant,
                    TechType.JellyPlant,
                    TechType.JellyPlant

                }
            };
            CraftDataHandler.SetTechData(PIJelly, techDataJsp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIJelly, "MI", "NIUnpack");
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
            techDataAep = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIAerosheet, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Aerogel,
                    TechType.Aerogel,
                    TechType.Aerogel,
                    TechType.Aerogel,
                    TechType.Aerogel,
                    TechType.Aerogel,
                    TechType.Aerogel,
                    TechType.Aerogel,
                    TechType.Aerogel,
                    TechType.Aerogel

                }
            };
            CraftDataHandler.SetTechData(PIAerosheet, techDataAep);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIAerosheet, "MI", "SIUnpack");
            techDataAerp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIArmidfiber, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.AramidFibers,
                    TechType.AramidFibers,
                    TechType.AramidFibers,
                    TechType.AramidFibers,
                    TechType.AramidFibers,
                    TechType.AramidFibers,
                    TechType.AramidFibers,
                    TechType.AramidFibers,
                    TechType.AramidFibers,
                    TechType.AramidFibers

                }
            };
            CraftDataHandler.SetTechData(PIArmidfiber, techDataAerp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIArmidfiber, "MI", "SIUnpack");
            techDataSlp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISilicone, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Silicone,
                    TechType.Silicone,
                    TechType.Silicone,
                    TechType.Silicone,
                    TechType.Silicone,
                    TechType.Silicone,
                    TechType.Silicone,
                    TechType.Silicone,
                    TechType.Silicone,
                    TechType.Silicone

                }
            };
            CraftDataHandler.SetTechData(PISilicone, techDataSlp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISilicone, "MI", "SIUnpack");
            techDataFp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIFibermesh, 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.FiberMesh,
                    TechType.FiberMesh,
                    TechType.FiberMesh,
                    TechType.FiberMesh,
                    TechType.FiberMesh,
                    TechType.FiberMesh,
                    TechType.FiberMesh,
                    TechType.FiberMesh,
                    TechType.FiberMesh,
                    TechType.FiberMesh

                }
            };
            CraftDataHandler.SetTechData(PIFibermesh, techDataFp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIFibermesh, "MI", "SIUnpack");
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
            techDataBp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIBleachjug , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Bleach,
                    TechType.Bleach,
                    TechType.Bleach,
                    TechType.Bleach,
                    TechType.Bleach,
                    TechType.Bleach,
                    TechType.Bleach,
                    TechType.Bleach,
                    TechType.Bleach,
                    TechType.Bleach

                }
            };
            CraftDataHandler.SetTechData(PIBleachjug, techDataBp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIBleachjug, "MI", "CIUnpack");
            techDataAp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIAcidjug , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.HydrochloricAcid,
                    TechType.HydrochloricAcid,
                    TechType.HydrochloricAcid,
                    TechType.HydrochloricAcid,
                    TechType.HydrochloricAcid,
                    TechType.HydrochloricAcid,
                    TechType.HydrochloricAcid,
                    TechType.HydrochloricAcid,
                    TechType.HydrochloricAcid,
                    TechType.HydrochloricAcid

                }
            };
            CraftDataHandler.SetTechData(PIAcidjug, techDataAp);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIAcidjug, "MI", "CIUnpack");
            techDataBep = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIBenzenejug , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Benzene,
                    TechType.Benzene,
                    TechType.Benzene,
                    TechType.Benzene,
                    TechType.Benzene,
                    TechType.Benzene,
                    TechType.Benzene,
                    TechType.Benzene,
                    TechType.Benzene,
                    TechType.Benzene

                }
            };
            CraftDataHandler.SetTechData(PIBenzenejug, techDataBep);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIBenzenejug, "MI", "CIUnpack");
            techDataPp = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIPjug , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Polyaniline,
                    TechType.Polyaniline,
                    TechType.Polyaniline,
                    TechType.Polyaniline,
                    TechType.Polyaniline,
                    TechType.Polyaniline,
                    TechType.Polyaniline,
                    TechType.Polyaniline,
                    TechType.Polyaniline,
                    TechType.Polyaniline

                }
            };
            CraftDataHandler.SetTechData(PIPPjug, techDataBep);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PIPPjug, "MI", "CIUnpack");
            techDataLup = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MILubricantjug , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    TechType.Lubricant,
                    TechType.Lubricant,
                    TechType.Lubricant,
                    TechType.Lubricant,
                    TechType.Lubricant,
                    TechType.Lubricant,
                    TechType.Lubricant,
                    TechType.Lubricant,
                    TechType.Lubricant,
                    TechType.Lubricant

                }
            };
            CraftDataHandler.SetTechData(PILubricantjug, techDataLup);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PILubricantjug, "MI", "CIUnpack");
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
            techDataGwps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MIS5GallonWater, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIGallonWater,
                    MIGallonWater,
                    MIGallonWater,
                    MIGallonWater,
                    MIGallonWater,
                    MIGallonWater,
                    MIGallonWater,
                    MIGallonWater,
                    MIGallonWater,
                    MIGallonWater

                }
            };
            CraftDataHandler.SetTechData(PISWaterFrom5Gallon, techDataGwps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISWaterFrom5Gallon, "BI", "FIUnstacked");
            techDataGeps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISGlass, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIGlass,
                    MIGlass,
                    MIGlass,
                    MIGlass,
                    MIGlass,
                    MIGlass,
                    MIGlass,
                    MIGlass,
                    MIGlass,
                    MIGlass

                }
            };
            CraftDataHandler.SetTechData(PISGlass, techDataGeps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISGlass, "BI", "NIUnstacked");
            techDataEgps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISEnameled, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIEnameled,
                    MIEnameled,
                    MIEnameled,
                    MIEnameled,
                    MIEnameled,
                    MIEnameled,
                    MIEnameled,
                    MIEnameled,
                    MIEnameled,
                    MIEnameled

                }
            };
            CraftDataHandler.SetTechData(PISEnameled, techDataEgps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISEnameled, "BI", "NIUnstacked");
            techDataSaps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISStaker, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIStaker,
                    MIStaker,
                    MIStaker,
                    MIStaker,
                    MIStaker,
                    MIStaker,
                    MIStaker,
                    MIStaker,
                    MIStaker,
                    MIStaker

                }
            };
            CraftDataHandler.SetTechData(PISStaker, techDataSaps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISStaker, "BI", "NIUnstacked");
            techDataAmps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISAcid, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid

                }
            };
            CraftDataHandler.SetTechData(PISAcid, techDataAmps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISAcid, "BI", "NIUnstacked");
            techDataAmps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISAcid, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid,
                    MIAcid

                }
            };
            CraftDataHandler.SetTechData(PISAcid, techDataAmps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISAcid, "BI", "NIUnstacked");
            techDataChps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISCoral, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MICoral,
                    MICoral,
                    MICoral,
                    MICoral,
                    MICoral,
                    MICoral,
                    MICoral,
                    MICoral,
                    MICoral,
                    MICoral

                }
            };
            CraftDataHandler.SetTechData(PISCoral, techDataChps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISCoral, "BI", "NIUnstacked");
            techDataTcps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISTable, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MITable,
                    MITable,
                    MITable,
                    MITable,
                    MITable,
                    MITable,
                    MITable,
                    MITable,
                    MITable,
                    MITable

                }
            };
            CraftDataHandler.SetTechData(PISTable, techDataTcps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISTable, "BI", "NIUnstacked");
            techDataCvps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISCreepp, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MICreepp,
                    MICreepp,
                    MICreepp,
                    MICreepp,
                    MICreepp,
                    MICreepp,
                    MICreepp,
                    MICreepp,
                    MICreepp,
                    MICreepp

                }
            };
            CraftDataHandler.SetTechData(PISCreepp, techDataCvps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISCreepp, "BI", "NIUnstacked");
            techDataScps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISSeed, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MISeed,
                    MISeed,
                    MISeed,
                    MISeed,
                    MISeed,
                    MISeed,
                    MISeed,
                    MISeed,
                    MISeed,
                    MISeed

                }
            };
            CraftDataHandler.SetTechData(PISSeed, techDataScps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISSeed, "BI", "NIUnstacked");
            techDataDmps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISWhite, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIWhite,
                    MIWhite,
                    MIWhite,
                    MIWhite,
                    MIWhite,
                    MIWhite,
                    MIWhite,
                    MIWhite,
                    MIWhite,
                    MIWhite

                }
            };
            CraftDataHandler.SetTechData(PISWhite, techDataDmps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISWhite, "BI", "NIUnstacked");
            techDataJsps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISJelly, 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIJelly,
                    MIJelly,
                    MIJelly,
                    MIJelly,
                    MIJelly,
                    MIJelly,
                    MIJelly,
                    MIJelly,
                    MIJelly,
                    MIJelly

                }
            };
            CraftDataHandler.SetTechData(PISJelly, techDataJsps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISJelly, "BI", "NIUnstacked");
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
            techDataAeps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISAerosheet , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIAerosheet,
                    MIAerosheet,
                    MIAerosheet,
                    MIAerosheet,
                    MIAerosheet,
                    MIAerosheet,
                    MIAerosheet,
                    MIAerosheet,
                    MIAerosheet,
                    MIAerosheet


                }
            };
            CraftDataHandler.SetTechData(PISAerosheet, techDataAeps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISAerosheet, "BI", "SIUnstacked");
            techDataAerps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISArmidfiber , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIArmidfiber,
                    MIArmidfiber,
                    MIArmidfiber,
                    MIArmidfiber,
                    MIArmidfiber,
                    MIArmidfiber,
                    MIArmidfiber,
                    MIArmidfiber,
                    MIArmidfiber,
                    MIArmidfiber


                }
            };
            CraftDataHandler.SetTechData(PISArmidfiber, techDataAerps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISArmidfiber, "BI", "SIUnstacked");
            techDataSlps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISSilicone , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MISilicone,
                    MISilicone,
                    MISilicone,
                    MISilicone,
                    MISilicone,
                    MISilicone,
                    MISilicone,
                    MISilicone,
                    MISilicone,
                    MISilicone


                }
            };
            CraftDataHandler.SetTechData(PISSilicone, techDataAerps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISSilicone, "BI", "SIUnstacked");
            techDataFps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISFibermesh , 10),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIFibermesh,
                    MIFibermesh,
                    MIFibermesh,
                    MIFibermesh,
                    MIFibermesh,
                    MIFibermesh,
                    MIFibermesh,
                    MIFibermesh,
                    MIFibermesh,
                    MIFibermesh


                }
            };
            CraftDataHandler.SetTechData(PISFibermesh, techDataFps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISFibermesh, "BI", "SIUnstacked");
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
            techDataAps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISAcidbarrel , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIAcidjug,
                    MIAcidjug,
                    MIAcidjug,
                    MIAcidjug,
                    MIAcidjug,
                    MIAcidjug,
                    MIAcidjug,
                    MIAcidjug,
                    MIAcidjug,
                    MIAcidjug

                }
            };
            CraftDataHandler.SetTechData(PISAcidbarrel, techDataAs);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISAcidbarrel, "BI", "CIUnstacked");
            techDataBps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISBleachbarrel , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIBleachjug,
                    MIBleachjug,
                    MIBleachjug,
                    MIBleachjug,
                    MIBleachjug,
                    MIBleachjug,
                    MIBleachjug,
                    MIBleachjug,
                    MIBleachjug,
                    MIBleachjug

                }
            };
            CraftDataHandler.SetTechData(PISBleachbarrel, techDataBps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISBleachbarrel, "BI", "CIUnstacked");
            techDataBeps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISBenzenebarrel , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIBenzenejug,
                    MIBenzenejug,
                    MIBenzenejug,
                    MIBenzenejug,
                    MIBenzenejug,
                    MIBenzenejug,
                    MIBenzenejug,
                    MIBenzenejug,
                    MIBenzenejug,
                    MIBenzenejug

                }
            };
            CraftDataHandler.SetTechData(PISBenzenebarrel, techDataBeps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISBenzenebarrel, "BI", "CIUnstacked");
            techDataPps = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISPbarrel , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    MIPjug,
                    MIPjug,
                    MIPjug,
                    MIPjug,
                    MIPjug,
                    MIPjug,
                    MIPjug,
                    MIPjug,
                    MIPjug,
                    MIPjug

                }
            };
            CraftDataHandler.SetTechData(PISPbarrel, techDataPps);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISPbarrel, "BI", "CIUnstacked");
            techDataLups = new TechData()
            {
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                 {
                 new Ingredient(MISLubricantbarrel , 1),
                 },
                LinkedItems = new List<TechType>()
                {
                    MILubricantjug,
                    MILubricantjug,
                    MILubricantjug,
                    MILubricantjug,
                    MILubricantjug,
                    MILubricantjug,
                    MILubricantjug,
                    MILubricantjug,
                    MILubricantjug,
                    MILubricantjug

                }
            };
            CraftDataHandler.SetTechData(PISLubricantbarrel, techDataLups);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, PISLubricantbarrel, "BI", "CIUnstacked");
            Console.WriteLine("Unstacked Loaded");
            Console.WriteLine("MoreIngots Loaded");
        }
        

        public static Atlas.Sprite GetSprite(string name)
        {
            return ImageUtils.LoadSpriteFromFile(@"./QMods/" + "MoreIngots" + "/Assets/" + name + ".png");
        
        }

    }
}
