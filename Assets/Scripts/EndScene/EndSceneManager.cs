using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class EndSceneManager : MonoBehaviour
{
    private int key;
    private int setkey;
    public CanvasGroup fadeimg;
    public CanvasGroup textcanvas;
    public CanvasGroup endcanvas;
    public TextMeshProUGUI endtext;
    private int textindex;
    void Awake()
    {
        endtext.text = "";
        textindex = 0;
        setkey = PlayerPrefs.GetInt("key");
        key = 0;
        textcanvas.blocksRaycasts = false;
        endcanvas.blocksRaycasts = false;
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
        textcanvas.DOFade(1, 1).SetDelay(2)
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
        if (Input.GetKeyDown(KeyCode.Escape) && key == 0)
        {
            DOTween.KillAll();
            SceneManager.LoadScene("StartScene");
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


        if (key == 1 && setkey == 51)
        {
            endtext.text = "첫 번째 엔딩, 맑음(희망)";
            endcanvas.DOFade(1, 2).SetDelay(1)
            .OnComplete(() =>
            {
                endcanvas.blocksRaycasts = true;
            });
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                fadeimg.DOFade(1, 2)
                .OnComplete(() =>
                {
                    PlayerPrefs.SetInt("Ending1", 1);
                    PlayerPrefs.Save();
                    DOTween.KillAll();
                    SceneManager.LoadScene("StartScene");
                });
            }
        }
        if (key == 1 && setkey == 52)
        {
            endtext.text = "두 번째 엔딩, 바람(변화)";
            endcanvas.DOFade(1, 2).SetDelay(1)
            .OnComplete(() =>
            {
                endcanvas.blocksRaycasts = true;
            });
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                fadeimg.DOFade(1, 2)
                .OnComplete(() =>
                {
                    PlayerPrefs.SetInt("Ending2", 1);
                    PlayerPrefs.Save();
                    DOTween.KillAll();
                    SceneManager.LoadScene("StartScene");
                });
            }
        }
        if (key == 1 && setkey == 53)
        {
            endtext.text = "세 번째 엔딩, 안개(망각)";
            endcanvas.DOFade(1, 2).SetDelay(1)
            .OnComplete(() =>
            {
                endcanvas.blocksRaycasts = true;
            });
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                fadeimg.DOFade(1, 2)
                .OnComplete(() =>
                {
                    PlayerPrefs.SetInt("Ending3", 1);
                    PlayerPrefs.Save();
                    DOTween.KillAll();
                    SceneManager.LoadScene("StartScene");
                });
            }
        }
        if (key == 1 && setkey == 54)
        {
            endtext.text = "네 번째 엔딩, 구름(무기력)";
            endcanvas.DOFade(1, 2).SetDelay(1)
            .OnComplete(() =>
            {
                endcanvas.blocksRaycasts = true;
            });
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                fadeimg.DOFade(1, 2)
                .OnComplete(() =>
                {
                    PlayerPrefs.SetInt("Ending4", 1);
                    PlayerPrefs.Save();
                    DOTween.KillAll();
                    SceneManager.LoadScene("StartScene");
                });
            }
        }
        if (key == 1 && setkey == 55)
        {
            endtext.text = "다섯 번째 엔딩, 비(슬픔)";
            endcanvas.DOFade(1, 2).SetDelay(1)
            .OnComplete(() =>
            {
                endcanvas.blocksRaycasts = true;
            });
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                fadeimg.DOFade(1, 2)
                .OnComplete(() =>
                {
                    PlayerPrefs.SetInt("Ending5", 1);
                    PlayerPrefs.Save();
                    DOTween.KillAll();
                    SceneManager.LoadScene("StartScene");
                });
            }
        }
        if (key == 1 && setkey == 56)
        {
            endtext.text = "여섯 번째 엔딩, 눈(고독)";
            endcanvas.DOFade(1, 2).SetDelay(1)
            .OnComplete(() =>
            {
                endcanvas.blocksRaycasts = true;
            });
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                fadeimg.DOFade(1, 2)
                .OnComplete(() =>
                {
                    PlayerPrefs.SetInt("Ending6", 1);
                    PlayerPrefs.Save();
                    DOTween.KillAll();
                    SceneManager.LoadScene("StartScene");
                });                
            }
        }
        
    }
}
