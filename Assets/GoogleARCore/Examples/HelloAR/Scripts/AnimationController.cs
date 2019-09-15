using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //The object that contains this behaviour manages the sofa animations
    private Animator sofaAnim;

    //Functions that manage animations
    public void setForward() {
        sofaAnim.SetBool("Forward", true);
        sofaAnim.SetBool("Backward", false);
    }
    public void setBackward() {
        sofaAnim.SetBool("Forward", false);
        sofaAnim.SetBool("Backward", true);
    }

    // Start is called before the first frame update
    void Start()
    {
        sofaAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
