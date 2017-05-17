using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour {

	List<string> thirdchoice = new List<string>() {"Avec Brad","Un strip-teaseur","On a enfermé Jean dehors","En pom pom girl"};

	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh>().text = secondchoice [0];
	}

	// Update is called once per frame
	void Update () {
		if (TextControl.randQuestion > -1) 
		{	
			GetComponent<TextMesh> ().text = thirdchoice [TextControl.randQuestion];
		}
	}

	void OnMouseDown()
	{

		TextControl.selectedAnswer = gameObject.name;
		TextControl.choiceSelected = "y";
	}

}