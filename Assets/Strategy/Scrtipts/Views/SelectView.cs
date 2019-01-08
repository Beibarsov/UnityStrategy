using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectView : MonoBehaviour, IObserver
{

	private TestUnit[] _models;
	IObservable IsSelected;

	// Start is called before the first frame update
	void Start()
    {
		_models = FindObjectsOfType<TestUnit>();
		Debug.Log(_models.Length + "Количество найденных моделей");
		foreach (TestUnit unit in _models)
		{
			unit.RegisterObserver(this);
		}
		
	}

	 public void UpdateSwtich(bool state, GameObject obj)
	{
		obj.GetComponent<TestUnit>().IsSelected = state;
		obj.GetComponentInChildren<Canvas>().enabled = state;
		obj.GetComponentInChildren<CanvasScaler>().enabled = state;
		Debug.Log("Наблюдатель отработал");
	}
}


/*
 Паттерн наблюдатель здесь реализуется для слежения за активностью (выделенностью) юнитом.
 Данный класс (SelectView) будет наблюдателем, все модели - наблюдаемыми. Если модель IsSelected - значит данный класс должен принять меры. 
	 
	 
*/
