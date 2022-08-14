using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour {

	private GameObject[] Animals;

	void Awake()
    {
		Animals = Resources.LoadAll<GameObject>("Animals");
    }

	// Use this for initialization
	void Start () {
		SpawnAnimal();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void SpawnAnimal()
    {
		int animalOrder = Random.Range(0, Animals.Length);
		Instantiate(Animals[animalOrder], transform.position, transform.rotation);
    }
}
