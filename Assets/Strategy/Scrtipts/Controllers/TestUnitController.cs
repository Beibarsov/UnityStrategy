using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestUnitController : BaseController
{

	private TestUnit _model;

	private void Awake()
	{
		_model = FindObjectOfType<TestUnit>();
	}

	public override void Select()
	{
		//if (Camera.main.ScreenPointToRay)
		base.Select();
		_model.Select();


	}

	public override void UnSelect()
	{
		base.UnSelect();
		_model.UnSelect();


	}

	public void Switch()
	{
		if (!IsSelected) Select();
		else UnSelect();
		Debug.Log(this.gameObject.name + " " + IsSelected.ToString());
	} 

}
