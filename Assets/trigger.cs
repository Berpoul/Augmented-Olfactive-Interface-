using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UduinoManager.Instance.pinMode(13, PinMode.Output);
    }


    void OnTriggerEnter() //When enterring the collider : Release HIGH
    {
        UduinoManager.Instance.digitalWrite(13, State.HIGH);
        //alternance delay de high low 
        
        Debug.Log("HIGH");
    }

    //ontrigger stay : quand tu es dedans l'action est réalisé 
    //Check tag : si c'est collider 1 VARIE LA FR2QUENCE
    void OnTriggerExit() //When exit the collider : Release LOW
    {
        UduinoManager.Instance.digitalWrite(13, State.LOW);
        Debug.Log("LOW");
    }
}
