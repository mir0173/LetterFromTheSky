using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MainScene4Manager : MonoBehaviour
{
    private int key;
    private int setkey;
    public Image background;
    public Sprite bg1;
    public Sprite bg2;
    public Sprite bg3;
    public Sprite bg4;
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
        if (setkey == 31)
        {
            background.sprite = bg1;
        }
        else if (setkey == 33)
        {
            background.sprite = bg2;
        }
        else if (setkey == 34)
        {
            background.sprite = bg3;
        }
        else if (setkey == 35)
        {
            background.sprite = bg4;
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
                if (setkey == 31)
                {
                    StartCoroutine(MainScript4Manager.PrintScript31(textindex++));     
                }
                else if (setkey == 33)
                {
                    StartCoroutine(MainScript4Manager.PrintScript33(textindex++));     
                }
                else if (setkey == 34)
                {
                    StartCoroutine(MainScript4Manager.PrintScript34(textindex++));     
                }
                else if (setkey == 35)
                {
                    StartCoroutine(MainScript4Manager.PrintScript35(textindex++));     
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
        if (key == 0 && setkey == 31 && textindex < 9 && Input.GetMouseButtonUp(0) && MainScript4Manager.isCantalk)
        {
            StartCoroutine(MainScript4Manager.PrintScript31(textindex++));
        }
        else if (key == 0 && setkey == 31 && textindex == 9 && Input.GetMouseButtonUp(0) && MainScript4Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript4Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 33 && textindex < 8 && Input.GetMouseButtonUp(0) && MainScript4Manager.isCantalk)
        {
            StartCoroutine(MainScript4Manager.PrintScript33(textindex++));
        }
        else if (key == 0 && setkey == 33 && textindex == 8 && Input.GetMouseButtonUp(0) && MainScript4Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript4Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 34 && textindex < 7 && Input.GetMouseButtonUp(0) && MainScript4Manager.isCantalk)
        {
            StartCoroutine(MainScript4Manager.PrintScript34(textindex++));
        }
        else if (key == 0 && setkey == 34 && textindex == 7 && Input.GetMouseButtonUp(0) && MainScript4Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript4Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 35 && textindex < 7 && Input.GetMouseButtonUp(0) && MainScript4Manager.isCantalk)
        {
            StartCoroutine(MainScript4Manager.PrintScript35(textindex++));
        }
        else if (key == 0 && setkey == 35 && textindex == 7 && Input.GetMouseButtonUp(0) && MainScript4Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript4Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }

        if (key == 1 && setkey == 31 && PlayerPrefs.GetInt("take1") == 1)
        {
            choose2.text = "당신은 갈림길에 도착했고 또다시 선택의 시간이 다가왔다";
            choose21.text = "왼쪽으로 가기(맑음)";
            choose22.text = "오른쪽으로 가기(바람)";
            choosecanvas2.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas2.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas2.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 41;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene5");
                    });
                }
                if (MouseOnUI.gameObj.name == "script2" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                   .OnComplete(() =>
                   {
                       key = 42;
                       PlayerPrefs.SetInt("key", key);
                       PlayerPrefs.Save();
                       SceneManager.LoadScene("MainScene5");
                   });
                }
            }
        }
        else if (key == 1 && setkey == 31)
        {
            choose1.text = "바람막이를 가져오지 않은 당신은 계속 맑은 길로 나아간다";
            choose11.text = "앞으로 나아가기(맑음)";
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
                        key = 41;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene5");
                    });
                }
            }
        }
        else if (key == 1 && setkey == 33)
        {
            choose1.text = "당신은 계속 안개가 가득한 길로 나아간다";
            choose11.text = "앞으로 나아가기(안개)";
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
                        key = 43;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene5");
                    });
                }
            }
        }
        else if (key == 1 && setkey == 34 && PlayerPrefs.GetInt("Ending1") == 1)
        {
            choose2.text = "당신은 갈림길에 도착했고 또다시 선택의 시간이 다가왔다";
            choose21.text = "왼쪽으로 가기(맑음)";
            choose22.text = "오른쪽으로 가기(구름)";
            choosecanvas2.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas2.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas2.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 41;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene5");
                    });
                }
                if (MouseOnUI.gameObj.name == "script2" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                   .OnComplete(() =>
                   {
                       key = 44;
                       PlayerPrefs.SetInt("key", key);
                       PlayerPrefs.Save();
                       SceneManager.LoadScene("MainScene5");
                   });
                }
            }
        }
        else if (key == 1 && setkey == 34)
        {
            choose1.text = "열쇠가 없는 당신은 계속 구름 낀 길로 나아간다";
            choose11.text = "앞으로 나아가기(구름)";
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
                        key = 44;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene5");
                    });
                }
            }
        }
        else if (key == 1 && setkey == 35)
        {
            choose2.text = "당신은 고장나서 버려진 우산을 발견한다";
            choose21.text = "우산을 줍기(비)";
            choose22.text = "우산을 줍지 않기(눈)";
            choosecanvas2.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas2.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas2.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 45;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene5");
                    });
                }
                if (MouseOnUI.gameObj.name == "script2" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                   .OnComplete(() =>
                   {
                       key = 46;
                       PlayerPrefs.SetInt("key", key);
                       PlayerPrefs.Save();
                       SceneManager.LoadScene("MainScene5");
                   });
                }
            }
        }
    }
}
