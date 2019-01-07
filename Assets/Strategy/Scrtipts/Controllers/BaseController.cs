using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
	public bool WeaponIsEnabled { get; private set; }

	private void Awake()
	{
		WeaponIsEnabled = true;
	}

	public virtual void WeaponOn()
	{
		WeaponIsEnabled = true;
	}

	public virtual void WeaponOff()
	{
		WeaponIsEnabled = false;
	}

}
