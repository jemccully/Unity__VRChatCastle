using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour {

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	void OnTriggerEnter(Collider box) {
		//if (box.CompareTag("Player")) {
			animator.SetBool("Open", true);
			Debug.Log("Open");
		//}			
	}
	
	void OnControllerColliderHit(ControllerColliderHit hit) {
		animator.SetBool("Open", true);
		Debug.Log("Controller open");
	}
	
	void OnTriggerExit(Collider box) {
		//if (box.CompareTag("Player")) {
			animator.SetBool("Close", true);
			Debug.Log("Close");
		//}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
