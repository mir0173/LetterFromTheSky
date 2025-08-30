using UnityEngine;
using System.Collections.Generic;

public class DialogueManager5 : MonoBehaviour
{
    public TextAsset csvFile41;
    public TextAsset csvFile42;
    public TextAsset csvFile43;
    public TextAsset csvFile44;
    public TextAsset csvFile45;
    public TextAsset csvFile46;

    public class DialogueLine
    {
        public int id;
        public string detail;
    }
    public static List<DialogueLine> lines41 = new List<DialogueLine>();
    public static List<DialogueLine> lines42 = new List<DialogueLine>();
    public static List<DialogueLine> lines43 = new List<DialogueLine>();
    public static List<DialogueLine> lines44 = new List<DialogueLine>();
    public static List<DialogueLine> lines45 = new List<DialogueLine>();
    public static List<DialogueLine> lines46 = new List<DialogueLine>();

    void Start()
    {
        LoadCSV41();
        LoadCSV42();
        LoadCSV43();
        LoadCSV44();
        LoadCSV45();
        LoadCSV46();
    }
    void LoadCSV41()
    {
        string[] rows = csvFile41.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines41.Add(dialogue);
        }
    }
    void LoadCSV42()
    {
        string[] rows = csvFile42.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines42.Add(dialogue);
        }
    }
    void LoadCSV43()
    {
        string[] rows = csvFile43.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines43.Add(dialogue);
        }
    }
    void LoadCSV44()
    {
        string[] rows = csvFile44.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines44.Add(dialogue);
        }
    }
    void LoadCSV45()
    {
        string[] rows = csvFile45.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines45.Add(dialogue);
        }
    }
    void LoadCSV46()
    {
        string[] rows = csvFile46.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines46.Add(dialogue);
        }
    }
}
