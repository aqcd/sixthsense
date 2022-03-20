using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoreMountains.TopDownEngine
{
public class WalkingStick : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (WalkingStickManager.hasWalkingStick) {
                Destroy(gameObject);
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Player")
            {
                WalkingStickManager.hasWalkingStick = true;
            }
        }
    }
}