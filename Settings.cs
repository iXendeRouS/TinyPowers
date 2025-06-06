using BTD_Mod_Helper.Api.Data;
using BTD_Mod_Helper.Api.ModOptions;

namespace TinyPowers
{
    public class Settings : ModSettings
    {
        public static readonly ModSettingBool ModEnabled = new(true)
        {
            description = "When enabled when entering a game, banana farmers and techbots can be placed almost everywhere and not block placement."
        };
    }
}
