using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {
	static Vector3 forwardForce = Vector3.right * 100000000000.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{
		var q3 = Quaternion.AngleAxis(Random.Range(-20.0f, 20.0f), Vector3.up);
		transform.rigidbody.AddTorque(q3 * forwardForce, ForceMode.VelocityChange);
		if(transform.position.z < -50 || transform.position.x < -800)
		{
			Destroy(this.gameObject);
		}
	}
	
	public void TurnRed ()
	{
		renderer.material.SetColor("_Color", Color.red);
	}
}
