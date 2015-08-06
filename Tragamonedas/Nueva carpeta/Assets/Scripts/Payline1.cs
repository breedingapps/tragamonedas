using UnityEngine;
using System.Collections;

public class Payline1 : MonoBehaviour {

	// Aqui se declaran el valor de las condiciones por figuras
	// Solo lectura de Payline1 Que toma los A1 --- A5
	//...........................
	private int condicionF1A3= 0;
	private int condicionF1A4= 0;
	private int condicionF1A5= 0;
	//...........................
	private int condicionF2A3= 0;
	private int condicionF2A4= 0;
	private int condicionF2A5= 0;
	//...........................
	private int condicionF3A3= 0;
	private int condicionF3A4= 0;
	private int condicionF3A5= 0;
	//...........................
	private int condicionF4A3= 0;
	private int condicionF4A4= 0;
	private int condicionF4A5= 0;
	//...........................
	private int condicionF5A3= 0;
	private int condicionF5A4= 0;
	private int condicionF5A5= 0;
	//...........................
	private int condicionF6A3= 0;
	private int condicionF6A4= 0;
	private int condicionF6A5= 0;
	//...........................
	private int condicionF7A3= 0;
	private int condicionF7A4= 0;
	private int condicionF7A5= 0;


	//===========Experiencia en Linea de pago 1=============
					public int P1L5Exp= 0;
					public int P1L4Exp= 0;
					public int P1L3Exp= 0;
	//======================================================


