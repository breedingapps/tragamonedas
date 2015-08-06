using UnityEngine;
using System.Collections;

public class Payline4 : MonoBehaviour {

	// Aqui se declaran el valor de las condiciones por figuras
	// Solo lectura de Payline4
	private int condicionF1P4L3= 0;
	private int condicionF1P4L4= 0;
	private int condicionF1P4L5= 0;

	private int condicionF2P4L3= 0;
	private int condicionF2P4L4= 0;
	private int condicionF2P4L5= 0;

	private int condicionF3P4L3= 0;
	private int condicionF3P4L4= 0;
	private int condicionF3P4L5= 0;

	private int condicionF4P4L3= 0;
	private int condicionF4P4L4= 0;
	private int condicionF4P4L5= 0;

	private int condicionF5P4L3= 0;
	private int condicionF5P4L4= 0;
	private int condicionF5P4L5= 0;

	private int condicionF6P4L3= 0;
	private int condicionF6P4L4= 0;
	private int condicionF6P4L5= 0;

	private int condicionF7P4L3= 0;
	private int condicionF7P4L4= 0;
	private int condicionF7P4L5= 0;

	//===========Experiencia en Linea de pago 4=============
	public int P4L5Exp= 0;
	public int P4L4Exp= 0;
	public int P4L3Exp= 0;
	//======================================================

	// Use this for initialization
	void Start () {
		//recibe notificaciones de las figuras
		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax5");
		NotificationCenter.DefaultCenter ().AddObserver (this,"CilindrosDetenidos");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1A5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2A5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3A5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4A5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5A5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6A5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7A5");
		
	}

