using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfVision : MonoBehaviour
{
    public static FieldOfVision instance;

    [SerializeField]
    public GameObject obj;

    [Header("Settings")]
    [SerializeField]
    public float initialScale = 20f;
    public float rateOfDecrease = 0.01f;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.transform.localScale.x > 3) {
            float dec = rateOfDecrease * Time.deltaTime;
            obj.transform.localScale -= new Vector3(dec, dec, dec);
        }
    }

    public void Reset()
    {
        obj.transform.localScale = new Vector3(initialScale, initialScale, initialScale);
    }
}
