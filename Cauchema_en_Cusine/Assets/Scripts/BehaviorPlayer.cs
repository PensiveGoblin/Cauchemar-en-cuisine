using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class BehaviorPlayer    
{
    public static float velocity=0.0f;
    public static void Motion(PlayerUnit unit)
    {
        
        {
            velocity=0.0f;
            if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftShift))  
            {
                while (velocity < Time.deltaTime * PlayerUnit.speed)
                {
                    velocity+=PlayerUnit.acceleration;
                }
                //velocity = Vector3.forward * Time.deltaTime * PlayerUnit.speed;  
                unit.transform.Translate(Vector3.forward * velocity);  
            
            }  
            else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift))
            {
                while (velocity < Time.deltaTime * PlayerUnit.speed*2)
                {
                    velocity+=PlayerUnit.acceleration;
                }
                //velocity = Vector3.forward * Time.deltaTime * PlayerUnit.speed;  
                unit.transform.Translate(Vector3.forward * velocity);  
            }
            else{
                while (velocity > 0){
                    velocity-=PlayerUnit.deceleration;
                }
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

    public static void Animate(PlayerUnit unit){
        int VelocityHash;
        Animator anim;
        anim=unit.GetComponent<Animator>();

        VelocityHash=Animator.StringToHash("velocity");

        anim.SetFloat(VelocityHash,velocity);

    }
}
