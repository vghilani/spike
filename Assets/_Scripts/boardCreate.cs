using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class boardCreate : MonoBehaviour
    {

        public GameObject tile;
        public int size;
    private GameObject gridtile;


        //the 'draw a board' method, which draws an n by n board.  n is declared in void start
        public void DrawBoard(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    //create a new object for each position on the grid.
                    GameObject gridTile = Instantiate(tile);
                    gridTile.transform.position = new Vector3(gridTile.transform.position.x + i, gridTile.transform.position.y, gridTile.transform.position.z + j); // move the object to the correct place in the grid

                }
            }
            
         }

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        GameObject[] Tiles = GameObject.FindGameObjectsWithTag("Tile");
           
    //        Debug.Log("you left");
    //    }
    //}

    // Use this for initialization
    void Start()
        {
            size = 3; //standard board size
            DrawBoard(size);
        }


        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown("1"))
            {
                GameObject[] Tiles = GameObject.FindGameObjectsWithTag("Tile"); //create an array of game objects that have the Tile tag
                foreach (GameObject Tile in Tiles) //get every Tile in the Tiles array and then delete it
                    Destroy(Tile);
            }

            if (Input.GetKeyDown("2"))
            {
                size += 2; // increase the board size and redraw it
                DrawBoard(size);
            }

        }
    }
