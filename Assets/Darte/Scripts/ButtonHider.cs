using UnityEngine;

public class ButtonHider : MonoBehaviour
{
    // Esse método vai ser chamado quando clicar no botão
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
