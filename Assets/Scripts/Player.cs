using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	void Update(){
		if (Input.GetMouseButtonDown(0)){ // if left button pressed...
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)){
				if (hit.transform.gameObject.CompareTag("Card")) {
					Card card = hit.transform.gameObject.GetComponent<Card> ();
					card.Activate ();
				}
			}
		}
	}
}