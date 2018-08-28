using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChooseFood : MonoBehaviour {
	[SerializeField]
	private Image Food1;

	[SerializeField]
	private Image Food2;

	[SerializeField]
	private Image Food3;


	public void Choose_Food(){
		if (StrengthScript.chosen_food == 0) {
			Food1.sprite = Resources.Load<Sprite> ("flags/" + StrengthScript.current_food);
			StrengthScript.chosen_food++;
		}else if (StrengthScript.chosen_food == 1) {
			Food2.sprite = Resources.Load<Sprite> ("flags/" + StrengthScript.current_food);
			StrengthScript.chosen_food++;
		}else if (StrengthScript.chosen_food == 2) {
			Food3.sprite = Resources.Load<Sprite> ("flags/" + StrengthScript.current_food);
			StrengthScript.chosen_food++;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
