using System;
using UnityEngine;

public class TargetArrow : MonoBehaviour
{
	[SerializeField] private GameObject spriteRenderer;
	
	private Vector3 targetPos;

	private IGameDataContainer _data;

	public void Init(IGameDataContainer gameDataContainer)
	{
		_data = gameDataContainer;
		
		//targetPos = gameDataContainer.GetGameData().EntitiesHandler.GetBuildingPosByType(BuildingType.WATER_PUMP);
		
		//_data.GetGameData().Player.GetTank.OnTankEmpty += ActivateArrow;

		DisableArrow();
	}
	private void LateUpdate()
	{
		transform.LookAt(targetPos);
	}

	public void SetTargetPos(Vector3 position)
	{
		position.y = transform.position.y;
		targetPos = position;
	}

	public void ActivateArrow()
	{
		EnableArrow(true);

		//_data.GetGameData().Player.GetTank.OnFuelChange += DisableArrow;
	}

	public void DisableArrow()
	{
		EnableArrow(false);
		
		//_data.GetGameData().Player.GetTank.OnFuelChange -= DisableArrow;
	}

	private void EnableArrow(bool enable)
	{
		spriteRenderer.SetActive(enable);
	}

	private void OnDestroy()
	{
		//_data.GetGameData().Player.GetTank.OnTankEmpty += ActivateArrow;
	}
}