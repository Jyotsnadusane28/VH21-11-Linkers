using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour {
	private GameObject[] characterlist;
	private int index;
	private void Start(){
		//first step - filled that array with model
		characterlist = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++)
			characterlist [i] = transform.GetChild (i).gameObject;
		//second step - we toggle off their model so that we can hide them
		foreach (GameObject go in characterlist)
			go.SetActive (false);
		//third step- we toggle on the first index so that first model will be visible
		if (characterlist [0])
			characterlist [0].SetActive (true);
	}

	public void ToggleLeft(){
		//Toggle Off the current model
		characterlist[index].SetActive(false);

		index--;
		if (index < 0)
			index = characterlist.Length - 1;

		//Toggle on the new model
		characterlist[index].SetActive(true);

	}

	public void ToggleRight(){
		//Toggle Off the current model
		characterlist[index].SetActive(false);

		index++;
		if (index == characterlist.Length)
			index = 0;

		//Toggle on the new model
		characterlist[index].SetActive(true);

	}

}
