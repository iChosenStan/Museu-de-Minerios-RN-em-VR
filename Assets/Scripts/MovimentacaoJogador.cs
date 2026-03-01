using UnityEngine;
using UnityEngine.InputSystem;
public class MovimentacaoJogador : MonoBehaviour
{
        // Variáveis públicas (ajustáveis no Inspector)
        public float velocidade = 5f;
        public float gravidade = -9.81f;

        // Referências privadas
        private CharacterController controller;
        private Vector3 velocidadeVertical;

        void Start()
    {
        // Obtém referência ao Character Controller
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Movimentação será implementada aqui
        Mover();
        AplicarGravidade();
    }
    void Mover()
    {
        // Captura input do teclado (WASD ou setas)
        float horizontal = Keyboard.current.aKey.isPressed ? -1 :
                           Keyboard.current.dKey.isPressed ? 1 : 0;
        float vertical = Keyboard.current.sKey.isPressed ? -1 :
                         Keyboard.current.wKey.isPressed ? 1 : 0;

        // Calcula direção do movimento relativa ao personagem
        Vector3 direcao = transform.right * horizontal + transform.forward * vertical;

        // Move o personagem
        controller.Move(direcao * velocidade * Time.deltaTime);
    }

    void AplicarGravidade()
    {
        // Verifica se está no chão
        if (controller.isGrounded && velocidadeVertical.y < 0)
        {
            velocidadeVertical.y = -2f; // Pequeno valor para manter no chão
        }
        // Aplica gravidade
        velocidadeVertical.y += gravidade * Time.deltaTime;
        controller.Move(velocidadeVertical * Time.deltaTime);
    }
}