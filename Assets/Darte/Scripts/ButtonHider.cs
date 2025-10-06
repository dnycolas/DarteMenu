using UnityEngine;

public class ShowMenuAnyKey : MonoBehaviour
{
    public GameObject menuCanvas;
    private bool menuAtivo = false;

    void Update()
    {
        // Se QUALQUER tecla ou bot�o for pressionado
        if (Input.anyKeyDown)
        {
            menuAtivo = !menuAtivo;
            menuCanvas.SetActive(menuAtivo);
        }
    }
}
