using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectionMenu : MonoBehaviour
{
    [Header ("UI")]
    public Image carImage;
    public TextMeshProUGUI carName;
    public Scrollbar speedScrollBar;
    public Scrollbar brakeScrollBar;
    public Scrollbar angleScrollBar;

    [Header ("Cars")]
    public CamMovement2 cam;
    public CarSo[] cars;
    private int index;
    private CarSo selectedCar;

    private float maxScrollbar = 1000;
    private float maxScrollbarAngle = 60;

    public Transform startPos;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        selectedCar = cars[index];
        UpdateUI();
    }

    //Método para actualizar el UI
    public void UpdateUI()
    {
        carImage.sprite = selectedCar.carImage;
        carName.text = selectedCar.carName;
        speedScrollBar.size = selectedCar.speed/ maxScrollbar;
        brakeScrollBar.size = selectedCar.brake/ maxScrollbar;
        angleScrollBar.size = selectedCar.angle/ maxScrollbarAngle;
    }

    //cambio de derecha a izquierda
    public void  ChangeCharacter(bool isButtonRight)
    {
        if (isButtonRight)
        {
            index = (index + 1) % cars.Length;
        }else
        {
            index = (index - 1 + cars.Length) % cars.Length;
        }
        selectedCar = cars[index];
        UpdateUI();
    }

    //metodo de seleccion
    public void SelectCar()
    {
        GameObject prefabSelected = Instantiate(selectedCar.carPrefab, startPos.position, Quaternion.identity);
        cam.target = prefabSelected.transform;
    }
}
