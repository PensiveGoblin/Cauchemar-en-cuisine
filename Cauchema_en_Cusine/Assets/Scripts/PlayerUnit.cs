using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
namespace Mirror
{
    public class PlayerUnit : NetworkBehaviour
    {
        //Category
        public string category;
        //Default value
        static public int speed = 5;
        static public int health = 10;
        static public int speedRotation = 2;
        // Start is called before the first frame update
        public override void OnStartLocalPlayer()
            {
                Camera.main.transform.SetParent(transform);
                Camera.main.transform.localPosition = new Vector3(0, 0, 0);
                Camera.main.transform.rotation = Quaternion.identity;
            }
        void Start()
        {
            if (category == "soldier")
            {
                speed = 20;
                health = 100;
                speedRotation = 2; 
            }

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (isLocalPlayer)
            {
                BehaviorPlayer.Motion(this);
            }
        }
    }
}