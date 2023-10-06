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
        public int speed = 5;
        static public int health = 10;
        static public int speedRotation = 2;
        public float acceleration = 0.1f;
        public float deceleration = 1f;
        public float velocity = 0.0f;

        
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
                acceleration=0.1f;
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
            Debug.Log("Velocity: "+velocity);
            //}
            
        }

        
    }
}