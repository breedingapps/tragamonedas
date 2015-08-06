using UnityEngine;
using System.Collections;

public class Payline6 : MonoBehaviour {

	// Aqui se declaran el valor de las condiciones por figuras
	// Solo lectura de Payline6
	private int condicionF1P6L3= 0;
	private int condicionF1P6L4= 0;
	private int condicionF1P6L5= 0;
	
	private int condicionF2P6L3= 0;
	private int condicionF2P6L4= 0;
	private int condicionF2P6L5= 0;
	
	private int condicionF3P6L3= 0;
	private int condicionF3P6L4= 0;
	private int condicionF3P6L5= 0;
	
	private int condicionF4P6L3= 0;
	private int condicionF4P6L4= 0;
	private int condicionF4P6L5= 0;
	
	private int condicionF5P6L3= 0;
	private int condicionF5P6L4= 0;
	private int condicionF5P6L5= 0;
	
	private int condicionF6P6L3= 0;
	private int condicionF6P6L4= 0;
	private int condicionF6P6L5= 0;
	
	private int condicionF7P6L3= 0;
	private int condicionF7P6L4= 0;
	private int condicionF7P6L5= 0;

	//===========Experiencia en Linea de pago 6=============
	public int P6L5Exp= 0;
	public int P6L4Exp= 0;
	public int P6L3Exp= 0;
	//======================================================

	// Use this for initialization
	void Start () {
		//recibe notificaciones de las figuras
		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax5");
		NotificationCenter.DefaultCenter ().AddObserver (this,"CilindrosDetenidos");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7A3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B5");
		
	}

