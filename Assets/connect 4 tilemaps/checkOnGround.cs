using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkOnGround : MonoBehaviour {

	public Collider2D groundCollider;
	private Rigidbody2D rb;


	public connect4Controle c4c;

	private bool turnHasEnded = false;
	private bool movementStarted = false;
	private bool soundPlayed = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (rb.velocity.magnitude >= .3) {
			movementStarted = true;
		}

		if (groundCollider.isTrigger) {

			if (soundPlayed == false) {
				soundPlayed = true;
			}

			if (rb.velocity.magnitude <= .2 && movementStarted == true) {


				this.transform.position = new Vector3(Mathf.Round(this.transform.position.x), Mathf.Round(this.transform.position.y), this.transform.position.z);
				if (turnHasEnded == false) {
					c4c.turnHasFinished();
					turnHasEnded = true;
				}
			}
		}
	}
}
