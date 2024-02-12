using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene : MonoBehaviour
{
   
public GameObject player;
public GameObject cutsceneCamera;

public Animator mugfuckingdies;  

void OnTriggerEnter (Collider collisionInfo){

if (collisionInfo.gameObject.tag == "Player"){
	cutsceneCamera.SetActive(true);
	player.SetActive(false);
	mugfuckingdies.SetTrigger("mugtrigger");
	Debug.Log("help girl");
}

}

}
