using UnityEngine;

public class BuildingWorldUI : MonoBehaviour
{
	//[SerializeField] private ProgressBarBuilding progressBar;

	private void Awake()
	{
		transform.forward = Camera.main.transform.forward;
	}

	public void UpdateProgressBar(float value)
	{
		//progressBar.UpdateBar(value);
	}
}