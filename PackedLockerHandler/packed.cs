using System.Collections.Generic;
using MoreIngots.Packed;
using UWE;

public class PackedLocker : ItemConverterLocker
{
    public override Dictionary<TechType, TechType> ConversionTable => new Dictionary<TechType, TechType>
    {
	    { TechType.Gold, PMIGold.techType },
        { TechType.Titanium, TechType.TitaniumIngot},
		{ TechType.Silver , PMISilver.techType },
		{ TechType.Lead , PMILead.techType },
		{ TechType.Lithium , PMILithium.techType },
		{ TechType.Copper , PMICopper.techType },
		{ TechType.Diamond , PMIDiamond.techType },
		{ TechType.AluminumOxide , PMIRuby.techType },
		{ TechType.Nickel , PMINickel.techType },
		{ TechType.PlasteelIngot , PMIPlasteel.techType },
		{ TechType.Salt , PMISalt.techType },
		{ TechType.Magnetite , PMIMagnetite.techType },
		{ TechType.Silicone , PMISilicone.techType },
		{ TechType.Quartz , PMIQuartz.techType },
		{ TechType.UraniniteCrystal , PMIUraninite.techType },
		{ TechType.WiringKit , PMIWirekit.techType },
		{ TechType.JeweledDiskPiece , PMITable.techType },
		{ TechType.Sulphur , PMISulphur.techType },
		{ TechType.StalkerTooth , PMIStalker.techType },
		{ TechType.Polyaniline , PMIPjug.techType },
		{ TechType.Lubricant , PMILubricantjug.techType },
		{ TechType.Kyanite , PMIKyanite.techType },
		{ TechType.PrecursorIonCrystal , PMIIon.techType },
		{ TechType.Glass , PMIGlass.techType },
		{ TechType.JellyPlant , PMIJelly.techType },
		{ TechType.GasPod , PMIPod.techType },
		{ TechType.FilteredWater , PMIGallonWater.techType },
		{ TechType.FiberMesh , PMIFibermesh.techType },
		{ TechType.EnameledGlass , PMIEnameled.techType },
		{ TechType.DisinfectedWater , PMIGallonDisWater.techType },
		{ TechType.WhiteMushroom , PMIWhite.techType },
		{ TechType.CreepvineSeedCluster , PMISeed.techType },
		{ TechType.CreepvinePiece , PMICreepp.techType },
		{ TechType.CrashPowder , PMICrash.techType },
		{ TechType.CoralChunk , PMICoral.techType },
		{ TechType.CopperWire , PMICopperwire.techType },
		{ TechType.ComputerChip , PMIComputerchip.techType },
		{ TechType.BloodOil , PMIBlood.techType },
		{ TechType.Bleach , PMIBleachjug.techType },
		{ TechType.BigFilteredWater , PMIbigfilteredwater.techType },
		{ TechType.Benzene , PMIBenzenejug.techType },
		{ TechType.AramidFibers , PMIArmidfiber.techType },
		{ TechType.AdvancedWiringKit , PMIAdvwirekit.techType },
		{ TechType.Aerogel , PMIAerosheet.techType },
		{ TechType.AcidMushroom , PMIAmush.techType },
		{ TechType.HydrochloricAcid , PMIAcidjug.techType }
    };

    public override int InputMultiplier => 10;
    public override int OutputMultiplier => 1;
}