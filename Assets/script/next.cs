using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnGUI(){
    	GUI.contentColor = Color.white;
    	if(GUI.Button(new Rect(Screen.width/2-50,Screen.height/2 +150,100,40),"Next Level?")){
    		Application.LoadLevel(3);
    	}

        
    }
}
