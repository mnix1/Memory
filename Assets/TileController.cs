using UnityEngine;

public class TileController : MonoBehaviour
{
    public GameManager gameManager;

    private Tile tile;

    private void OnMouseDown()
    {
        BoxCollider2D boxCollider = gameObject.GetComponent<BoxCollider2D>();
        Destroy(boxCollider);
        gameManager.ChangeSide(tile);
        Render();
    }

    public void SetTile(Tile tile)
    {
        this.tile = tile;
    }

    public void Render()
    {
        if (tile.State == TileState.BACK)
        {
            Render(tile.Back.Load());
        }
        else if (tile.State == TileState.HEAD)
        {
            Render(tile.Wisie.Load());
        }
    }

    public void Render(Sprite sprite)
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite;

        float unitWidth = sprite.textureRect.width / sprite.pixelsPerUnit;
        float unitHeight = sprite.textureRect.height / sprite.pixelsPerUnit;
        float targetHeight = 4;
        float targetWidth = unitWidth * targetHeight / unitHeight;
        Debug.Log("unitWidth=" + unitWidth + ", unitHeight=" + unitHeight + ", targetWidth=" + targetWidth);
        spriteRenderer.transform.localScale = new Vector3(targetWidth / unitWidth, targetHeight / unitHeight);

        BoxCollider2D boxCollider = gameObject.AddComponent<BoxCollider2D>();
    }

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {

    }
}
