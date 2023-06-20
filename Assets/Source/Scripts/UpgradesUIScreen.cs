using System.Collections.Generic;
using UnityEngine;

public class UpgradesUIScreen : UIScreen
{
	[SerializeField] private Transform upgradesRoot;
	[SerializeField] private UpgradeUILine upgradeUILine;

	//public Dictionary<UpgradesType, UpgradeUILine> upgradesByType = new();
	public override UIScreenType GetUIType()
	{
		return UIScreenType.UPGRADE_STATS;
	}

	public override void Init(IGameDataContainer loader, GameCanvas gameCanvas)
	{
		base.Init(loader, gameCanvas);

		/*foreach (var item in loader.GetGameConfig().Upgrades)
		{
			CreateUpgradeLine(item);
		}*/
	}

	public override void Open()
	{
		base.Open();

		/*foreach (var item in upgradesByType)
		{
			item.Value.UpdateInfo();
		}*/
	}

	/*public void CreateUpgradeLine(UpgradeProgression upgradeProgression)
	{
		var uiLine = Instantiate(upgradeUILine, upgradesRoot);

		uiLine.Init(_gameDataContainer, upgradeProgression, gameCanvas);

		upgradesByType.Add(upgradeProgression.Type, uiLine);
	}*/
}