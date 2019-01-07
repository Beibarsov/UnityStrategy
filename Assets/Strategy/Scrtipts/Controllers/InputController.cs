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
					unit.Select();
				}
			}

			
		}



		//Main.Instance.TestUnitController.Select();
	}
}
