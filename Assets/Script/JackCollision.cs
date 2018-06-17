using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackCollision : MonoBehaviour {

	[SerializeField]
	GameController GC;

	[SerializeField]
	string level;

	private AudioSource foodSound;

	// Use this for initialization
	void Start () {
		
		foodSound = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag.Equals ("Pear")) {

			Debug.Log ("Collider foodSound\n");

			if (foodSound != null) foodSound.Play ();
				
		}
		if (other.gameObject.tag.Equals ("Peach")) {

			Debug.Log ("Collider foodSound\n");

			if (foodSound != null) foodSound.Play ();

		}

		if (other.gameObject.tag.Equals ("Eggplant")) {

			Debug.Log ("Collider foodSound\n");

			if (foodSound != null) foodSound.Play ();

		}

		if (other.gameObject.tag.Equals ("Pear")) {
			
			Debug.Log ("jack eat Pear\n");
			other.gameObject.GetComponent<FoodController> ().Reset ();
			// Player.Instance.(-----) will be change in next level
			// level 1 Player.Instance.HealthPointLevel1 
			// level 2 Player.Instance.HealthPointLevel2 
			// level 3 Player.Instance.HealthPointLevel3 


			if (level == "level1") {
				Player.Instance.HealthPointLevel1 += 100;
			} else if (level == "level2") {
				Player.Instance.HealthPointLevel2 += 100;
			}else if (level == "level3") {
				Player.Instance.HealthPointLevel3 += 100;
			}

		} 

		else if (other.gameObject.tag.Equals ("Peach")) {

			Debug.Log ("jack eat Peach\n");
			other.gameObject.GetComponent<FoodController> ().Reset ();


			if (level == "level1") {
				Player.Instance.HealthPointLevel1 += 200;
			} else if (level == "level2") {
				Player.Instance.HealthPointLevel2 += 200;
			}else if (level == "level3") {
				Player.Instance.HealthPointLevel3 += 200;
			}

					
		}

		else if (other.gameObject.tag.Equals ("Eggplant")) {

			Debug.Log ("jack eat Egeplant\n");
			other.gameObject.GetComponent<FoodController> ().Reset ();

			if (level == "level1") {
				Player.Instance.HealthPointLevel1 += 300;
			} else if (level == "level2") {
				Player.Instance.HealthPointLevel2 += 300;
			}else if (level == "level3") {
				Player.Instance.HealthPointLevel3 += 300;
			}

		} 

		else if (other.gameObject.tag.Equals ("Stake")) {

			Debug.Log ("jack eat Stake\n");
			other.gameObject.GetComponent<FoodController> ().Reset ();


			if (level == "level1") {
				Player.Instance.HealthPointLevel1  -=60;
			} else if (level == "level2") {
				Player.Instance.HealthPointLevel2  -=60;
			}else if (level == "level3") {
				Player.Instance.HealthPointLevel3  -=60;
			}


		}

		else if (other.gameObject.tag.Equals ("Sausage")) {

			Debug.Log ("jack eat Sausage\n");
			other.gameObject.GetComponent<FoodController> ().Reset ();


			if (level == "level1") {
				Player.Instance.HealthPointLevel1  -=30;
			} else if (level == "level2") {
				Player.Instance.HealthPointLevel2  -=30;
			}else if (level == "level3") {
				Player.Instance.HealthPointLevel3  -=30;
			}


		}

		else if (other.gameObject.tag.Equals ("Chocolate")) {

			Debug.Log ("jack eat Chocolate\n");
			other.gameObject.GetComponent<FoodController> ().Reset ();

			if (level == "level1") {
				Player.Instance.HealthPointLevel1  -=40;
			} else if (level == "level2") {
				Player.Instance.HealthPointLevel2  -=40;
			}else if (level == "level3") {
				Player.Instance.HealthPointLevel3  -=0;
			}

		}
	}
}
