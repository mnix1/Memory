using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject tilePrefab;

    public int cols;
    public int rows;
    public int repeat;

    private Tile[,] tiles;

    private List<Tile> notUsedTiles = new List<Tile>();
    private List<Wisie> notUsedWisies = new List<Wisie>(Wisie.WISIES);
    private Back back;

    private void InitTiles()
    {
        tiles = new Tile[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                notUsedTiles.Add(new Tile(row, col));
            }
        }
        for (int i = 0; i < rows * cols / repeat; i++)
        {
            Wisie wisie = RandomUtil.RandomElement(notUsedWisies);
            notUsedWisies.Remove(wisie);
            for (int r = 0; r < repeat; r++)
            {
                Tile tile = RandomUtil.RandomElement(notUsedTiles);
                notUsedTiles.Remove(tile);
                tile.Wisie = wisie;
                tile.Back = back;
                InitTile(tile);
            }
        }
    }

    private void InitTile(Tile tile)
    {
        //tilePrefab.GetComponent<SpriteRenderer>().sprite = tile.Wisie.Load();
        float height = Camera.main.orthographicSize * 2;
        float width = height * Screen.width / Screen.height;
      
        float tileWidth = width / cols;
        float tileHeight = height / rows;

        Vector3 position = new Vector3(tileWidth * tile.Col - tileWidth * (cols - 1) / 2, tileHeight * tile.Row - tileHeight * (rows - 1) / 2);

        GameObject gameObject = Instantiate(tilePrefab, position, Quaternion.identity);

        TileController tileController = gameObject.GetComponent<TileController>();
        tileController.SetTile(tile);
        tileController.Render();
    }

    public void ChangeSide(Tile tile)
    {
        tile.ChangeSide();
    }

    void Start()
    {
        back = RandomUtil.RandomElement(Back.BACKS);
        InitTiles();
    }

    void Update()
    {

    }
}
