using UnityEngine;

public class CubeController : MonoBehaviour
{
    void Start()
    {
        // quando o jogo começar, deixa invisível
        gameObject.SetActive(false);
    }

    public void ShowCube()
    {
        // deixa o cubo visível
        gameObject.SetActive(true);
    }
}
