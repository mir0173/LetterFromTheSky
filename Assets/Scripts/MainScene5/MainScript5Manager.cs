using TMPro;
using UnityEngine;
using System.Collections;
public class MainScript5Manager : MonoBehaviour
{
    public static bool isCantalk;
    public static TextMeshProUGUI script;
    public TextMeshProUGUI scriptInInspector;

    void Awake()
    {
        script = scriptInInspector;
    }

    public static IEnumerator PrintScript41(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager5.lines41[index].detail.Length; i++)
        {
            script.text = DialogueManager5.lines41[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript42(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager5.lines42[index].detail.Length; i++)
        {
            script.text = DialogueManager5.lines42[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript43(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager5.lines43[index].detail.Length; i++)
        {
            script.text = DialogueManager5.lines43[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript44(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager5.lines44[index].detail.Length; i++)
        {
            script.text = DialogueManager5.lines44[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript45(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager5.lines45[index].detail.Length; i++)
        {
            script.text = DialogueManager5.lines45[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }
    
    public static IEnumerator PrintScript46(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager5.lines46[index].detail.Length; i++)
        {
            script.text = DialogueManager5.lines46[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }
}
