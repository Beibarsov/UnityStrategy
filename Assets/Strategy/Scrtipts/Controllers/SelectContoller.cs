using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Отвечает за выделение юнитов
/// </summary>
public class SelectContoller : BaseController
{
	/// <summary>
	/// Передает модели информацию, что теперь она выбрана (юнит выделен)
	/// </summary>
	/// <param name="unit"></param>
	public void Switch(TestUnit unit)
	{
		unit.Switch();
	}

}
