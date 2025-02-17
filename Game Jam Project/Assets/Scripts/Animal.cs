using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float hungerLevels = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hungerLevels -= 1;

        if(hungerLevels <= 30)
        {
            // // Insert code for exclamation animation
        }
        
    }
}
