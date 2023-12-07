using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bengala : MonoBehaviour

    
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)){
            anim.SetInteger("clicou", 1);
        }
    }
    public void setClicouZero()
    {
        anim.SetInteger("clicou", 0);
    }
}
