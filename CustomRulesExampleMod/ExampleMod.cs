using VoxelTycoon;
using VoxelTycoon.Game.UI.ModernUI;
using VoxelTycoon.Modding;

namespace CustomRulesExampleMod;

public class ExampleMod : Mod
{
    private bool _fixedGameSpeed;

    protected override void OnGameStarted()
    {
        _fixedGameSpeed = WorldSettings.Current.CustomRules.Get(ExampleCustomRulesMod.FixedGameSpeedCustomRuleKey);
    }

    protected override void OnLateUpdate()
    {
        if (_fixedGameSpeed)
        {
            TimeManager.Current.ForcedPause = false;
            TimeControls.Current.SetTimeScale(TimeControls.TimeScale.Turtle);
        }
    }
}