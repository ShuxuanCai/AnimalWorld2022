using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserveAnimalOrNot : MonoBehaviour {

	public Vector3 mousePos;
	public Vector3 animalPos;

	// Use this for initialization
	void Start () {
		transform.LookAt(GameObject.FindGameObjectWithTag("Avatar").transform);
	}
	
	// Update is called once per frame
	void Update () {
		mousePos = Input.mousePosition;
		animalPos = Camera.main.WorldToScreenPoint(gameObject.transform.position);

		float disX = Mathf.Abs(mousePos.x - animalPos.x);
		float disY = Mathf.Abs(mousePos.y - animalPos.y);
		if (Input.GetMouseButton(0) && disX <= 30.0f && disY <= 300.0f)
		{
			UIManager_02.Instance.ShowObserve(true);
			Destroy(gameObject);
			UIManager_02.Instance.destroy = true;
		}
	}
}
