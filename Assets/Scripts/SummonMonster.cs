using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SummonMonster : CardAbility {
	public List<GameObject> monsterGOs;

	public override void Activate() {
		Debug.Log ("Activated summon");
		foreach (GameObject monsterGO in monsterGOs) {
			Instantiate (monsterGO);
		}
	}
}
