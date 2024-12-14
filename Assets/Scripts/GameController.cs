//using UnityEngine;
//using System.Collections.Generic;

//public class GameController : MonoBehaviour
//{
//    public static GameController Instance; // Singleton instance
//    public int currentScore;
//    public Vector3 playerPosition;
//    public List<Vector3> tilePositions = new List<Vector3>(); // To save positions of all tiles

//    private void Awake()
//    {
//        if (Instance == null)
//        {
//            Instance = this;
//            DontDestroyOnLoad(gameObject); // Persist across scenes
//        }
//        else
//        {
//            Destroy(gameObject);
//        }
//    }

//    // Save the game state
//    public void SaveGameState(int score, Vector3 playerPos, List<GameObject> tiles)
//    {
//        currentScore = score;
//        playerPosition = playerPos;

//        tilePositions.Clear(); // Clear any previous tile positions
//        foreach (GameObject tile in tiles)
//        {
//            tilePositions.Add(tile.transform.position); // Save each tile's position
//        }
//    }

//    // Load the game state
//    public void LoadGameState(GameObject player, List<GameObject> tiles)
//    {
//        player.transform.position = playerPosition;
//        Debug.Log("Game state restored: Score = " + currentScore);

//        // Restore tile positions
//        for (int i = 0; i < tiles.Count; i++)
//        {
//            tiles[i].transform.position = tilePositions[i];
//        }
//    }
//}
