using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField]
    public float speed = 6;

    [SerializeField]
    public bool isGoingLeft = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Destroy(gameObject, 20);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 originalPosition = gameObject.transform.position;
        Vector3 deltaPosition = new Vector3((isGoingLeft ? -1 : 1) * speed * Time.deltaTime, 0, 0);
        gameObject.transform.position = originalPosition + deltaPosition;
        
        if (Vector3.Distance(gameObject.transform.position, PlayerPositionManager.instance.position) < 10.0f) {
            audioSource.mute = false;
            audioSource.panStereo = (gameObject.transform.position.x - PlayerPositionManager.instance.position.x) / 10.0f;
        } else {
            audioSource.mute = true;
        }
    }
}
