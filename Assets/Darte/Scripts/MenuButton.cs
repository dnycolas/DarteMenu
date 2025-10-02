using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject cube;     // refer�ncia ao cubo
    public GameObject button;   // refer�ncia ao bot�o

    public void OnButtonClick()
    {
        // mostra o cubo
        cube.SetActive(true);

        // esconde o bot�o
        button.SetActive(false);
    }
}
