using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class DoggoManager : MonoBehaviour
{
    public static DoggoManager instance;

    public static bool hasDoggo;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hasDoggo = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}