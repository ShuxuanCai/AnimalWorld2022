using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPoints : MonoBehaviour {

	public GameObject player;
	public GameObject prePoint;
	public float minDis = 3.0f;
	public float maxDis = 50.0f;

	private Vector3 playerPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnPoints()
    {
		playerPos = player.transform.position;
		float dis = Random.Range(minDis, maxDis);

		Vector2 v = Random.insideUnitCircle;
		Vector2 normal = v.normalized;

		Vector3 pos = new Vector3(playerPos.x + normal.x * dis, 0, playerPos.z + normal.y * dis);

		GameObject events = Instantiate(prePoint, pos, transform.rotation);
    }
}
