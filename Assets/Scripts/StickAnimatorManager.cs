using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class StickAnimatorManager : MonoBehaviour
{
    public static StickAnimatorManager instance;

    [SerializeField]
    public RuntimeAnimatorController noStick;
    
    [SerializeField]
    public RuntimeAnimatorController stick;

    [SerializeField]
    public Animator am;

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

    public void Stick()
    {
        am.runtimeAnimatorController = stick; 
    }

    public void NoStick()
    {
        am.runtimeAnimatorController = noStick; 
    }
}