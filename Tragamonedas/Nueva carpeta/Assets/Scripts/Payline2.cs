using UnityEngine;
using System.Collections;

public class Payline2 : MonoBehaviour {

	// Aqui se declaran el valor de las condiciones por figuras
	// Solo lectura de Payline1 Que toma los B1 --- B5
	//...........................
	private int condicionF1B3= 0;
	private int condicionF1B4= 0;
	private int condicionF1B5= 0;
	//...........................
	private int condicionF2B3= 0;
	private int condicionF2B4= 0;
	private int condicionF2B5= 0;
	//...........................
	private int condicionF3B3= 0;
	private int condicionF3B4= 0;
	private int condicionF3B5= 0;
	//...........................
	private int condicionF4B3= 0;
	private int condicionF4B4= 0;
	private int condicionF4B5= 0;
	//...........................
	private int condicionF5B3= 0;
	private int condicionF5B4= 0;
	private int condicionF5B5= 0;
	//...........................
	private int condicionF6B3= 0;
	private int condicionF6B4= 0;
	private int condicionF6B5= 0;
	//...........................
	private int condicionF7B3= 0;
	private int condicionF7B4= 0;
	private int condicionF7B5= 0;
	//...........................



	//===========Experiencia en Linea de pago 2=============
	public int P2L5Exp= 0;
	public int P2L4Exp= 0;
	public int P2L3Exp= 0;
	//======================================================

