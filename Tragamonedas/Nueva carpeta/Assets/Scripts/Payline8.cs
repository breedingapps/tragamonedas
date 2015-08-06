using UnityEngine;
using System.Collections;

public class Payline8 : MonoBehaviour {
	// Aqui se declaran el valor de las condiciones por figuras
	// Solo lectura de Payline8
	private int condicionF1P8L3= 0;
	private int condicionF1P8L4= 0;
	private int condicionF1P8L5= 0;
	
	private int condicionF2P8L3= 0;
	private int condicionF2P8L4= 0;
	private int condicionF2P8L5= 0;
	
	private int condicionF3P8L3= 0;
	private int condicionF3P8L4= 0;
	private int condicionF3P8L5= 0;
	
	private int condicionF4P8L3= 0;
	private int condicionF4P8L4= 0;
	private int condicionF4P8L5= 0;
	
	private int condicionF5P8L3= 0;
	private int condicionF5P8L4= 0;
	private int condicionF5P8L5= 0;
	
	private int condicionF6P8L3= 0;
	private int condicionF6P8L4= 0;
	private int condicionF6P8L5= 0;
	
	private int condicionF7P8L3= 0;
	private int condicionF7P8L4= 0;
	private int condicionF7P8L5= 0;

	//===========Experiencia en Linea de pago 8=============
	public int P8L5Exp= 0;
	public int P8L4Exp= 0;
	public int P8L3Exp= 0;
	//======================================================

	// Use this for initialization
	void Start () {
		//recibe notificaciones de las figuras
		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax5");
		NotificationCenter.DefaultCenter ().AddObserver (this,"CilindrosDetenidos");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4B5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5B5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6B5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7A1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7A2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7B5");
		
	}

