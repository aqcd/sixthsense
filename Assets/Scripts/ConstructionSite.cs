using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructionSite : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, PlayerPositionManager.instance.position) < 10.0f) {
            audioSource.mute = false;
            audioSource.panStereo = (gameObject.transform.position.x - PlayerPositionManager.instance.position.x) / 10.0f;
        } else {
            audioSource.mute = true;
        }
    }
}
