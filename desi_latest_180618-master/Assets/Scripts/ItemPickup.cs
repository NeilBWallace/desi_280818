using UnityEngine;
using UnityEngine.UI;
public class ItemPickup : Interactable {

//	[SerializeField]
//	public GameObject eat_food_panel;
	private AudioSource[] allAudioSources;

    
	// When the player interacts with the item
	public override void Interact()
	{
		base.Interact();

		PickUp();	// Pick it up!
	}

	public Opening_Values o;
	// Pick up the item
	void PickUp ()
	{

	
		CanvasGroup c =GameObject.Find("Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 1;
	 c =GameObject.Find("Eat_Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 1;
	

		Text t = GameObject.Find ("food_title1").GetComponent<Text> ();
		t.text= gameObject.name;

		Image i = GameObject.Find ("foodbank").GetComponent<Image> ();

		i.sprite = Resources.Load<Sprite> ("flags/" +gameObject.name);

		Text g = GameObject.Find ("fd").GetComponent<Text> ();
		g.text =GameObject.Find (gameObject.name).GetComponent<stats>().fd.ToString();

		g = GameObject.Find ("strength").GetComponent<Text> ();
		g.text =GameObject.Find (gameObject.name).GetComponent<stats>().strength.ToString();


		g = GameObject.Find ("health").GetComponent<Text> ();
		g.text =GameObject.Find (gameObject.name).GetComponent<stats>().health.ToString();

		g = GameObject.Find ("smartness").GetComponent<Text> ();
		g.text =GameObject.Find (gameObject.name).GetComponent<stats>().smartness.ToString();

		g = GameObject.Find ("food_group").GetComponent<Text> ();
		g.text =GameObject.Find (gameObject.name).GetComponent<stats>().food_group.ToString();


	}

}