	void CilindrosDetenidos(){
		Inicio ();
	}
	//--------------------Suma a la Var Condicion-------------------------------------------
	//..................f1.......................
	void F1A1(){
		condicionF1P8L3 += 1;
		condicionF1P8L4 += 1;
		condicionF1P8L5 += 1;
		
	}
	void F1A2(){
		condicionF1P8L3 += 1;
		condicionF1P8L4 += 1;
		condicionF1P8L5 += 1;
	}
	void F1B3(){
		condicionF1P8L3 += 1;
		condicionF1P8L4 += 1;
		condicionF1P8L5 += 1;
	}
	void F1C4(){
		condicionF1P8L3 -= 1;
		condicionF1P8L4 += 1;
		condicionF1P8L5 += 1;
	}
	void F1B5(){
		condicionF1P8L4 -= 1;
		condicionF1P8L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f2.......................
	void F2A1(){
		condicionF2P8L3 += 1;
		condicionF2P8L4 += 1;
		condicionF2P8L5 += 1;
	}
	void F2A2(){
		condicionF2P8L3 += 1;
		condicionF2P8L4 += 1;
		condicionF2P8L5 += 1;
	}
	void F2B3(){
		condicionF2P8L3 += 1;
		condicionF2P8L4 += 1;
		condicionF2P8L5 += 1;
	}
	void F2C4(){
		condicionF2P8L3 -= 1;
		condicionF2P8L4 += 1;
		condicionF2P8L5 += 1;
	}
	void F2B5(){
		condicionF2P8L4 -= 1;
		condicionF2P8L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f3.......................
	void F3A1(){
		condicionF3P8L3 += 1;
		condicionF3P8L4 += 1;
		condicionF3P8L5 += 1;
	}
	void F3A2(){
		condicionF3P8L3 += 1;
		condicionF3P8L4 += 1;
		condicionF3P8L5 += 1;
	}
	void F3B3(){
		condicionF3P8L3 += 1;
		condicionF3P8L4 += 1;
		condicionF3P8L5 += 1;
	}
	void F3C4(){
		condicionF3P8L3 -= 1;
		condicionF3P8L4 += 1;
		condicionF3P8L5 += 1;
	}
	void F3B5(){
		condicionF3P8L4 -= 1;
		condicionF3P8L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f4.......................
	void F4A1(){
		condicionF4P8L3 += 1;
		condicionF4P8L4 += 1;
		condicionF4P8L5 += 1;
	}
	void F4A2(){
		condicionF4P8L3 += 1;
		condicionF4P8L4 += 1;
		condicionF4P8L5 += 1;
	}
	void F4B3(){
		condicionF4P8L3 += 1;
		condicionF4P8L4 += 1;
		condicionF4P8L5 += 1;
	}
	void F4C4(){
		condicionF4P8L3 -= 1;
		condicionF4P8L4 += 1;
		condicionF4P8L5 += 1;
	}
	void F4B5(){
		condicionF4P8L4 -= 1;
		condicionF4P8L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f5.......................
	void F5A1(){
		condicionF5P8L3 += 1;
		condicionF5P8L4 += 1;
		condicionF5P8L5 += 1;
	}
	void F5A2(){
		condicionF5P8L3 += 1;
		condicionF5P8L4 += 1;
		condicionF5P8L5 += 1;
	}
	void F5B3(){
		condicionF5P8L3 += 1;
		condicionF5P8L4 += 1;
		condicionF5P8L5 += 1;
	}
	void F5C4(){
		condicionF5P8L3 -= 1;
		condicionF5P8L4 += 1;
		condicionF5P8L5 += 1;
	}
	void F5B5(){
		condicionF5P8L4 -= 1;
		condicionF5P8L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f6.......................
	void F6A1(){
		condicionF6P8L3 += 1;
		condicionF6P8L4 += 1;
		condicionF6P8L5 += 1;
	}
	void F6A2(){
		condicionF6P8L3 += 1;
		condicionF6P8L4 += 1;
		condicionF6P8L5 += 1;
	}
	void F6B3(){
		condicionF6P8L3 += 1;
		condicionF6P8L4 += 1;
		condicionF6P8L5 += 1;
	}
	void F6C4(){
		condicionF6P8L3 -= 1;
		condicionF6P8L4 += 1;
		condicionF6P8L5 += 1;
	}
	void F6B5(){
		condicionF6P8L4 -= 1;
		condicionF6P8L5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f7.......................
	void F7A1(){
		condicionF7P8L3 += 1;
		condicionF7P8L4 += 1;
		condicionF7P8L5 += 1;
	}
	void F7A2(){
		condicionF7P8L3 += 1;
		condicionF7P8L4 += 1;
		condicionF7P8L5 += 1;
	}
	void F7B3(){
		condicionF7P8L3 += 1;
		condicionF7P8L4 += 1;
		condicionF7P8L5 += 1;
	}
	void F7C4(){
		condicionF7P8L3 -= 1;
		condicionF7P8L4 += 1;
		condicionF7P8L5 += 1;
	}
	void F7B5(){
		condicionF7P8L4 -= 1;
		condicionF7P8L5 += 1;
	}
	//-----------------------------------------------------------------------------
	
	// Update is called once per frame
	
	//--------------------------------------Condiciones-----------------------------
	//---------------------------------------------1-------------------------------------------
	void Update () {
		}
	void Parallax5(){
		if (condicionF1P8L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura1P8L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L5exp", P8L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF1P8L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1P8L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L4exp", P8L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF1P8L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1P8L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L3exp", P8L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------2-----------------------------------------------
		
		if (condicionF2P8L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura2P8L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L5exp", P8L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF2P8L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2P8L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L4exp", P8L4Exp);

			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF2P8L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2P8L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L3exp", P8L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------3---------------------------------------------
		
		if (condicionF3P8L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura3P8L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L5exp", P8L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF3P8L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3P8L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L4exp", P8L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF3P8L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3P8L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L3exp", P8L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------4---------------------------------------------
		
		if (condicionF4P8L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura4P8L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L5exp", P8L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF4P8L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4P8L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L4exp", P8L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF4P8L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4P8L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L3exp", P8L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------5-----------------------------------------------
		
		if (condicionF5P8L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura5P8L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L5exp", P8L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF5P8L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5P8L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L4exp", P8L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF5P8L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5P8L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L3exp", P8L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//---------------------------------------------6-------------------------------------------
		
		if (condicionF6P8L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura6P8L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L5exp", P8L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF6P8L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6P8L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L4exp", P8L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF6P8L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6P8L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L3exp", P8L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//------------------------------------------7----------------------------------------------
		
		if (condicionF7P8L5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura7P8L5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L5exp", P8L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF7P8L4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7P8L4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L4exp", P8L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF7P8L3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7P8L3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P8L3exp", P8L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	}
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------
	
	void Inicio(){
		condicionF1P8L3 = 0;
		condicionF1P8L4 = 0;
		condicionF1P8L5 = 0;
		
		condicionF2P8L3 = 0;
		condicionF2P8L4 = 0;
		condicionF2P8L5 = 0;
		
		condicionF3P8L3 = 0;
		condicionF3P8L4 = 0;
		condicionF3P8L5 = 0;
		
		condicionF4P8L3 = 0;
		condicionF4P8L4 = 0;
		condicionF4P8L5 = 0;
		
		condicionF5P8L3 = 0;
		condicionF5P8L4 = 0;
		condicionF5P8L5 = 0;
		
		condicionF6P8L3 = 0;
		condicionF6P8L4 = 0;
		condicionF6P8L5 = 0;
		
		condicionF7P8L3 = 0;
		condicionF7P8L4 = 0;
		condicionF7P8L5 = 0;
	}
	
}