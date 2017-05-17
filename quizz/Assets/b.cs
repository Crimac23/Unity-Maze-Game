using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b : MonoBehaviour {

	List<string> secondchoice = new List<string>() {"Avec Bard","Une strip-teaseuse","Des voisins se sont plaints pour le bruit","En abeille"};

	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh>().text = secondchoice [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (TextControl.randQuestion > -1) 
		{	
			GetComponent<TextMesh> ().text = secondchoice [TextControl.randQuestion];
		}
	}

	void OnMouseDown()
	{

		TextControl.selectedAnswer = gameObject.name;
		TextControl.choiceSelected = "y";
	}

}
