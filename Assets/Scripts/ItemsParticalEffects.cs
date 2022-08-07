using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsParticalEffects : MonoBehaviour {

	private float radian = 0.0f;
	private float perRad = 0.03f;
	private float dis = 0.0f;
	private Vector3 pos;

	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		radian += perRad;
		dis = Mathf.Sin(radian);
		transform.position = pos + new Vector3(0.0f, dis, 0.0f);

		transform.Rotate(0.0f, Time.deltaTime + 2.5f, 0.0f, Space.World);
	}
}
