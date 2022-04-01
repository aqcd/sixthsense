using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfVision : MonoBehaviour
{
    public static FieldOfVision instance;

    [SerializeField]
    public GameObject obj;

    [SerializeField]
    public GameObject square;

    [Header("Settings")]
    [SerializeField]
    public float initialScale = 20f;
    public float rateOfDecrease = 0.01f;

    public float initialAlpha = 0.95f;
    public float rateOfIncrease = 0.002f;

    private SpriteRenderer sr;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        sr = square.GetComponent<SpriteRenderer>();
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.transform.localScale.x > 3) {
            float dec = rateOfDecrease * Time.deltaTime;
            obj.transform.localScale -= new Vector3(dec, dec, dec);
        }
        if (sr.color.a < 255) {
            Color tmp = sr.color;
            tmp.a = tmp.a + rateOfIncrease * Time.deltaTime;
            sr.color = tmp;
        }
    }

    public void Reset()
    {
        obj.transform.localScale = new Vector3(initialScale, initialScale, initialScale);
        Color tmp = sr.color;
        tmp.a = initialAlpha;
        sr.color = tmp;
    }
}
