using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcAdd : MonoBehaviour {
	public int Num1;
	public int Num2;
	int Total;

	void Start(){	

	 	Calc(Num1,Num2);

		Calc(12, 23);

		Calc(3,16); 
	 
	}

	public void Calc(int One, int Two){

		Total = One + Two;

		print(Total);
		debug.log("Hello Everyone!");
	}

	
}
