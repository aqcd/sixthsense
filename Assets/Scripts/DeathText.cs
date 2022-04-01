using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathText : MonoBehaviour
{
    public static DeathText instance;

    [SerializeField]
    public Text textField;

    private string[] texts = new string[]{"1", "2", "3", "4", "5"};
    
    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start() {
        RandomiseText();
    }

    public void Reset() {
        RandomiseText();
    }

    private void RandomiseText()
    {
        textField.text = texts[Random.Range(0, texts.Length - 1)];
    }
}