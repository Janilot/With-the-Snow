using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObjectScript : MonoBehaviour
{
    public Color _color;
    public enum StateList { LEFT, SHIFT_LEFT, SHIFT_RIGHT, RIGHT };
    public StateList _curState;
    public StateList _correctState;
    public float shiftTimer;
    public float openTimer;
    public float maxAngle;
    private float curAngle;
    public float angleRotateSpeed = 2;

    private float handleTimer;
    private float doortimer;
    private float toAlpha;
    [SerializeField]
    GameObject handleObj;
    [SerializeField]
    GameObject rotateObj;
    [SerializeField]
    GameObject doorObj;

    // Start is called before the first frame update
    void Start()
    {
        handleObj = this.transform.Find("Switch").Find("Lever").Find("Handle").gameObject;
        rotateObj = this.transform.Find("Switch").Find("Lever").gameObject;
        doorObj = this.transform.Find("Door").gameObject;
        handleObj.GetComponent<MeshRenderer>().materials[0].color = _color;
        doorObj.GetComponent<MeshRenderer>().materials[0].color = _color;

        curAngle = _curState == StateList.LEFT ? -maxAngle : maxAngle;
        StartCheckDoor();
    }

    // Update is called once per frame
    void Update()
    {
        if (_curState == StateList.SHIFT_LEFT || _curState == StateList.SHIFT_RIGHT)
        {
            int isToRight = _curState == StateList.SHIFT_RIGHT ? 1 : -1;
            handleTimer += Time.deltaTime;
            curAngle += angleRotateSpeed * maxAngle * isToRight * Time.deltaTime / shiftTimer;
           rotateObj.transform.localRotation = Quaternion.Euler(0, 0, curAngle);
            
            if (handleTimer >= shiftTimer)
            {
                _curState = isToRight == 1 ? _curState = StateList.RIGHT : _curState = StateList.LEFT;
                CheckDoor();
            }
        }
    }

    public void CollideLever(Transform collider)
    {
        if (_curState == StateList.LEFT || _curState == StateList.RIGHT)
        {
            /***************************/
            //Todo : Sound. Switch µþ±ï
            SoundManager.instance.PlaySFX("switch");
            /***************************/
            _curState = _curState == StateList.RIGHT ? StateList.SHIFT_LEFT : StateList.SHIFT_RIGHT;
            handleTimer = 0;
        }
    }


    public void StartCheckDoor()
    {
        bool isCollect = _curState == _correctState ? true : false;
        doorObj.GetComponent<BoxCollider>().isTrigger = isCollect;

        if (isCollect)
            doorObj.GetComponent<MeshRenderer>().materials[0].SetFloat("_Alpha", 0);
        else
            doorObj.GetComponent<MeshRenderer>().materials[0].SetFloat("_Alpha", 1);

        //Todo : alpha
        //doorObj.GetComponent<MeshRenderer>().materials[0].
    }

    public void CheckDoor()
    {
        bool isCollect = _curState == _correctState ? true : false;
        doorObj.GetComponent<BoxCollider>().isTrigger = isCollect;

        /***************************/
        //Todo : Sound. ¹®ÀÌ ¿­¸°´Ù
        SoundManager.instance.PlaySFX("barrier");
        /***************************/

        if (isCollect)
            doorObj.GetComponent<MeshRenderer>().materials[0].SetFloat("_Alpha", 0);
        else
            doorObj.GetComponent<MeshRenderer>().materials[0].SetFloat("_Alpha", 1);

        //Todo : alpha
        //doorObj.GetComponent<MeshRenderer>().materials[0].
    }

}