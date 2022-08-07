using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour {

	public GameObject Cage;
	public GameObject Animals;
	public GameObject Food;

	// Use this for initialization
	void Start () {
		int randomEvent = Random.Range(0, 3);
		if(randomEvent == 0)
        {
			SpawnAnimals();
        }
		else if(randomEvent == 1)
        {
			SpawnCages();
        }
		else
        {
			SpawnFood();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void SpawnAnimals()
    {
		Instantiate(Animals, transform.position, transform.rotation);
    }

	private void SpawnCages()
	{
		Quaternion q = new Quaternion(180.0f, 0.0f, 0.0f, 0.0f);
		Instantiate(Cage, transform.position + new Vector3(0.0f, 3.0f, 0.0f), q);
	}

	private void SpawnFood()
	{
		Instantiate(Food, transform.position + new Vector3(0.0f, 3.0f, 0.0f), transform.rotation);
	}
}
