using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour {

	//[SerializeField]
	//float minYSpeed = 1f;
	//[SerializeField]
	//float maxYSpeed = 2f;
	// X will be left or right so we will move in opposit direction
	// so the sign is negetive
	//[SerializeField]
	//float minXSpeed = 0f;
	//[SerializeField]
	//float maxXSpeed = 0f;


	private Rigidbody2D _rigidBody = null;
	private Transform _transform;
	// Enemy speed will be random 
	private Vector2 _currentSpeed;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_rigidBody = gameObject.GetComponent<Rigidbody2D> ();
		Reset ();
	}



	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.y <= -430) {
			IsGrounded ();
			Reset ();
		}
	}


	private bool IsGrounded () {

		SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer> ();
		Vector2 pos = gameObject.transform.position;

		RaycastHit2D res = Physics2D.Linecast (
			 new Vector2 (pos.x, pos.y - (sr.bounds.size.y / 2)),
			 new Vector2 (pos.x, pos.y - (sr.bounds.size.y / 2 + 0.2f))

		);

		Debug.DrawLine (
			new Vector2 (pos.x, pos.y - (sr.bounds.size.y / 2)),
			new Vector2 (pos.x, pos.y - (sr.bounds.size.y / 2 + 0.2f))
		);

		return res != null && res.collider != null;
			
	}


	public void Reset(){

		// this method change the speed 
		//float xSpeed = Random.Range (minXSpeed, maxXSpeed);
		//float ySpeed = Random.Range (minYSpeed, maxYSpeed);
		//_currentSpeed = new Vector2 (xSpeed, ySpeed);

		// move Enemy to the top

		// <--- --->
		float x = Random.Range (-150, 150); 
		// 415 is Y of the top of the ocean 
		_transform.position = new Vector2 (x, 430 + Random.Range (0, 500));

	}
}
