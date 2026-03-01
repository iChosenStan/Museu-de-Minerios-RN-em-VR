using UnityEngine;
public class ControleCamera : MonoBehaviour
{
    public float sensibilidade = 2f;
    public Transform corpoJogador;

    private float rotacaoX = 0f;

    void Start()
    {
        // Trava o cursor no centro da tela
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Captura movimento do mouse
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade;
        // Rotação vertical (olhar para cima/baixo)
        rotacaoX -= mouseY;
        rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f); // Limita para não  virar de cabeça para baixo
        transform.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);

        // Rotação horizontal (girar para os lados)
        corpoJogador.Rotate(Vector3.up * mouseX);
    }
}