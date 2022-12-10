using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPress = Input.GetKey("w");
        if (forwardPress)
        {
            animator.SetBool("isWalking", true);
        }
        if(!forwardPress)
        {
            animator.SetBool("isWalking", false);
        }
    }
}
