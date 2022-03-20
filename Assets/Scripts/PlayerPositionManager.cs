using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class PlayerPositionManager : MonoBehaviour
{
    public static PlayerPositionManager instance;

    public Vector3 position;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        this.position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.position = gameObject.transform.position;
        Debug.Log(position);
    }
}