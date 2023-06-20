using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public abstract class UIScreen : MonoBehaviour
{
    [SerializeField] protected float fadeInOutDuration = .4f;
    [SerializeField] protected Button[] closeButtons;
    
    protected CanvasGroup canvasGroup;
    protected GameCanvas gameCanvas;
    //protected IGameDataContainer _gameDataContainer;

    public abstract UIScreenType GetUIType();

    //[Button("Open")]
    public virtual void Open()
    {
        //canvasGroup.DOFade(0, 0).SetUpdate(true);
        canvasGroup.gameObject.SetActive(true);
        //canvasGroup.DOFade(1, fadeInOutDuration).SetUpdate(true);
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }
    
    //[Button("Close")]
    public virtual void Close()
    {
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        /*canvasGroup.DOFade(0, fadeInOutDuration).SetUpdate(true).OnComplete(
            () =>
            {
                canvasGroup.gameObject.SetActive(false);
            });*/
    }

    public virtual void Init(IGameDataContainer gameDataContainer, GameCanvas gameCanvas)
    {
        canvasGroup = GetComponent<CanvasGroup>();
        //_gameDataContainer = gameDataContainer;
        
        this.gameCanvas = gameCanvas;
        
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        //canvasGroup.DOFade(0, 0).SetUpdate(true);
        canvasGroup.gameObject.SetActive(false);

        foreach (var item in closeButtons)
        {
			item.onClick.AddListener(Close);
        }
    }
}

public interface IGameDataContainer
{
}

public enum UIScreenType
{
    MAIN = 1,
    WIN = 2,
    LOSE = 3,
    CHARACTER_CANVASES = 4,
    MENU = 5,
    DEBUG = 6,
    SHOP = 7,
    MONEY = 8,
    SETTINGS = 9,
    UPGRADE_STATS = 10,
    WATER_BAR = 11,
    PROGRESS_BAR = 12,
    TUTORIAL = 13,
    TANK_NOTIFY
}