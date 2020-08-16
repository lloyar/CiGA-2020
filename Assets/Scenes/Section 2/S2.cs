using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class S2 : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer BG;
    public Sprite BG2;
    public Sprite BG3;
    
    public Text T_L_1;
    public Text T_R_1;

    public Text T_L_2;
    public Text T_R_2;

    public GameObject Overlap;
    public Text OverlapText;
    private int ActionIdx=0;
    private bool ActionFinish = false;

    public AudioClip c1;
    public AudioClip c2;


    public AudioClip cv1;
    public AudioClip cv2;
    public AudioClip cv3;
    public AudioClip cv4;
    public AudioClip cv5;
    public AudioClip cv6;
    public AudioClip cv7;
    public AudioClip cv8;
    public AudioClip cv9;
    public AudioClip cv10;
    public AudioClip cv11;
    public AudioClip cv12;
    public AudioClip cv13;
    public AudioClip cv14;

    public AudioSource source;

    void Start()
    {
    }

    // Update is called once per frame
    async void  Update()
    {
        if (!ActionFinish)
        {
            switch (ActionIdx)
            {
                case 0:
                    source.PlayOneShot(c1);
                    ActionFinish = true;
                    await WaitForSecondAsync(10);
                    source.PlayOneShot(c2);

                    await WaitForSecondAsync(5);
                    OverlapText.text = "";
                    Overlap.SetActive(false);
                    ActionIdx++;
                    ActionFinish = false;
                    break;
                case 1:
                    T_L_1.text = "听说昨日灵车又出新探员了";
                    source.PlayOneShot(cv1);

                    ActionFinish = true;
                    await WaitForSecondAsync(6);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 2:
                    T_R_1.text = "是啊，名字叫朝妲乃子，立绘真的是大，\r 啊不，正能量是真的精美。\r 昨天刚一出，就成了我的新老婆了";
                    source.PlayOneShot(cv2);


                    ActionFinish = true;

                    await WaitForSecondAsync(15);
                    ActionFinish = false;

                    ActionIdx++;
                    break;
                case 3:
                    T_L_1.text = "你这个人真是的，怎么天天换老婆啊";
                    source.PlayOneShot(cv3);

                    ActionFinish = true;

                    await WaitForSecondAsync(6);
                    ActionFinish = false;

                    ActionIdx++;
                    break;
                case 4:
                    T_R_1.text = "正经人谁不换老婆啊，你换老婆吗？";
                    source.PlayOneShot(cv4);

                    ActionFinish = true;
                    await WaitForSecondAsync(7);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 5:
                    T_L_1.text = "我肯定也要换老婆啊，老婆不换还能叫老婆吗？";
                    source.PlayOneShot(cv5);

                    ActionFinish = true;
                    await WaitForSecondAsync(7);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 6:
                    source.PlayOneShot(cv6);

                    ActionFinish = true;
                    await WaitForSecondAsync(5);
                    ActionFinish = false;
                    source.PlayOneShot(cv7);

                    T_L_1.text = "真香";
                    T_R_1.text = "真香";
                    ActionFinish = true;
                    await WaitForSecondAsync(4);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 7:
                    BG.sprite = BG2;
                    source.PlayOneShot(cv8);
                    ActionFinish = true;
                    T_L_1.text = "";
                    T_R_1.text = "";
                    await WaitForSecondAsync(8);
                    ActionFinish = false;
                    Overlap.SetActive(true);
                    ActionFinish = true;
                    await WaitForSecondAsync(1);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 8:
                    BG.sprite = BG3;
                    ActionFinish = true;
                    Overlap.SetActive(false);
                    await WaitForSecondAsync(1);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 9:
                    source.PlayOneShot(cv9);

                    T_L_2.text = "昨天看《重生之战神吕布爱上我》\r的时候气死我了，\r有人竟然说哥哥没有演技";
                    ActionFinish = true;
                    await WaitForSecondAsync(12);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 10:
                    source.PlayOneShot(cv10);

                    T_R_2.text = "什么?还有这种事？ 哥哥这么帅怎么可能没有演技？";
                    ActionFinish = true;
                    await WaitForSecondAsync(10);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 11:
                    source.PlayOneShot(cv11);

                    T_L_2.text = "对啊，我当时就和这人吵起来了，\r我说“你这么有演技你怎么不去演？”";
                    ActionFinish = true;
                    await WaitForSecondAsync(10);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 12:
                    source.PlayOneShot(cv12);

                    T_R_2.text = "说得好！这群臭屌丝就是见不得别人好。";
                    ActionFinish = true;
                    await WaitForSecondAsync(7);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 13:
                    source.PlayOneShot(cv13);

                    T_L_2.text = "就是就是，臭屌丝，下贱";
                    ActionFinish = true;
                    await WaitForSecondAsync(6);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 14:
                    source.PlayOneShot(cv14);

                    T_R_2.text = "真下贱";
                    ActionFinish = true;
                    await WaitForSecondAsync(3);
                    Overlap.SetActive(true);
                    ActionFinish = false;
                    ActionIdx++;
                    break;
                case 15:
                    await WaitForSecondAsync(1);
                    OverlapText.text = "完";
                    
                    //TODO change scene
                    break;
            }
        }
    }

    private async Task WaitForSecondAsync(float s)
    {
        await Task.Delay(TimeSpan.FromSeconds(s));
    }
}