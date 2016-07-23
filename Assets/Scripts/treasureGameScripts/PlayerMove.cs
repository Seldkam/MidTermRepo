using UnityEngine;
using System.Collections;

public class PlayerMove: MonoBehaviour {

	public int playerSpeed = 300;
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
	
		if (Input.GetKey(KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D>().velocity += new Vector2(0,playerSpeed) * Time.deltaTime;
		}
		if ( Input.GetKey(KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D>().velocity += new Vector2(0, -playerSpeed) * Time.deltaTime;
		}
		if ( Input.GetKey(KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D>().velocity += new Vector2(playerSpeed, 0) * Time.deltaTime;
		}
		if ( Input.GetKey(KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D>().velocity += new Vector2(-playerSpeed, 0) * Time.deltaTime;
		}
				
				
	}
}
