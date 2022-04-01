using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class ResetManager : MonoBehaviour
{
    public static ResetManager instance;

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
        MoreMountains.TopDownEngine.GUIManager.Instance.SetWinScreen(false);
        FieldOfVision.instance.Reset();
        PostProcessingManager.instance.Reset();
        WalkingStickManager.hasWalkingStick = false;
        StickAnimatorManager.instance.NoStick();
        Timer.instance.Reset();
        Timer.instance.StartTimer();
        WinSplashManager.instance.Reset();
        DeathText.instance.Reset();
    }
}