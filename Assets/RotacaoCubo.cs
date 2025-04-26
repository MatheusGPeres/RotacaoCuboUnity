using UnityEngine;

public class RotacaoCubo : MonoBehaviour
{
    [SerializeField] private Transform alvoRotacao;
    [SerializeField] private Vector3 eixoRotacao = Vector3.up;
    [SerializeField] private float velocidadeRotacao = 50f;

    void Update()
    {
        if (alvoRotacao != null)
        {
            transform.RotateAround(alvoRotacao.position, eixoRotacao, velocidadeRotacao * Time.deltaTime);
        }
    }
}
