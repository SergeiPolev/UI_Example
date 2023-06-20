using TMPro;
using UnityEngine;

public class MoneyUIScreen : UIScreen
{
    [SerializeField] private TextMeshProUGUI _moneyText;

    public override void Init(IGameDataContainer gameDataContainer, GameCanvas gameCanvas)
    {
        base.Init(gameDataContainer, gameCanvas);

        /*gameDataContainer.GetGameData().CurrencyManager.GetCurrencyConfig(CurrencyType.MONEY).OnChangeValue +=
            UpdateMoneyText;*/
        
        UpdateMoneyText();
    }

    private void UpdateMoneyText()
    {
        //_moneyText.text = $"{_gameDataContainer.GetGameData().CurrencyManager.GetCurrencyTuple(CurrencyType.MONEY).Amount}";
    }

    private void OnDestroy()
    {
        /*_gameDataContainer.GetGameData().CurrencyManager.GetCurrencyConfig(CurrencyType.MONEY).OnChangeValue -=
            UpdateMoneyText;*/
    }

    public override UIScreenType GetUIType()
    {
        return UIScreenType.MONEY;
    }
}