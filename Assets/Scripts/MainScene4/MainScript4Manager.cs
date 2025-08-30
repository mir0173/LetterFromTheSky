using TMPro;
using UnityEngine;
using System.Collections;
public class MainScript4Manager : MonoBehaviour
{
    public static bool isCantalk;
    public static TextMeshProUGUI script;
    public TextMeshProUGUI scriptInInspector;

    void Awake()
    {
        script = scriptInInspector;
    }

    public static IEnumerator PrintScript31(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager4.lines31[index].detail.Length; i++)
        {
            script.text = DialogueManager4.lines31[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript33(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager4.lines33[index].detail.Length; i++)
        {
            script.text = DialogueManager4.lines33[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript34(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager4.lines34[index].detail.Length; i++)
        {
            script.text = DialogueManager4.lines34[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }
    
    public static IEnumerator PrintScript35(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager4.lines35[index].detail.Length; i++)
        {
            script.text = DialogueManager4.lines35[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }
}
