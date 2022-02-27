using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
 
    public void gotRed(){
        this.GetComponent<Renderer>().material.color = Color.red;
    }

    public void gotBlue(){
        this.GetComponent<Renderer>().material.color = Color.blue;
    }

    public void gotGreen(){
        this.GetComponent<Renderer>().material.color = Color.green;
    }
}
