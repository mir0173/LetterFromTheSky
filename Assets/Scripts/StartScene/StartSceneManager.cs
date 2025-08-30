using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class StartSceneManager : MonoBehaviour
{
    private bool key;
    private bool Isexp;
    private bool Isexping;
    private bool Isrec;
    private bool Isrecoding;
    private bool Cond;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;
    public TextMeshProUGUI text5;
    public TextMeshProUGUI text6;
    public TextMeshProUGUI text7;
    public TextMeshProUGUI text;
    public TextMeshProUGUI eggtext;
    public CanvasGroup fadeimg;
    public CanvasGroup expcanvas;
    public CanvasGroup recordcanvas;
    public CanvasGroup eggcanvas;
    void Awake()
    {
        text1.alpha = 0.5f;
        text2.alpha = 0.5f;
        text3.alpha = 0.5f;
        text4.alpha = 0.5f;
        text5.alpha = 0.5f;
        text6.alpha = 0.5f;
        PlayerPrefs.SetInt("key", 0);
        PlayerPrefs.SetInt("take1", 0);
        PlayerPrefs.Save();
        if (!PlayerPrefs.HasKey("Ending1"))
        {
            PlayerPrefs.SetInt("Ending1", 0);
            PlayerPrefs.SetInt("Ending2", 0);
            PlayerPrefs.SetInt("Ending3", 0);
            PlayerPrefs.SetInt("Ending4", 0);
            PlayerPrefs.SetInt("Ending5", 0);
            PlayerPrefs.SetInt("Ending6", 0);
            PlayerPrefs.Save();
        }
        Cond = false;
        Isexp = false;
        Isexping = false;
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
        expcanvas.blocksRaycasts = false;
        recordcanvas.blocksRaycasts = false;
        eggcanvas.blocksRaycasts = false;
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
        if (PlayerPrefs.GetInt("Ending1") == 1)
        {
            text1.alpha = 1;
        }
        if (PlayerPrefs.GetInt("Ending2") == 1)
        {
            text2.alpha = 1;
        }
        if (PlayerPrefs.GetInt("Ending3") == 1)
        {
            text3.alpha = 1;
        }
        if (PlayerPrefs.GetInt("Ending4") == 1)
        {
            text4.alpha = 1;
        }
        if (PlayerPrefs.GetInt("Ending5") == 1)
        {
            text5.alpha = 1;
        }
        if (PlayerPrefs.GetInt("Ending6") == 1)
        {
            text6.alpha = 1;
        }
        if (!Isexp && !Isexping && !Isrec && !Isrecoding)
        {
            Cond = true;
        }
        else
        {
            Cond = false;
        }
        if (Isexp && Input.GetKeyDown(KeyCode.Escape))
        {
            Isexp = false;
            Isexping = true;
            text.text = "";
            expcanvas.DOFade(0, 1f)
            .OnComplete(() =>
            {
                Isexping = false;
                expcanvas.blocksRaycasts = false;
            });
        }
        if (Isrec && Input.GetKeyDown(KeyCode.Escape))
        {
            Isrec = false;
            Isrecoding = true;
            text1.text = "";
            text2.text = "";
            text3.text = "";
            text4.text = "";
            text5.text = "";
            text6.text = "";
            text7.text = "";
            recordcanvas.DOFade(0, 1f)
            .OnComplete(() =>
            {
                Isrecoding = false;
                recordcanvas.blocksRaycasts = false;
            });
        }
        if (MouseOnUI.isMouseOver)
        {
            if (MouseOnUI.gameObj.name == "Startgame" && Cond)
            {
                MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                key = true;
                if (Input.GetMouseButtonDown(0))
                {
                    DOTween.KillAll();
                    SceneManager.LoadScene("MainScene");
                }
            }
            if (MouseOnUI.gameObj.name == "Recordgame" && Cond)
            {
                MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                key = true;
                if (Input.GetMouseButtonDown(0))
                {
                    Isrec = true;
                    Isrecoding = true;
                    text7.text = "ESC를 눌러 종료";
                    recordcanvas.DOFade(1, 0.5f)
                    .OnComplete(() =>
                    {
                        Isrecoding = false;
                        recordcanvas.blocksRaycasts = true;
                    });
                }
            }
            if (MouseOnUI.gameObj.name == "Expgame" && Cond)
            {
                MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                key = true;
                if (Input.GetMouseButtonDown(0))
                {
                    Isexp = true;
                    Isexping = true;
                    text.text = @"'하늘에게 받은 편지'는 날씨에 따라 변하는 기억을 통해 
하나의 이야기를 완성하는 짧은 서사 게임입니다
길을 걷다 보면 두 갈래의 하늘이 나타나고 당신은 하나를 선택합니다
당신의 선택은 하나의 발자취로 기록되어 새로운 결말을 가져옵니다
기본적인 날씨별 결말 6가지와 모든 결말을 확인한 후에
찾을 수 있는 하나의 이스터에그가 존재합니다
날씨를 고르며 당신의 발자취로 이야기를 완성하세요.


ESC 를 눌러서 종료";
                    expcanvas.DOFade(1, 0.5f)
                    .OnComplete(() =>
                    {
                        Isexping = false;
                        expcanvas.blocksRaycasts = true;
                    });
                }
            }
            if (MouseOnUI.gameObj.name == "Endgame" && Cond)
            {
                MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                key = true;
                if (Input.GetMouseButtonDown(0))
                {
#if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
#else
                    Application.Quit();
#endif
                }
            }
            if (MouseOnUI.gameObj.name == "title" && Input.GetMouseButtonDown(0) && Cond && PlayerPrefs.GetInt("Ending1") == 1 && PlayerPrefs.GetInt("Ending2") == 1 && PlayerPrefs.GetInt("Ending3") == 1 && PlayerPrefs.GetInt("Ending4") == 1 && PlayerPrefs.GetInt("Ending5") == 1 && PlayerPrefs.GetInt("Ending6") == 1)
            {
                eggtext.text = @"이야기를 전부 보며
너는 많은 하늘을 걸었겠지만  
그 모든 순간이 틀리지 않았다는 말을
이 편지로 전하고 싶었어

결과로 향하는 문은 언제나 네 옆에 있을 거야
네가 정한 결말을 향해 그 문을 힘껏 밀어봐
그 문 너머에는 어떤 날씨가 기다리고 있을까?

- 하늘 아래를 먼저 걸었던, 그리고 다시 걷게 될 너에게";
                eggcanvas.DOFade(1, 0.5f)
                .OnComplete(() =>
                {
                    eggcanvas.blocksRaycasts = true;
                    eggcanvas.DOFade(0, 2).SetDelay(7)
                    .OnStart(() =>
                    {
                        eggtext.text = "";
                    })
                    .OnComplete(() =>
                    {
                        eggcanvas.blocksRaycasts = false;
                    });
                });
            }
            if (Isrec)
                {
                    if (MouseOnUI.gameObj.name == "Text1" && PlayerPrefs.GetInt("Ending1") == 1)
                    {
                        text1.text = "희망";
                        key = true;
                    }
                    else
                    {
                        text1.text = "맑음";
                    }
                    if (MouseOnUI.gameObj.name == "Text2" && PlayerPrefs.GetInt("Ending2") == 1)
                    {
                        text2.text = "변화";
                        key = true;
                    }
                    else
                    {
                        text2.text = "바람";
                    }
                    if (MouseOnUI.gameObj.name == "Text3" && PlayerPrefs.GetInt("Ending3") == 1)
                    {
                        text3.text = "망각";
                        key = true;
                    }
                    else
                    {
                        text3.text = "안개";
                    }
                    if (MouseOnUI.gameObj.name == "Text4" && PlayerPrefs.GetInt("Ending4") == 1)
                    {
                        text4.text = "무기력";
                        key = true;
                    }
                    else
                    {
                        text4.text = "구름";
                    }
                    if (MouseOnUI.gameObj.name == "Text5" && PlayerPrefs.GetInt("Ending5") == 1)
                    {
                        text5.text = "슬픔";
                        key = true;
                    }
                    else
                    {
                        text5.text = "비";
                    }
                    if (MouseOnUI.gameObj.name == "Text6" && PlayerPrefs.GetInt("Ending6") == 1)
                    {
                        text6.text = "고독";
                        key = true;
                    }
                    else
                    {
                        text6.text = "눈";
                    }
                }          
        }
        else if (key == true)
        {
            if (MouseOnUI.gameObj != null) MouseOnUI.gameObj.transform.DOScale(1f, 0.5f);
            key = false;
        }

    }
}
