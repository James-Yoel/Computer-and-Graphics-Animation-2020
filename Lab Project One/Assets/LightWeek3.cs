using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightWeek3 : MonoBehaviour
{
    public GameObject GameObject;//to get the position in worldspace to which this gameObject will rotate around.
 
     [Header("The axis by which it will rotate around")]
     public Vector3 axis = new Vector3(0, 1, 0);//by which axis it will rotate. x,y or z.
 
 
     // Update is called once per frame
     void Update ()
     {
         //Gets the position of your 'Turret' and rotates this gameObject around it by the 'axis' provided at speed 'angle' in degrees per update 
         transform.RotateAround(GameObject.transform.position, axis, -(12.5f * Time.deltaTime));
     }
}