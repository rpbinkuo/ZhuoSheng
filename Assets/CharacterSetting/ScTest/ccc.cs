using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ccc : MonoBehaviour
{
    public VRTK_SlideObjectControlAction ss;
    public VRTK_SlideObjectControlAction yy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Test.dd)
        {
            ss.maximumSpeed = 8f;
            yy.maximumSpeed = 8f;
        }
    }
}
