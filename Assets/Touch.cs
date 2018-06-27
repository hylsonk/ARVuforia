using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {

    public GameObject spider;
    Animator animator;
    

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        int nbTouches = Input.touchCount;
        
        if(nbTouches> 0)
        {
            for(int i = 0; i< nbTouches; i++)
            {
                TouchPhase phase = Input.GetTouch(i).phase;
                switch (phase)
                {
                    case TouchPhase.Began:
                        print("New touch detected");
                       
                        animator.SetBool("walk", true);
                   
                        break;
                    case TouchPhase.Stationary:
                        print("New touch stationary");
                        break;
                    case TouchPhase.Ended:
                        
                        animator.SetBool("walk", false);
                        print("New touch stationary");
                        break;

                }
            }
        }
	}
}
