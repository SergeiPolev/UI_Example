using TMPro;
using UnityEngine;

public class CharacterUICanvas : MonoBehaviour
{
    [SerializeField] private ProgressBar healthBar;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private RectTransform rectTransform;

    public RectTransform RectTransform => rectTransform;
    
    public void InitCanvas(bool isPlayer)
    {
        levelText.gameObject.SetActive(!isPlayer);
        healthBar.Init(isPlayer);
    }
    
    public void UpdateHealthBar(float current, float max)
    {
        var rounded = Mathf.Ceil(current);
        healthBar.UpdateBar(rounded / max);
        healthText.text = $"{rounded}";
    }
    public void UpdateLevelText(int value)
    {
        levelText.text = $"{value}";
    }
}