//using DG.Tweening;
using UnityEngine;

public class TankNotifyUIScreen : UIScreen
{
	[SerializeField] private Transform _textRoot;

	/*public override void Init(IGameDataContainer gameDataContainer, GameCanvas gameCanvas)
	{
		base.Init(gameDataContainer, gameCanvas);

		_textRoot.DOScale(1.1f, 1f).SetLoops(-1, LoopType.Yoyo);

		gameDataContainer.GetGameData().Player.GetTank.OnTankEmpty += Open;
	}*/

	public override void Open()
	{
		base.Open();
		//_gameDataContainer.GetGameData().Player.GetTank.OnFuelChange += Close;
	}

	public override void Close()
	{
		base.Close();
		//_gameDataContainer.GetGameData().Player.GetTank.OnFuelChange -= Close;
	}

	public override UIScreenType GetUIType()
	{
		return UIScreenType.TANK_NOTIFY;
	}
}