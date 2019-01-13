using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectView : MonoBehaviour, IObserver
{

	private TestUnit[] _models;
	IObservable IsSelected;
	private List<HUDtextModel> hUDtextModels;
	private Text _textName;
	private Text _textHP;

	// Start is called before the first frame update
	void Start()
    {
		hUDtextModels = new List<HUDtextModel>(FindObjectsOfType<HUDtextModel>());
		_textName = hUDtextModels[1].GetComponent<Text>();
		_textHP = hUDtextModels[0].GetComponent<Text>();

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
		_textName.text = obj.GetComponent<TestUnit>().Name;
		_textHP.text = obj.GetComponent<TestUnit>().HPCounter().ToString();
		obj.GetComponentInChildren<Text>().text = "HP: " + obj.GetComponent<TestUnit>().HPCounter();
		if (state == false)
		{
			_textName.text = "Не выбран";
			_textHP.text = "Не выбран";

		}



	}

	public void UpdateHP(int hp, TestUnit unit)
	{
		unit.GetComponentInChildren<Text>().text = "HP: " + hp;
		_textHP.text = unit.HPCounter().ToString();

	}
}


/*
 Паттерн наблюдатель здесь реализуется для слежения за активностью (выделенностью) юнитом.
 Данный класс (SelectView) будет наблюдателем, все модели - наблюдаемыми. Если модель IsSelected - значит данный класс должен принять меры. 
	 
	 
*/
