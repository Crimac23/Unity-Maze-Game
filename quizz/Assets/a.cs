using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour {

	List<string> firstchoice = new List<string>() {"Avec Michel","Les parents de l'hôte","Il faisait trop froid","En zombie"};

	// L'agorithme commence
	void Start () {
		
	}
	
	// L'emplacement de texte suit l'ordre aléatoire des questions, afin que les réponses correspondent avec les questions
	void Update () {
		if (TextControl.randQuestion>-1) 
		{
			GetComponent<TextMesh> ().text = firstchoice [TextControl.randQuestion];
		}		
	}

	void OnMouseDown()
	{

		TextControl.selectedAnswer = gameObject.name;
		TextControl.choiceSelected = "y";
	}

}
