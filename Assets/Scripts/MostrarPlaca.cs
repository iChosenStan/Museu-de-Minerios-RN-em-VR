using UnityEngine;

public class MostrarPlaca : MonoBehaviour
{
    public GameObject placa;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            placa.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            placa.SetActive(false);
        }
    }
}