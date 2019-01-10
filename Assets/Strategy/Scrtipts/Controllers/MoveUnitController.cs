using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Контролит приказы на движение для юнита
/// </summary>
public class MoveUnitController : BaseController
{
    // Start is called before the first frame update
    
	/// <summary>
	/// Движение для юнита (navmesh.destination)
	/// </summary>
	/// <param name="unit">Кому нужно двигаться</param>
	/// <param name="dest">Куда нужно двигаться</param>
	public void MoveOrder(TestUnit unit, Vector3 dest)
	{
		unit.Move(dest);
	}
}
