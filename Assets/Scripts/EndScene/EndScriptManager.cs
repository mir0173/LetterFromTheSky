using TMPro;
using UnityEngine;
using System.Collections;
public class EndScriptManager : MonoBehaviour
{
    public static bool isCantalk;
    public static TextMeshProUGUI script;
    public TextMeshProUGUI scriptInInspector;

    void Awake()
    {
        script = scriptInInspector;
    }

    public static IEnumerator PrintScript51(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManagerEnd.lines51[index].detail.Length; i++)
        {
            script.text = DialogueManagerEnd.lines51[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript52(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManagerEnd.lines52[index].detail.Length; i++)
        {
            script.text = DialogueManagerEnd.lines52[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript53(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManagerEnd.lines53[index].detail.Length; i++)
        {
            script.text = DialogueManagerEnd.lines53[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript54(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManagerEnd.lines54[index].detail.Length; i++)
        {
            script.text = DialogueManagerEnd.lines54[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }

    public static IEnumerator PrintScript55(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManagerEnd.lines55[index].detail.Length; i++)
        {
            script.text = DialogueManagerEnd.lines55[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }
    
    public static IEnumerator PrintScript56(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManagerEnd.lines56[index].detail.Length; i++)
        {
            script.text = DialogueManagerEnd.lines56[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }
}
