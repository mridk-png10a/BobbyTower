global using BTD_Mod_Helper.Extensions;
using MelonLoader;
using BTD_Mod_Helper;
using BobbyTower;

[assembly: MelonInfo(typeof(BobbyTower.BobbyTower), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BobbyTower;

public class BobbyTower : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<BobbyTower>("BobbyTower loaded!");
    }
}