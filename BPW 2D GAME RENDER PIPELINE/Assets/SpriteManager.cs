using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SpriteManager : MonoBehaviour
{
    public GameObject[] daySprites;
    public GameObject[] nightSprites;

    public PostProcessProfile day;
    public PostProcessProfile night;

    public PostProcessVolume ppv;
    public bool dayStart;
    // Start is called before the first frame update
    void Start()
    {
        if (dayStart)
        {
            ppv.profile = day;
            foreach (GameObject go1 in daySprites)
            {
                go1.SetActive(true);
            }
            foreach (GameObject go2 in nightSprites)
            {
                go2.SetActive(false);
            }
        }
        else
        {
            ppv.profile = night;
            foreach (GameObject go1 in daySprites)
            {
                go1.SetActive(false);
            }
            foreach (GameObject go2 in nightSprites)
            {
                go2.SetActive(true);
            }
        }

    }

    // Update is called once per frame
    public void changeDay()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    if (ppv.profile == day)
        //    {
        //        ppv.profile = night;
        //    }
        //    else
        //    {
        //        ppv.profile = day;
        //    }
        //}

        if (ppv.profile == day)
        {
            ppv.profile = night;

            foreach (GameObject go1 in daySprites)
            {
                go1.SetActive(false);
            }
            foreach (GameObject go2 in nightSprites)
            {
                go2.SetActive(true);
            }
        }

        if (ppv.profile == night)
        {
            ppv.profile = day;
            foreach (GameObject go1 in daySprites)
            {
                go1.SetActive(true);
            }
            foreach (GameObject go2 in nightSprites)
            {
                go2.SetActive(false);
            }
        }
    }
}
