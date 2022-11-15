using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{   

    public Canvas canvas;
    // public Button button;

    void OnTriggerEnter2D(Collider2D collider){
        Debug.Log("Entered");
        canvas.enabled = true;
    }

    void Start(){
        canvas.enabled = false;
    }

    void OnButtonPress(){
        Debug.Log("PRESSED");

    }

    void OnTriggerExit2D(Collider2D collider){
        canvas.enabled = false;
        Debug.Log("Exited");
    }
}
