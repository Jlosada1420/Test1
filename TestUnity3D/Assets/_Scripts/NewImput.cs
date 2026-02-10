
using UnityEngine;
using UnityEngine.InputSystem;

public class NewImput : MonoBehaviour
{
    // Se declaran las variables
    private PlayerInput playerInput;
    private float inputX;

    // Al inicio de juego
    private void Start()
    {
        // Se almacena en la variable el componente acorde de Unity
        playerInput = GetComponent<PlayerInput>();
    }

    // Cada frame
    private void Update()
    {
        // Se llama al método para que funcione
        GetInput();
    }

    public void Button(InputAction.CallbackContext context)
    {
        // Tres momentos: cuando se presiona, cuando se está presionando y cuando se deja de presionar
        if (context.started)
        {
            // Forma de escribir en consola
            Debug.Log("Shoot");
        }
    }

  
    public void GetInput()
    {
        // Almacena en la variable el varlor del axis del archvio de PlayerActions
        inputX = playerInput.actions["Move"].ReadValue<float>();

        // Forma con concatenación
       //Debug.Log("Movimiento: " + inputX);

        // Forma con formato
       // Debug.Log(string.Format("Movimiento: {0}", inputX));
    }
}
