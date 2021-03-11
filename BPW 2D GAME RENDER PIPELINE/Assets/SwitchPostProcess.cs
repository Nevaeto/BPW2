using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SwitchPostProcess : MonoBehaviour
{
    public SpriteManager sm;
    public GameObject triggerPoint;


    void Update()
    {
        //Debug.Log(Vector2.Distance(this.gameObject.transform.position, triggerPoint.transform.position));
        if(Vector2.Distance(this.gameObject.transform.position, triggerPoint.transform.position) < 3.5f && Input.GetKeyDown(KeyCode.R)){
            sm.changeDay();
            Debug.Log("yep");
        }
    }
}
