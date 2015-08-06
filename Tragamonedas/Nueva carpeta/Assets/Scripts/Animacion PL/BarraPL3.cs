using UnityEngine;
using System.Collections;

public class BarraPL3 : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Awake(){
		animator = GetComponent<Animator>();
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL3C5");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL3C5stop");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL3C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL3C4stop");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL3C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL3C3stop");
		NotificationCenter.DefaultCenter ().AddObserver (this, "HidePL3");
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPL1");
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPL2");
	}
	void Start () {

	
	}
	void ActivePL3C5(){
		animator.SetBool ("WinPL3C5", true);
	}
	void ActivePL3C5stop(){
		animator.SetBool ("WinPL3C5", false);
	}

	//-------------------------------------
	void ActivePL3C4(){
		animator.SetBool ("WinPL3C4", true);
		animator.SetBool ("ReturnPL3", false);
	}
	void ActivePL3C4stop(){
		animator.SetBool ("WinPL3C4", false);
	}
	//---------------------------------

	void ActivePL3C3(){
		animator.SetBool ("WinPL3C3", true);
		animator.SetBool ("ReturnPL3", false);
	}
	void ActivePL3C3stop(){
		animator.SetBool ("WinPL3C3", false);
	}
	//---------------------------------
	void HidePL3(){
		gameObject.SetActive (false);
	}

	void BotonPL1(){
		animator.SetBool ("ReturnPL3", true);
	}
	void BotonPL2(){
		animator.SetBool ("ReturnPL3", true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
