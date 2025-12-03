using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Animator demoSwordAnimator;
    [SerializeField] private Collider demoSwordCollider;
    [SerializeField] private SpriteRenderer demoSwordSprite;
    [SerializeField] private Animator demoMaceAnimator;
    [SerializeField] private Collider demoMaceCollider;
    [SerializeField] private SpriteRenderer demoMaceSprite;
    [SerializeField] private Animator demoPistolAnimator;
    [SerializeField] private Collider demoPistolCollider;
    [SerializeField] private SpriteRenderer demoPistolSprite;
    [SerializeField] private Animator demoShotgunAnimator;
    [SerializeField] private Collider demoShotgunCollider;
    [SerializeField] private SpriteRenderer demoShotgunSprite;

    public int damage;
    [SerializeField] private int excaliburDamage;
    [SerializeField] private int muramasaDamage;
    [SerializeField] private int estocDamage;
    [SerializeField] private int shortswordDamage;
    [SerializeField] private int maceDamage;
    [SerializeField] private int flailDamage;
    [SerializeField] private int morningstarDamage;
    [SerializeField] private int holyWaterSprinklerDamage;
    [SerializeField] private int pistolDamage;
    [SerializeField] private int silveredBulletsDamage;
    [SerializeField] private int blessedBulletsDamage;
    [SerializeField] private int aurumArgentumDamage;
    [SerializeField] private int shotgunDamage;
    [SerializeField] private int blessedShellsDamage;
    [SerializeField] private int demonDoubleBarrelDamage;
    [SerializeField] private int belzebubBreakActionDamage;

    public int magicCooldown;
    [SerializeField] private int fireboltDamage;
    [SerializeField] private int elvenArrowDamage;
    [SerializeField] private int aresAmmoDamage;
    [SerializeField] private int hearthOfHadesDamage;


    private bool isAttacking = false;

    private void Start()
    {
        demoSwordCollider.enabled = false;
        demoSwordSprite.enabled = false;
        demoMaceCollider.enabled = false;
        demoMaceSprite.enabled = false;
        demoPistolCollider.enabled = false;
        demoPistolSprite.enabled = false;
        demoShotgunCollider.enabled = false;
        demoShotgunSprite.enabled = false;
    }


    void Update()
    {
        //All sword attacks
        if (PlayerInv.Inventory.Contains("Excalibur"))
        {
            damage = excaliburDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Sword Attack");
                StartSwordAttack();
            }
        }
        else if(PlayerInv.Inventory.Contains("Muramasa"))
        {
            damage = muramasaDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Sword Attack");
                StartSwordAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("Estoc"))
        {
            damage = estocDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Sword Attack");
                StartSwordAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("Shortsword"))
        {
            damage = shortswordDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("sword Attack");
                StartSwordAttack();
            }
        }

        //All mace attacks
        if (PlayerInv.Inventory.Contains("HolyWaterSprinkler"))
        {
            damage = holyWaterSprinklerDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Mace Attack");
                StartMaceAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("Morningstar"))
        {
            damage = morningstarDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Mace Attack");
                StartMaceAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("Flail"))
        {
            damage = flailDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Mace Attack");
                StartMaceAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("Mace"))
        {
            damage = maceDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Mace Attack");
                StartMaceAttack();
            }
        }

        //All pistol attacks
        if (PlayerInv.Inventory.Contains("AurumArgentum"))
        {
            damage = aurumArgentumDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Pistol Attack");
                StartPistolAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("BlessedBullets"))
        {
            damage = blessedBulletsDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Pistol Attack");
                StartPistolAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("SilveredBullets"))
        {
            damage = silveredBulletsDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Pistol Attack");
                StartPistolAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("Pistol"))
        {
            damage = pistolDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Pistol Attack");
                StartPistolAttack();
            }
        }

        //All shotgun attacks
        if (PlayerInv.Inventory.Contains("BelzebubBreakAction"))
        {
            damage = belzebubBreakActionDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Shotgun Attack");
                StartShotgunAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("DemonDoubleBarrel"))
        {
            damage = demonDoubleBarrelDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Shotgun Attack");
                StartShotgunAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("BlessedShells"))
        {
            damage = blessedShellsDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Shotgun Attack");
                StartShotgunAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("Shotgun"))
        {
            damage = shotgunDamage;
            if (!isAttacking && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Shotgun Attack");
                StartShotgunAttack();
            }
        }

    }

    private void StartSwordAttack()
    {
        isAttacking = true;

        // Reset the animator state so the animation always restarts
        demoSwordAnimator.Rebind();
        demoSwordAnimator.Update(0f);

        demoSwordCollider.enabled = true;
        demoSwordSprite.enabled = true;
        demoSwordAnimator.SetTrigger("SwordAttack");
    }

    private void StartMaceAttack()
    {
        isAttacking = true;

        // Reset the animator state so the animation always restarts
        demoMaceAnimator.Rebind();
        demoMaceAnimator.Update(0f);

        demoMaceCollider.enabled = true;
        demoMaceSprite.enabled = true;
        demoMaceAnimator.SetTrigger("MaceAttack");
    }

    private void StartPistolAttack()
    {
        isAttacking = true;

        // Reset the animator state so the animation always restarts
        demoPistolAnimator.Rebind();
        demoPistolAnimator.Update(0f);

        demoPistolCollider.enabled = true;
        demoPistolSprite.enabled = true;
        demoPistolAnimator.SetTrigger("PistolAttack");
    }

    private void StartShotgunAttack()
    {
        isAttacking = true;

        // Reset the animator state so the animation always restarts
        demoShotgunAnimator.Rebind();
        demoShotgunAnimator.Update(0f);

        demoShotgunCollider.enabled = true;
        demoShotgunSprite.enabled = true;
        demoShotgunAnimator.SetTrigger("ShotgunAttack");
    }

    // Called as animation events
    public void EndSwordAttack()
    {
        demoSwordCollider.enabled = false;
        demoSwordSprite.enabled = false;

        isAttacking = false;
    }
    public void EndMaceAttack()
    {
        demoMaceCollider.enabled = false;
        demoMaceSprite.enabled = false;

        isAttacking = false;
    }
    public void EndPistolAttack()
    {
        demoPistolCollider.enabled = false;
        demoPistolSprite.enabled = false;

        isAttacking = false;
    }
    public void EndShotgunAttack()
    {
        demoShotgunCollider.enabled = false;
        demoShotgunSprite.enabled = false;

        isAttacking = false;
    }
}