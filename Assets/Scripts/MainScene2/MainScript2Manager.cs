using TMPro;
using UnityEngine;
using System.Collections;
public class MainScript2Manager : MonoBehaviour
{
    public static bool isCantalk;
    public static TextMeshProUGUI script;
    public TextMeshProUGUI scriptInInspector;

    void Awake()
    {
        script = scriptInInspector;
    }

    public static IEnumerator PrintScript11(int index)
    {
        isCantalk = false;
        script.text = "";

        for (int i = 0; i < DialogueManager2.lines11[index].detail.Length; i++)
        {
            script.text = DialogueManager2.lines11[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true;
    }
    
    public static IEnumerator PrintScript14(int index)
    {
        isCantalk = false; 
        script.text = "";

        for (int i = 0; i < DialogueManager2.lines14[index].detail.Length; i++)
        {
            script.text = DialogueManager2.lines14[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.033f);
        }

        isCantalk = true; 
    }
}
