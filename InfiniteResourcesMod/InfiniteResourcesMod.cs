using System.Collections.Generic;
using VoxelTycoon;
using VoxelTycoon.Deposits;
using VoxelTycoon.Modding;
using VoxelTycoon.UI;

namespace InfiniteResourcesMod
{
    public class InfiniteResourcesMod : Mod
    {
        private HashSet<Indicator> _processedIndicators = new HashSet<Indicator>();

        protected override void OnUpdate()
        {
            var deposits = DepositManager.Current.GetAll();
            for (var i = 0; i < deposits.Count; i++)
            {
                var deposit = deposits[i];
                deposit.Count = deposit.Capacity;
                TryHideCountFromIndicator(deposit);
            }
        }

        private void TryHideCountFromIndicator(Deposit deposit)
        {
            var indicator = deposit.Indicator;
            if (indicator != null && _processedIndicators.Add(indicator))
            {
                indicator.transform.GetChild(2).SetActive(false);
                indicator.transform.GetChild(3).SetActive(false);
            }
        }
    }
}
