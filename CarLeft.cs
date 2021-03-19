using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CarLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	bool ispressed = false;
	public GameObject player;


	// Update is called once per frame
	void Update () {
		if (ispressed) {
			player.transform.Translate (-0.2f,0,0);
		}
	}

	public void OnPointerDown(PointerEventData evenData){
		ispressed = true;
	}
	public void OnPointerUp(PointerEventData evenData){
		ispressed = false;
	}

}
