using TMPro;
using UnityEngine;
using System.Collections;
public class MainScriptManager : MonoBehaviour
{
    public static bool isCantalk;
    public static TextMeshProUGUI script;
    public TextMeshProUGUI scriptInInspector;

    void Awake()
    {
        script = scriptInInspector;
    }
    
    public static IEnumerator PrintScript(int index)
    {
        isCantalk = false; 
        script.text = "";

        for (int i = 0; i < DialogueManager.lines1[index].detail.Length; i++)
        {
            script.text = DialogueManager.lines1[index].detail[..(i + 1)];
            yield return new WaitForSeconds(0.05f);
        }

        isCantalk = true; 
    }
}
