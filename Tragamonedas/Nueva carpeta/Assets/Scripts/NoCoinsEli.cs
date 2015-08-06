using UnityEngine;
using System.Collections;

public class NoCoinsEli : MonoBehaviour {
	private Animator animator;

	void Awake(){
		animator = GetComponent<Animator>();
	}
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "showActive");
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
	
	}
	void showActive(){
		animator.SetBool ("show", true);
	}
}
