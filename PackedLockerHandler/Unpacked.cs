using System.Collections.Generic;
using MoreIngots.Packed;
using UWE;

public class UnpackedLocker : ItemConverterLocker
{
    public override Dictionary<TechType, TechType> ConversionTable => new Dictionary<TechType, TechType>
    {
        { PMIGold.techType, TechType.Gold },
    { TechType.TitaniumIngot, TechType.Titanium },
    { PMISilver.techType, TechType.Silver },
    { PMILead.techType, TechType.Lead },
    { PMILithium.techType, TechType.Lithium },
    { PMICopper.techType, TechType.Copper },
    { PMIDiamond.techType, TechType.Diamond },
    { PMIRuby.techType, TechType.AluminumOxide },
    { PMINickel.techType, TechType.Nickel },
    { PMIPlasteel.techType, TechType.PlasteelIngot },
    { PMISalt.techType, TechType.Salt },
    { PMIMagnetite.techType, TechType.Magnetite },
    { PMISilicone.techType, TechType.Silicone },
    { PMIQuartz.techType, TechType.Quartz },
    { PMIUraninite.techType, TechType.UraniniteCrystal },
    { PMIWirekit.techType, TechType.WiringKit },
    { PMITable.techType, TechType.JeweledDiskPiece },
    { PMISulphur.techType, TechType.Sulphur },
    { PMIStalker.techType, TechType.StalkerTooth },
    { PMIPjug.techType, TechType.Polyaniline },
    { PMILubricantjug.techType, TechType.Lubricant },
    { PMIKyanite.techType, TechType.Kyanite },
    { PMIIon.techType, TechType.PrecursorIonCrystal },
    { PMIGlass.techType, TechType.Glass },
    { PMIJelly.techType, TechType.JellyPlant },
    { PMIPod.techType, TechType.GasPod },
    { PMIGallonWater.techType, TechType.FilteredWater },
    { PMIFibermesh.techType, TechType.FiberMesh },
    { PMIEnameled.techType, TechType.EnameledGlass },
    { PMIGallonDisWater.techType, TechType.DisinfectedWater },
    { PMIWhite.techType, TechType.WhiteMushroom },
    { PMISeed.techType, TechType.CreepvineSeedCluster },
    { PMICreepp.techType, TechType.CreepvinePiece },
    { PMICrash.techType, TechType.CrashPowder },
    { PMICoral.techType, TechType.CoralChunk },
    { PMICopperwire.techType, TechType.CopperWire },
    { PMIComputerchip.techType, TechType.ComputerChip },
    { PMIBlood.techType, TechType.BloodOil },
    { PMIBleachjug.techType, TechType.Bleach },
    { PMIbigfilteredwater.techType, TechType.BigFilteredWater },
    { PMIBenzenejug.techType, TechType.Benzene },
    { PMIArmidfiber.techType, TechType.AramidFibers },
    { PMIAdvwirekit.techType, TechType.AdvancedWiringKit },
    { PMIAerosheet.techType, TechType.Aerogel },
    { PMIAmush.techType, TechType.AcidMushroom },
    { PMIAcidjug.techType, TechType.HydrochloricAcid }

    };

    public override int InputMultiplier => 1;
    public override int OutputMultiplier => 10;
}