using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageConroller : BaseController
{
    public void Damage(TestUnit unit)
	{
		unit.TakeDamage(10);
		Main.Instance.SelectView.UpdateHP(unit.HPCounter(), unit);

	}
}
