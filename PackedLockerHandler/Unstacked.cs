using System.Collections.Generic;
using MoreIngots.Packed;
using UWE;

public class UnstackedLocker : ItemConverterLocker
{
    public override Dictionary<TechType, TechType> ConversionTable => new Dictionary<TechType, TechType>
    {
        { PMISGold.techType, PMIGold.techType },
{ PMISSilver.techType, PMISilver.techType },
{ PMISLead.techType, PMILead.techType },
{ PMISLithium.techType, PMILithium.techType },
{ PMISCopper.techType, PMICopper.techType },
{ PMISDiamond.techType, PMIDiamond.techType },
{ PMISRuby.techType, PMIRuby.techType },
{ PMISNickel.techType, PMINickel.techType },
{ PMISPlasteel.techType, PMIPlasteel.techType },
{ PMISSalt.techType, PMISalt.techType },
{ PMISMagnetite.techType, PMIMagnetite.techType },
{ PMISSilicone.techType, PMISilicone.techType },
{ PMISQuartz.techType, PMIQuartz.techType },
{ PMISUraninite.techType, PMIUraninite.techType },
{ PMISWirekit.techType, PMIWirekit.techType },
{ PMISTable.techType, PMITable.techType },
{ PMISSulphur.techType, PMISulphur.techType },
{ PMISStalker.techType, PMIStalker.techType },
{ PMISP.techType, PMIPjug.techType },
{ PMISLubricant.techType, PMILubricantjug.techType },
{ PMISKyanite.techType, PMIKyanite.techType },
{ PMISIon.techType, PMIIon.techType },
{ PMISGlass.techType, PMIGlass.techType },
{ PMISJelly.techType, PMIJelly.techType },
{ PMISPod.techType, PMIPod.techType },
{ PMIS5GallonWater.techType, PMIGallonWater.techType },
{ PMISFibermesh.techType, PMIFibermesh.techType },
{ PMISEnameled.techType, PMIEnameled.techType },
{ PMISGallonDisWater.techType, PMIGallonDisWater.techType },
{ PMISWhite.techType, PMIWhite.techType },
{ PMISSeed.techType, PMISeed.techType },
{ PMISCreepp.techType, PMICreepp.techType },
{ PMISCrash.techType, PMICrash.techType },
{ PMISCoral.techType, PMICoral.techType },
{ PMISCopperwire.techType, PMICopperwire.techType },
{ PMISComputerchip.techType, PMIComputerchip.techType },
{ PMISBlood.techType, PMIBlood.techType },
{ PMISBleach.techType, PMIBleachjug.techType },
{ PMISbigfilteredwater.techType, PMIbigfilteredwater.techType },
{ PMISBenzene.techType, PMIBenzenejug.techType },
{ PMISArmidfiber.techType, PMIArmidfiber.techType },
{ PMISAdvwirekit.techType, PMIAdvwirekit.techType },
{ PMISAerosheet.techType, PMIAerosheet.techType },
{ PMISAmush.techType, PMIAmush.techType },
{ PMISAcid.techType, PMIAcidjug.techType },
{PMISTitanium.techType, TechType.TitaniumIngot}

    };

    public override int InputMultiplier => 1;
    public override int OutputMultiplier => 10;
}