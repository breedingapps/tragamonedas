using UnityEngine;
using System.Collections;

public class BarraPL2 : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Awake(){
		animator = GetComponent<Animator>();
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL2B5");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL2B5stop");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL2B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL2B4stop");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL2B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "ActivePL2B3stop");
		NotificationCenter.DefaultCenter ().AddObserver (this, "HidePL2");
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPL1");
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPL2");
	}
	void Start () {

	
	}
	void ActivePL2B5(){
		animator.SetBool ("WinPL2B5", true);
	}
	void ActivePL2B5stop(){
		animator.SetBool ("WinPL2B5", false);
	}

	//-------------------------------------
	void ActivePL2B4(){
		animator.SetBool ("WinPL2B4", true);
		animator.SetBool ("ReturnPL2", false);
	}
	void ActivePL2B4stop(){
		animator.SetBool ("WinPL2B4", false);
	}
	//---------------------------------

	void ActivePL2B3(){
		animator.SetBool ("WinPL2B3", true);
		animator.SetBool ("ReturnPL2", false);
	}
	void ActivePL2B3stop(){
		animator.SetBool ("WinPL2B3", false);
	}
	//---------------------------------
	void HidePL2(){
		gameObject.SetActive (false);
	}

	void BotonPL1(){
		animator.SetBool ("ReturnPL2", true);
	}
	void BotonPL2(){
		animator.SetBool ("ReturnPL2", true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
