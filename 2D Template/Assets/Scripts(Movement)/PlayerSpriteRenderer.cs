using UnityEngine;

public class PlayerSpriteRenderer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private PlayerMovement movement;
    public Sprite idle;
    public Sprite Upwalking;
    public Sprite Rightwalking;
    public Sprite Leftwalking;
    public Sprite Downwalking;
    public Sprite attacking;
    public AnimationSprite sprint;

    private void Awake()
    {
        movement = GetComponentInParent<PlayerMovement>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnEnable()
    {
        spriteRenderer.enabled = true;
    }

    private void OnDisable()
    {
        spriteRenderer.enabled = false;
        sprint.enabled = false;
    }

    private void LateUpdate()
    {
        if (movement.Rightwalk == true)
        {
            spriteRenderer.sprite = Rightwalking;
        }
        else if (movement.Downwalk == true)
        {
            spriteRenderer.sprite = Downwalking;
        }
        if (movement.Leftwalk == true)
        {
            spriteRenderer.sprite = Leftwalking;
        }
        else if (movement.Upwalk == true)
        {
            spriteRenderer.sprite = Upwalking;
        }

    }
    
}