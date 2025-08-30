using UnityEngine;
using System.Collections.Generic;

public class DialogueManager4 : MonoBehaviour
{
    public TextAsset csvFile31;
    public TextAsset csvFile33;
    public TextAsset csvFile34;
    public TextAsset csvFile35;

    public class DialogueLine
    {
        public int id;
        public string detail;
    }
    public static List<DialogueLine> lines31 = new List<DialogueLine>();
    public static List<DialogueLine> lines33 = new List<DialogueLine>();
    public static List<DialogueLine> lines34 = new List<DialogueLine>();
    public static List<DialogueLine> lines35 = new List<DialogueLine>();

    void Start()
    {
        LoadCSV31();
        LoadCSV33();
        LoadCSV34();
        LoadCSV35();
    }
    void LoadCSV31()
    {
        string[] rows = csvFile31.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines31.Add(dialogue);
        }
    }
    void LoadCSV33()
    {
        string[] rows = csvFile33.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines33.Add(dialogue);
        }
    }
    void LoadCSV34()
    {
        string[] rows = csvFile34.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines34.Add(dialogue);
        }
    }
    void LoadCSV35()
    {
        string[] rows = csvFile35.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines35.Add(dialogue);
        }
    }
}
