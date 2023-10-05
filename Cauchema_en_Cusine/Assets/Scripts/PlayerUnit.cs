using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
namespace Mirror
{
    public class PlayerUnit : NetworkBehaviour
    {
        Animator anim;
        //Category
        public string category;
        //Default value
        static public int speed = 5;
        static public int health = 10;
        static public int speedRotation = 2;
        static public float acceleration = 0.001f;
        static public float deceleration = 0.05f;

        
        // Start is called before the first frame update
        public override void OnStartLocalPlayer()
            {
                Camera.main.transform.SetParent(transform);
                Camera.main.transform.localPosition = new Vector3(0, 3, -5);
                Camera.main.transform.rotation = Quaternion.identity;
            }
        void Start()
        {
            if (category == "soldier")
            {
                speed = 5;
                health = 100;
                speedRotation = 2; 
                acceleration=0.001f;
            }
            anim=GetComponent<Animator>();

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            
            if (isLocalPlayer)
            {
                BehaviorPlayer.Motion(this);
                BehaviorPlayer.Animate(this);
                
            }
            //if(BehaviorPlayer.velocity>0.5){
            Debug.Log("Velocity: "+BehaviorPlayer.velocity);
            //}
            
        }

        
    }
}