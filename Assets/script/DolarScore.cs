using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DolarScore : MonoBehaviour
{
	public static int hitungDolar;
	Text hitungDolarText;
    // Start is called before the first frame update
    void Start()
    {
    	hitungDolar = 0;
    	hitungDolarText = GetComponent<Text> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        hitungDolarText.text = hitungDolar.ToString();
    }
}
