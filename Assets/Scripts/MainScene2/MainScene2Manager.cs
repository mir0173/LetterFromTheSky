using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MainScene2Manager : MonoBehaviour
{
    private int key;
    private int setkey;
    private bool take1;
    public Image background;
    public Sprite bg1;
    public Sprite bg2;
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
        take1 = false;
        setkey = PlayerPrefs.GetInt("key");
        if (setkey == 11)
        {
            background.sprite = bg1;
        }
        else
        {
            background.sprite = bg2;
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
        if (key == 0 && setkey == 11)
        {
            choose2.text = "새로운 길에서 당신은 버려진 바람막이를 발견한다";
            choose21.text = "가져간다";
            choose22.text = "가져가지 않는다";
            choosecanvas2.blocksRaycasts = true;
            choosecanvas2.DOFade(1, 2)
            .OnComplete(() =>
            {
            });
            if (MouseOnUI.isMouseOver && choosecanvas2.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    key = -1;
                    PlayerPrefs.SetInt("take1", 1);
                    PlayerPrefs.Save();
                    choosecanvas2.DOFade(0, 2)
                    .OnComplete(() =>
                    {
                        choosecanvas2.blocksRaycasts = false;
                        take1 = true;
                        choose2.text = "";
                        choose21.text = "";
                        choose22.text = "";
                        textcanvas.DOFade(1, 1)
                        .OnComplete(() =>
                        {
                            textcanvas.blocksRaycasts = true;
                            StartCoroutine(MainScript2Manager.PrintScript11(textindex++));
                            key = 1;
                        });
                    });
                }
                if (MouseOnUI.gameObj.name == "script2" && Input.GetMouseButtonDown(0))
                {
                    key = -1;
                    choosecanvas2.DOFade(0, 2)
                    .OnComplete(() =>
                    {
                        choosecanvas2.blocksRaycasts = false;
                        take1 = false;
                        choose2.text = "";
                        choose21.text = "";
                        choose22.text = "";
                        textcanvas.DOFade(1, 1)
                        .OnComplete(() =>
                        {
                            textcanvas.blocksRaycasts = true;
                            StartCoroutine(MainScript2Manager.PrintScript11(textindex++));
                            key = 1;
                        });
                    });
                }
            }
        }
        else if (key == 0)
        {
            textcanvas.DOFade(1, 1)
            .OnComplete(() =>
            {
                textcanvas.blocksRaycasts = true;
                StartCoroutine(MainScript2Manager.PrintScript14(textindex++));
                key = 1;
            });
        }
        if (key == 1 && setkey == 11 && textindex < 9 && Input.GetMouseButtonUp(0) && MainScript2Manager.isCantalk)
        {
            StartCoroutine(MainScript2Manager.PrintScript11(textindex++));
        }
        else if (key == 1 && setkey == 11 && textindex == 9 && Input.GetMouseButtonUp(0) && MainScript2Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript2Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 2;
            });
        }
        if (key == 1 && setkey == 14 && textindex < 9 && Input.GetMouseButtonUp(0) && MainScript2Manager.isCantalk)
        {
            StartCoroutine(MainScript2Manager.PrintScript14(textindex++));
        }
        else if (key == 1 && setkey == 14 && textindex == 9 && Input.GetMouseButtonUp(0) && MainScript2Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript2Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 2;
            });
        }


        if (key == 2 && setkey == 11 && take1)
        {
            choose2.text = "당신은 갈림길에 도착했고 두 번째 선택의 시간이 다가왔다";
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
                        key = 21;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene3");
                    });
                }
                if (MouseOnUI.gameObj.name == "script2" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                   .OnComplete(() =>
                   {
                       key = 22;
                       PlayerPrefs.SetInt("key", key);
                       PlayerPrefs.Save();
                       SceneManager.LoadScene("MainScene3");
                   });
                }
            }
        }
        else if (key == 2 && setkey == 11)
        {
            choose1.text = "당신은 계속 맑은 길로 나아간다";
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
                        key = 21;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene3");
                    });
                }
            }
        }
        else if (key == 2 && setkey == 14)
        {
            choose2.text = "당신은 갈림길에 도착했고 두 번째 선택의 시간이 다가왔다";
            choose21.text = "왼쪽으로 가기(구름)";
            choose22.text = "오른쪽으로 가기(비)";
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
                        key = 24;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene3");
                    });
                }
                if (MouseOnUI.gameObj.name == "script2" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                   .OnComplete(() =>
                   {
                       key = 25;
                       PlayerPrefs.SetInt("key", key);
                       PlayerPrefs.Save();
                       SceneManager.LoadScene("MainScene3");
                   });
                }
            }
        }
    }
}
