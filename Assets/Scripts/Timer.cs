using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    public static Timer instance;

    [SerializeField]
    public Text textField;

    private float time = 0.0f;

    private bool isActive = true;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        textField.text = time.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive) {
            time += Time.deltaTime;
            textField.text = time.ToString();
        }
    }

    public void Reset()
    {
        time = 0.0f;
    }

    public void StartTimer() {
        isActive = true;
    }

    public void StopTimer() {
        isActive = false;
    }

    public string GetTime() {
        return time.ToString();
    }
}