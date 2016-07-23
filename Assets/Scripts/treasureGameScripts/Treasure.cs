using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Treasure : MonoBehaviour {


	public Text OnScreenText; // Creates text object on "Treasure," which I can assign to false.
	public Transform PlayerCharacter; // Creates a player object, which I will link to my player sprite
	public foundJesus jesusScript;

	void Update () {
		if ((PlayerCharacter.position - transform.position).magnitude < 5f) {
			
			OnScreenText.text = "Press [SPACE] to cast your vote!";

			if (Input.GetKeyDown (KeyCode.Space) && jesusScript.hasFoundJesus) {
				
			
				SceneManager.LoadScene (2);


			} 

		

		}
	}
}

