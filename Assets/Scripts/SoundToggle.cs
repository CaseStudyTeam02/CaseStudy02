using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundToggle : MonoBehaviour
{

    public GameObject soundMenu;
    private GameObject bsoundMenu;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickTrigger()
    {
        if(bsoundMenu == null)
        {
            bsoundMenu = Instantiate(soundMenu,null);
        }
    }
}
