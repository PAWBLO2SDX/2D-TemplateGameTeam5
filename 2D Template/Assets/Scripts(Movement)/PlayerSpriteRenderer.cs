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
        run.enabled = movement.running;

        if (movement.UpWalk)
        {
            spriteRenderer.sprite = Upwalk;
        }

        else if (movement.sliding)
        {
            spriteRenderer.sprite = slide;
        }
        //else if (!movement.running)
        //{
        //    spriteRenderer.sprite = idle;
        //}
    }
    
//}