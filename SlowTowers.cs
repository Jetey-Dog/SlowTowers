global using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using MelonLoader;
using SlowTowers;

[assembly: MelonInfo(typeof(SlowTowers.SlowTowers), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6-Epic")]

namespace SlowTowers;

public class SlowTowers : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<SlowTowers>("SlowTowers loaded!");
    }
    public override void OnNewGameModel(GameModel result)
    {
        foreach (var weapon in result.GetDescendants<WeaponModel>().ToList())
        {
            weapon.rate = 20;
        }
    }


}