	//...........................
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax5");
		NotificationCenter.DefaultCenter ().AddObserver (this,"CilindrosDetenidos");
		//recibe notificaciones de las figuras
		NotificationCenter.DefaultCenter ().AddObserver (this, "BA1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BA2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BA3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BA4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BA5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1A5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2A5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3A5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4A5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5A5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6A5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7A4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7A5");

	}

	void CilindrosDetenidos(){
		Inicio ();
	}
	//--------------------Suma a la Var Condicion-------------------------------------------
	//................Bonus.....................
	void BA1(){
		condicionF1A3 += 1;
		condicionF1A3 += 1;
		condicionF1A5 += 1;
	}

	void BA2(){
		condicionF1A3 += 1;
		condicionF1A4 += 1;
		condicionF1A5 += 1;
	}
	void BA3(){
		condicionF1A3 += 1;
		condicionF1A4 += 1;
		condicionF1A5 += 1;
	}
	void BA4(){
		condicionF1A3 -= 1;
		condicionF1A4 += 1;
		condicionF1A5 += 1;
	}
	void BA5(){
		condicionF1A4 -= 1;
		condicionF1A5 += 1;
	}
	//..................f1.......................
	void F1A1(){
		condicionF1A3 += 1;
		condicionF1A4 += 1;
		condicionF1A5 += 1;

	}
	void F1A2(){
		condicionF1A3 += 1;
		condicionF1A4 += 1;
		condicionF1A5 += 1;
		
	}
	void F1A3(){
		condicionF1A3 += 1;
		condicionF1A4 += 1;
		condicionF1A5 += 1;
		
	}
	void F1A4(){
		condicionF1A3 -= 1;
		condicionF1A4 += 1;
		condicionF1A5 += 1;
	//	conA4 = true;

		
	}
	void F1A5(){
		condicionF1A4 -= 1;
		condicionF1A5 += 1;
	
	}

	//-----------------------------------------------------------------------------
	//..................f2.......................
	void F2A1(){
		condicionF2A3 += 1;
		condicionF2A4 += 1;
		condicionF2A5 += 1;
		
	}
	void F2A2(){
		condicionF2A3 += 1;
		condicionF2A4 += 1;
		condicionF2A5 += 1;

		
	}
	void F2A3(){
		condicionF2A3 += 1;
		condicionF2A4 += 1;
		condicionF2A5 += 1;

	}
	void F2A4(){
		condicionF2A3 -= 1;
		condicionF2A4 += 1;
		condicionF2A5 += 1;

		
	}
	void F2A5(){

		condicionF2A4 -= 1;
		condicionF2A5 += 1;

	}
	//-----------------------------------------------------------------------------
	//..................f3.......................
	void F3A1(){
		condicionF3A3 += 1;
		condicionF3A4 += 1;
		condicionF3A5 += 1;
		
	}
	void F3A2(){
		condicionF3A3 += 1;
		condicionF3A4 += 1;
		condicionF3A5 += 1;
		
	}
	void F3A3(){
		condicionF3A3 += 1;
		condicionF3A4 += 1;
		condicionF3A5 += 1;
		
	}
	void F3A4(){
		condicionF3A3 -= 1;
		condicionF3A4 += 1;
		condicionF3A5 += 1;
		
	}
	void F3A5(){

		condicionF3A4 -= 1;
		condicionF3A5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f4.......................
	void F4A1(){
		condicionF4A3 += 1;
		condicionF4A4 += 1;
		condicionF4A5 += 1;
		
	}
	void F4A2(){
		condicionF4A3 += 1;
		condicionF4A4 += 1;
		condicionF4A5 += 1;
		
	}
	void F4A3(){
		condicionF4A3 += 1;
		condicionF4A4 += 1;
		condicionF4A5 += 1;
		
	}
	void F4A4(){
		condicionF4A3 -= 1;
		condicionF4A4 += 1;
		condicionF4A5 += 1;
	}
	void F4A5(){

		condicionF4A4 -= 1;
		condicionF4A5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f5.......................
	void F5A1(){
		condicionF5A3 += 1;
		condicionF5A4 += 1;
		condicionF5A5 += 1;
		
	}
	void F5A2(){
		condicionF5A3 += 1;
		condicionF5A4 += 1;
		condicionF5A5 += 1;
		
	}
	void F5A3(){
		condicionF5A3 += 1;
		condicionF5A4 += 1;
		condicionF5A5 += 1;
		
	}
	void F5A4(){
		condicionF5A3 -= 1;
		condicionF5A4 += 1;
		condicionF5A5 += 1;
		
	}
	void F5A5(){

		condicionF5A4 -= 1;
		condicionF5A5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f6.......................
	void F6A1(){
		condicionF6A3 += 1;
		condicionF6A4 += 1;
		condicionF6A5 += 1;
		
	}
	void F6A2(){
		condicionF6A3 += 1;
		condicionF6A4 += 1;
		condicionF6A5 += 1;
		
	}
	void F6A3(){
		condicionF6A3 += 1;
		condicionF6A4 += 1;
		condicionF6A5 += 1;
		
	}
	void F6A4(){
		condicionF6A3 -= 1;
		condicionF6A4 += 1;
		condicionF6A5 += 1;
		
	}
	void F6A5(){

		condicionF6A4 -= 1;
		condicionF6A5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f7.......................
	void F7A1(){
		condicionF7A3 += 1;
		condicionF7A4 += 1;
		condicionF7A5 += 1;
		
	}
	void F7A2(){
		condicionF7A3 += 1;
		condicionF7A4 += 1;
		condicionF7A5 += 1;
		
	}
	void F7A3(){
		condicionF7A3 += 1;
		condicionF7A4 += 1;
		condicionF7A5 += 1;
		
	}
	void F7A4(){
		condicionF7A3 -= 1;
		condicionF7A4 += 1;
		condicionF7A5 += 1;
		
	}
	void F7A5(){

		condicionF7A4 -= 1;
		condicionF7A5 += 1;
		
	}
	//-----------------------------------------------------------------------------

	// Update is called once per frame

	//--------------------------------------Condiciones-----------------------------
//---------------------------------------------1-------------------------------------------
	void Update () {
		}
	void Parallax5(){
		if (condicionF1A5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura1A5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L5exp", P1L5Exp);
			Invoke("Inicio", 1.0f);


		}
		if (condicionF1A4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1A4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L4exp", P1L4Exp);
			Invoke("Inicio", 1.0f);

		}
		if (condicionF1A3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1A3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L3exp", P1L3Exp);

			Invoke("Inicio", 1.0f);
		
		}
	
	//---------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------

	//-----------------------------------------2-----------------------------------------------

		if (condicionF2A5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura2A5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L5exp", P1L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF2A4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2A4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L4exp");
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF2A3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2A3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L3exp", P1L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------

	//-------------------------------------------3---------------------------------------------

		if (condicionF3A5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura3A5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L5exp", P1L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF3A4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3A4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L4exp", P1L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF3A3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3A3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L3exp", P1L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------

	//-------------------------------------------4---------------------------------------------

		if (condicionF4A5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura4A5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L5exp", P1L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF4A4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4A4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L4exp", P1L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF4A3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4A3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L3exp", P1L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------

	//-----------------------------------------5-----------------------------------------------

		if (condicionF5A5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura5A5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L5exp", P1L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF5A4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5A4");

			NotificationCenter.DefaultCenter().PostNotification(this,"P1L4exp", P1L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF5A3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5A3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L3exp", P1L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------

	//---------------------------------------------6-------------------------------------------

		if (condicionF6A5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura6A5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L5exp", P1L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF6A4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6A4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L4exp", P1L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF6A3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6A3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L3exp", P1L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------

	//------------------------------------------7----------------------------------------------

		if (condicionF7A5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura7A5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L5exp", P1L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF7A4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7A4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L4exp", P1L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF7A3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7A3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P1L3exp", P1L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	}
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------
	
	void Inicio(){
		condicionF1A3 = 0;
		condicionF1A4 = 0;
		condicionF1A5 = 0;
		//................
		condicionF2A3 = 0;
		condicionF2A4 = 0;
		condicionF2A5 = 0;
		//................
		condicionF3A3 = 0;
		condicionF3A4 = 0;
		condicionF3A5 = 0;
		//................
		condicionF4A3 = 0;
		condicionF4A4 = 0;
		condicionF4A5 = 0;
		//................
		condicionF5A3 = 0;
		condicionF5A4 = 0;
		condicionF5A5 = 0;
		//................
		condicionF6A3 = 0;
		condicionF6A4 = 0;
		condicionF6A5 = 0;
		//................
		condicionF7A3 = 0;
		condicionF7A4 = 0;
		condicionF7A5 = 0;
		//................
	}

}
