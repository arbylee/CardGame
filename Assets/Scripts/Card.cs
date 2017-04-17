using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Card : MonoBehaviour {
	public List<GameObject> abilityGOs;
	private List<CardAbility> cardAbilities;

	void Awake() {
		cardAbilities = new List<CardAbility> ();
	}

	void Start() {
		for (int i = 0; i < abilityGOs.Count; i++) {
			CardAbility ability = abilityGOs [i].GetComponent<CardAbility>();
			cardAbilities.Add (ability);
		}
	}

	void OnMouseEnter() {
		Debug.Log ("ENTER");
	}

	void OnMouseExit() {
		Debug.Log ("EXIT");
	}

	public void Activate (){
		for(int i = 0; i < cardAbilities.Count; i++) {
			CardAbility ability = cardAbilities [i];
			ability.Activate ();
		}
	}
}
