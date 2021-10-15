using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public GameObject myballoon; 
    public GameObject lightSource; 

    void Start()
    {
        LeanTween.moveY(myballoon, 2, 3).setLoopPingPong();
                //(myballoon(object name), 5 (speed/distance?), 3 second (time) 
    }


}
