using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject cube;     // referência ao cubo
    public GameObject button;   // referência ao botão

    public void OnButtonClick()
    {
        // mostra o cubo
        cube.SetActive(true);

        // esconde o botão
        button.SetActive(false);
    }
}
