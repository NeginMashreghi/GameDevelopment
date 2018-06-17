using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

	static private Player _instance;
	static public Player Instance{
		get{ 
			if (_instance == null) {
				_instance = new Player ();
			}
			return _instance;
		}
	}

	public GameController gCtrl;

	private Player(){}

	private int _HealthPoint ;

	public int HealthPointLevel1 {
		get{ return _HealthPoint; }
		set { 
			_HealthPoint = value;

			if (_HealthPoint >= 3000) {

				gCtrl.changeScene("LOneToLTwoScene");

			}else if (_HealthPoint <= 0) {

				gCtrl.gameOver ();

			}else {

				gCtrl.updateUI (HealthPointLevel1);

			}

		}

	}



	public int HealthPointLevel2 {
		
		get{ return _HealthPoint; }

		set { 
			_HealthPoint = value;

			if (_HealthPoint >= 2000) {

				gCtrl.changeScene("LTwoToLThreeScene");

			}else if (_HealthPoint <= 0) {

				gCtrl.gameOver ();

			}else {

				gCtrl.updateUI (HealthPointLevel2);

			}

		}

	}


	public int HealthPointLevel3 {
		
		get{ return _HealthPoint; }
		set { 
			_HealthPoint = value;

			if (_HealthPoint >= 1500) {

				gCtrl.changeScene("LastScene");

			}else if (_HealthPoint <= 0) {

				gCtrl.gameOver ();

			}else {

				gCtrl.updateUI (HealthPointLevel3);

			}

		}

	}

}
