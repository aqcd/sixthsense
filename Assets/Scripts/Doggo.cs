using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doggo : MonoBehaviour
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
        if (DoggoManager.hasDoggo) {
            r.enabled = false;
        } else {
            r.enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            DoggoManager.hasDoggo = true;
            DoggoFollowManager.instance.Doggo();
        }
    }
}