	void CilindrosDetenidos(){
		Inicio ();
	}
	//--------------------Suma a la Var Condicion-------------------------------------------
	//..................f1.......................
	void F1B1(){
		condicionF1P6L3 += 1;
		condicionF1P6L4 += 1;
		condicionF1P6L5 += 1;
		
	}
	void F1B2(){
		condicionF1P6L3 += 1;
		condicionF1P6L4 += 1;
		condicionF1P6L5 += 1;
	}
	void F1A3(){
		condicionF1P6L3 += 1;
		condicionF1P6L4 += 1;
		condicionF1P6L5 += 1;
	}
	void F1B4(){
		condicionF1P6L3 -= 1;
		condicionF1P6L4 += 1;
		condicionF1P6L5 += 1;
	}
	void F1B5(){
		condicionF1P6L4 -= 1;
		condicionF1P6L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f2.......................
	void F2B1(){
		condicionF2P6L3 += 1;
		condicionF2P6L4 += 1;
		condicionF2P6L5 += 1;
	}
	void F2B2(){
		condicionF2P6L3 += 1;
		condicionF2P6L4 += 1;
		condicionF2P6L5 += 1;
	}
	void F2A3(){
		condicionF2P6L3 += 1;
		condicionF2P6L4 += 1;
		condicionF2P6L5 += 1;
	}
	void F2B4(){
		condicionF2P6L3 -= 1;
		condicionF2P6L4 += 1;
		condicionF2P6L5 += 1;
	}
	void F2B5(){
		condicionF2P6L4 -= 1;
		condicionF2P6L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f3.......................
	void F3B1(){
		condicionF3P6L3 += 1;
		condicionF3P6L4 += 1;
		condicionF3P6L5 += 1;
	}
	void F3B2(){
		condicionF3P6L3 += 1;
		condicionF3P6L4 += 1;
		condicionF3P6L5 += 1;
	}
	void F3A3(){
		condicionF3P6L3 += 1;
		condicionF3P6L4 += 1;
		condicionF3P6L5 += 1;
	}
	void F3B4(){
		condicionF3P6L3 -= 1;
		condicionF3P6L4 += 1;
		condicionF3P6L5 += 1;
	}
	void F3B5(){
		condicionF3P6L4 -= 1;
		condicionF3P6L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f4.......................
	void F4B1(){
		condicionF4P6L3 += 1;
		condicionF4P6L4 += 1;
		condicionF4P6L5 += 1;
	}
	void F4B2(){
		condicionF4P6L3 += 1;
		condicionF4P6L4 += 1;
		condicionF4P6L5 += 1;
	}
	void F4A3(){
		condicionF4P6L3 += 1;
		condicionF4P6L4 += 1;
		condicionF4P6L5 += 1;
	}
	void F4B4(){
		condicionF4P6L3 -= 1;
		condicionF4P6L4 += 1;
		condicionF4P6L5 += 1;
	}
	void F4B5(){
		condicionF4P6L4 -= 1;
		condicionF4P6L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f5.......................
	void F5B1(){
		condicionF5P6L3 += 1;
		condicionF5P6L4 += 1;
		condicionF5P6L5 += 1;
	}
	void F5B2(){
		condicionF5P6L3 += 1;
		condicionF5P6L4 += 1;
		condicionF5P6L5 += 1;
	}
	void F5A3(){
		condicionF5P6L3 += 1;
		condicionF5P6L4 += 1;
		condicionF5P6L5 += 1;
	}
	void F5B4(){
		condicionF5P6L3 -= 1;
		condicionF5P6L4 += 1;
		condicionF5P6L5 += 1;
	}
	void F5B5(){
		condicionF5P6L4 -= 1;
		condicionF5P6L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f6.......................
	void F6B1(){
		condicionF6P6L3 += 1;
		condicionF6P6L4 += 1;
		condicionF6P6L5 += 1;
	}
	void F6B2(){
		condicionF6P6L3 += 1;
		condicionF6P6L4 += 1;
		condicionF6P6L5 += 1;
	}
	void F6A3(){
		condicionF6P6L3 += 1;
		condicionF6P6L4 += 1;
		condicionF6P6L5 += 1;
	}
	void F6B4(){
		condicionF6P6L3 -= 1;
		condicionF6P6L4 += 1;
		condicionF6P6L5 += 1;
	}
	void F6B5(){
		condicionF6P6L4 -= 1;
		condicionF6P6L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f7.......................
	void F7B1(){
		condicionF7P6L3 += 1;
		condicionF7P6L4 += 1;
		condicionF7P6L5 += 1;
	}
	void F7B2(){
		condicionF7P6L3 += 1;
		condicionF7P6L4 += 1;
		condicionF7P6L5 += 1;
	}
	void F7A3(){
		condicionF7P6L3 += 1;
		condicionF7P6L4 += 1;
		condicionF7P6L5 += 1;
	}
	void F7B4(){
		condicionF7P6L3 -= 1;
		condicionF7P6L4 += 1;
		condicionF7P6L5 += 1;
	}
	void F7B5(){
		condicionF7P6L4 -= 1;
		condicionF7P6L5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	
	// Update is called once per frame
	
	//--------------------------------------Condiciones-----------------------------
	//---------------------------------------------1-------------------------------------------
	void Update () {
		}
	void Parallax5(){
		if (condicionF1P6L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura1P6L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L5exp", P6L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF1P6L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1P6L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L4exp", P6L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF1P6L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1P6L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L3exp", P6L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------2-----------------------------------------------
		
		if (condicionF2P6L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura2P6L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L5exp", P6L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF2P6L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2P6L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L4exp", P6L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF2P6L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2P6L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L3exp", P6L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------3---------------------------------------------
		
		if (condicionF3P6L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura3P6L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L5exp", P6L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF3P6L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3P6L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L4exp", P6L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF3P6L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3P6L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L3exp", P6L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------4---------------------------------------------
		
		if (condicionF4P6L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura4P6L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L5exp", P6L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF4P6L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4P6L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L4exp", P6L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF4P6L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4P6L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L3exp", P6L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------5-----------------------------------------------
		
		if (condicionF5P6L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura5P6L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L5exp", P6L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF5P6L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5P6L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L4exp", P6L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF5P6L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5P6L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L3exp", P6L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//---------------------------------------------6-------------------------------------------
		
		if (condicionF6P6L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura6P6L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L5exp", P6L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF6P6L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6P6L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L4exp", P6L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF6P6L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6P6L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L3exp", P6L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//------------------------------------------7----------------------------------------------
		
		if (condicionF7P6L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura7P6L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L5exp", P6L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF7P6L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7P6L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L4exp", P6L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF7P6L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7P6L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P6L3exp", P6L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	}
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------
	
	void Inicio(){
		condicionF1P6L3 = 0;
		condicionF1P6L4 = 0;
		condicionF1P6L5 = 0;
		
		condicionF2P6L3 = 0;
		condicionF2P6L4 = 0;
		condicionF2P6L5 = 0;
		
		condicionF3P6L3 = 0;
		condicionF3P6L4 = 0;
		condicionF3P6L5 = 0;
		
		condicionF4P6L3 = 0;
		condicionF4P6L4 = 0;
		condicionF4P6L5 = 0;
		
		condicionF5P6L3 = 0;
		condicionF5P6L4 = 0;
		condicionF5P6L5 = 0;
		
		condicionF6P6L3 = 0;
		condicionF6P6L4 = 0;
		condicionF6P6L5 = 0;
		
		condicionF7P6L3 = 0;
		condicionF7P6L4 = 0;
		condicionF7P6L5 = 0;
	}
	
}