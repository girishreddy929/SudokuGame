using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public void Loadlevel(string name){
		Application.LoadLevel (name);
	}

	public void Exitrequest(){
		Application.Quit ();
	}



}
