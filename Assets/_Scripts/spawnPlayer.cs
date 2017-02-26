using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class spawnPlayer : MonoBehaviour
    {
        public GameObject player;
        public int centerIndex;
     

    public void spawn()
        {
            GameObject[] Tiles = GameObject.FindGameObjectsWithTag("Tile");
            centerIndex = (Tiles.Length / 2);
            //int index = (int)centerIndex;

            GameObject playerOne = (GameObject)Instantiate(player);
            Vector3 playerStart = transform.position;
            playerStart.x = Tiles[centerIndex].transform.position.x;
            playerStart.y = .5f;
            playerStart.z = Tiles[centerIndex].transform.position.z;
            playerOne.transform.position = playerStart;
            //player.transform.position = new Vector3(player.transform.position.x = Tiles[index].transform.position.x, player.transform.position.y = 1, player.transform.position.z = Tiles[index].transform.position.z);
         }


        // Use this for initialization
        void Start()
        {
            spawn();
        }

        // Update is called once per frame
        void Update()
        {
           if (Input.GetKeyDown("1"))
          {
            GameObject[] Players = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject Player in Players)
                DestroyObject(Player);
          }

        if (Input.GetKeyDown("2"))
        {
            spawn();
        }

    }


}
