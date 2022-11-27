using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Mirror
{
    public class Controller : NetworkBehaviour
    {
            public float speed = 30;
        // Start is called before the first frame update
        void Start()
        {
            
        }
    
        // Update is called once per frame
        void FixedUpdate()
        {
            if (isLocalPlayer)
                {
                    if (Input.GetKey(KeyCode.UpArrow))  
                    {  
                        this.transform.Translate(Vector3.forward * Time.deltaTime);  
                    }  
                     
                    if (Input.GetKey(KeyCode.DownArrow))  
                    {  
                        this.transform.Translate(Vector3.back * Time.deltaTime);  
                    }  
                     
                    if (Input.GetKey(KeyCode.LeftArrow))  
                    {  
                        this.transform.Rotate(Vector3.up, -10);  
                    }  
                    
                    if (Input.GetKey(KeyCode.RightArrow))  
                    {  
                        this.transform.Rotate(Vector3.up, 10);  
                    }
                }
            
        }
    }
}