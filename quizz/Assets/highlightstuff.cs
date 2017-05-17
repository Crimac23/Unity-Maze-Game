using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highlightstuff : MonoBehaviour {

	// L'algorithme commence
	void Start () {
		
	}
	
	// étape conventionnelle du logiciel
	void Update () {
		
	}

	// Quand le joueur passe la souris sur l'emplacement texte, changement de couleur (ici vert)

	void OnMouseOver()
	{
		GetComponent<TextMesh> ().color = new Color (0, 1, 0);
		GetComponent<TextMesh> ().fontSize = 48;
	}

	// Quand la souris n'est plus sur l'emplacement texte, réinitialisation de la police et de la couleur

	void OnMouseExit()
	{
		GetComponent<TextMesh> ().color = new Color (1, 1, 1);
		GetComponent<TextMesh> ().fontSize = 42;
	}
}
