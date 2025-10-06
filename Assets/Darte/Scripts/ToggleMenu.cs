using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    [Header("Arraste aqui o Canvas ou Painel do menu")]
    public GameObject menuCanvas;

    [Header("Tecla para ativar/desativar")]
    public KeyCode teclaAtivar = KeyCode.M;

    void Start()
    {
        // Garante que o menu começa desativado
        if (menuCanvas != null)
            menuCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(teclaAtivar))
        {
            if (menuCanvas != null)
            {
                // Alterna igual o Active do Inspector
                bool estadoAtual = menuCanvas.activeSelf;
                menuCanvas.SetActive(!estadoAtual);
            }
            else
            {
                Debug.LogWarning("MenuCanvas não está atribuído no Inspector!");
            }
        }
    }
}