	// Use this for initialization
	void Start () {
		//recibe notificaciones de las figuras
		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax5");
		NotificationCenter.DefaultCenter ().AddObserver (this,"CilindrosDetenidos");
		//-------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "BB1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BB2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BB3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BB4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BB5");
		//------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B5");
		
	}
	void CilindrosDetenidos(){
		Inicio ();
	}
	//--------------------Suma a la Var Condicion-------------------------------------------
	//.................Bonus....................
	void BB1(){
		condicionF1B3 += 1;
		condicionF1B4 += 1;
		condicionF1B5 += 1;
	}
	void BB2(){
		condicionF1B3 += 1;
		condicionF1B4 += 1;
		condicionF1B5 += 1;
	}
	void BB3(){
		condicionF1B3 += 1;
		condicionF1B4 += 1;
		condicionF1B5 += 1;
	}
	void BB4(){
		condicionF1B3 -= 1;
		condicionF1B4 += 1;
		condicionF1B5 += 1;
	}
	void BB5(){
		condicionF1B4 -= 1;
		condicionF1B5 += 1;
	}
	//..................f1.......................
	void F1B1(){
		condicionF1B3 += 1;
		condicionF1B4 += 1;
		condicionF1B5 += 1;
		
	}
	void F1B2(){
		condicionF1B3 += 1;
		condicionF1B4 += 1;
		condicionF1B5 += 1;
		
	}
	void F1B3(){
		condicionF1B3 += 1;
		condicionF1B4 += 1;
		condicionF1B5 += 1;
		
	}
	void F1B4(){
		condicionF1B3 -= 1;
		condicionF1B4 += 1;
		condicionF1B5 += 1;
		
	}
	void F1B5(){
		condicionF1B4 -= 1;
		condicionF1B5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f2.......................
	void F2B1(){
		condicionF2B3 += 1;
		condicionF2B4 += 1;
		condicionF2B5 += 1;
		
	}
	void F2B2(){
		condicionF2B3 += 1;
		condicionF2B4 += 1;
		condicionF2B5 += 1;
		
	}
	void F2B3(){
		condicionF2B3 += 1;
		condicionF2B4 += 1;
		condicionF2B5 += 1;
		
	}
	void F2B4(){
		condicionF2B3 -= 1;
		condicionF2B4 += 1;
		condicionF2B5 += 1;
		
	}
	void F2B5(){
		condicionF2B4 -= 1;
		condicionF2B5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f3.......................
	void F3B1(){
		condicionF3B3 += 1;
		condicionF3B4 += 1;
		condicionF3B5 += 1;
		
	}
	void F3B2(){
		condicionF3B3 += 1;
		condicionF3B4 += 1;
		condicionF3B5 += 1;
		
	}
	void F3B3(){
		condicionF3B3 += 1;
		condicionF3B4 += 1;
		condicionF3B5 += 1;
		
	}
	void F3B4(){
		condicionF3B3 -= 1;
		condicionF3B4 += 1;
		condicionF3B5 += 1;
		
	}
	void F3B5(){
		condicionF3B4 -= 1;
		condicionF3B5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f4.......................
	void F4B1(){
		condicionF4B3 += 1;
		condicionF4B4 += 1;
		condicionF4B5 += 1;
		
	}
	void F4B2(){
		condicionF4B3 += 1;
		condicionF4B4 += 1;
		condicionF4B5 += 1;
		
	}
	void F4B3(){
		condicionF4B3 += 1;
		condicionF4B4 += 1;
		condicionF4B5 += 1;
		
	}
	void F4B4(){
		condicionF4B3 -= 1;
		condicionF4B4 += 1;
		condicionF4B5 += 1;
		
	}
	void F4B5(){
		condicionF4B4 -= 1;
		condicionF4B5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f5.......................
	void F5B1(){
		condicionF5B3 += 1;
		condicionF5B4 += 1;
		condicionF5B5 += 1;
		
	}
	void F5B2(){
		condicionF5B3 += 1;
		condicionF5B4 += 1;
		condicionF5B5 += 1;
		
	}
	void F5B3(){
		condicionF5B3 += 1;
		condicionF5B4 += 1;
		condicionF5B5 += 1;
		
	}
	void F5B4(){
		condicionF5B3 -= 1;
		condicionF5B4 += 1;
		condicionF5B5 += 1;
		
	}
	void F5B5(){
		condicionF5B4 -= 1;
		condicionF5B5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f6.......................
	void F6B1(){
		condicionF6B3 += 1;
		condicionF6B4 += 1;
		condicionF6B5 += 1;
		
	}
	void F6B2(){
		condicionF6B3 += 1;
		condicionF6B4 += 1;
		condicionF6B5 += 1;
		
	}
	void F6B3(){
		condicionF6B3 += 1;
		condicionF6B4 += 1;
		condicionF6B5 += 1;
		
	}
	void F6B4(){
		condicionF6B3 -= 1;
		condicionF6B4 += 1;
		condicionF6B5 += 1;
		
	}
	void F6B5(){
		condicionF6B4 -= 1;
		condicionF6B5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f7.......................
	void F7B1(){
		condicionF7B3 += 1;
		condicionF7B4 += 1;
		condicionF7B5 += 1;
		
	}
	void F7B2(){
		condicionF7B3 += 1;
		condicionF7B4 += 1;
		condicionF7B5 += 1;
		
	}
	void F7B3(){
		condicionF7B3 += 1;
		condicionF7B4 += 1;
		condicionF7B5 += 1;
		
	}
	void F7B4(){
		condicionF7B3 -= 1;
		condicionF7B4 += 1;
		condicionF7B5 += 1;
		
	}
	void F7B5(){
		condicionF7B4 -= 1;
		condicionF7B5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	
	// Update is called once per frame
	
	//--------------------------------------Condiciones-----------------------------
	//---------------------------------------------1-------------------------------------------
	void Update () {
		}
	void Parallax5(){
		if (condicionF1B5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura1B5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L5exp", P2L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF1B4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1B4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L4exp", P2L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF1B3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1B3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L3exp", P2L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------2-----------------------------------------------
		
		if (condicionF2B5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura2B5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L5exp", P2L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF2B4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2B4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L4exp", P2L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF2B3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2B3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L3exp", P2L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------3---------------------------------------------
		
		if (condicionF3B5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura3B5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L5exp", P2L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF3B4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3B4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L4exp", P2L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF3B3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3B3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L3exp", P2L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------4---------------------------------------------
		
		if (condicionF4B5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura4B5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L5exp", P2L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF4B4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4B4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L4exp", P2L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF4B3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4B3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L3exp", P2L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------5-----------------------------------------------
		
		if (condicionF5B5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura5B5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L5exp", P2L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF5B4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5B4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L4exp", P2L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF5B3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5B3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L3exp", P2L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//---------------------------------------------6-------------------------------------------
		
		if (condicionF6B5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura6B5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L5exp", P2L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF6B4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6B4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L4exp", P2L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF6B3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6B3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L3exp", P2L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//------------------------------------------7----------------------------------------------
		
		if (condicionF7B5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura7B5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L5exp", P2L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF7B4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7B4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L4exp", P2L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF7B3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7B3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P2L3exp", P2L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	}
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------
	
	void Inicio(){
		condicionF1B3 = 0;
		condicionF1B4 = 0;
		condicionF1B5 = 0;
		//.................
		condicionF2B3 = 0;
		condicionF2B4 = 0;
		condicionF2B5 = 0;
		//.................
		condicionF3B3 = 0;
		condicionF3B4 = 0;
		condicionF3B5 = 0;
		//.................
		condicionF4B3 = 0;
		condicionF4B4 = 0;
		condicionF4B5 = 0;
		//.................
		condicionF5B3 = 0;
		condicionF5B4 = 0;
		condicionF5B5 = 0;
		//.................
		condicionF6B3 = 0;
		condicionF6B4 = 0;
		condicionF6B5 = 0;
		//.................
		condicionF7B3 = 0;
		condicionF7B4 = 0;
		condicionF7B5 = 0;
	}
	
}