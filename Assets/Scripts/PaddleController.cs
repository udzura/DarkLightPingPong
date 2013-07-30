using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
	private Camera mainCamera;
	
	void Start()
	{
		mainCamera = GameObject.Find("Main Camera").camera;
	}

	void Update ()
	{
		var mousePos = Input.mousePosition;
		Debug.Log(mousePos);
		Debug.Log(Screen.height + ", " + Screen.width);
		var newPos = this.transform.position;
		newPos.y = 150.0f * mousePos.y / Screen.height;
		newPos.z = -240.0f * mousePos.x / Screen.width + 120.0f;
	    this.transform.position = newPos;
	}
}
