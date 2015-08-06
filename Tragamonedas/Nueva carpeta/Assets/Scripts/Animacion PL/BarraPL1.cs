using UnityEngine;
using System.Collections;

public class BarraPL1 : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Awake(){
		animator = GetComponent<Animator>();

		NotificationCenter.DefaultCenter ().AddObserver (this, "HidePL1");

		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL1A5");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL1A5stop");

		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL1A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL1A4stop");

		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL1A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL1A3stop");


		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPL1");
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPL2");
	}
	void Start () {

	
	}
	void ActivePL1A5(){
		animator.SetBool ("WinPL1A5", true);
	}
	void ActivePL1A5stop(){
		animator.SetBool ("WinPL1A5", false);
	}

	//-------------------------------------
	void ActivePL1A4(){
		animator.SetBool ("WinPL1A4", true);
		animator.SetBool ("ReturnPL1", false);
	}
	void ActivePL1A4stop(){
		animator.SetBool ("WinPL1A4", false);
	}
	//---------------------------------

	void ActivePL1A3(){
		animator.SetBool ("WinPL1A3", true);
		animator.SetBool ("ReturnPL1", false);
	}
	void ActivePL1A3stop(){
		animator.SetBool ("WinPL1A3", false);
	}
	//---------------------------------
	void HidePL1(){
		gameObject.SetActive (false);
	}

	void BotonPL1(){
		animator.SetBool ("ReturnPL1", true);
	}
	void BotonPL2(){
		animator.SetBool ("ReturnPL1", true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
