using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager_02 : MonoBehaviour {

	public Text CageNumber;
	public Text FoodNumber;
	public GameObject Observe;
	public bool destroy = false;

	public static UIManager_02 Instance;

	void Awake()
    {
		Instance = this;
    }

	public void AddCageNumber()
    {
		int cageNumber = int.Parse(CageNumber.text);
		cageNumber++;
		CageNumber.text = cageNumber.ToString();
    }

	public void AddFoodNumber()
	{
		int foodNumber = int.Parse(FoodNumber.text);
		foodNumber++;
		FoodNumber.text = foodNumber.ToString();
	}

	public void ShowObserve(bool observe)
    {
		Observe.SetActive(observe);
    }
}
