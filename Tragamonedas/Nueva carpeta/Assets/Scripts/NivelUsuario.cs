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



	//--------------p1----------------
	void P1L5exp(Notification DataExp){
		ExpActual += (int)DataExp.data;

	}
	void P1L4exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P1L3exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	//-------------------------------

	//---------------p2---------------
	void P2L5exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P2L4exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P2L3exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	//-------------------------------

	//--------------p3----------------
	void P3L5exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P3L4exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P3L3exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	//-------------------------------

	//--------------p4----------------
	void P4L5exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P4L4exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P4L3exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	//-------------------------------

	//-------------p5-----------------
	void P5L5exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P5L4exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P5L3exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	//-------------------------------

	//-------------p6-----------------
	void P6L5exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P6L4exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P6L3exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	//-------------------------------

	//-------------p7-----------------
	void P7L5exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P7L4exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P7L3exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	//-------------------------------

	//---------------p8---------------
	void P8L5exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P8L4exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P8L3exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	//-------------------------------

	//----------------p9--------------
	void P9L5exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P9L4exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	void P9L3exp(Notification DataExp){
		ExpActual += (int)DataExp.data;
		
	}
	//-------------------------------





	// Update is called once per frame
	void Update () {
		Debug.Log (ExpActual);
		if (ExpActual >= 100) {
			LevelData = 2;	
			Debug.Log("Nivel2");
		}

		if (LevelData == 1) {

			ExpMaxima= 100;

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
		if (LevelData == 2) {

			ExpMaxima= 200;
			
			nivel1= false;
			nivel2= true;
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