	void CilindrosDetenidos(){
		Inicio ();
	}
	//--------------------Suma a la Var Condicion-------------------------------------------
	//..................f1.......................
	void F1A1(){
		condicionF1P4L3 += 1;
		condicionF1P4L4 += 1;
		condicionF1P4L5 += 1;
		
	}
	void F1B2(){
		condicionF1P4L3 += 1;
		condicionF1P4L4 += 1;
		condicionF1P4L5 += 1;
	}
	void F1C3(){
		condicionF1P4L3 += 1;
		condicionF1P4L4 += 1;
		condicionF1P4L5 += 1;
	}
	void F1B4(){
		condicionF1P4L3 -= 1;
		condicionF1P4L4 += 1;
		condicionF1P4L5 += 1;
	}
	void F1A5(){
		condicionF1P4L4 -= 1;
		condicionF1P4L5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f2.......................
	void F2A1(){
		condicionF2P4L3 += 1;
		condicionF2P4L4 += 1;
		condicionF2P4L5 += 1;
	}
	void F2B2(){
		condicionF2P4L3 += 1;
		condicionF2P4L4 += 1;
		condicionF2P4L5 += 1;
	}
	void F2C3(){
		condicionF2P4L3 += 1;
		condicionF2P4L4 += 1;
		condicionF2P4L5 += 1;
	}
	void F2B4(){
		condicionF2P4L3 -= 1;
		condicionF2P4L4 += 1;
		condicionF2P4L5 += 1;
	}
	void F2A5(){
		condicionF2P4L4 -= 1;
		condicionF2P4L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f3.......................
	void F3A1(){
		condicionF3P4L3 += 1;
		condicionF3P4L4 += 1;
		condicionF3P4L5 += 1;
	}
	void F3B2(){
		condicionF3P4L3 += 1;
		condicionF3P4L4 += 1;
		condicionF3P4L5 += 1;
	}
	void F3C3(){
		condicionF3P4L3 += 1;
		condicionF3P4L4 += 1;
		condicionF3P4L5 += 1;
	}
	void F3B4(){
		condicionF3P4L3 -= 1;
		condicionF3P4L4 += 1;
		condicionF3P4L5 += 1;
	}
	void F3A5(){
		condicionF3P4L4 -= 1;
		condicionF3P4L5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f4.......................
	void F4A1(){
		condicionF4P4L3 += 1;
		condicionF4P4L4 += 1;
		condicionF4P4L5 += 1;
	}
	void F4B2(){
		condicionF4P4L3 += 1;
		condicionF4P4L4 += 1;
		condicionF4P4L5 += 1;
	}
	void F4C3(){
		condicionF4P4L3 += 1;
		condicionF4P4L4 += 1;
		condicionF4P4L5 += 1;
	}
	void F4B4(){
		condicionF4P4L3 -= 1;
		condicionF4P4L4 += 1;
		condicionF4P4L5 += 1;
	}
	void F4A5(){
		condicionF4P4L4 -= 1;
		condicionF4P4L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f5.......................
	void F5A1(){
		condicionF5P4L3 += 1;
		condicionF5P4L4 += 1;
		condicionF5P4L5 += 1;
	}
	void F5B2(){
		condicionF5P4L3 += 1;
		condicionF5P4L4 += 1;
		condicionF5P4L5 += 1;
	}
	void F5C3(){
		condicionF5P4L3 += 1;
		condicionF5P4L4 += 1;
		condicionF5P4L5 += 1;
	}
	void F5B4(){
		condicionF5P4L3 -= 1;
		condicionF5P4L4 += 1;
		condicionF5P4L5 += 1;
	}
	void F5A5(){
		condicionF5P4L4 -= 1;
		condicionF5P4L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f6.......................
	void F6A1(){
		condicionF6P4L3 += 1;
		condicionF6P4L4 += 1;
		condicionF6P4L5 += 1;
	}
	void F6B2(){
		condicionF6P4L3 += 1;
		condicionF6P4L4 += 1;
		condicionF6P4L5 += 1;
	}
	void F6C3(){
		condicionF6P4L3 += 1;
		condicionF6P4L4 += 1;
		condicionF6P4L5 += 1;
	}
	void F6B4(){
		condicionF6P4L3 -= 1;
		condicionF6P4L4 += 1;
		condicionF6P4L5 += 1;
	}
	void F6A5(){
		condicionF6P4L4 -= 1;
		condicionF6P4L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f7.......................
	void F7A1(){
		condicionF7P4L3 += 1;
		condicionF7P4L4 += 1;
		condicionF7P4L5 += 1;
	}
	void F7B2(){
		condicionF7P4L3 += 1;
		condicionF7P4L4 += 1;
		condicionF7P4L5 += 1;
	}
	void F7C3(){
		condicionF7P4L3 += 1;
		condicionF7P4L4 += 1;
		condicionF7P4L5 += 1;
	}
	void F7B4(){
		condicionF7P4L3 -= 1;
		condicionF7P4L4 += 1;
		condicionF7P4L5 += 1;
	}
	void F7A5(){
		condicionF7P4L4 -= 1;
		condicionF7P4L5 += 1;
	}
	//-----------------------------------------------------------------------------
	
	// Update is called once per frame
	
	//--------------------------------------Condiciones-----------------------------
	//---------------------------------------------1-------------------------------------------
	void Update () {
		}
	void Parallax5(){
		if (condicionF1P4L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura1P4L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L5exp", P4L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF1P4L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1P4L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L4exp", P4L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF1P4L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1P4L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L3exp", P4L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------2-----------------------------------------------
		
		if (condicionF2P4L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura2P4L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L5exp", P4L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF2P4L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2P4L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L4exp", P4L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF2P4L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2P4L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L3exp", P4L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------3---------------------------------------------
		
		if (condicionF3P4L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura3P4L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L5exp", P4L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF3P4L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3P4L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L4exp", P4L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF3P4L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3P4L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L3exp", P4L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------4---------------------------------------------
		
		if (condicionF4P4L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura4P4L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L5exp", P4L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF4P4L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4P4L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L4exp", P4L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF4P4L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4P4L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L3exp", P4L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------5-----------------------------------------------
		
		if (condicionF5P4L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura5P4L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L5exp", P4L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF5P4L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5P4L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L4exp", P4L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF5P4L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5P4L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L3exp", P4L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//---------------------------------------------6-------------------------------------------
		
		if (condicionF6P4L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura6P4L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L5exp", P4L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF6P4L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6P4L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L4exp", P4L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF6P4L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6P4L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L3exp", P4L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//------------------------------------------7----------------------------------------------
		
		if (condicionF7P4L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura7P4L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L5exp", P4L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF7P4L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7P4L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L4exp", P4L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF7P4L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7P4L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P4L3exp", P4L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	}
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------
	
	void Inicio(){
		condicionF1P4L3 = 0;
		condicionF1P4L4 = 0;
		condicionF1P4L5 = 0;

		condicionF2P4L3 = 0;
		condicionF2P4L4 = 0;
		condicionF2P4L5 = 0;

		condicionF3P4L3 = 0;
		condicionF3P4L4 = 0;
		condicionF3P4L5 = 0;

		condicionF4P4L3 = 0;
		condicionF4P4L4 = 0;
		condicionF4P4L5 = 0;

		condicionF5P4L3 = 0;
		condicionF5P4L4 = 0;
		condicionF5P4L5 = 0;

		condicionF6P4L3 = 0;
		condicionF6P4L4 = 0;
		condicionF6P4L5 = 0;

		condicionF7P4L3 = 0;
		condicionF7P4L4 = 0;
		condicionF7P4L5 = 0;
	}
	
}