using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon2 : MonoBehaviour
{
    public GameObject myballoon;  

    void Start()
    {
        LeanTween.moveY(myballoon, 2, 4).setLoopPingPong();
                //(myballoon(object name), 5 (speed/distance?), 3 second (time) 
}
}