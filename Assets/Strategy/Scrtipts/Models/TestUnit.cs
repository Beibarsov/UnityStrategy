﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUnit : BaseSceneModel
{
	[SerializeField]
	private int _hp;

	public TestUnit()
	{
		_hp = 100;
	}

	public void Die()
	{
		 GameObject.Destroy(this.gameObject);
	}

	public void WeaponReady()
	{
		Debug.Log("Оружие готово");
	}

	public void WeaponNotReady()
	{
		Debug.Log("Оружие не готово");
	}



	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (_hp < 10) Die();

	}
}
