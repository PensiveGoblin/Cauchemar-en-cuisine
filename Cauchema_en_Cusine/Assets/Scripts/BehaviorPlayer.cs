using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class BehaviorPlayer    
{
    public static void Motion(PlayerUnit unit)
    {
        
            {
                if (Input.GetKey(KeyCode.UpArrow))  
                {  
                    unit.transform.Translate(Vector3.forward * Time.deltaTime*PlayerUnit.speed);  
                }  
                 
                if (Input.GetKey(KeyCode.DownArrow))  
                {  
                    unit.transform.Translate(Vector3.back * Time.deltaTime);  
                }  
                 
                if (Input.GetKey(KeyCode.LeftArrow))  
                {  
                    unit.transform.Rotate(Vector3.up, -10);  
                }  
                
                if (Input.GetKey(KeyCode.RightArrow))  
                {  
                    unit.transform.Rotate(Vector3.up, 10);  
                }
            }
        
    }
}
