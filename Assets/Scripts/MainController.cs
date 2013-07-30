using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour {

	void Start()
	{
		var pos = new Vector3(-245, 75, 0);
		var tilt = Quaternion.Euler(new Vector3(0, 0, 245));
		GameObject paddle =
			Instantiate(Resources.Load("GameObjects/Paddle"), pos, tilt) as GameObject;
	}
	
	void Update()
	{
	
	}
}
