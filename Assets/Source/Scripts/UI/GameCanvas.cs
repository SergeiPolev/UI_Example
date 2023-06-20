using System;
using System.Collections.Generic;
//using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.UI;
//using Zenject;

public class GameCanvas : MonoBehaviour
{
	[SerializeField] private UIScreenType[] startScreens;
	[SerializeField] private Transform joystickRoot;
	[SerializeField] private CanvasScaler canvasScaler;
	[SerializeField] private RectTransform canvasRect;
	[SerializeField] private Canvas _canvas;
	//[SerializeField] private MMF_Player _feedback;

	private Dictionary<UIScreenType, UIScreen> uiScreens = new();

	public Transform JoystickRoot => joystickRoot;
	public Canvas Canvas => _canvas;
	public CanvasScaler CanvasScaler => canvasScaler;
	public RectTransform CanvasRect => canvasRect;

	private IGameDataContainer _loader;

	private void Start()
	{
		foreach (var screen in startScreens)
		{
			Open(screen);
		}

		_canvas ??= GetComponent<Canvas>();
	}

	/*[Inject]
	public void Construct(IGameDataContainer loader)
	{
		_loader = loader;
		loader.GetGameData().GameCanvas = this;
		
		Init();
	}*/

	public void Init()
	{
		InitScreens();
	}
	
	private void InitScreens()
	{
		var screens = GetComponentsInChildren<UIScreen>();

		foreach (var item in screens)
		{
			uiScreens.Add(item.GetUIType(), item);
			item.Init(_loader, this);
		}
	}

	public T GetScreen<T>(UIScreenType type) where T : UIScreen
	{
		return uiScreens[type] as T;
	}
	public void Open(UIScreenType type)
	{
		if (uiScreens.ContainsKey(type))
		{
			uiScreens[type].Open();
			
			return;
		}

		throw new Exception($"There's no screen for type {type.GetType().Name}");
	}
	public void Close(UIScreenType type)
	{
		if (uiScreens.ContainsKey(type))
		{
			uiScreens[type].Close();
			
			return;
		}

		throw new Exception($"There's no screen for type {type.GetType()}");
	}

	public void HapticOnClick()
	{
		//_feedback?.PlayFeedbacks();
	}
}