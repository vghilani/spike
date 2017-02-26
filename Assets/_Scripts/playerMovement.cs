using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public GameObject player;
    public static int moves = 2;
    public float speed;

    private bool playerTurnOne = (moves == 2);

 //   private bool playerTurnTwo = (moves == 1);
 //   private bool playerTurnEnd = (moves == 0);



    // Update is called once per frame
    void Update () {
	if (playerTurnOne)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {

                  //  Vector3 playerPos = Vector3.MoveTowards(player.transform.position, hit.point, Time.deltaTime * speed);

                    Vector3 playerPos = transform.position;
                    playerPos.z = hit.transform.gameObject.transform.position.z;
                    playerPos.x = hit.transform.gameObject.transform.position.x;

                    player.transform.position = playerPos;

                   
                    // moves -= 1;  this isn't having the desired effect.  Bascially, i can move as many times as i want until the next level, where i cannot move at all.
                    Debug.Log("click");
                }

                //MAKE A GAMEOBJECT THAT IS EQUAL TO THE RAYCASTS HIT THAT UPDATES THAT VARIABLE EACH TURN, AND USES IT IN AN EXIT DESTROY METHOD

            }

        }	
	}




}
