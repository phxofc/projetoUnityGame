using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    public GameObject lanterna;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (lanterna.activeSelf)
            {
                lanterna.SetActive(false);
            }
            else{
                lanterna.SetActive(true);
            }
        }
        
    }
}
