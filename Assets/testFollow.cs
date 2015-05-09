using UnityEngine;
using System.Collections;

public class testFollow : MonoBehaviour {

	GameObject player;
	float startTime;
	Vector3 startpos;
	float journeyLength;
	public float speed = 1.0f;


	// Use this for initialization
	void Start () {
		startTime = Time.time;
		player = GameObject.Find("Player");
		startpos = transform.position;
		journeyLength = Vector3.Distance(startpos, player.transform.position);
	
	}
	
	// Update is called once per frame
	void Update () {
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp(startpos, player.transform.position, fracJourney);
	
	}
}
