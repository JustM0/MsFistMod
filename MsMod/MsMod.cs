using MelonLoader;
using BTD_Mod_Helper;
using MsMod;

[assembly: MelonInfo(typeof(MsMod.MsMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace MsMod;

public class MsMod : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<MsMod>("MsMod loaded!");
    }
}