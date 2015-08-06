using UnityEngine;
using System.Collections;

public class NivelUsuario : MonoBehaviour {
	private int ExpMaxima=0;
	private int ExpActual= 0;
	private int LevelData=1;


	private bool nivel1= false;
	private bool nivel2= false;
	private bool nivel3= false;
	private bool nivel4= false;
	private bool nivel5= false;
	private bool nivel6= false;
	// Use this for initialization
	void Start () {

		//-------------------------------------------------------------//
		NotificationCenter.DefaultCenter().AddObserver(this,"P1L5exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P1L4exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P1L3exp");
		//==========================================================
		NotificationCenter.DefaultCenter().AddObserver(this,"P2L5exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P2L4exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P2L3exp");
		//==========================================================
		NotificationCenter.DefaultCenter().AddObserver(this,"P3L5exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P3L4exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P3L3exp");
		//==========================================================
		NotificationCenter.DefaultCenter().AddObserver(this,"P4L5exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P4L4exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P4L3exp");
		//===========================================================
		NotificationCenter.DefaultCenter().AddObserver(this,"P5L5exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P5L4exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P5L3exp");
		//==========================================================
		NotificationCenter.DefaultCenter().AddObserver(this,"P6L5exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P6L4exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P6L3exp");
		//==========================================================
		NotificationCenter.DefaultCenter().AddObserver(this,"P7L5exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P7L4exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P7L3exp");
		//==========================================================
		NotificationCenter.DefaultCenter().AddObserver(this,"P8L5exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P8L4exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P8L3exp");
		//============================================================
		NotificationCenter.DefaultCenter().AddObserver(this,"P9L5exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P9L4exp");
		NotificationCenter.DefaultCenter().AddObserver(this,"P9L3exp");
		//-----------------------------------------------------------//
	}

	void P1L5Exp(Notification DataExp){


	}
	// Update is called once per frame
	void Update () {
		if (LevelData == 1) {
			nivel1= true;
			nivel2= false;
			nivel3=false;
			nivel4= false;
			nivel3=false;
			nivel2= false;
			nivel3=false;
			nivel2= false;
			nivel3=false;

				}
	}
}
