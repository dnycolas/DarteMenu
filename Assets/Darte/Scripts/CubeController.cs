using UnityEngine;

public class CubeController : MonoBehaviour
{
    void Start()
    {
        // quando o jogo come�ar, deixa invis�vel
        gameObject.SetActive(false);
    }

    public void ShowCube()
    {
        // deixa o cubo vis�vel
        gameObject.SetActive(true);
    }
}
