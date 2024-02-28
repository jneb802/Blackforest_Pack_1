using BepInEx.Logging;

namespace Blackforest_Pack_1;

public class WarpLogger
{
    public static readonly ManualLogSource Logger = BepInEx.Logging.Logger.CreateLogSource(Blackforest_Pack_1Plugin.ModName);
}