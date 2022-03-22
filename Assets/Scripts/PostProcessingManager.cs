using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using MoreMountains.Tools;

public class PostProcessingManager : MonoBehaviour
{
    public static PostProcessingManager instance;

    [SerializeField]
    public float defaultFocus = 5.0f;

    [SerializeField]
    public float rateOfDecrease = 0.05f;

    private PostProcessVolume ppv;
    
    private PostProcessProfile ppp;

    private DepthOfField dph;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ppv = gameObject.GetComponent<PostProcessVolume>();
        ppp = ppv.profile;
        if (ppp.TryGetSettings<DepthOfField>(out dph))
        {
            dph.focusDistance.value = defaultFocus;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (dph.focusDistance.value > 0.1) {
            dph.focusDistance.value -= rateOfDecrease * Time.deltaTime;
        }
    }

    public void Reset()
    {
        dph.focusDistance.value = defaultFocus;
    }
}