using System;
using System.Collections.Generic;
using QModManager.API.ModLoading;
using SMLHelper.V2.Crafting;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Utility;
using UnityEngine;

namespace MoreIngots.craftable
{
	// Token: 0x02000002 RID: 2
	[QModCore]
	public class Qpatch
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[QModPatch]
		public static void Patch()
		{
			TechType techType = TechTypeHandler.AddTechType("MIGold", "Gold Ingot", "Au. Compressed gold. Added by the MoreIngots mod", Qpatch.GetSprite("MIGold"));
			TechData techData = new TechData();
			TechType techType2 = TechTypeHandler.AddTechType("MIDiamond", "Compressed Diamond", "C. Compressed diamond. Added by the MoreIngots mod", Qpatch.GetSprite("MIDiamond"));
			TechData techData2 = new TechData();
			TechType techType3 = TechTypeHandler.AddTechType("MILithium", "Lithium Ingot", "Li. Compressed lithium. Added by the MoreIngots mod", Qpatch.GetSprite("MILithum"));
			TechData techData3 = new TechData();
			TechType techType4 = TechTypeHandler.AddTechType("MICopper", "Copper Ingot", "Cu. Compressed copper. Added by the MoreIngots mod", Qpatch.GetSprite("MICopper"));
			TechData techData4 = new TechData();
			TechType techType5 = TechTypeHandler.AddTechType("MILead", "Lead Ingot", "Pb. Compressed lead. Added by the MoreIngots mod", Qpatch.GetSprite("MILead"));
			TechData techData5 = new TechData();
			TechType techType6 = TechTypeHandler.AddTechType("MISilver", "Silver Ingot", "Ag. Compressed silver. Added by the MoreIngots mod", Qpatch.GetSprite("MISilver"));
			TechData techData6 = new TechData();
			TechType techType7 = TechTypeHandler.AddTechType("MIMagnetite", "Compressed Magnetite", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", Qpatch.GetSprite("MIMagnetite"));
			TechData techData7 = new TechData();
			TechType techType8 = TechTypeHandler.AddTechType("MINickel", "Nickel Ingot", "Ni. Compressed nickel. Added by the MoreIngots mod", Qpatch.GetSprite("MINickel"));
			TechData techData8 = new TechData();
			TechType techType9 = TechTypeHandler.AddTechType("MIKyanite", "Compressed Kyanite", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", Qpatch.GetSprite("MIKyanite"));
			TechData techData9 = new TechData();
			TechType techType10 = TechTypeHandler.AddTechType("MIRuby", "Compressed Ruby", "Al2O3. Compressed ruby. Added by the MoreIngots mod", Qpatch.GetSprite("MIRuby"));
			TechData techData10 = new TechData();
			TechType techType11 = TechTypeHandler.AddTechType("MIUraninite", "Compressed Uraninite", "U3O8. Compressed uraninite. Added by the MoreIngots mod", Qpatch.GetSprite("MIUrninite"));
			TechData techData11 = new TechData();
			TechType techType12 = TechTypeHandler.AddTechType("MIIon", "Ion Ingot ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", Qpatch.GetSprite("MIIon"));
			TechData techData12 = new TechData();
			TechType techType13 = TechTypeHandler.AddTechType("MIQuartz", "Compressed Quartz", "SiO4. Compressed quartz. Added by the MoreIngots mod", Qpatch.GetSprite("MIQuartz"));
			TechData techData13 = new TechData();
			TechType techType14 = TechTypeHandler.AddTechType("MISalt", "Salt Lick", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", Qpatch.GetSprite("MISalt"));
			TechData techData14 = new TechData();
			TechType techType15 = TechTypeHandler.AddTechType("MISulphur", "Compressed Sulphur", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISulphur"));
			TechData techData15 = new TechData();
			TechType techType16 = TechTypeHandler.AddTechType("MICrash", "Compressed Crashpowder", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MICrash"));
			TechData techData16 = new TechData();
			TechType techType17 = TechTypeHandler.AddTechType("MIComputerchip", "Packed Computer Chip", "S. Packeded Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIComputerchip"));
			TechData techData17 = new TechData();
			TechType techType18 = TechTypeHandler.AddTechType("MICopperwire", "Packed Copperwire", "S. Packed Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MICopperwire"));
			TechData techData18 = new TechData();
			TechType techType19 = TechTypeHandler.AddTechType("MIWirekit", "Packed Wire Kit", "S. Packed Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIWirekit"));
			TechData techData19 = new TechData();
			TechType techType20 = TechTypeHandler.AddTechType("MIAdvwirekit", "Packed Advanced Wiring Kit", "S. Packed Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIAdvwirekit"));
			TechData techData20 = new TechData();
			TechType techType21 = TechTypeHandler.AddTechType("MISGold", "Gold Ingot Stacked ", "Au. Compressed gold. Added by the MoreIngots mod", Qpatch.GetSprite("MISGold"));
			TechData techData21 = new TechData();
			TechType techType22 = TechTypeHandler.AddTechType("MISDiamond", "Compressed Diamond Stacked", "C. Compressed diamond. Added by the MoreIngots mod", Qpatch.GetSprite("MISDiamond"));
			TechData techData22 = new TechData();
			TechType techType23 = TechTypeHandler.AddTechType("MISLithium", "Lithium Ingot Stacked", "Li. Compressed lithium. Added by the MoreIngots mod", Qpatch.GetSprite("MISLithium"));
			TechData techData23 = new TechData();
			TechType techType24 = TechTypeHandler.AddTechType("MISCopper", "Copper Ingot Stacked", "Cu. Compressed copper. Added by the MoreIngots mod", Qpatch.GetSprite("MISCopper"));
			TechData techData24 = new TechData();
			TechType techType25 = TechTypeHandler.AddTechType("MISLead", "Lead Ingot Stacked", "Pb. Compressed lead. Added by the MoreIngots mod", Qpatch.GetSprite("MISLead"));
			TechData techData25 = new TechData();
			TechType techType26 = TechTypeHandler.AddTechType("MISSilver", "Silver Ingot Stacked", "Ag. Compressed silver. Added by the MoreIngots mod", Qpatch.GetSprite("MISSilver"));
			TechData techData26 = new TechData();
			TechType techType27 = TechTypeHandler.AddTechType("MISMagnetite", "Compressed Magnetite Stacked", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", Qpatch.GetSprite("MISMagnetite"));
			TechData techData27 = new TechData();
			TechType techType28 = TechTypeHandler.AddTechType("MISNickel", "Nickel Ingot Stacked", "Ni. Compressed nickel. Added by the MoreIngots mod", Qpatch.GetSprite("MISNickel"));
			TechData techData28 = new TechData();
			TechType techType29 = TechTypeHandler.AddTechType("MISKyanite", "Compressed Kyanite Stacked", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", Qpatch.GetSprite("MISKyanite"));
			TechData techData29 = new TechData();
			TechType techType30 = TechTypeHandler.AddTechType("MISRuby", "Compressed Ruby Stacked", "Al2O3. Compressed ruby. Added by the MoreIngots mod", Qpatch.GetSprite("MISRuby"));
			TechData techData30 = new TechData();
			TechType techType31 = TechTypeHandler.AddTechType("MISUraninite", "Compressed Uraninite Stacked", "U3O8. Compressed uraninite. Added by the MoreIngots mod", Qpatch.GetSprite("MISUraninite"));
			TechData techData31 = new TechData();
			TechType techType32 = TechTypeHandler.AddTechType("MISIon", "Ion Ingot Stacked ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", Qpatch.GetSprite("MISIon"));
			TechData techData32 = new TechData();
			TechType techType33 = TechTypeHandler.AddTechType("MISQuartz", "Compressed Quartz Stacked", "SiO4. Compressed quartz. Added by the MoreIngots mod", Qpatch.GetSprite("MISQuartz"));
			TechData techData33 = new TechData();
			TechType techType34 = TechTypeHandler.AddTechType("MISSalt", "Salt Lick Stacked", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", Qpatch.GetSprite("MISSalt"));
			TechData techData34 = new TechData();
			TechType techType35 = TechTypeHandler.AddTechType("MISSulphur", "Compressed Sulphur Stacked", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISSulphur"));
			TechData techData35 = new TechData();
			TechType techType36 = TechTypeHandler.AddTechType("MISCrash", "Compressed Crashpowder Stacked", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISCrash"));
			TechData techData36 = new TechData();
			TechType techType37 = TechTypeHandler.AddTechType("MISTitanim", "Stacked Titanium", "SAu. Stacked Titanium. Added by the MoreIngotsplus mod. (Suggested by Cookie)", Qpatch.GetSprite("MISTitanium"));
			TechData techData37 = new TechData();
			TechType techType38 = TechTypeHandler.AddTechType("MISComputerchip", "Stacked Computer Chip", "S. Stacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISComputerchip"));
			TechData techData38 = new TechData();
			TechType techType39 = TechTypeHandler.AddTechType("MISCopperwire", "stacked Copperwire", "S. Stacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISCopperwire"));
			TechData techData39 = new TechData();
			TechType techType40 = TechTypeHandler.AddTechType("MISWirekit", "Stacked Wire Kit", "S. Stacked Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISWirekit"));
			TechData techData40 = new TechData();
			TechType techType41 = TechTypeHandler.AddTechType("MISAdvwirekit", "Stacked Advanced Wiring Kit", "S. Stacked Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISAdvwirekit"));
			TechData techData41 = new TechData();
			TechType techType42 = TechTypeHandler.AddTechType("PIGold", "Unpacked Gold Ingot", "Au. Compressed gold. Added by the MoreIngots mod", Qpatch.GetSprite("PIGold"));
			TechData techData42 = new TechData();
			TechType techType43 = TechTypeHandler.AddTechType("PIDiamond", "Unpacked Compressed Diamond", "C. Compressed diamond. Added by the MoreIngots mod", Qpatch.GetSprite("PIDiamond"));
			TechData techData43 = new TechData();
			TechType techType44 = TechTypeHandler.AddTechType("PILithium", "Unpacked Lithium Ingot", "Li. Compressed lithium. Added by the MoreIngots mod", Qpatch.GetSprite("PILithium"));
			TechData techData44 = new TechData();
			TechType techType45 = TechTypeHandler.AddTechType("PICopper", "Unpacked Copper Ingot", "Cu. Compressed copper. Added by the MoreIngots mod", Qpatch.GetSprite("PICopper"));
			TechData techData45 = new TechData();
			TechType techType46 = TechTypeHandler.AddTechType("PILead", "Unpacked Lead Ingot", "Pb. Compressed lead. Added by the MoreIngots mod", Qpatch.GetSprite("PILead"));
			TechData techData46 = new TechData();
			TechType techType47 = TechTypeHandler.AddTechType("PISilver", "Unpacked Silver Ingot", "Ag. Compressed silver. Added by the MoreIngots mod", Qpatch.GetSprite("PISilver"));
			TechData techData47 = new TechData();
			TechType techType48 = TechTypeHandler.AddTechType("PIMagnetite", "Unpacked Compressed Magnetite", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", Qpatch.GetSprite("PIMagnetite"));
			TechData techData48 = new TechData();
			TechType techType49 = TechTypeHandler.AddTechType("PINickel", "Unpacked Nickel Ingot", "Ni. Compressed nickel. Added by the MoreIngots mod", Qpatch.GetSprite("PINickel"));
			TechData techData49 = new TechData();
			TechType techType50 = TechTypeHandler.AddTechType("PIKyanite", "Unpacked Compressed Kyanite", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", Qpatch.GetSprite("PIKyanite"));
			TechData techData50 = new TechData();
			TechType techType51 = TechTypeHandler.AddTechType("PIRuby", "Unpacked Compressed Ruby", "Al2O3. Compressed ruby. Added by the MoreIngots mod", Qpatch.GetSprite("PIRuby"));
			TechData techData51 = new TechData();
			TechType techType52 = TechTypeHandler.AddTechType("PIUraninite", "Unpacked Compressed Uraninite", "U3O8. Compressed uraninite. Added by the MoreIngots mod", Qpatch.GetSprite("PIUrninite"));
			TechData techData52 = new TechData();
			TechType techType53 = TechTypeHandler.AddTechType("PIIon", "Unpacked Ion Ingot ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", Qpatch.GetSprite("PIIon"));
			TechData techData53 = new TechData();
			TechType techType54 = TechTypeHandler.AddTechType("PIQuartz", "Unpacked Compressed Quartz", "SiO4. Compressed quartz. Added by the MoreIngots mod", Qpatch.GetSprite("PIQuartz"));
			TechData techData54 = new TechData();
			TechType techType55 = TechTypeHandler.AddTechType("PISalt", "Unpacked Salt Lick", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", Qpatch.GetSprite("PISalt"));
			TechData techData55 = new TechData();
			TechType techType56 = TechTypeHandler.AddTechType("PISulphur", "Unpacked Compressed Sulphur", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PISulphur"));
			TechData techData56 = new TechData();
			TechType techType57 = TechTypeHandler.AddTechType("PICrash", "Unpacked Compressed Crashpowder", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PICrash"));
			TechData techData57 = new TechData();
			TechType techType58 = TechTypeHandler.AddTechType("PITitanim", "Unpacked Titanium", "SAu. Unpacked Titanium. Added by the MoreIngotsplus mod. (Suggested by Cookie)", Qpatch.GetSprite("PITitanium"));
			TechData techData58 = new TechData();
			TechType techType59 = TechTypeHandler.AddTechType("PIComputerchip", "Unpacked Computer Chip", "S. Unpackeded Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIComputerchip"));
			TechData techData59 = new TechData();
			TechType techType60 = TechTypeHandler.AddTechType("PICopperwire", "Unpacked Copperwire", "S. Unpacked Copperwire Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PICopperwire"));
			TechData techData60 = new TechData();
			TechType techType61 = TechTypeHandler.AddTechType("PIWirekit", "Unpacked Wire Kit", "S. Unpacked Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIWirekit"));
			TechData techData61 = new TechData();
			TechType techType62 = TechTypeHandler.AddTechType("PIAdvwirekit", "Unpacked Advanced Wiring Kit", "S. Unpacked Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIAdvwirekit"));
			TechData techData62 = new TechData();
			TechType techType63 = TechTypeHandler.AddTechType("PISGold", "Unstacked Gold Ingot", "Au. Compressed gold. Added by the MoreIngots mod", Qpatch.GetSprite("MIGold"));
			TechData techData63 = new TechData();
			TechType techType64 = TechTypeHandler.AddTechType("PISDiamond", "Unstacked Compressed Diamond", "C. Compressed diamond. Added by the MoreIngots mod", Qpatch.GetSprite("MIDiamond"));
			TechData techData64 = new TechData();
			TechType techType65 = TechTypeHandler.AddTechType("PISLithium", "Unstacked Lithium Ingot", "Li. Compressed lithium. Added by the MoreIngots mod", Qpatch.GetSprite("MILithum"));
			TechData techData65 = new TechData();
			TechType techType66 = TechTypeHandler.AddTechType("PISCopper", "Unstacked Copper Ingot", "Cu. Compressed copper. Added by the MoreIngots mod", Qpatch.GetSprite("MICopper"));
			TechData techData66 = new TechData();
			TechType techType67 = TechTypeHandler.AddTechType("PISLead", "Unstacked Lead Ingot", "Pb. Compressed lead. Added by the MoreIngots mod", Qpatch.GetSprite("MILead"));
			TechData techData67 = new TechData();
			TechType techType68 = TechTypeHandler.AddTechType("PISSilver", "Unstacked Silver Ingot", "Ag. Compressed silver. Added by the MoreIngots mod", Qpatch.GetSprite("MISilver"));
			TechData techData68 = new TechData();
			TechType techType69 = TechTypeHandler.AddTechType("PISMagnetite", "Unstacked Compressed Magnetite", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", Qpatch.GetSprite("MIMagnetite"));
			TechData techData69 = new TechData();
			TechType techType70 = TechTypeHandler.AddTechType("PISNickel", "Unstacked Nickel Ingot", "Ni. Compressed nickel. Added by the MoreIngots mod", Qpatch.GetSprite("MINickel"));
			TechData techData70 = new TechData();
			TechType techType71 = TechTypeHandler.AddTechType("PISKyanite", "Unstacked Compressed Kyanite", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", Qpatch.GetSprite("MIKyanite"));
			TechData techData71 = new TechData();
			TechType techType72 = TechTypeHandler.AddTechType("PISRuby", "Unstacked Compressed Ruby", "Al2O3. Compressed ruby. Added by the MoreIngots mod", Qpatch.GetSprite("MIRuby"));
			TechData techData72 = new TechData();
			TechType techType73 = TechTypeHandler.AddTechType("PISUraninite", "Unstacked Compressed Uraninite", "U3O8. Compressed uraninite. Added by the MoreIngots mod", Qpatch.GetSprite("MIUrninite"));
			TechData techData73 = new TechData();
			TechType techType74 = TechTypeHandler.AddTechType("PISIon", "Unstacked Ion Ingot ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", Qpatch.GetSprite("MIIon"));
			TechData techData74 = new TechData();
			TechType techType75 = TechTypeHandler.AddTechType("PISQuartz", "Unstacked Compressed Quartz", "SiO4. Compressed quartz. Added by the MoreIngots mod", Qpatch.GetSprite("MIQuartz"));
			TechData techData75 = new TechData();
			TechType techType76 = TechTypeHandler.AddTechType("PISSalt", "Unstacked Salt Lick", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", Qpatch.GetSprite("MISalt"));
			TechData techData76 = new TechData();
			TechType techType77 = TechTypeHandler.AddTechType("PISSulphur", "Unstacked Compressed Sulphur", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISulphur"));
			TechData techData77 = new TechData();
			TechType techType78 = TechTypeHandler.AddTechType("PISCrash", "Unstacked Compressed Crashpowder", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MICrash"));
			TechData techData78 = new TechData();
			TechType techType79 = TechTypeHandler.AddTechType("PISTitanim", "UnStacked Titanium", "SAu. UnStacked Titanium. Added by the MoreIngotsplus mod. (Suggested by Cookie)", Qpatch.GetSprite("MITitanim"));
			TechData techData79 = new TechData();
			TechType techType80 = TechTypeHandler.AddTechType("PISComputerchip", "Unstacked Computer Chip", "S. Unstacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIComputerchip"));
			TechData techData80 = new TechData();
			TechType techType81 = TechTypeHandler.AddTechType("PISCopperwire", "Unstacked Copperwire", "S. Unstacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MICopperwire"));
			TechData techData81 = new TechData();
			TechType techType82 = TechTypeHandler.AddTechType("PISWirekit", "Unstacked Wire Kit", "S. Unstacked Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIWirekit"));
			TechData techData82 = new TechData();
			TechType techType83 = TechTypeHandler.AddTechType("PISAdvwirekit", "Unstacked Advanced Wiring Kit", "S. Unstacked Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIAdvwirekit"));
			TechData techData83 = new TechData();
			TechType techType84 = TechTypeHandler.AddTechType("MIBleachjug", "Jugged Bleach", "S. Jugged Bleach. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIBleachjug"));
			TechData techData84 = new TechData();
			TechType techType85 = TechTypeHandler.AddTechType("PIBleachjug", "UnJugged Bleach", "S. Unjugged Bleach. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIBleachjug"));
			TechData techData85 = new TechData();
			TechType techType86 = TechTypeHandler.AddTechType("MISBleachbarrel", "Bleach Barreled", "S. Bleach Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISBleachbarrel"));
			TechData techData86 = new TechData();
			TechType techType87 = TechTypeHandler.AddTechType("PISBleachbarrel", "Bleach Unbarreled", "S. Bleach Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIBleachjug"));
			TechData techData87 = new TechData();
			TechType techType88 = TechTypeHandler.AddTechType("MILubricantjug", "Jugged Lubricant", "S. Jugged Lubricant. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MILubricantjug"));
			TechData techData88 = new TechData();
			TechType techType89 = TechTypeHandler.AddTechType("PILubricantjug", "UnJugged Lubricantjug", "S. Unjugged Lubricantjug. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PILubricantjug"));
			TechData techData89 = new TechData();
			TechType techType90 = TechTypeHandler.AddTechType("MISLubricantbarrel", "Lubricant Barreled", "S. Lubricant Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISLubricantbarrel"));
			TechData techData90 = new TechData();
			TechType techType91 = TechTypeHandler.AddTechType("PISLubricantbarrel", "Lubricant Unbarreled", "S. Lubricant Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MILubricantjug"));
			TechData techData91 = new TechData();
			TechType techType92 = TechTypeHandler.AddTechType("MIPjug", "Jugged Polyaniline", "S. Jugged Polyaniline. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIPjug"));
			TechData techData92 = new TechData();
			TechType techType93 = TechTypeHandler.AddTechType("PIPjug", "UnJugged Polyanilinetjug", "S. Unjugged Polyanilinejug. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIPPjug"));
			TechData techData93 = new TechData();
			TechType techType94 = TechTypeHandler.AddTechType("MISPbarrel", "Polyaniline Barreled", "S. Polyaniline Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISPbarrel"));
			TechData techData94 = new TechData();
			TechType techType95 = TechTypeHandler.AddTechType("PISPbarrel", "Polyaniline Unbarreled", "S. Polyaniline Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIPjug"));
			TechData techData95 = new TechData();
			TechType techType96 = TechTypeHandler.AddTechType("MIAcidjug", "Jugged Acid", "S. Jugged Acid. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIAcidjug"));
			TechData techData96 = new TechData();
			TechType techType97 = TechTypeHandler.AddTechType("PIAcidjug", "UnJugged Acidjug", "S. Unjugged Acidjug. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIAcidjug"));
			TechData techData97 = new TechData();
			TechType techType98 = TechTypeHandler.AddTechType("MISAcidbarrel", "Acid Barreled", "S. Acid Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISAcidbarrel"));
			TechData techData98 = new TechData();
			TechType techType99 = TechTypeHandler.AddTechType("PISAcidbarrel", "Acid Unbarreled", "S. Acid Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIAcidjug"));
			TechData techData99 = new TechData();
			TechType techType100 = TechTypeHandler.AddTechType("MIBenzenejug", "Jugged Benzene", "S. Jugged Benzene. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIBenzenejug"));
			TechData techData100 = new TechData();
			TechType techType101 = TechTypeHandler.AddTechType("PIBenzenejug", "UnJugged Benzenejug", "S. Unjugged Benzenejug. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIBenzenejug"));
			TechData techData101 = new TechData();
			TechType techType102 = TechTypeHandler.AddTechType("MISBenzenebarrel", "Benzene Barreled", "S. Benzene Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISBenzenebarrel"));
			TechData techData102 = new TechData();
			TechType techType103 = TechTypeHandler.AddTechType("PISBenzenebarrel", "Benzene Unbarreled", "S. Benzene Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIBenzenejug"));
			TechData techData103 = new TechData();
			TechType techType104 = TechTypeHandler.AddTechType("MIGallonWater", "Jugged GallonWater", "S. Jugged GallonWater. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIGallonWater"));
			TechData techData104 = new TechData();
			TechType techType105 = TechTypeHandler.AddTechType("PIWaterfromGallon", "UnJugged WaterfromGallon", "S.Unjugged WaterfromGallon. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIWaterfromGallon"));
			TechData techData105 = new TechData();
			TechType techType106 = TechTypeHandler.AddTechType("MIS5GallonWater", "5 Gallon Water ", "S. 5 Gallon Water. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIS5GallonWater"));
			TechData techData106 = new TechData();
			TechType techType107 = TechTypeHandler.AddTechType("PISWaterFrom5Gallon", "Water From 5 Gallon", "S. WaterFrom5Gallon. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIGallonWater"));
			TechData techData107 = new TechData();
			TechType techType108 = TechTypeHandler.AddTechType("MIAerosheet", "packed Aerosheet", "S. packed Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIAerosheet"));
			TechData techData108 = new TechData();
			TechType techType109 = TechTypeHandler.AddTechType("PIAerosheet", "Unpacked Aerosheet", "S.Unpacked Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIAerosheet"));
			TechData techData109 = new TechData();
			TechType techType110 = TechTypeHandler.AddTechType("MISAerosheet", " Stacked Aerosheet ", "S. Stacked Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISAerosheet"));
			TechData techData110 = new TechData();
			TechType techType111 = TechTypeHandler.AddTechType("PISAerosheet", "Unstacked Aerosheet", "S. Unstacked Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIAerosheet"));
			TechData techData111 = new TechData();
			TechType techType112 = TechTypeHandler.AddTechType("MIArmidfiber", "packed Armidfiber", "S. packed Armidfiber. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIArmidfiber"));
			TechData techData112 = new TechData();
			TechType techType113 = TechTypeHandler.AddTechType("PIArmidfiber", "Unpacked Armidfiber", "S. Unpacked Armidfiber.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIArmidfiber"));
			TechData techData113 = new TechData();
			TechType techType114 = TechTypeHandler.AddTechType("MISArmidfiber", " Stacked Armidfiber ", "S. Stacked Armidfiber. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISArmidfiber"));
			TechData techData114 = new TechData();
			TechType techType115 = TechTypeHandler.AddTechType("PISArmidfiber", "Unstacked Armidfiber", "S. Unstacked Armidfiber. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIArmidfiber"));
			TechData techData115 = new TechData();
			TechType techType116 = TechTypeHandler.AddTechType("MISilicone", "packed Silicone", "S. packed Silicone. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISilicone"));
			TechData techData116 = new TechData();
			TechType techType117 = TechTypeHandler.AddTechType("PISilicone", "Unpacked Silicone", "S. Unpacked Silicone.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PISilicone"));
			TechData techData117 = new TechData();
			TechType techType118 = TechTypeHandler.AddTechType("MISSilicone", " Stacked Silicone ", "S. Stacked Silicone. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISSilicone"));
			TechData techData118 = new TechData();
			TechType techType119 = TechTypeHandler.AddTechType("PISSilicone", "Unstacked Silicone", "S. Unstacked Silicone. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISilicone"));
			TechData techData119 = new TechData();
			TechType techType120 = TechTypeHandler.AddTechType("MIFibermesh", "packed Fibermesh", "S. packed Fibermesh. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIFibermesh"));
			TechData techData120 = new TechData();
			TechType techType121 = TechTypeHandler.AddTechType("PIFibermesh", "Unpacked Fibermesh", "S. Unpacked Fibermesh.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIFibermesh"));
			TechData techData121 = new TechData();
			TechType techType122 = TechTypeHandler.AddTechType("MISFibermesh", " Stacked Fibermesh ", "S. Stacked Fibermesh. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISFibermesh"));
			TechData techData122 = new TechData();
			TechType techType123 = TechTypeHandler.AddTechType("PISFibermesh", "Unstacked Fibermesh", "S. Unstacked Fibermesh. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIFibermesh"));
			TechData techData123 = new TechData();
			TechType techType124 = TechTypeHandler.AddTechType("MIGlass", "packed Glass", "S. packed Glass. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIGlass"));
			TechData techData124 = new TechData();
			TechType techType125 = TechTypeHandler.AddTechType("PIGlass", "Unpacked Glass", "S. Unpacked Glass.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIGlass"));
			TechData techData125 = new TechData();
			TechType techType126 = TechTypeHandler.AddTechType("MISGlass", " Stacked Glass ", "S. Stacked Glass. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISGlass"));
			TechData techData126 = new TechData();
			TechType techType127 = TechTypeHandler.AddTechType("PISGlass", "Unstacked Glass", "S. Unstacked Glass. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIGlass"));
			TechData techData127 = new TechData();
			TechType techType128 = TechTypeHandler.AddTechType("MIEnameled", "packed Enameled Glass", "S. packed Enameled Glass. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIEnameled"));
			TechData techData128 = new TechData();
			TechType techType129 = TechTypeHandler.AddTechType("PIEnameled", "Unpacked Enameled Glass", "S. Unpacked Enameled Glass.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIEnameled"));
			TechData techData129 = new TechData();
			TechType techType130 = TechTypeHandler.AddTechType("MISEnameled", " Stacked Enameled Glass ", "S. Stacked Enameled Glass. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISEnameled"));
			TechData techData130 = new TechData();
			TechType techType131 = TechTypeHandler.AddTechType("PISEnameled", "Unstacked Enameled Glass", "S. Unstacked Enameled Glass. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIEnameled"));
			TechData techData131 = new TechData();
			TechType techType132 = TechTypeHandler.AddTechType("MIStaker", "packed Staker Tooth", "S. packed Staker Tooth. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIStaker"));
			TechData techData132 = new TechData();
			TechType techType133 = TechTypeHandler.AddTechType("PIStaker", "Unpacked Staker Tooth", "S. Unpacked Staker Tooth.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIStaker"));
			TechData techData133 = new TechData();
			TechType techType134 = TechTypeHandler.AddTechType("MISStaker", " Stacked Staker Tooth ", "S. Stacked Staker Tooth. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISStaker"));
			TechData techData134 = new TechData();
			TechType techType135 = TechTypeHandler.AddTechType("PISStaker", "Unstacked Staker Tooth", "S. Unstacked Staker Tooth. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIStaker"));
			TechData techData135 = new TechData();
			TechType techType136 = TechTypeHandler.AddTechType("MIAcid", "packed Acid Mushroom", "S. packed Acid Mushroom. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIAcid"));
			TechData techData136 = new TechData();
			TechType techType137 = TechTypeHandler.AddTechType("PIAcid", "Unpacked Acid Mushroom", "S. Unpacked Acid Mushroom.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIAcid"));
			TechData techData137 = new TechData();
			TechType techType138 = TechTypeHandler.AddTechType("MISAcid", " Stacked Acid Mushroom ", "S. Stacked Acid Mushroom. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISAcid"));
			TechData techData138 = new TechData();
			TechType techType139 = TechTypeHandler.AddTechType("PISAcid", "Unstacked Acid Mushroom", "S. Unstacked Acid Mushroom. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIAcid"));
			TechData techData139 = new TechData();
			TechType techType140 = TechTypeHandler.AddTechType("MICoral", "packed CoralChunk", "S. packed CoralChunk . Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MICoral"));
			TechData techData140 = new TechData();
			TechType techType141 = TechTypeHandler.AddTechType("PICoral", "Unpacked CoralChunk", "S. Unpacked CoralChunk.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PICoral"));
			TechData techData141 = new TechData();
			TechType techType142 = TechTypeHandler.AddTechType("MISCoral", " Stacked CoralChunk ", "S. Stacked CoralChunk. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISCoral"));
			TechData techData142 = new TechData();
			TechType techType143 = TechTypeHandler.AddTechType("PISCoral", "Unstacked CoralChunk", "S. Unstacked CoralChunk. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MICoral"));
			TechData techData143 = new TechData();
			TechType techType144 = TechTypeHandler.AddTechType("MITable", "packed Table Coral", "S. packed Table Coral . Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MITable"));
			TechData techData144 = new TechData();
			TechType techType145 = TechTypeHandler.AddTechType("PITable", "Unpacked Table Coral", "S. Unpacked Table Coral .Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PITable"));
			TechData techData145 = new TechData();
			TechType techType146 = TechTypeHandler.AddTechType("MISTablel", " Stacked Table Coral ", "S. Stacked Table Coral. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISTable"));
			TechData techData146 = new TechData();
			TechType techType147 = TechTypeHandler.AddTechType("PISTable", "Unstacked Table Coral", "S. Unstacked Table Coral. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MITable"));
			TechData techData147 = new TechData();
			TechType techType148 = TechTypeHandler.AddTechType("MICreepp", "packed CreepVinePiece", " S.packed CreepVinePiece.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MICreepp"));
			TechData techData148 = new TechData();
			TechType techType149 = TechTypeHandler.AddTechType("PICreepp", "Unpacked CreepVinePiece", "S. Unpacked CreepVinePiece.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PICreepp"));
			TechData techData149 = new TechData();
			TechType techType150 = TechTypeHandler.AddTechType("MISCreepp", " Stacked CreepVinePiece ", "S. Stacked CreepVinePiece. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISCreepp"));
			TechData techData150 = new TechData();
			TechType techType151 = TechTypeHandler.AddTechType("PISCreepp", "Unstacked CreepVinePiece", "S. Unstacked CreepVinePiece. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MICreepp"));
			TechData techData151 = new TechData();
			TechType techType152 = TechTypeHandler.AddTechType("MISeed", "packed Creepvine Seed Cluster", "S.packed Creepvine Seed Cluster.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISeed"));
			TechData techData152 = new TechData();
			TechType techType153 = TechTypeHandler.AddTechType("PISeed", "Unpacked Creepvine Seed Cluster", "S. Unpacked Creepvine Seed Cluster.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PISeed"));
			TechData techData153 = new TechData();
			TechType techType154 = TechTypeHandler.AddTechType("MISSeed", " Stacked Creepvine Seed Cluster ", "S. Stacked Creepvine Seed Cluster. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISSeed"));
			TechData techData154 = new TechData();
			TechType techType155 = TechTypeHandler.AddTechType("PISSeed", "Unstacked  Creepvine Seed Cluster", "S. Unstacked Deep Shroom. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISeed"));
			TechData techData155 = new TechData();
			TechType techType156 = TechTypeHandler.AddTechType("MIWhite", "packed Deep Shroom", "S.packed Deep Shroom.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIWhite"));
			TechData techData156 = new TechData();
			TechType techType157 = TechTypeHandler.AddTechType("PIWhite", "Unpacked Deep Shroom", "S. Unpacked Deep Shroom.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIWhite"));
			TechData techData157 = new TechData();
			TechType techType158 = TechTypeHandler.AddTechType("MISWhite", " Stacked Deep Shroom ", "S. Stacked Deep Shroom. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISWhite"));
			TechData techData158 = new TechData();
			TechType techType159 = TechTypeHandler.AddTechType("PISWhite", "Unstacked Deep Shroom", "S. Unstacked Deep Shroom. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIWhite"));
			TechData techData159 = new TechData();
			TechType techType160 = TechTypeHandler.AddTechType("MIJelly", "packed Jellyshroom", "S.packed Jellyshroom.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIJelly"));
			TechData techData160 = new TechData();
			TechType techType161 = TechTypeHandler.AddTechType("PIJelly", "Unpacked Deep Shroom", "S. Unpacked Jellyshroom.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIJelly"));
			TechData techData161 = new TechData();
			TechType techType162 = TechTypeHandler.AddTechType("MISJelly", " Stacked Jellyshroom ", "S. Stacked Jellyshroom. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISJelly"));
			TechData techData162 = new TechData();
			TechType techType163 = TechTypeHandler.AddTechType("PISJelly", "Unstacked Jellyshroom", "S. Unstacked Jellyshroom. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIJelly"));
			TechData techData163 = new TechData();
			TechType techType164 = TechTypeHandler.AddTechType("PIPlasteel", "Unpacked plasteel ingot", "S. Unpacked plasteel ingot.Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("PIPlasteel"));
			TechData techData164 = new TechData();
			TechType techType165 = TechTypeHandler.AddTechType("MISPlasteel", " Stacked plasteel ingot ", "S. Stacked plasteel ingot. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MISPlasteel"));
			TechData techData165 = new TechData();
			TechType techType166 = TechTypeHandler.AddTechType("PISPlasteel", "Unstacked plasteel ingot", "S. Unstacked plasteel ingot. Added by the MoreIngots mod. (Suggested by gnivler)", Qpatch.GetSprite("MIPlasteel"));
			TechData techData166 = new TechData();
			Console.WriteLine("Loading Moreingots");
			Console.WriteLine("Loading Fabricator");
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MI", "MoreIngots", Qpatch.GetSprite("MI"), new string[]
			{
				"Resources",
				"BasicMaterials"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "BI", "Hoarder", Qpatch.GetSprite("BI"), new string[]
			{
				"Resources",
				"BasicMaterials"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SI", "Stacked", Qpatch.GetSprite("SI"), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIStacked", "Metal Stacked", SpriteManager.Get(TechType.TitaniumIngot), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIStacked", "Food Stacked", SpriteManager.Get(TechType.Bladderfish), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIStacked", "Nature Stacked", SpriteManager.Get(TechType.Sulphur), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIStacked", "Energy Stacked", SpriteManager.Get(TechType.Battery), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIStacked", "Chemical Stacked", SpriteManager.Get(TechType.Bleach), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIStacked", "synthetic Stacked", SpriteManager.Get(TechType.Silicone), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "USI", "Unstacked", Qpatch.GetSprite("USI"), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnstacked", "Metal Unstacked", SpriteManager.Get(TechType.TitaniumIngot), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIUnstacked", "Food Unstacked", SpriteManager.Get(TechType.Bladderfish), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIUnstacked", "Nature Unstacked", SpriteManager.Get(TechType.Sulphur), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIUnstacked", "Energy Unstacked", SpriteManager.Get(TechType.Battery), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIUnstacked", "Chemical Unstacked", SpriteManager.Get(TechType.Bleach), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIUnstacked", "synthetic Unstacked", SpriteManager.Get(TechType.Silicone), new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "PI", "packed", Qpatch.GetSprite("PI"), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SICraft", "synthetic Pack", SpriteManager.Get(TechType.Silicone), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CICraft", "Chemical Pack", SpriteManager.Get(TechType.Bleach), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MICraft", "Metal Pack", SpriteManager.Get(TechType.TitaniumIngot), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NICraft", "Nature Pack", SpriteManager.Get(TechType.Sulphur), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FICraft", "Food Pack", SpriteManager.Get(TechType.Peeper), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EICraft", "Energy Pack", SpriteManager.Get(TechType.Battery), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "UI", "Unpacked", Qpatch.GetSprite("UI"), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SICraft", "synthetic Pack", SpriteManager.Get(TechType.Silicone), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIUnpack", "Food Unpack", SpriteManager.Get(TechType.Peeper), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnpack", "Metal Unpack", SpriteManager.Get(TechType.TitaniumIngot), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIUnpack", "Nature Unpack", SpriteManager.Get(TechType.Sulphur), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIUnpack", "Enegry Unpack", SpriteManager.Get(TechType.Battery), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIUnpack", "Chemical Unpack", SpriteManager.Get(TechType.Bleach), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIUnpack", "synthetic Unpack", SpriteManager.Get(TechType.Silicone), new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI"
			});
			Console.WriteLine("Loaded Fabricator");
			Console.WriteLine("Loading Ingots");
			techData = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Gold, 10)
				}
			};
			CraftDataHandler.SetTechData(techType, techData);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"EICraft"
			});
			techData2 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Diamond, 10)
				}
			};
			CraftDataHandler.SetTechData(techType2, techData2);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType2, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData3 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Lithium, 10)
				}
			};
			CraftDataHandler.SetTechData(techType3, techData3);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType3, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"MICraft"
			});
			techData124 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Glass, 10)
				}
			};
			CraftDataHandler.SetTechData(techType124, techData124);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType124, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData128 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.EnameledGlass, 10)
				}
			};
			CraftDataHandler.SetTechData(techType128, techData128);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType128, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData132 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.StalkerTooth, 10)
				}
			};
			CraftDataHandler.SetTechData(techType132, techData132);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType132, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData136 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.AcidMushroom, 10)
				}
			};
			CraftDataHandler.SetTechData(techType136, techData136);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType136, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData140 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.CoralChunk, 10)
				}
			};
			CraftDataHandler.SetTechData(techType140, techData140);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType140, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData144 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.JeweledDiskPiece, 10)
				}
			};
			CraftDataHandler.SetTechData(techType144, techData144);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType144, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData148 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.CreepvinePiece, 10)
				}
			};
			CraftDataHandler.SetTechData(techType148, techData148);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType148, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData152 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.CreepvineSeedCluster, 10)
				}
			};
			CraftDataHandler.SetTechData(techType152, techData152);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType152, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData156 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.WhiteMushroom, 10)
				}
			};
			CraftDataHandler.SetTechData(techType156, techData156);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType156, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData160 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.JellyPlant, 10)
				}
			};
			CraftDataHandler.SetTechData(techType160, techData160);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType160, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData4 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Copper, 10)
				}
			};
			CraftDataHandler.SetTechData(techType4, techData4);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType4, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"EICraft"
			});
			techData5 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Lead, 10)
				}
			};
			CraftDataHandler.SetTechData(techType5, techData5);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType5, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"MICraft"
			});
			techData6 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Silver, 10)
				}
			};
			CraftDataHandler.SetTechData(techType6, techData6);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType6, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"EICraft"
			});
			techData7 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Magnetite, 10)
				}
			};
			CraftDataHandler.SetTechData(techType7, techData7);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType7, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"EICraft"
			});
			techData8 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Nickel, 10)
				}
			};
			CraftDataHandler.SetTechData(techType8, techData8);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType8, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"MICraft"
			});
			techData108 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Aerogel, 10)
				}
			};
			CraftDataHandler.SetTechData(techType108, techData108);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType108, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"SICraft"
			});
			techData112 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.AramidFibers, 10)
				}
			};
			CraftDataHandler.SetTechData(techType112, techData112);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType112, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"SICraft"
			});
			techData116 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Silicone, 10)
				}
			};
			CraftDataHandler.SetTechData(techType116, techData116);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType116, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"SICraft"
			});
			techData120 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.FiberMesh, 10)
				}
			};
			CraftDataHandler.SetTechData(techType120, techData120);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType120, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"SICraft"
			});
			techData9 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Kyanite, 10)
				}
			};
			CraftDataHandler.SetTechData(techType9, techData9);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType9, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData10 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.AluminumOxide, 10)
				}
			};
			CraftDataHandler.SetTechData(techType10, techData10);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType10, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData11 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.UraniniteCrystal, 10)
				}
			};
			CraftDataHandler.SetTechData(techType11, techData11);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType11, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"EICraft"
			});
			techData13 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Quartz, 10)
				}
			};
			CraftDataHandler.SetTechData(techType13, techData13);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType13, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData14 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Salt, 10)
				}
			};
			CraftDataHandler.SetTechData(techType14, techData14);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType14, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData15 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Sulphur, 10)
				}
			};
			CraftDataHandler.SetTechData(techType15, techData15);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType15, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData16 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.CrashPowder, 10)
				}
			};
			CraftDataHandler.SetTechData(techType16, techData16);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType16, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"NICraft"
			});
			techData12 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.PrecursorIonCrystal, 10)
				}
			};
			CraftDataHandler.SetTechData(techType12, techData12);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType12, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"EICraft"
			});
			techData17 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.ComputerChip, 10)
				}
			};
			CraftDataHandler.SetTechData(techType17, techData17);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType17, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"EICraft"
			});
			techData18 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.CopperWire, 10)
				}
			};
			CraftDataHandler.SetTechData(techType18, techData18);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType18, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"EICraft"
			});
			techData19 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.WiringKit, 10)
				}
			};
			CraftDataHandler.SetTechData(techType19, techData19);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType19, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"EICraft"
			});
			techData20 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.AdvancedWiringKit, 10)
				}
			};
			CraftDataHandler.SetTechData(techType20, techData20);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType20, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"EICraft"
			});
			techData84 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Bleach, 10)
				}
			};
			CraftDataHandler.SetTechData(techType84, techData84);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType84, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"CICraft"
			});
			techData88 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Lubricant, 10)
				}
			};
			CraftDataHandler.SetTechData(techType88, techData88);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType88, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"CICraft"
			});
			techData92 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Polyaniline, 10)
				}
			};
			CraftDataHandler.SetTechData(techType92, techData92);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType92, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"CICraft"
			});
			techData96 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.HydrochloricAcid, 10)
				}
			};
			CraftDataHandler.SetTechData(techType96, techData96);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType96, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"CICraft"
			});
			techData100 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Benzene, 10)
				}
			};
			CraftDataHandler.SetTechData(techType100, techData100);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType100, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"CICraft"
			});
			techData104 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.FilteredWater, 10)
				}
			};
			CraftDataHandler.SetTechData(techType104, techData104);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType104, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"PI",
				"FICraft"
			});
			Console.WriteLine("Ingots Loaded");
			Console.WriteLine("Stacked Loading");
			techData21 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType, 10)
				}
			};
			CraftDataHandler.SetTechData(techType21, techData21);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType21, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"EIStacked"
			});
			techData22 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType2, 10)
				}
			};
			CraftDataHandler.SetTechData(techType22, techData22);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType22, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData110 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType108, 10)
				}
			};
			CraftDataHandler.SetTechData(techType110, techData110);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType110, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"SIStacked"
			});
			techData126 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType124, 10)
				}
			};
			CraftDataHandler.SetTechData(techType126, techData126);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType126, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData165 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.PlasteelIngot, 10)
				}
			};
			CraftDataHandler.SetTechData(techType165, techData165);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType165, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"MIStacked"
			});
			techData130 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType128, 10)
				}
			};
			CraftDataHandler.SetTechData(techType130, techData130);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType130, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData134 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType132, 10)
				}
			};
			CraftDataHandler.SetTechData(techType134, techData134);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType134, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData138 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType136, 10)
				}
			};
			CraftDataHandler.SetTechData(techType138, techData138);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType138, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData142 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType140, 10)
				}
			};
			CraftDataHandler.SetTechData(techType142, techData142);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType142, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData146 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType144, 10)
				}
			};
			CraftDataHandler.SetTechData(techType146, techData146);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType146, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData150 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType148, 10)
				}
			};
			CraftDataHandler.SetTechData(techType150, techData150);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType150, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData154 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType152, 10)
				}
			};
			CraftDataHandler.SetTechData(techType154, techData154);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType154, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData158 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType156, 10)
				}
			};
			CraftDataHandler.SetTechData(techType158, techData158);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType158, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData162 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType160, 10)
				}
			};
			CraftDataHandler.SetTechData(techType162, techData162);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType162, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData114 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType112, 10)
				}
			};
			CraftDataHandler.SetTechData(techType114, techData114);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType114, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"SIStacked"
			});
			techData26 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType116, 10)
				}
			};
			CraftDataHandler.SetTechData(techType118, techData26);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType118, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"SIStacked"
			});
			techData122 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType120, 10)
				}
			};
			CraftDataHandler.SetTechData(techType122, techData122);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType122, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"SIStacked"
			});
			techData23 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType3, 10)
				}
			};
			CraftDataHandler.SetTechData(techType23, techData23);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType23, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"MIStacked"
			});
			techData24 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType4, 10)
				}
			};
			CraftDataHandler.SetTechData(techType24, techData24);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType24, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"EIStacked"
			});
			techData25 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType5, 10)
				}
			};
			CraftDataHandler.SetTechData(techType25, techData25);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType25, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"MIStacked"
			});
			techData26 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType6, 10)
				}
			};
			CraftDataHandler.SetTechData(techType26, techData26);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType26, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"EIStacked"
			});
			techData27 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType7, 10)
				}
			};
			CraftDataHandler.SetTechData(techType27, techData27);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType27, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"EIStacked"
			});
			techData28 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType8, 10)
				}
			};
			CraftDataHandler.SetTechData(techType28, techData28);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType28, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"MIStacked"
			});
			techData106 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType104, 10)
				}
			};
			CraftDataHandler.SetTechData(techType106, techData106);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType106, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"FIStacked"
			});
			techData29 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType9, 10)
				}
			};
			CraftDataHandler.SetTechData(techType29, techData29);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType29, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData30 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType10, 10)
				}
			};
			CraftDataHandler.SetTechData(techType30, techData30);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType30, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData31 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType11, 10)
				}
			};
			CraftDataHandler.SetTechData(techType31, techData31);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType31, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"EIStacked"
			});
			techData33 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType13, 10)
				}
			};
			CraftDataHandler.SetTechData(techType33, techData33);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType33, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData34 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType14, 10)
				}
			};
			CraftDataHandler.SetTechData(techType34, techData34);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType34, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData35 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType15, 10)
				}
			};
			CraftDataHandler.SetTechData(techType35, techData35);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType35, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData36 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType16, 10)
				}
			};
			CraftDataHandler.SetTechData(techType36, techData36);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType36, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"NIStacked"
			});
			techData32 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType12, 10)
				}
			};
			CraftDataHandler.SetTechData(techType32, techData32);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType32, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"EIStacked"
			});
			techData37 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.TitaniumIngot, 10)
				}
			};
			CraftDataHandler.SetTechData(techType37, techData37);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType37, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"MIStacked"
			});
			techData38 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType17, 10)
				}
			};
			CraftDataHandler.SetTechData(techType38, techData38);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType38, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"EIStacked"
			});
			TechData techData167 = new TechData();
			techData167.craftAmount = 1;
			techData167.Ingredients = new List<Ingredient>
			{
				new Ingredient(techType18, 10)
			};
			CraftDataHandler.SetTechData(techType39, techData38);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType39, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"EIStacked"
			});
			techData40 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType19, 10)
				}
			};
			CraftDataHandler.SetTechData(techType40, techData40);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType40, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"EIStacked"
			});
			techData41 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType20, 10)
				}
			};
			CraftDataHandler.SetTechData(techType41, techData41);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType41, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"EIStacked"
			});
			techData86 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType84, 10)
				}
			};
			CraftDataHandler.SetTechData(techType86, techData86);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType86, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"CIStacked"
			});
			techData94 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType92, 10)
				}
			};
			CraftDataHandler.SetTechData(techType94, techData94);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType94, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"CIStacked"
			});
			techData98 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType96, 10)
				}
			};
			CraftDataHandler.SetTechData(techType98, techData98);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType98, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"CIStacked"
			});
			techData102 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType100, 10)
				}
			};
			CraftDataHandler.SetTechData(techType102, techData102);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType102, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"CIStacked"
			});
			techData102 = new TechData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType88, 10)
				}
			};
			CraftDataHandler.SetTechData(techType90, techData102);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType90, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"SI",
				"CIStacked"
			});
			Console.WriteLine("Stacked Loaded");
			Console.WriteLine("Unpacked Loading");
			techData42 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType42, techData42);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType42, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"EIUnpack"
			});
			techData43 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType2, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType43, techData43);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType43, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData164 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.PlasteelIngot, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType164, techData164);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType164, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"MIUnpack"
			});
			techData105 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType104, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType105, techData105);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType105, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"FIUnpack"
			});
			techData125 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType124, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType125, techData125);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType125, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData129 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType128, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType129, techData129);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType129, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData133 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType132, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType133, techData133);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType133, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData137 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType136, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType137, techData137);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType137, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData141 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType140, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType141, techData141);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType141, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData145 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType144, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType145, techData145);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType145, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData149 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType148, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType149, techData149);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType149, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData153 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType152, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType153, techData153);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType153, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData157 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType156, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType157, techData157);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType157, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData161 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType160, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType161, techData161);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType161, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData44 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType3, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType44, techData44);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType44, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"MIUnpack"
			});
			techData109 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType108, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType109, techData109);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType109, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"SIUnpack"
			});
			techData113 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType112, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType113, techData113);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType113, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"SIUnpack"
			});
			techData117 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType116, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType117, techData117);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType117, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"SIUnpack"
			});
			techData121 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType120, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType121, techData121);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType121, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"SIUnpack"
			});
			techData45 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType4, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType45, techData45);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType45, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"EIUnpack"
			});
			techData46 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType5, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType46, techData46);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType46, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"MIUnpack"
			});
			techData47 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType6, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType47, techData47);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType47, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"EIUnpack"
			});
			techData48 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType7, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.Magnetite,
					TechType.Magnetite,
					TechType.Magnetite,
					TechType.Magnetite,
					TechType.Magnetite,
					TechType.Magnetite,
					TechType.Magnetite,
					TechType.Magnetite,
					TechType.Magnetite,
					TechType.Magnetite
				}
			};
			CraftDataHandler.SetTechData(techType48, techData48);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType48, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"EIUnpack"
			});
			techData49 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType8, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.Nickel,
					TechType.Nickel,
					TechType.Nickel,
					TechType.Nickel,
					TechType.Nickel,
					TechType.Nickel,
					TechType.Nickel,
					TechType.Nickel,
					TechType.Nickel,
					TechType.Nickel
				}
			};
			CraftDataHandler.SetTechData(techType49, techData49);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType49, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"MIUnpack"
			});
			techData50 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType9, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.Kyanite,
					TechType.Kyanite,
					TechType.Kyanite,
					TechType.Kyanite,
					TechType.Kyanite,
					TechType.Kyanite,
					TechType.Kyanite,
					TechType.Kyanite,
					TechType.Kyanite,
					TechType.Kyanite
				}
			};
			CraftDataHandler.SetTechData(techType50, techData50);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType50, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData50 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType10, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.AluminumOxide,
					TechType.AluminumOxide,
					TechType.AluminumOxide,
					TechType.AluminumOxide,
					TechType.AluminumOxide,
					TechType.AluminumOxide,
					TechType.AluminumOxide,
					TechType.AluminumOxide,
					TechType.AluminumOxide,
					TechType.AluminumOxide
				}
			};
			CraftDataHandler.SetTechData(techType51, techData50);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType51, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData52 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType11, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.UraniniteCrystal,
					TechType.UraniniteCrystal,
					TechType.UraniniteCrystal,
					TechType.UraniniteCrystal,
					TechType.UraniniteCrystal,
					TechType.UraniniteCrystal,
					TechType.UraniniteCrystal,
					TechType.UraniniteCrystal,
					TechType.UraniniteCrystal,
					TechType.UraniniteCrystal
				}
			};
			CraftDataHandler.SetTechData(techType52, techData52);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType52, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"EIUnpack"
			});
			techData53 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType12, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.PrecursorIonCrystal,
					TechType.PrecursorIonCrystal,
					TechType.PrecursorIonCrystal,
					TechType.PrecursorIonCrystal,
					TechType.PrecursorIonCrystal,
					TechType.PrecursorIonCrystal,
					TechType.PrecursorIonCrystal,
					TechType.PrecursorIonCrystal,
					TechType.PrecursorIonCrystal,
					TechType.PrecursorIonCrystal
				}
			};
			CraftDataHandler.SetTechData(techType53, techData53);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType53, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"EIUnpack"
			});
			techData54 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType13, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.Quartz,
					TechType.Quartz,
					TechType.Quartz,
					TechType.Quartz,
					TechType.Quartz,
					TechType.Quartz,
					TechType.Quartz,
					TechType.Quartz,
					TechType.Quartz,
					TechType.Quartz
				}
			};
			CraftDataHandler.SetTechData(techType54, techData54);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType54, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData55 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType14, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.Salt,
					TechType.Salt,
					TechType.Salt,
					TechType.Salt,
					TechType.Salt,
					TechType.Salt,
					TechType.Salt,
					TechType.Salt,
					TechType.Salt,
					TechType.Salt
				}
			};
			CraftDataHandler.SetTechData(techType55, techData55);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType55, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData56 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType15, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.Sulphur,
					TechType.Sulphur,
					TechType.Sulphur,
					TechType.Sulphur,
					TechType.Sulphur,
					TechType.Sulphur,
					TechType.Sulphur,
					TechType.Sulphur,
					TechType.Sulphur,
					TechType.Sulphur
				}
			};
			CraftDataHandler.SetTechData(techType56, techData56);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType56, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData57 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType16, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.CrashPowder,
					TechType.CrashPowder,
					TechType.CrashPowder,
					TechType.CrashPowder,
					TechType.CrashPowder,
					TechType.CrashPowder,
					TechType.CrashPowder,
					TechType.CrashPowder,
					TechType.CrashPowder,
					TechType.CrashPowder
				}
			};
			CraftDataHandler.SetTechData(techType57, techData57);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType57, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"NIUnpack"
			});
			techData58 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.TitaniumIngot, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType58, techData58);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType58, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"MIUnpack"
			});
			techData85 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType84, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType85, techData85);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType85, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"CIUnpack"
			});
			techData97 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType96, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType97, techData97);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType97, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"CIUnpack"
			});
			techData101 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType100, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType101, techData101);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType101, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"CIUnpack"
			});
			techData93 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType92, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType93, techData93);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType93, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"CIUnpack"
			});
			techData89 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType88, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType89, techData89);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType89, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"CIUnpack"
			});
			techData59 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType17, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType59, techData59);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType59, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"EIUnpack"
			});
			techData60 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType18, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType60, techData60);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType60, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"EIUnpack"
			});
			techData61 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType19, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType61, techData61);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType61, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"EIUnpack"
			});
			techData62 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType20, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType62, techData62);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType62, new string[]
			{
				"Resources",
				"BasicMaterials",
				"MI",
				"UI",
				"EIUnpack"
			});
			Console.WriteLine("Unpacked Loaded");
			Console.WriteLine("Unstacked Loading");
			techData63 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType21, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType,
					techType,
					techType,
					techType,
					techType,
					techType,
					techType,
					techType,
					techType,
					techType
				}
			};
			CraftDataHandler.SetTechData(techType63, techData63);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType63, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"EIUnstacked"
			});
			techData64 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType22, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType2,
					techType2,
					techType2,
					techType2,
					techType2,
					techType2,
					techType2,
					techType2,
					techType2,
					techType2
				}
			};
			CraftDataHandler.SetTechData(techType64, techData64);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType64, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData107 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType106, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType104,
					techType104,
					techType104,
					techType104,
					techType104,
					techType104,
					techType104,
					techType104,
					techType104,
					techType104
				}
			};
			CraftDataHandler.SetTechData(techType107, techData107);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType107, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"FIUnstacked"
			});
			techData166 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType165, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.PlasteelIngot,
					TechType.PlasteelIngot,
					TechType.PlasteelIngot,
					TechType.PlasteelIngot,
					TechType.PlasteelIngot,
					TechType.PlasteelIngot,
					TechType.PlasteelIngot,
					TechType.PlasteelIngot,
					TechType.PlasteelIngot,
					TechType.PlasteelIngot
				}
			};
			CraftDataHandler.SetTechData(techType166, techData166);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType166, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"MIUnstacked"
			});
			techData127 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType126, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType124,
					techType124,
					techType124,
					techType124,
					techType124,
					techType124,
					techType124,
					techType124,
					techType124,
					techType124
				}
			};
			CraftDataHandler.SetTechData(techType127, techData127);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType127, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData131 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType130, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType128,
					techType128,
					techType128,
					techType128,
					techType128,
					techType128,
					techType128,
					techType128,
					techType128,
					techType128
				}
			};
			CraftDataHandler.SetTechData(techType131, techData131);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType131, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData135 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType134, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType132,
					techType132,
					techType132,
					techType132,
					techType132,
					techType132,
					techType132,
					techType132,
					techType132,
					techType132
				}
			};
			CraftDataHandler.SetTechData(techType135, techData135);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType135, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData139 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType138, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType136,
					techType136,
					techType136,
					techType136,
					techType136,
					techType136,
					techType136,
					techType136,
					techType136,
					techType136
				}
			};
			CraftDataHandler.SetTechData(techType139, techData139);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType139, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData143 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType142, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType140,
					techType140,
					techType140,
					techType140,
					techType140,
					techType140,
					techType140,
					techType140,
					techType140,
					techType140
				}
			};
			CraftDataHandler.SetTechData(techType143, techData143);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType143, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData147 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType146, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType144,
					techType144,
					techType144,
					techType144,
					techType144,
					techType144,
					techType144,
					techType144,
					techType144,
					techType144
				}
			};
			CraftDataHandler.SetTechData(techType147, techData147);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType147, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData151 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType150, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType148,
					techType148,
					techType148,
					techType148,
					techType148,
					techType148,
					techType148,
					techType148,
					techType148,
					techType148
				}
			};
			CraftDataHandler.SetTechData(techType151, techData151);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType151, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData155 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType154, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType152,
					techType152,
					techType152,
					techType152,
					techType152,
					techType152,
					techType152,
					techType152,
					techType152,
					techType152
				}
			};
			CraftDataHandler.SetTechData(techType155, techData155);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType155, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData159 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType158, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType156,
					techType156,
					techType156,
					techType156,
					techType156,
					techType156,
					techType156,
					techType156,
					techType156,
					techType156
				}
			};
			CraftDataHandler.SetTechData(techType159, techData159);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType159, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData163 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType162, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType160,
					techType160,
					techType160,
					techType160,
					techType160,
					techType160,
					techType160,
					techType160,
					techType160,
					techType160
				}
			};
			CraftDataHandler.SetTechData(techType163, techData163);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType163, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData65 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType23, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType3,
					techType3,
					techType3,
					techType3,
					techType3,
					techType3,
					techType3,
					techType3,
					techType3,
					techType3
				}
			};
			CraftDataHandler.SetTechData(techType65, techData65);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType65, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"MIUnstacked"
			});
			techData66 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType24, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType4,
					techType4,
					techType4,
					techType4,
					techType4,
					techType4,
					techType4,
					techType4,
					techType4,
					techType4
				}
			};
			CraftDataHandler.SetTechData(techType66, techData66);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType66, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"EIUnstacked"
			});
			techData67 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType25, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType5,
					techType5,
					techType5,
					techType5,
					techType5,
					techType5,
					techType5,
					techType5,
					techType5,
					techType5
				}
			};
			CraftDataHandler.SetTechData(techType67, techData67);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType67, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"MIUnstacked"
			});
			techData68 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType26, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType6,
					techType6,
					techType6,
					techType6,
					techType6,
					techType6,
					techType6,
					techType6,
					techType6,
					techType6
				}
			};
			CraftDataHandler.SetTechData(techType68, techData68);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType68, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"EIUnstacked"
			});
			techData69 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType27, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType7,
					techType7,
					techType7,
					techType7,
					techType7,
					techType7,
					techType7,
					techType7,
					techType7,
					techType7
				}
			};
			CraftDataHandler.SetTechData(techType69, techData69);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType69, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"EIUnstacked"
			});
			techData70 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType28, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType8,
					techType8,
					techType8,
					techType8,
					techType8,
					techType8,
					techType8,
					techType8,
					techType8,
					techType8
				}
			};
			CraftDataHandler.SetTechData(techType70, techData70);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType70, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"MIUnstacked"
			});
			techData71 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType29, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType9,
					techType9,
					techType9,
					techType9,
					techType9,
					techType9,
					techType9,
					techType9,
					techType9,
					techType9
				}
			};
			CraftDataHandler.SetTechData(techType71, techData71);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType71, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData72 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType30, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType10,
					techType10,
					techType10,
					techType10,
					techType10,
					techType10,
					techType10,
					techType10,
					techType10,
					techType10
				}
			};
			CraftDataHandler.SetTechData(techType72, techData72);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType72, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData111 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType110, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType108,
					techType108,
					techType108,
					techType108,
					techType108,
					techType108,
					techType108,
					techType108,
					techType108,
					techType108
				}
			};
			CraftDataHandler.SetTechData(techType111, techData111);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType111, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"SIUnstacked"
			});
			techData115 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType114, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType112,
					techType112,
					techType112,
					techType112,
					techType112,
					techType112,
					techType112,
					techType112,
					techType112,
					techType112
				}
			};
			CraftDataHandler.SetTechData(techType115, techData115);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType115, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"SIUnstacked"
			});
			techData119 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType118, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType116,
					techType116,
					techType116,
					techType116,
					techType116,
					techType116,
					techType116,
					techType116,
					techType116,
					techType116
				}
			};
			CraftDataHandler.SetTechData(techType119, techData119);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType119, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"SIUnstacked"
			});
			techData123 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType122, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType120,
					techType120,
					techType120,
					techType120,
					techType120,
					techType120,
					techType120,
					techType120,
					techType120,
					techType120
				}
			};
			CraftDataHandler.SetTechData(techType123, techData123);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType123, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"SIUnstacked"
			});
			techData73 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType31, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType11,
					techType11,
					techType11,
					techType11,
					techType11,
					techType11,
					techType11,
					techType11,
					techType11,
					techType11
				}
			};
			CraftDataHandler.SetTechData(techType73, techData73);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType73, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"EIUnstacked"
			});
			techData74 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType32, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType12,
					techType12,
					techType12,
					techType12,
					techType12,
					techType12,
					techType12,
					techType12,
					techType12,
					techType12
				}
			};
			CraftDataHandler.SetTechData(techType74, techData74);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType74, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"EIUnstacked"
			});
			techData75 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType33, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType13,
					techType13,
					techType13,
					techType13,
					techType13,
					techType13,
					techType13,
					techType13,
					techType13,
					techType13
				}
			};
			CraftDataHandler.SetTechData(techType75, techData75);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType75, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData76 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType34, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType14,
					techType14,
					techType14,
					techType14,
					techType14,
					techType14,
					techType14,
					techType14,
					techType14,
					techType14
				}
			};
			CraftDataHandler.SetTechData(techType76, techData76);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType76, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData77 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType35, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType15,
					techType15,
					techType15,
					techType15,
					techType15,
					techType15,
					techType15,
					techType15,
					techType15,
					techType15
				}
			};
			CraftDataHandler.SetTechData(techType77, techData77);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType77, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData78 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType36, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType16,
					techType16,
					techType16,
					techType16,
					techType16,
					techType16,
					techType16,
					techType16,
					techType16,
					techType16
				}
			};
			CraftDataHandler.SetTechData(techType78, techData78);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType78, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"NIUnstacked"
			});
			techData79 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType37, 1)
				},
				LinkedItems = new List<TechType>
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
			CraftDataHandler.SetTechData(techType79, techData79);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType79, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"MIUnstacked"
			});
			techData80 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType38, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType17,
					techType17,
					techType17,
					techType17,
					techType17,
					techType17,
					techType17,
					techType17,
					techType17,
					techType17
				}
			};
			CraftDataHandler.SetTechData(techType80, techData80);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType80, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"EIUnstacked"
			});
			techData81 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType39, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType18,
					techType18,
					techType18,
					techType18,
					techType18,
					techType18,
					techType18,
					techType18,
					techType18,
					techType18
				}
			};
			CraftDataHandler.SetTechData(techType81, techData81);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType81, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"EIUnstacked"
			});
			techData82 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType40, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType19,
					techType19,
					techType19,
					techType19,
					techType19,
					techType19,
					techType19,
					techType19,
					techType19,
					techType19
				}
			};
			CraftDataHandler.SetTechData(techType82, techData82);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType82, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"EIUnstacked"
			});
			techData83 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType41, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType20,
					techType20,
					techType20,
					techType20,
					techType20,
					techType20,
					techType20,
					techType20,
					techType20,
					techType20
				}
			};
			CraftDataHandler.SetTechData(techType83, techData83);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType83, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"EIUnstacked"
			});
			techData99 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType98, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType96,
					techType96,
					techType96,
					techType96,
					techType96,
					techType96,
					techType96,
					techType96,
					techType96,
					techType96
				}
			};
			CraftDataHandler.SetTechData(techType99, techData99);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType99, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"CIUnstacked"
			});
			techData87 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType86, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType84,
					techType84,
					techType84,
					techType84,
					techType84,
					techType84,
					techType84,
					techType84,
					techType84,
					techType84
				}
			};
			CraftDataHandler.SetTechData(techType87, techData87);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType87, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"CIUnstacked"
			});
			techData103 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType102, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType100,
					techType100,
					techType100,
					techType100,
					techType100,
					techType100,
					techType100,
					techType100,
					techType100,
					techType100
				}
			};
			CraftDataHandler.SetTechData(techType103, techData103);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType103, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"CIUnstacked"
			});
			techData95 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType94, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType92,
					techType92,
					techType92,
					techType92,
					techType92,
					techType92,
					techType92,
					techType92,
					techType92,
					techType92
				}
			};
			CraftDataHandler.SetTechData(techType95, techData95);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType95, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"CIUnstacked"
			});
			techData91 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType90, 1)
				},
				LinkedItems = new List<TechType>
				{
					techType88,
					techType88,
					techType88,
					techType88,
					techType88,
					techType88,
					techType88,
					techType88,
					techType88,
					techType88
				}
			};
			CraftDataHandler.SetTechData(techType91, techData91);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType91, new string[]
			{
				"Resources",
				"BasicMaterials",
				"BI",
				"USI",
				"CIUnstacked"
			});
			Console.WriteLine("Unstacked Loaded");
			Console.WriteLine("MoreIngots Loaded");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		public static Atlas.Sprite GetSprite(string name)
		{
			return ImageUtils.LoadSpriteFromFile("./QMods/MoreIngots/Assets/" + name + ".png", TextureFormat.BC7);
		}
	}
}
