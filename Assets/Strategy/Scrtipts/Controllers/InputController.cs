using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : BaseController
{
	RaycastHit hitMouse1Down;
	RaycastHit hitMouse1Up;

	// Start is called before the first frame update
	void Start()
	{
		
		
	}

	// Update is called once per frame
	void Update()
	{


		if (Input.GetButtonDown("Fire1"))
		{
			Main.Instance.SelectContoller.CancelSelected();
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hitMouse1Down, Mathf.Infinity))
			{
				if (hitMouse1Down.collider.GetComponent<TestUnit>())
				{
					TestUnit unit = hitMouse1Down.collider.GetComponent<TestUnit>();
					Main.Instance.SelectContoller.Switch(unit);
					//unit.Switch();
				}
			}
		}

		if (Input.GetButtonUp("Fire1"))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Physics.Raycast(ray, out hitMouse1Up, Mathf.Infinity);
		}
		




		//Команда на движение/атаку и т.д.
		if (Input.GetButtonDown("Fire2"))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				Debug.Log(hit.point);
				if (hit.collider.name == "Plane")
				{
					Debug.Log("Это пол");
					
					foreach (TestUnit unit in Main.Instance.SelectContoller.WhoSelected())
					{
						if (unit.IsSelected) Main.Instance.MoveUnitController.MoveOrder(unit, hit.point);
					}
				}

				if (hit.collider.GetComponent<TestUnit>())
				{
					TestUnit unit = hit.collider.GetComponent<TestUnit>();
					Main.Instance.DamageConroller.Damage(unit);
					//unit.Switch();
				}
			}
		}


		if (Input.GetAxis("Horizontal") > 0)
			Main.Instance.CameraController.CameraRight();
		if (Input.GetAxis("Horizontal") < 0)
			Main.Instance.CameraController.CameraLeft();
		if (Input.GetAxis("Vertical") > 0)
			Main.Instance.CameraController.CameraUp();
		if (Input.GetAxis("Vertical") < 0)
			Main.Instance.CameraController.CameraDown();

	}
}