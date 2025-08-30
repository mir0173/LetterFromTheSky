using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class EndSceneManager : MonoBehaviour
{
    private int key;
    private int setkey;
    public CanvasGroup fadeimg;
    public CanvasGroup textcanvas;
    private int textindex;
    void Awake()
    {
        textindex = 0;
        setkey = PlayerPrefs.GetInt("key");
        key = 0;
        textcanvas.blocksRaycasts = false;
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
        textcanvas.DOFade(1, 1)
        .OnComplete(() =>
        {
            textcanvas.blocksRaycasts = true;
            if (setkey == 51)
            {
                StartCoroutine(EndScriptManager.PrintScript51(textindex++));
            }
            else if (setkey == 52)
            {
                StartCoroutine(EndScriptManager.PrintScript52(textindex++));
            }
            else if (setkey == 53)
            {
                StartCoroutine(EndScriptManager.PrintScript53(textindex++));
            }
            else if (setkey == 54)
            {
                StartCoroutine(EndScriptManager.PrintScript54(textindex++));
            }
            else if (setkey == 55)
            {
                StartCoroutine(EndScriptManager.PrintScript55(textindex++));
            }
            else if (setkey == 56)
            {
                StartCoroutine(EndScriptManager.PrintScript56(textindex++));     
            }
        });
    }
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
        if (key == 0 && setkey == 51 && textindex < 8 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            StartCoroutine(EndScriptManager.PrintScript51(textindex++));
        }
        else if (key == 0 && setkey == 51 && textindex == 8 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                EndScriptManager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 52 && textindex < 9 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            StartCoroutine(EndScriptManager.PrintScript52(textindex++));
        }
        else if (key == 0 && setkey == 52 && textindex == 9 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                EndScriptManager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 53 && textindex < 10 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            StartCoroutine(EndScriptManager.PrintScript53(textindex++));
        }
        else if (key == 0 && setkey == 53 && textindex == 10 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                EndScriptManager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 54 && textindex < 7 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            StartCoroutine(EndScriptManager.PrintScript54(textindex++));
        }
        else if (key == 0 && setkey == 54 && textindex == 7 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                EndScriptManager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 55 && textindex < 6 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            StartCoroutine(EndScriptManager.PrintScript55(textindex++));
        }
        else if (key == 0 && setkey == 55 && textindex == 6 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                EndScriptManager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 56 && textindex < 7 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            StartCoroutine(EndScriptManager.PrintScript56(textindex++));
        }
        else if (key == 0 && setkey == 56 && textindex == 7 && Input.GetMouseButtonUp(0) && EndScriptManager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                EndScriptManager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
    }
}
