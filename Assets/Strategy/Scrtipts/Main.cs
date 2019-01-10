using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
	public static Main Instance { get; private set; }


	public InputController InputController { get; private set; }
	//public TestUnitController TestUnitController { get; private set; }
	public SelectContoller SelectContoller { get; private set; }
	public SelectView SelectView { get; private set; }
	public DamageConroller DamageConroller { get; private set; }
	public MoveUnitController MoveUnitController { get; private set; }

	private void Awake()
	{
		if (Instance) DestroyImmediate(gameObject);
		else Instance = this;
	}

	private void Start()
	{
		InputController = gameObject.AddComponent<InputController>();
		//TestUnitController = gameObject.AddComponent<TestUnitController>();
		SelectContoller = gameObject.AddComponent<SelectContoller>();
		SelectView = gameObject.AddComponent<SelectView>();
		DamageConroller = gameObject.AddComponent<DamageConroller>();
		MoveUnitController = gameObject.AddComponent<MoveUnitController>();
	}


}
