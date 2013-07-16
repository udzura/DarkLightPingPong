using UnityEngine;
using System.Collections;

public class BallShooterController : MonoBehaviour {
	public float ballInterval;

	// Use this for initialization
	void Start ()
	{
		InvokeRepeating("ShootBall", 1.0f, ballInterval);
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void ShootBall ()
	{
		float power = Random.Range(360.0f, 400.0f);
		var pos = transform.position + Vector3.left * (power - 360.0f) * 4.0f;
		GameObject ball = Instantiate(Resources.Load("GameObjects/PingPongBall"), pos, Quaternion.identity) as GameObject;
		var q1 = Quaternion.AngleAxis(Random.Range(-3.0f, 3.0f), Vector3.up);
		var q2 = Quaternion.AngleAxis(Random.Range(7.5f, 12.5f), Vector3.forward);
		Vector3 force = q1 * q2 * Vector3.left * power;
		ball.transform.rigidbody.AddForce(force, ForceMode.VelocityChange);
	}
}
