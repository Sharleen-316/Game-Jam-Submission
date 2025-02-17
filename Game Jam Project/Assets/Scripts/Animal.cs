using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float hungerLevels = 100;
    public float hungerDecrement = 1;

    public float hungerMin = 30;

    public float timer = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(hungerLevels <= hungerMin)
        {
            // // Insert code for exclamation animation
        }
        
    }

    private void FixedUpdate()
    {
        Time.fixedDeltaTime = timer;

        if(hungerLevels > 0)
        {
            // // Slowly decreases the animal's hunger levels
            hungerLevels -= hungerDecrement;
            //UnityEngine.Debug.Log(hungerLevels);
        }
    }
}
