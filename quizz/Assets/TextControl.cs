using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class TextControl : MonoBehaviour {

	List<string> questions = new List<string>() {"Avec qui es-tu venu à la soirée ?","Vers 21h, une personne inattendue a débarqué à la soirée. Qui c'était ?", "A un moment l'hôte a voulu qu'on rentre tous dans la maison. Pourquoi ?","Ulysse croyait que c'était une soirée déguisée, donc il avait un costume. Il est venu comment ?"};

	// on définit les réponses correctes
	List<string> correctAnswer = new List<string>() {"3","1","3","2"};


	public Transform resultObj;

	public static string selectedAnswer;

	public static string choiceSelected="n";

	public static int randQuestion=-1;

	// début de l'algorithme
	void Start () {
		//GetComponent<TextMesh> ().text = questions [0];

	}
	
	// On choisit l'emplacement de 0 à 5, les questions sont disposés dans un ordre aléaoire
	void Update () {
		if (randQuestion == -1)
		{
			randQuestion = Random.Range (0, 4);
		}
		if (randQuestion>-1)
		{	
			GetComponent<TextMesh> ().text = questions [randQuestion];
		}
		//Debug.Log (questions [randQuestion]);

		if (choiceSelected=="y") {

			choiceSelected = "n";

			if (correctAnswer [randQuestion] == selectedAnswer) {

				resultObj.GetComponent<TextMesh> ().text = "Bonne réponse ! Clique sur continuer";

			} 

			else 
			{
				resultObj.GetComponent<TextMesh> ().text = "Mauvaise réponse ! Clique sur continuer";
					

			}

		}
	}
}
