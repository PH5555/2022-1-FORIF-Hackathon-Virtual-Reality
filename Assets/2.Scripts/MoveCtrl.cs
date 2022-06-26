using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCtrl : MonoBehaviour
{
    private Transform camTr;
    private Rigidbody rigidbody;
    
    public float speed = 1.0f;
    private int balloon = 0;
    public GameObject player;
    public static bool isMove;

    public GameObject canvas;
    public Text text;
    

    void Awake()
    {
        camTr = Camera.main.GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody>();
        isMove = false;
    }

    void Update()
    {
        MoveLookAt();
    }

    void MoveLookAt(){
        if(isMove){
            Vector3 dir = camTr.TransformDirection(Vector3.forward);
            rigidbody.MovePosition(rigidbody.position + dir * speed * Time.deltaTime);
        }
    }

    void resetCamera(){
        player.transform.rotation = Quaternion.Euler(90, 0, 0);
        // camTr.rotation = Quaternion.Euler(0, 0, 0);

        isMove = false;
    }

    void settingUI(){
        canvas.SetActive(true);
        if(balloon == 3){
            text.text = "풍선을 다 모아서 무사히 착륙했다!!! ㅎㅎ\n이제 축제 가야징~ ";
        }
        else{
            text.text = "착륙했지만 다리가 부러졌어 ㅠㅠㅠ \n축제는 다음에 가야겠다...";
        }

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.name == "Spear_Body"){
            ChangeScene.NextSceneWithNum();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Balloons")
        {
            Destroy(other.gameObject, .5f);
            balloon++;
        }

        if (other.gameObject.name == "Block"){
            resetCamera();
            settingUI();
        }
    }
}