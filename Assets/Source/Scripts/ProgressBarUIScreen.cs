using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarUIScreen : UIScreen
{
    [SerializeField] private Slider _progressBar;
    [SerializeField] private TextMeshProUGUI _progressText;

    public override void Init(IGameDataContainer gameDataContainer, GameCanvas gameCanvas)
    {
        base.Init(gameDataContainer, gameCanvas);
        
        //_gameDataContainer.GetGameData().ProgressHandler.OnProgressRecalculate += UpdateProgress;
    }

    private void UpdateProgress(float progress)
    {
        _progressBar.value = progress;
        _progressText.text = $"{progress * 100:F1}%";
    }

    public override UIScreenType GetUIType()
    {
        return UIScreenType.PROGRESS_BAR;
    }
}