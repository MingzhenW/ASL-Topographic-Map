using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlFlashLight : MonoBehaviour
{
    public GameObject PlayerObject;
    private static GameObject MyFlashLight;
    private bool IfOn = false;
    // Start is called before the first frame update
    void Start()
    {
        ASL.ASLHelper.InstantiateASLObject("PlayerFlashLight", new Vector3(0, 60, 0), Quaternion.identity, "", "", GetLightObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ControlFlashLight()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (IfOn)
            {

            }
            else
            {

            }
        }
    }

    private static void GetLightObject(GameObject _myGameObject)
    {
        MyFlashLight = _myGameObject;
        MyFlashLight.SetActive(false);
    }

}
