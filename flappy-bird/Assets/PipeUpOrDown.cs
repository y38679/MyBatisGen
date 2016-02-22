using UnityEngine;
using System.Collections;

public class PipeUpOrDown : MonoBehaviour {

	void OnCollisionEnter(Collision other){
		print ("OnCollisionEnter");
		if(other.gameObject.tag=="Player"){
			GameManager._intance.GameState=GameManager.GAMESTATE_END;
		}
	}

}
