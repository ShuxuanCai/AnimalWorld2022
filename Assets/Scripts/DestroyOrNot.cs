using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOrNot : MonoBehaviour {

	private bool des;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		des = UIManager_02.Instance.destroy;
		if(des == true)
        {
			Destroy(gameObject);
        }
	}
}
