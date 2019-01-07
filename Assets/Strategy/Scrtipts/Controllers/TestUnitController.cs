using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUnitController : BaseController
{

	private TestUnit _model;

	private void Awake()
	{
		_model = FindObjectOfType<TestUnit>();
	}

	public override void WeaponOn()
	{
		base.WeaponOn();
		_model.WeaponReady();
	}

	public override void WeaponOff()
	{
		base.WeaponOff();
		_model.WeaponNotReady();

	}

	public void Switch()
	{
		if (WeaponIsEnabled) WeaponOff();
		else WeaponOn();
	} 

}
