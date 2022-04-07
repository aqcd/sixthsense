using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathText : MonoBehaviour
{
    public static DeathText instance;

    [SerializeField]
    public Text textField;

    private string[] texts = new string[]{  "Did you know there are varying degrees of blindness - only about 10-15% of people are completely blind?",
                                            "Did you know 2-8% of visually impaired people use a white cane to navigate - the rest use guide dogs or nothing at all?",
                                            "Did you know visually impaired people rely mainly on audio, tactile and memorised ground level features to navigate?",
                                            "Did you know the lack of tactile points and raised curbs makes it difficult for the visually impaired to identify streets?",
                                            "Did you know to always ask first before offering any help to a visually impaired person?",
                                            "Did you know that guide dogs cannot read traffic lights but are trained to stop at intersections?",
                                            "Did you know that the leading cause of blindness is age-related cataracts?",
                                            "Did you know that you are not supposed to pet a guide dog while they are at work?",
                                            "Did you know that the visually impaired do not have sharper hearing, instead they learn to pay more attention to sounds?",
                                            "Did you know that many public spaces are exploring bluetooth technology to provide visually impaired with audio cues from their smartphones?",
                                            };
    
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