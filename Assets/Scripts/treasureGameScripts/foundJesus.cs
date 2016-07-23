using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class foundJesus : MonoBehaviour {

	public bool hasFoundJesus = false;
	public Transform PlayerCharacter;
	public Text OnScreenText;
	public string EnterText;
	public PlayerMove playerMoveScript;
	// Use this for initialization

	void Update () {
		if ((PlayerCharacter.position - transform.position).magnitude < 5f){
		if (Input.GetKeyDown (KeyCode.Space)) {
			hasFoundJesus = true;
				playerMoveScript.playerSpeed = 600;
		}
		{
			OnScreenText.text = EnterText;
	}
}
}
}