using UnityEngine;

public class ButtonHider : MonoBehaviour
{
    // Esse m�todo vai ser chamado quando clicar no bot�o
    public void HideAllButtons()
    {
        // Pega todos os objetos com a Tag "Button"
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");

        // Desativa cada um
        foreach (GameObject btn in buttons)
        {
            btn.SetActive(false);
        }
    }
}
