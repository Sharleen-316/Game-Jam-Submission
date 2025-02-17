using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public float waterLevels = 100;
    public float waterDecrement = 1;
    public float waterMin = 30;

    public float timer = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if (waterLevels <= waterMin)
       {
            // // Insert code for wilting animation
       }
    }

    private void FixedUpdate()
    {
        Time.fixedDeltaTime = timer;
        
        if(waterLevels > 0)
       {
            // // Slowly decreases the how much water the plants have
            waterLevels -= waterDecrement;
       }

    }
}
