using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
	public bool IsSelected { get; private set; }

	private void Awake()
	{
		IsSelected = false;
	}

	public virtual void Select()
	{
		IsSelected = true;
	}

	public virtual void UnSelect()
	{
		IsSelected = false;
	}

}
