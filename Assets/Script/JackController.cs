using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackController : MonoBehaviour {

	[SerializeField]
	private float speed = 7f;

	[SerializeField]
	private float leftX;
	[SerializeField]
	private float rightx;

	private Transform _transform ;
	private Vector2 _CurrentPos;


	// Use this for initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform>();
		_CurrentPos = _transform.position;

	}

	// Update is called once per frame
	void Update () {
		_CurrentPos = _transform.position;


		float userInput = Input.GetAxis ("Horizontal");

		//if (Input.GetKey (KeyCode.LeftArrow)) 
		if(userInput<0)
		{
			//if left arrow is pressed move left
			_CurrentPos -= new Vector2(speed, 0);
		}

		//if (Input.GetKey (KeyCode.RightArrow)) 
		if(userInput>0)
		{
			//if roght arrow is pressed move right
			_CurrentPos += new Vector2(speed, 0);
		}

		CheckBounds ();

		_transform.position = _CurrentPos;

	}


	// check the bound 
	private void CheckBounds()
	{
		if (_CurrentPos.x < leftX) {

			_CurrentPos.x = leftX;

		}else if (_CurrentPos.x > rightx){

			_CurrentPos.x = rightx;
		}
	}
}
