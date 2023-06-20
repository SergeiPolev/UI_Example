using UnityEngine;
using UnityEngine.UI;

public class MainUIScreen : UIScreen
{
    [SerializeField] private Button _endLevelBtn;
    [SerializeField] private Button _settingsBtn;

    public override void Init(IGameDataContainer gameDataContainer, GameCanvas gameCanvas)
    {
        base.Init(gameDataContainer, gameCanvas);

        _endLevelBtn.gameObject.SetActive(false);
        _endLevelBtn.onClick.AddListener(OpenWinScreen);
        _settingsBtn.onClick.AddListener(OpenSettingsScreen);
        //_gameDataContainer.GetGameData().ProgressHandler.OnComplete += OnCompleteLevel;
    }

    private void OpenSettingsScreen()
    {
        gameCanvas.Open(UIScreenType.SETTINGS);
    }

    private void OnCompleteLevel()
    {
        _endLevelBtn.gameObject.SetActive(true);
    }

    private void OpenWinScreen()
    {
        gameCanvas.Open(UIScreenType.WIN);
        _endLevelBtn.onClick.RemoveAllListeners();
        Close();
    }

    public override UIScreenType GetUIType()
    {
        return UIScreenType.MAIN;
    }
}