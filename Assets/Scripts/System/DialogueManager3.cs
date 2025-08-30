using UnityEngine;
using System.Collections.Generic;

public class DialogueManager3 : MonoBehaviour
{
    public TextAsset csvFile21;
    public TextAsset csvFile22;
    public TextAsset csvFile24;
    public TextAsset csvFile25;

    public class DialogueLine
    {
        public int id;
        public string detail;
    }
    public static List<DialogueLine> lines21 = new List<DialogueLine>();
    public static List<DialogueLine> lines22 = new List<DialogueLine>();
    public static List<DialogueLine> lines24 = new List<DialogueLine>();
    public static List<DialogueLine> lines25 = new List<DialogueLine>();

    void Start()
    {
        LoadCSV21();
        LoadCSV22();
        LoadCSV24();
        LoadCSV25();
    }
    void LoadCSV21()
    {
        string[] rows = csvFile21.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines21.Add(dialogue);
        }
    }
    void LoadCSV22()
    {
        string[] rows = csvFile22.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines22.Add(dialogue);
        }
    }
    void LoadCSV24()
    {
        string[] rows = csvFile24.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines24.Add(dialogue);
        }
    }
    void LoadCSV25()
    {
        string[] rows = csvFile25.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines25.Add(dialogue);
        }
    }
}
