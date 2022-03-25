using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class WalkingStickManager : MonoBehaviour
{
    public static WalkingStickManager instance;

    public static bool hasWalkingStick;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hasWalkingStick = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}