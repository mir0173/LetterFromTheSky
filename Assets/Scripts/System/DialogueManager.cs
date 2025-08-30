using UnityEngine;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public TextAsset csvFile1;

    public class DialogueLine
    {
        public int id;
        public string detail;
    }

    public static List<DialogueLine> lines1 = new List<DialogueLine>();

    void Start()
    {
        LoadCSV1();
    }

    void LoadCSV1()
    {
        string[] rows = csvFile1.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines1.Add(dialogue);
        }
    }
}
