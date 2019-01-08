using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestUnit : BaseSceneModel, IObservable
{
	[SerializeField]
	private int _hp;

	public bool IsSelected { get; set; }
	//Список наблюдателей
	public List<IObserver> observers;
	//Событие выбора, на нем завязана view
	public Action<bool> Selected;


	private void Awake()
	{
		IsSelected = false;
		//Для наблюдателя, инициализация списка наблюдателей
		observers = new List<IObserver>();
	}

	public TestUnit()
	{
		_hp = 100;
	}

	public void Die()
	{
		 GameObject.Destroy(this.gameObject);
	}

	public void Select()
	{
		Debug.Log("Выбран этот юнит" + gameObject.name);
		IsSelected = true;
		if (Selected != null) Selected.Invoke(true);
	}

	public void UnSelect()
	{
		Debug.Log("Отмена выбора этого юнита");
		IsSelected = false;
		if (Selected != null) Selected.Invoke(false);
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


	public void Switch()
	{
		if (!IsSelected) Select();
		else UnSelect();
		Debug.Log(this.gameObject.name + " " + IsSelected.ToString());
		NotifyObservers();
		Debug.Log(observers.Count);
	}



	

	/// <summary>
	/// Регистрация наблюдателя в #Наблюдатель
	/// </summary>
	/// <param name="o"></param>
	public void RegisterObserver(IObserver o)
	{
		observers.Add(o);
	}

	/// <summary>
	/// Удаление наблюдателя из #Наблюдатель
	/// </summary>
	/// <param name="o"></param>
	public void RemoveObserver(IObserver o)
	{
		observers.Remove(o);
	}
	/// <summary>
	/// Уведомление наблюдателей в #Наблюдатель
	/// </summary>
	public void NotifyObservers()
	{
		foreach (IObserver observer in observers)
		{
			observer.UpdateSwtich(IsSelected, this.gameObject);
		}
	}
}
