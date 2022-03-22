using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class FieldOfVisionManager : MonoBehaviour
{
    public static FieldOfVisionManager instance;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        FieldOfVision.instance.Reset();
        PostProcessingManager.instance.Reset();
    }
}