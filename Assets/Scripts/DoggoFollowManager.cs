using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class DoggoFollowManager : MonoBehaviour
{
    public static DoggoFollowManager instance;

    public GameObject doggo;

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

    public void Doggo()
    {
        doggo.SetActive(true);
    }

    public void Reset()
    {
        doggo.SetActive(false);
    }
}