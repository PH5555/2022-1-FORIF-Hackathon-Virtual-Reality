using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject canvas;
    public Text text;
    public Text BtnText;
    private string[] textArray = {
        "나 납치당했나? ㅎㅎ",
        "아 근데 나 내일\n축제가야 되는데...",
        "빨리 탈출해야겠다!",
        "우주선을 찾아보장"
    };

    private string[] diveTextArray = {
        "아 우주선 폭발했나보다!",
        "근데 여기서 떨어지면 죽을 것 같은데 ㅠㅠ",
        "풍선을 달고 떨어지면 덜 아플 것 같은뎅...",
        "풍선을 잡아보자!"
    };

    private int textIndex = 0;
    private int diveTextIndex = 0;

    public void showNextText(){
        text.text = textArray[textIndex++];
        if(textIndex == 3){
            BtnText.text = "완료";
        }

        if(textIndex == 4){
            canvas.SetActive(false);
            MoveCtrl.isMove = true;
        }
    }

    public void showNextDiveText(){
        text.text = diveTextArray[diveTextIndex++];
        if(diveTextIndex == 3){
            BtnText.text = "완료";
        }

        if(diveTextIndex == 4){
            canvas.SetActive(false);
            MoveCtrl.isMove = true;
        }
    }
}
