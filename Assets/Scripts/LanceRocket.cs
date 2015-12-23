using UnityEngine;
using System.Collections;

public class LanceRocket : MonoBehaviour {

	public GameObject rocket;
	public Transform rocketPosition;
	public Transform head;
	// Use this for initialization

	void OnEnable(){
		Cardboard.SDK.OnTrigger += magnetTrigger;
	}

	void magnetTrigger(){

		GameObject superRocket  = (GameObject) Instantiate(rocket, rocketPosition.position, rocketPosition.rotation);
		superRocket.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000);

	}

	// you can use this also if the first one doesnt work
	/*void TriggerPulled(){

		GameObject superRocket  = (GameObject) Instantiate(rocket, rocketPosition.position, rocketPosition.rotation);
		superRocket.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000);
	}*/

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.Space)) {

			GameObject superRocket  = (GameObject) Instantiate(rocket, rocketPosition.position, rocketPosition.rotation);
			superRocket.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000);

		}
	
	}













}
