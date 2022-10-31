using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OnFlashlight : MonoBehaviour
{
    [SerializeField] GameObject Flash;
    private bool FlashlightActive = false;


    // Start is called before the first frame update
    void Start()
    {
        Flash.gameObject.SetActive(false);
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(OnFlash);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFlash(ActivateEventArgs arg)
    {
        if (FlashlightActive == false)
        {
            Flash.gameObject.SetActive(true);
            FlashlightActive = true;
        }
    }
}
