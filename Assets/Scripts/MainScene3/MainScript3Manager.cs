using TMPro;
using UnityEngine;
using System.Collections;
public class MainScript3Manager : MonoBehaviour
{
    public static bool isCantalk;
    public static TextMeshProUGUI script;
    public TextMeshProUGUI scriptInInspector;

    void Awake()
    {
        script = scriptInInspector;
    }

    public static IEnumerator PrintScript21(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager3.lines21[index].detail.Length; i++)
        {
            script.text = DialogueManager3.lines21[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript22(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager3.lines22[index].detail.Length; i++)
        {
            script.text = DialogueManager3.lines22[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript24(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager3.lines24[index].detail.Length; i++)
        {
            script.text = DialogueManager3.lines24[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }
    
    public static IEnumerator PrintScript25(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager3.lines25[index].detail.Length; i++)
        {
            script.text = DialogueManager3.lines25[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }
}
