using UnityEngine;
using System.Collections;

public class Payline3 : MonoBehaviour {

	// Aqui se declaran el valor de las condiciones por figuras
	// Solo lectura de Payline1 Que toma los C1 --- C5
	private int condicionF1C3= 0;
	private int condicionF1C4= 0;
	private int condicionF1C5= 0;
	//...........................
	private int condicionF2C3= 0;
	private int condicionF2C4= 0;
	private int condicionF2C5= 0;
	//...........................
	private int condicionF3C3= 0;
	private int condicionF3C4= 0;
	private int condicionF3C5= 0;
	//...........................
	private int condicionF4C3= 0;
	private int condicionF4C4= 0;
	private int condicionF4C5= 0;
	//...........................
	private int condicionF5C3= 0;
	private int condicionF5C4= 0;
	private int condicionF5C5= 0;
	//...........................
	private int condicionF6C3= 0;
	private int condicionF6C4= 0;
	private int condicionF6C5= 0;
	//...........................
	private int condicionF7C3= 0;
	private int condicionF7C4= 0;
	private int condicionF7C5= 0;

	//===========Experiencia en Linea de pago 3=============
	public int P3L5Exp= 0;
	public int P3L4Exp= 0;
	public int P3L3Exp= 0;
	//======================================================

	// Use this for initialization
	void Start () {
		//recibe notificaciones de las figuras
		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax5");
		NotificationCenter.DefaultCenter ().AddObserver (this,"CilindrosDetenidos");
		//-------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "BC1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BC2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BC3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BC4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BC5");
		//-------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F1C5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F2C5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F3C5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F4C5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F5C5");
		//--------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F6C5");
		//---------------------------------------------------------------
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7C1");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7C2");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7C3");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7C4");
		NotificationCenter.DefaultCenter ().AddObserver (this, "F7C5");
		
	}
	void CilindrosDetenidos(){
		Inicio ();
	}
	//--------------------Suma a la Var Condicion-------------------------------------------
	//..................Bonus........................
	void BC1(){
		condicionF1C3 += 1;
		condicionF1C4 += 1;
		condicionF1C5 += 1;
		
	}
	void BC2(){
		condicionF1C3 += 1;
		condicionF1C4 += 1;
		condicionF1C5 += 1;
		
	}
	void BC3(){
		condicionF1C3 += 1;
		condicionF1C4 += 1;
		condicionF1C5 += 1;
		
	}
	void BC4(){
		condicionF1C3 -= 1;
		condicionF1C4 += 1;
		condicionF1C5 += 1;
		
	}
	void BC5(){
		condicionF1C4 -= 1;
		condicionF1C5 += 1;
		
	}
	//..................f1.......................
	void F1C1(){
		condicionF1C3 += 1;
		condicionF1C4 += 1;
		condicionF1C5 += 1;
		
	}
	void F1C2(){
		condicionF1C3 += 1;
		condicionF1C4 += 1;
		condicionF1C5 += 1;
		
	}
	void F1C3(){
		condicionF1C3 += 1;
		condicionF1C4 += 1;
		condicionF1C5 += 1;
		
	}
	void F1C4(){
		condicionF1C3 -= 1;
		condicionF1C4 += 1;
		condicionF1C5 += 1;
		
	}
	void F1C5(){
		condicionF1C4 -= 1;
		condicionF1C5 += 1;
		
	}
	//-----------------------------------------------------------------------------
	//..................f2.......................
	void F2C1(){
		condicionF2C3 += 1;
		condicionF2C4 += 1;
		condicionF2C5 += 1;
		
	}
	void F2C2(){
		condicionF2C3 += 1;
		condicionF2C4 += 1;
		condicionF2C5 += 1;
	}
	void F2C3(){
		condicionF2C3 += 1;
		condicionF2C4 += 1;
		condicionF2C5 += 1;
	}
	void F2C4(){
		condicionF2C3 -= 1;
		condicionF2C4 += 1;
		condicionF2C5 += 1;
	}
	void F2C5(){
		condicionF2C4 += 1;
		condicionF2C5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f3.......................
	void F3C1(){
		condicionF3C3 += 1;
		condicionF3C4 += 1;
		condicionF3C5 += 1;
	}
	void F3C2(){
		condicionF3C3 += 1;
		condicionF3C4 += 1;
		condicionF3C5 += 1;
	}
	void F3C3(){
		condicionF3C3 += 1;
		condicionF3C4 += 1;
		condicionF3C5 += 1; 
		
	}
	void F3C4(){
		condicionF3C3 -= 1;
		condicionF3C4 += 1;
		condicionF3C5 += 1;
	}
	void F3C5(){
		condicionF3C4 -= 1;
		condicionF3C5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f4.......................
	void F4C1(){
		condicionF4C3 += 1;
		condicionF4C4 += 1;
		condicionF4C5 += 1;
		
	}
	void F4C2(){
		condicionF4C3 += 1;
		condicionF4C4 += 1;
		condicionF4C5 += 1;
	}
	void F4C3(){
		condicionF4C3 += 1;
		condicionF4C4 += 1;
		condicionF4C5 += 1;
	}
	void F4C4(){
		condicionF4C3 -= 1;
		condicionF4C4 += 1;
		condicionF4C5 += 1;
	}
	void F4C5(){
		condicionF4C4 -= 1;
		condicionF4C5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f5.......................
	void F5C1(){
		condicionF5C3 += 1;
		condicionF5C4 += 1;
		condicionF5C5 += 1;
	}
	void F5C2(){
		condicionF5C3 += 1;
		condicionF5C4 += 1;
		condicionF5C5 += 1;
	}
	void F5C3(){
		condicionF5C3 += 1;
		condicionF5C4 += 1;
		condicionF5C5 += 1;
	}
	void F5C4(){
		condicionF5C3 -= 1;
		condicionF5C4 += 1;
		condicionF5C5 += 1;
	}
	void F5C5(){
		condicionF5C4 -= 1;
		condicionF5C5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f6.......................
	void F6C1(){
		condicionF6C3 += 1;
		condicionF6C4 += 1;
		condicionF6C5 += 1;
	}
	void F6C2(){
		condicionF6C3 += 1;
		condicionF6C4 += 1;
		condicionF6C5 += 1;
	}
	void F6C3(){
		condicionF6C3 += 1;
		condicionF6C4 += 1;
		condicionF6C5 += 1;
	}
	void F6C4(){
		condicionF6C3 -= 1;
		condicionF6C4 += 1;
		condicionF6C5 += 1;
	}
	void F6C5(){
		condicionF6C4 -= 1;
		condicionF6C5 += 1;
	}
	//-----------------------------------------------------------------------------
	//..................f7.......................
	void F7C1(){
		condicionF7C3 += 1;
		condicionF7C4 += 1;
		condicionF7C5 += 1;
	}
	void F7C2(){
		condicionF7C3 += 1;
		condicionF7C4 += 1;
		condicionF7C5 += 1;
	}
	void F7C3(){
		condicionF7C3 += 1;
		condicionF7C4 += 1;
		condicionF7C5 += 1;
	}
	void F7C4(){
		condicionF7C3 -= 1;
		condicionF7C4 += 1;
		condicionF7C5 += 1;
	}
	void F7C5(){
		condicionF7C4 -= 1;
		condicionF7C5 += 1;
	}
	//-----------------------------------------------------------------------------
	
	// Update is called once per frame
	
	//--------------------------------------Condiciones-----------------------------
	//---------------------------------------------1-------------------------------------------
	void Update () {
		}
	void Parallax5(){
		if (condicionF1C5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura1C5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L5exp",P3L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF1C4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1C4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L4exp", P3L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF1C3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura1C3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L3exp", P3L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------2-----------------------------------------------
		
		if (condicionF2C5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura2C5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L5exp",P3L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF2C4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2C4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L4exp", P3L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF2C3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura2C3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L3exp", P3L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------3---------------------------------------------
		
		if (condicionF3C5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura3C5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L5exp",P3L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF3C4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3C4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L4exp", P3L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF3C3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura3C3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L3exp", P3L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-------------------------------------------4---------------------------------------------
		
		if (condicionF4C5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura4C5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L5exp",P3L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF4C4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4C4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L4exp", P3L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF4C3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura4C3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L3exp", P3L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//-----------------------------------------5-----------------------------------------------
		
		if (condicionF5C5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura5C5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L5exp",P3L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF5C4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5C4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L4exp", P3L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF5C3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura5C3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L3exp", P3L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//---------------------------------------------6-------------------------------------------
		
		if (condicionF6C5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura6C5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L5exp",P3L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF6C4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6C4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L4exp", P3L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF6C3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura6C3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L3exp", P3L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
		
		//---------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------
		
		//------------------------------------------7----------------------------------------------
		
		if (condicionF7C5 == 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "Figura7C5");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L5exp",P3L5Exp);
			Invoke("Inicio", 1.0f);
			
			
		}
		if (condicionF7C4 == 4) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7C4");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L4exp", P3L4Exp);
			Invoke("Inicio", 1.0f);
			
		}
		if (condicionF7C3 == 3) {
			NotificationCenter.DefaultCenter().PostNotification(this, "Figura7C3");
			NotificationCenter.DefaultCenter().PostNotification(this,"P3L3exp", P3L3Exp);
			
			Invoke("Inicio", 1.0f);
			
		}
	}
	//---------------------------------------------------------------------------------------
	//-------------------------------------------------------------------------------------------
	
	void Inicio(){
		condicionF1C3 = 0;
		condicionF1C4 = 0;
		condicionF1C5 = 0;
		//................
		condicionF2C3 = 0;
		condicionF2C4 = 0;
		condicionF2C5 = 0;
		//................
		condicionF3C3 = 0;
		condicionF3C4 = 0;
		condicionF3C5 = 0;
		//................
		condicionF4C3 = 0;
		condicionF4C4 = 0;
		condicionF4C5 = 0;
		//................
		condicionF5C3 = 0;
		condicionF5C4 = 0;
		condicionF5C5 = 0;
		//................
		condicionF6C3 = 0;
		condicionF6C4 = 0;
		condicionF6C5 = 0;
		//................
		condicionF7C3 = 0;
		condicionF7C4 = 0;
		condicionF7C5 = 0;
	}
	
}