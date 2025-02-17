using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Camera mainCamera;

    public Animal animal;
    public PlayerController player;


    private void Awake()
    {
        mainCamera = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));

        if (!rayHit.collider) return;

        if(rayHit.collider.CompareTag("Feed"))
        {
            player.animalFeed += 1;
            UnityEngine.Debug.Log(player.animalFeed);
        }
        else if (rayHit.collider.CompareTag("Animal") && animal.hungerLevels < 100)
        {
            player.animalFeed -= 100 - animal.hungerLevels;
            UnityEngine.Debug.Log(player.animalFeed);
            
            animal.hungerLevels += 100 - animal.hungerLevels;
            UnityEngine.Debug.Log(animal.hungerLevels);
        }
    }
}
