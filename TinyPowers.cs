using MelonLoader;
using BTD_Mod_Helper;
using TinyPowers;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;

[assembly: MelonInfo(typeof(TinyPowers.TinyPowers), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace TinyPowers;

public class TinyPowers : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<TinyPowers>("TinyPowers loaded!");
    }

    public override void OnNewGameModel(GameModel result)
    {
        if (!Settings.ModEnabled) return;

        base.OnNewGameModel(result);

        PatchFootprint(result.GetTower("BananaFarmer").footprint);
        PatchFootprint(result.GetTower("TechBot").footprint);
    }

    private static void PatchFootprint(FootprintModel footprint)
    {
        if (footprint == null) return;

        footprint.doesntBlockTowerPlacement = true;
        footprint.ignoresPlacementCheck = true;
        footprint.ignoresTowerOverlap = true;
    }
}