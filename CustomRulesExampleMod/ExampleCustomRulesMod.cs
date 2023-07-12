using VoxelTycoon.Modding;

namespace CustomRulesExampleMod;

public class ExampleCustomRulesMod : CustomRulesMod
{
    public const string FixedGameSpeedCustomRuleKey = "voxeltycoon_custom_rules_example/custom_rule_fixed_game_speed";

    protected override IEnumerable<string> GetCustomRuleKeys()
    {
        return new[] { FixedGameSpeedCustomRuleKey };
    }
}