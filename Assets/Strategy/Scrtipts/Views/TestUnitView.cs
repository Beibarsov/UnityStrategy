using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUnitView : MonoBehaviour
{

	private TestUnit _model;

    // Start is called before the first frame update
    void Awake()
    {
		//_model = FindObjectOfType<TestUnit>();
		//_model.Selected += HUDenabled;
		//GetComponent<Canvas>().enabled = false;
		//GetComponent<CanvasScaler>().enabled = false;
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	void HUDenabled(bool state)
	{
		//Debug.Log(state);
		//if (state) { 
		//GetComponent<Canvas>().enabled = true;
		//GetComponent<CanvasScaler>().enabled = true;
		//GetComponent<Canvas>().GetComponentInChildren<Text>().text = _model.IsSelected.ToString();
		//} else
		//{
		//	GetComponent<Canvas>().enabled = false;
		//	GetComponent<CanvasScaler>().enabled = false;
		//}
	}
}
