using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MainScene5Manager : MonoBehaviour
{
    private int key;
    private int setkey;
    public Image background;
    public Sprite bg1;
    public Sprite bg2;
    public Sprite bg3;
    public Sprite bg4;
    public Sprite bg5;
    public Sprite bg6;
    public CanvasGroup fadeimg;
    public CanvasGroup textcanvas;
    public CanvasGroup choosecanvas1;
    public TextMeshProUGUI choose1;
    public TextMeshProUGUI choose11;
    public CanvasGroup choosecanvas2;
    public TextMeshProUGUI choose2;
    public TextMeshProUGUI choose21;
    public TextMeshProUGUI choose22;
    private int textindex;
    void Awake()
    {
        textindex = 0;
        setkey = PlayerPrefs.GetInt("key");
        if (setkey == 41)
        {
            background.sprite = bg1;
        }
        else if (setkey == 42)
        {
            background.sprite = bg2;
        }
        else if (setkey == 43)
        {
            background.sprite = bg3;
        }
        else if (setkey == 44)
        {
            background.sprite = bg4;
        }
        else if (setkey == 45)
        {
            background.sprite = bg5;
        }
        else if (setkey == 46)
        {
            background.sprite = bg6;
        }
        key = 0;
        choose1.text = "";
        choose11.text = "";
        choose2.text = "";
        choose21.text = "";
        choose21.text = "";
        textcanvas.blocksRaycasts = false;
        choosecanvas1.blocksRaycasts = false;
        choosecanvas2.blocksRaycasts = false;
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
        fadeimg.DOFade(0, 2)
        .OnComplete(() =>
        {
            fadeimg.blocksRaycasts = false;
            textcanvas.DOFade(1, 1)
            .OnComplete(() =>
            {
                textcanvas.blocksRaycasts = true;
                if (setkey == 41)
                {
                    StartCoroutine(MainScript5Manager.PrintScript41(textindex++));
                }
                else if (setkey == 42)
                {
                    StartCoroutine(MainScript5Manager.PrintScript42(textindex++));
                }
                else if (setkey == 43)
                {
                    StartCoroutine(MainScript5Manager.PrintScript43(textindex++));
                }
                else if (setkey == 44)
                {
                    StartCoroutine(MainScript5Manager.PrintScript44(textindex++));
                }
                else if (setkey == 45)
                {
                    StartCoroutine(MainScript5Manager.PrintScript45(textindex++));
                }
                else if (setkey == 46)
                {
                    StartCoroutine(MainScript5Manager.PrintScript46(textindex++));     
                }
            });
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
        if (key == 0 && setkey == 41 && textindex < 8 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            StartCoroutine(MainScript5Manager.PrintScript41(textindex++));
        }
        else if (key == 0 && setkey == 41 && textindex == 8 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript5Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 42 && textindex < 8 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            StartCoroutine(MainScript5Manager.PrintScript42(textindex++));
        }
        else if (key == 0 && setkey == 42 && textindex == 8 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript5Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 43 && textindex < 7 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            StartCoroutine(MainScript5Manager.PrintScript43(textindex++));
        }
        else if (key == 0 && setkey == 43 && textindex == 7 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript5Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 44 && textindex < 7 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            StartCoroutine(MainScript5Manager.PrintScript44(textindex++));
        }
        else if (key == 0 && setkey == 44 && textindex == 7 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript5Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 45 && textindex < 6 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            StartCoroutine(MainScript5Manager.PrintScript45(textindex++));
        }
        else if (key == 0 && setkey == 45 && textindex == 6 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript5Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 46 && textindex < 7 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            StartCoroutine(MainScript5Manager.PrintScript46(textindex++));
        }
        else if (key == 0 && setkey == 46 && textindex == 7 && Input.GetMouseButtonUp(0) && MainScript5Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript5Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }



        if (key == 1 && setkey == 41)
        {
            choose1.text = "당신은 계속해서 맑은 길의 종점을 향해 나아간다";
            choose11.text = "엔딩 보러가기(맑음)";
            choosecanvas1.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas1.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas1.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 51;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("EndScene");
                    });
                }
            }
        }
        else if (key == 1 && setkey == 42)
        {
            choose1.text = "당신은 계속해서 바람 부는 길의 종점을 향해 나아간다";
            choose11.text = "엔딩 보러가기(바람)";
            choosecanvas1.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas1.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas1.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 52;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("EndScene");
                    });
                }
            }
        }
        else if (key == 1 && setkey == 43)
        {
            choose1.text = "당신은 계속해서 안개 낀 길의 종점을 향해 나아간다";
            choose11.text = "엔딩 보러가기(안개)";
            choosecanvas1.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas1.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas1.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 53;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("EndScene");
                    });
                }
            }
        }
        else if (key == 1 && setkey == 44)
        {
            choose1.text = "당신은 계속해서 구름 낀 길의 종점을 향해 나아간다";
            choose11.text = "엔딩 보러가기(구름)";
            choosecanvas1.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas1.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas1.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 54;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("EndScene");
                    });
                }
            }
        }
        else if (key == 1 && setkey == 45)
        {
            choose1.text = "당신은 계속해서 비 오는 길의 종점을 향해 나아간다";
            choose11.text = "엔딩 보러가기(비)";
            choosecanvas1.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas1.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas1.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 55;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("EndScene");
                    });
                }
            }
        }
        else if (key == 1 && setkey == 46)
        {
            choose1.text = "당신은 계속해서 눈 오는 길의 종점을 향해 나아간다";
            choose11.text = "엔딩 보러가기(눈)";
            choosecanvas1.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas1.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas1.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 56;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("EndScene");
                    });
                }
            }
        }
    }
}
