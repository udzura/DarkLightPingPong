using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter (Collider other)
	{
		var ball = other.gameObject.GetComponent<BallBehaviour>() as BallBehaviour;
		ball.TurnRed();
	}
}
