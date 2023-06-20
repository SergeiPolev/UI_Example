//using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WaterBarUIScreen : UIScreen
{
    
    [SerializeField] private Slider _fuelBar;
    [SerializeField] private TextMeshProUGUI _fuelText;
    
    [Header("Tween Settings")]
    [SerializeField] private Image _fillImage;
    [SerializeField] private Color _completeColor;
    [SerializeField] private float _punchPower = .3f;
    [SerializeField] private float _punchDuration = .1f;
    [SerializeField] private float _colorDuration = 1f;

    //private WaterTank _tank;

    //private Tween _punchTween;
    //private Tween _colorTween;

    private Color _originalColor;
    
    public override void Init(IGameDataContainer gameDataContainer, GameCanvas gameCanvas)
    {
        base.Init(gameDataContainer, gameCanvas);

        //_tank = _gameDataContainer.GetGameData().Player.GetTank;
        //_tank.OnFuelChange += UpdateUI;

        _originalColor = _fillImage.color;
        
        UpdateUI();
    }

    private void UpdateUI()
    {
        /*float fillProgress = _tank.GetCurrentFuel / _tank.GetCurrentCapacity;
        
        _fuelBar.value = fillProgress;
        _fuelText.text = $"{_tank.GetCurrentFuel :F1} / {_tank.GetCurrentCapacity :F1}";

        if (_tank.IsFull)
        {
            _punchTween.KillTo0();
            _colorTween.KillTo0();
            
            _punchTween = _fuelBar.transform.DOPunchScale(Vector3.one * _punchPower, _punchDuration).SetRelative();

            _fillImage.color = _completeColor;
            _colorTween = _fillImage.DOColor(_originalColor, _colorDuration);
        }*/
    }

    public override UIScreenType GetUIType()
    {
        return UIScreenType.WATER_BAR;
    }
}