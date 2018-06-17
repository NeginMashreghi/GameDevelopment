using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {


	[SerializeField]
	string level;

	[SerializeField]
	Text levelLabel;
	[SerializeField]
	Text healthPointLable;
	[SerializeField]
	Text youLostLable;
	[SerializeField]
	Button playAgainBtn;


	private void initialize(){

		// HealthPoint will be change in next level
		// level 1 Player.Instance.HealthPointLevel1 = 200;
		// level 2 Player.Instance.HealthPointLevel2 = 500;
		// level 3 Player.Instance.HealthPointLevel3 = 800;
		if (level == "level1") {
			Player.Instance.HealthPointLevel1 = 200;
		} else if (level == "level2") {
			Player.Instance.HealthPointLevel2 = 500;
		}else if (level == "level3") {
			Player.Instance.HealthPointLevel3 = 800;
		}

		healthPointLable.gameObject.SetActive (true);
		levelLabel.gameObject.SetActive (true);
		youLostLable.gameObject.SetActive (false);
		playAgainBtn.gameObject.SetActive (false);

	}

	public void gameOver(){

		healthPointLable.gameObject.SetActive (false);
		levelLabel.gameObject.SetActive (false);
		youLostLable.gameObject.SetActive (true);
		playAgainBtn.gameObject.SetActive (true);
	}

	public void updateUI( int hp ){

		healthPointLable.text = "Health Point: " + hp ;
	}
	public void changeScene (string sceneName){

		Application.LoadLevel(sceneName);
	}


	void Start () {
		Player.Instance.gCtrl = this;
		initialize ();
	}


	void Update () {

	}


}
