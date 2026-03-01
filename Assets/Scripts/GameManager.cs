using UnityEngine;

public class ModoExecucao : MonoBehaviour
{
    public GameObject jogadorPC;
    public GameObject jogadorVR;

    void Start()
    {
        if (UnityEngine.XR.XRSettings.isDeviceActive)
        {
            // VR ativo
            jogadorPC.SetActive(false);
            jogadorVR.SetActive(true);
        }
        else
        {
            // PC
            jogadorPC.SetActive(true);
            jogadorVR.SetActive(false);
        }
    }
}