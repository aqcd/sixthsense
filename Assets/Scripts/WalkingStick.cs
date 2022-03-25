using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingStick : MonoBehaviour
{
    private Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (WalkingStickManager.hasWalkingStick) {
            r.enabled = false;
        } else {
            r.enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            WalkingStickManager.hasWalkingStick = true;
            StickAnimatorManager.instance.Stick();
        }
    }
}