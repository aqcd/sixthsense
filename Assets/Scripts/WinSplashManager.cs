using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class WinSplashManager : MonoBehaviour
{
    public static WinSplashManager instance;

    private bool won = false;

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
        if (!won && (PlayerPositionManager.instance.position.y > 195.0f)) {
            MoreMountains.TopDownEngine.GUIManager.Instance.SetWinScreen(true);
            won = true;
        }
    }

    public void Reset() {
        StartCoroutine(ResetWin());
    }

    IEnumerator ResetWin()
    {
        yield return new WaitForSeconds(5);

        won = false;
    }
}