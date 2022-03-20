using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    public float speed = 6;

    [SerializeField]
    public bool isGoingLeft = false;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 20);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 originalPosition = gameObject.transform.position;
        Vector3 deltaPosition = new Vector3((isGoingLeft ? -1 : 1) * speed * Time.deltaTime, 0, 0);
        gameObject.transform.position = originalPosition + deltaPosition;
    }
}
