using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public float waterLevels = 100;
    public float waterDecrement = 1;
    public float waterMin = 30;

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

       if(waterLevels > 0)
       {
            waterLevels -= waterDecrement;
       }

    }
}
