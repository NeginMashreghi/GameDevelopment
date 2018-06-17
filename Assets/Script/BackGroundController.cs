using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour {

	// Public varible
	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float startY;
	[SerializeField]
	private float endY;


	// Private varible

	// Transform is a Component of gameObject that keeps track position
	private Transform _transform ;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {

		// allow us to accsses the all the component that this game object
		_transform = gameObject.GetComponent<Transform>();
		_currentPos = _transform.position;

	}

	// Update is called once per frame
	void Update () {

		// get the current position 
		_currentPos = _transform.position;

		// move it down
		_currentPos -= new Vector2( 0 , speed);

		if ( _currentPos.y < endY)
		{
			// if it reached to the top of the BackGround image 
			// go to bottom of the BackGround image
			Reset();
		}

		// apply the changes 
		_transform.position = _currentPos;

	}

	private void Reset(){

		// go to the bottom of the BackGround image
		_currentPos = new Vector2 (0 , startY);
	}
}
