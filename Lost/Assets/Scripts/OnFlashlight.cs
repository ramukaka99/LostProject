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
        Flash.SetActive(false);
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(OnFlash);
    }

    public void OnFlash(ActivateEventArgs arg)
    {
        if (FlashlightActive == false)
        {
            Flash.SetActive(true);
            FlashlightActive = true;
        }
    }
}
