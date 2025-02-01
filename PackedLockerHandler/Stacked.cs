using System.Collections.Generic;
using MoreIngots.Packed;
using MoreIngots.Unpacked;
using UWE;

public class StackedLocker : ItemConverterLocker
{
    public override Dictionary<TechType, TechType> ConversionTable => new Dictionary<TechType, TechType>
    {
       { PMIGold.techType, PMISGold.techType },
{ PMISilver.techType, PMISSilver.techType },
{ PMILead.techType, PMISLead.techType },
{ PMILithium.techType, PMISLithium.techType },
{ PMICopper.techType, PMISCopper.techType },
{ PMIDiamond.techType, PMISDiamond.techType },
{ PMIRuby.techType, PMISRuby.techType },
{ PMINickel.techType, PMISNickel.techType },
{ PMIPlasteel.techType, PMISPlasteel.techType },
{ PMISalt.techType, PMISSalt.techType },
{ PMIMagnetite.techType, PMISMagnetite.techType },
{ PMISilicone.techType, PMISSilicone.techType },
{ PMIQuartz.techType, PMISQuartz.techType },
{ PMIUraninite.techType, PMISUraninite.techType },
{ PMIWirekit.techType, PMISWirekit.techType },
{ PMITable.techType, PMISTable.techType },
{ PMISulphur.techType, PMISSulphur.techType },
{ PMIStalker.techType, PMISStalker.techType },
{ PMIPjug.techType, PMISP.techType },
{ PMILubricantjug.techType, PMISLubricant.techType },
{ PMIKyanite.techType, PMISKyanite.techType },
{ PMIIon.techType, PMISIon.techType },
{ PMIGlass.techType, PMISGlass.techType },
{ PMIJelly.techType, PMISJelly.techType },
{ PMIPod.techType, PMISPod.techType },
{ PMIGallonWater.techType, PMIS5GallonWater.techType },
{ PMIFibermesh.techType, PMISFibermesh.techType },
{ PMIEnameled.techType, PMISEnameled.techType },
{ PMIGallonDisWater.techType, PMISGallonDisWater.techType },
{ PMIWhite.techType, PMISWhite.techType },
{ PMISeed.techType, PMISSeed.techType },
{ PMICreepp.techType, PMISCreepp.techType },
{ PMICrash.techType, PMISCrash.techType },
{ PMICoral.techType, PMISCoral.techType },
{ PMICopperwire.techType, PMISCopperwire.techType },
{ PMIComputerchip.techType, PMISComputerchip.techType },
{ PMIBlood.techType, PMISBlood.techType },
{ PMIBleachjug.techType, PMISBleach.techType },
{ PMIbigfilteredwater.techType, PMISbigfilteredwater.techType },
{ PMIBenzenejug.techType, PMISBenzene.techType },
{ PMIArmidfiber.techType, PMISArmidfiber.techType },
{ PMIAdvwirekit.techType, PMISAdvwirekit.techType },
{ PMIAerosheet.techType, PISAerosheet.techType },
{ PMIAmush.techType, PMISAmush.techType },
{ PMIAcidjug.techType, PMISAcid.techType },
{ TechType.TitaniumIngot, PMISTitanium.techType }

    };

    public override int InputMultiplier => 10;
    public override int OutputMultiplier => 1;
}