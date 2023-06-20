using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinUIScreen : UIScreen
{
	[SerializeField] private Button _restartButton;
	[SerializeField] private TextMeshProUGUI _rewardText;

	public override void Init(IGameDataContainer gameDataContainer, GameCanvas gameCanvas)
	{
		base.Init(gameDataContainer, gameCanvas);
		
		_restartButton.onClick.AddListener(Restart);
		//gameDataContainer.GetGameData().GameStateMachine.SubscribeToState(GameState.WIN, UpdateReward);
	}

	public override void Open()
	{
		base.Open();
		//_gameDataContainer.GetGameData().GameStateMachine.SetState(GameState.WIN);
		Time.timeScale = 0;
	}

	private void UpdateReward()
	{
		//float value = _gameDataContainer.GetGameData().RewardSystem.GetCurrentIncrease();
		//_rewardText.text = $"+{value} <sprite index=0>";
	}

	private void Restart()
	{
		Time.timeScale = 1;

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public override UIScreenType GetUIType()
    {
	    return UIScreenType.WIN;
    }
}