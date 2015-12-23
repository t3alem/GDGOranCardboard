using UnityEngine;
using System.Collections;

public class AutoDestrcution : MonoBehaviour {

	public float dure = 2.0f;
	private float beginigTime;

	// Use this for initialization
	void Start () {
		beginigTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > beginigTime + dure) {
			Destroy(gameObject);
		}
	}
}
