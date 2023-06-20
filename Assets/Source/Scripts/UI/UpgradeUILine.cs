using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUILine : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleName;
    [SerializeField] private TextMeshProUGUI valueText;
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private Image upgradeIcon;
    [SerializeField] private Button[] buyButtons;

    private IGameDataContainer gameDataContainer;/*
    private UpgradesType type;
    private UpgradeProgression progression;

    private GameData _gd => gameDataContainer.GetGameData();
    private GameConfig _config => gameDataContainer.GetGameConfig();*/
    
    public void Init(IGameDataContainer gameDataContainer, UpgradeProgression progression, GameCanvas gameCanvas)
    {
        /*this.gameDataContainer = gameDataContainer;
        this.progression = progression;
        type = progression.Type;
        
        InitInfo();
        foreach (var button in buyButtons)
        {
            button.onClick.AddListener(Upgrade);
            button.onClick.AddListener(gameCanvas.HapticOnClick);
        }

        gameDataContainer.GetGameData().CurrencyManager.GetCurrencyTuple(CurrencyType.MONEY).Currency.OnChangeValue +=
            UpdateInfo;*/
    }

    private void InitInfo()
    {/*
        titleName.text = progression.TitleName;
        upgradeIcon.sprite = progression.Icon;*/

        UpdateInfo();
    }

    private void Upgrade()
    {
        /*var upgradePrice = _gd.PlayerUpgrades.GetUpgradePrice(type);
        if (_gd.CurrencyManager.HaveEnough(CurrencyType.MONEY, upgradePrice))
        {
            _gd.PlayerUpgrades.Upgrade(type);
            _gd.CurrencyManager.RemoveCurrency(CurrencyType.MONEY,upgradePrice);
            
            UpdateInfo();
        }*/
    }

    public void UpdateInfo()
    {
        /*PlayerUpgrades upgradesManager = _gd.PlayerUpgrades;
        bool isMaxLevel = upgradesManager.IsMaxLevel(type);

        var upgradeValue = upgradesManager.GetUpgradeValue(type);
        float baseBValue = 0f;
        switch (type)
        {
            case UpgradesType.TANK_CAPACITY:
                baseBValue = _config.PlayerStats.Capacity;
                break;
            case UpgradesType.WATERING_RADIUS:
                baseBValue = _config.PlayerStats.Radius;
                break;
            case UpgradesType.MOVE_SPEED:
                baseBValue = _config.PlayerStats.Speed;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        var calculatedValue = baseBValue * (1 + upgradeValue / 100);
        //valueText.text = $"{AbbrevationUtility.FormatK(upgradeValue)}";
        valueText.text = isMaxLevel ? $"{calculatedValue :F1}" : $"{calculatedValue :F1} <sprite index=0> {baseBValue * (1 + upgradesManager.GetNextUpgradeValue(type) / 100) :F1}";
        priceText.text = isMaxLevel ? "Max" : $"<sprite index=0> {upgradesManager.GetUpgradePrice(type)}";

        bool haveEnough = _gd.CurrencyManager.HaveEnough(CurrencyType.MONEY, upgradesManager.GetUpgradePrice(type));
        foreach (var button in buyButtons)
        {
            button.interactable = !isMaxLevel && haveEnough;
        }

        if (isMaxLevel)
        {
            foreach (var button in buyButtons)
            {
                button.onClick.RemoveAllListeners();
            }
        }*/
    }
}

public class UpgradeProgression
{
}