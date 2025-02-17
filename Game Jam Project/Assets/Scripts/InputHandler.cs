using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Camera mainCamera; // // Reference to the camera

    //public Animal animal; // // Reference to Animal script
    public PlayerController player; // // Reference to PlayerController script

    public Plant plant;

    public float water;


    private void Awake()
    {
        mainCamera = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        Animal animal = GetComponent<Animal>();

        // // Checks if player has actually hit something
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));

        if (!rayHit.collider) return;

        // // Lets player collect more feed if clicking on Feed box
        if(rayHit.collider.CompareTag("Feed"))
        {
            player.animalFeed += 1;
            UnityEngine.Debug.Log(player.animalFeed);
        }
        // // Feeds animal
        else if (rayHit.collider.CompareTag("Animal") && animal.hungerLevels < 100)
        {
            player.animalFeed -= 100 - animal.hungerLevels;
            UnityEngine.Debug.Log(player.animalFeed);

            animal.hungerLevels += 100 - animal.hungerLevels;
            UnityEngine.Debug.Log(animal.hungerLevels);
        }
        else if (rayHit.collider.CompareTag("Water"))
        {
            water += 1;
        }
        else if (rayHit.collider.CompareTag("Plant") && plant.waterLevels < 100)
        {
            water -= 100 - plant.waterLevels;
            plant.waterLevels += 100 - plant.waterLevels;

        }
    }
}
