using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

	private Transform _campos;

	private void Awake()
	{
		_campos = Camera.main.transform;
	}

	// Update is called once per frame
	void Update()
    {


		Debug.Log("Позиция мыши" + Input.mousePosition.y);
		Debug.Log("экран" + Screen.currentResolution.width);


		if (Input.mousePosition.x > (Screen.currentResolution.width - Screen.currentResolution.width / 10)) CameraRight();
		if (Input.mousePosition.x < (Screen.currentResolution.width - (Screen.currentResolution.width - Screen.currentResolution.width / 10))) CameraLeft();
		if (Input.mousePosition.y > (Screen.currentResolution.height - Screen.currentResolution.height / 10)) CameraUp();
		if (Input.mousePosition.y < (Screen.currentResolution.height - (Screen.currentResolution.height - Screen.currentResolution.height / 10))) CameraDown();
		if (Input.GetAxis("Mouse ScrollWheel") > 0) CameraWheelUp();
		if (Input.GetAxis("Mouse ScrollWheel") < 0) CameraWheelDown();
		//Debug.Log(Screen.currentResolution);
		//Camera.main.transform.position += new Vector3(0, 0, 1);




	}



	public void CameraUp()
	{
		_campos.position += new Vector3(0, 0, 0.05f);
	}
	public void CameraDown()
	{
		_campos.position += new Vector3(0, 0, -0.05f);
	}
	public void CameraRight()
	{
		_campos.position += new Vector3(0.05f, 0, 0);
	}
	public void CameraLeft()
	{
		_campos.position += new Vector3(-0.05f, 0, 0);
	}
	public void CameraWheelUp()
	{
		_campos.position += new Vector3(0, -0.1f, 0);
	}
	public void CameraWheelDown()
	{
		_campos.position += new Vector3(0, 0.1f, 0);
	}
}
