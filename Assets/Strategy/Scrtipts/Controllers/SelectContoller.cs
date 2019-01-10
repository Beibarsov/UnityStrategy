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
	/// <param name="unit">Выбрать/отменить выбор юнитов</param>
	public void Switch(TestUnit unit)
	{
		unit.Switch();
	}
	/// <summary>
	/// Возвращает (массивом) перечень выбранных юнитов
	/// </summary>
	/// <returns>TestUnit[] перечень выбранных юнитов</returns>
	public TestUnit[] WhoSelected()
	{

		List<TestUnit> units = new List<TestUnit>();
		foreach (TestUnit unit in FindObjectsOfType<TestUnit>())
		{
			if (unit.IsSelected) units.Add(unit);
		}
		return units.ToArray();
	}

}
