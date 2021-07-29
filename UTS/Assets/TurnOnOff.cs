using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class TurnOnOff : MonoBehaviour

{
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {       
        if(Input.GetKey(KeyCode.Q))
            this.GetComponent<Light>().enabled = true;

        if(Input.GetKey(KeyCode.E))
            this.GetComponent<Light>().enabled = false;

    }
        
}
