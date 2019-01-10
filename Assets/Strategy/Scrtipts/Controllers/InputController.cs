using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : BaseController
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				Debug.Log(hit.point);
				if (hit.collider.GetComponent<TestUnit>())
				{
					TestUnit unit = hit.collider.GetComponent<TestUnit>();
					Main.Instance.SelectContoller.Switch(unit);
					//unit.Switch();
				}
			}



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



			//Main.Instance.TestUnitController.Select();
		}
	}
}