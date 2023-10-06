using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class BehaviorPlayer    
{
    //public static float velocity=0.0f;
    public static void Motion(PlayerUnit unit)
    {
        
        {
            //velocity=0.0f;
            if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftShift))  
            {
                if (unit.velocity < Time.deltaTime * unit.speed)
                {
                    unit.velocity+=Time.deltaTime *unit.acceleration;
                }
                else if (unit.velocity > Time.deltaTime * unit.speed)
                {
                    unit.velocity-=Time.deltaTime *unit.deceleration;
                }
                //velocity = Vector3.forward * Time.deltaTime * PlayerUnit.speed;  
                unit.transform.Translate(Vector3.forward * unit.velocity);  
            
            }  
            else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift))
            {
                if (unit.velocity < Time.deltaTime * unit.speed*2)
                {
                    unit.velocity+=Time.deltaTime *unit.acceleration;
                }
                //velocity = Vector3.forward * Time.deltaTime * PlayerUnit.speed;  
                unit.transform.Translate(Vector3.forward * unit.velocity);  
            }
            else{
                while (unit.velocity > 0){
                    unit.velocity-=unit.velocity*unit.deceleration;
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
        NetworkAnimator netAnim;
        anim=unit.GetComponent<Animator>();
        netAnim=unit.GetComponent<NetworkAnimator>();

        VelocityHash=Animator.StringToHash("velocity");

        anim.SetFloat(VelocityHash,unit.velocity);

    }
}
