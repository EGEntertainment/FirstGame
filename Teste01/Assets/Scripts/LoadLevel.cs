using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public int Level;

	void Start () {
		
	}
	
	void Update () {
		//Application.LoadLevel ("Level1");	
	}
	
	public void CarregaLevel (int Level){
		Application.LoadLevel (Level);
	}
}