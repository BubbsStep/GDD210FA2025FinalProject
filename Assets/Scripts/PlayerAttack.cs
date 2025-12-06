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

    static public int damage;
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

    static public int magicCooldown;
    [SerializeField] private int fireboltDamage;
    [SerializeField] private Animator demoFireboltAnimator;
    [SerializeField] private Collider demoFireboltCollider;
    [SerializeField] private SpriteRenderer demoFireboltSprite;
    [SerializeField] private ParticleSystem demoFireboltParticle;
    [SerializeField] private int elvenArrowDamage;
    [SerializeField] private Animator demoElvenArrowAnimator;
    [SerializeField] private Collider demoElvenArrowCollider;
    [SerializeField] private SpriteRenderer demoElvenArrowSprite;
    [SerializeField] private ParticleSystem demoElvenArrowParticle;
    [SerializeField] private int aresAmmoDamage;
    [SerializeField] private Animator demoAresAmmoAnimator;
    [SerializeField] private Collider demoAresAmmoCollider;
    [SerializeField] private SpriteRenderer demoAresAmmoSprite;
    [SerializeField] private ParticleSystem demoAresAmmoParticle;
    [SerializeField] private int hearthOfHadesDamage;
    [SerializeField] private Animator demoHadesAnimator;
    [SerializeField] private Collider demoHadesCollider;
    [SerializeField] private MeshRenderer demoHadesRend;


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
        demoFireboltCollider.enabled = false;
        demoFireboltSprite.enabled = false;
        demoFireboltParticle.Stop();
        demoElvenArrowCollider.enabled = false;
        demoElvenArrowSprite.enabled = false;
        demoElvenArrowParticle.Stop();
        demoAresAmmoCollider.enabled = false;
        demoAresAmmoSprite.enabled = false;
        demoAresAmmoParticle.Stop();
        demoHadesCollider.enabled = false;
        demoHadesRend.enabled = false;
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

        //All magic attacks
        if (PlayerInv.Inventory.Contains("HearthOfHades"))
        {
            damage = hearthOfHadesDamage;
            if (!isAttacking && Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Magic Attack");
                StartHadesAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("AresAmmoFrenzy"))
        {
            damage = aresAmmoDamage;
            if (!isAttacking && Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Magic Attack");
                StartAresAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("ElvenArrowEdge"))
        {
            damage = elvenArrowDamage;
            if (!isAttacking && Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Magic Attack");
                StartElvenAttack();
            }
        }
        else if (PlayerInv.Inventory.Contains("FaeFirebolt"))
        {
            damage = fireboltDamage;
            if (!isAttacking && Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Magic Attack");
                StartFireboltAttack();
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

    private void StartHadesAttack()
    {
        isAttacking = true;

        // Reset the animator state so the animation always restarts
        demoHadesAnimator.Rebind();
        demoHadesAnimator.Update(0f);

        demoHadesCollider.enabled = true;
        demoHadesRend.enabled = true;
        demoHadesAnimator.SetTrigger("MagicAttack");
    }

    private void StartAresAttack()
    {
        isAttacking = true;

        // Reset the animator state so the animation always restarts
        demoAresAmmoAnimator.Rebind();
        demoAresAmmoAnimator.Update(0f);

        demoAresAmmoCollider.enabled = true;
        demoAresAmmoSprite.enabled = true;
        demoAresAmmoParticle.Play();
        demoAresAmmoAnimator.SetTrigger("MagicAttack");
    }

    private void StartElvenAttack()
    {
        isAttacking = true;

        // Reset the animator state so the animation always restarts
        demoElvenArrowAnimator.Rebind();
        demoElvenArrowAnimator.Update(0f);

        demoElvenArrowCollider.enabled = true;
        demoElvenArrowSprite.enabled = true;
        demoElvenArrowParticle.Play();
        demoElvenArrowAnimator.SetTrigger("MagicAttack");
    }

    private void StartFireboltAttack()
    {
        isAttacking = true;

        // Reset the animator state so the animation always restarts
        demoFireboltAnimator.Rebind();
        demoFireboltAnimator.Update(0f);

        demoFireboltCollider.enabled = true;
        demoFireboltSprite.enabled = true;
        demoFireboltParticle.Play();
        demoFireboltAnimator.SetTrigger("MagicAttack");
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
    public void EndHadesAttack()
    {
        demoHadesCollider.enabled = false;
        demoHadesRend.enabled = false;

        isAttacking = false;
    }
    public void EndAresAttack()
    {
        demoAresAmmoCollider.enabled = false;
        demoAresAmmoSprite.enabled = false;
        demoAresAmmoParticle.Stop();

        isAttacking = false;
    }
    public void EndElvenAttack()
    {
        demoElvenArrowCollider.enabled = false;
        demoElvenArrowSprite.enabled = false;
        demoElvenArrowParticle.Stop();

        isAttacking = false;
    }
    public void EndFireboltAttack()
    {
        demoFireboltCollider.enabled = false;
        demoFireboltSprite.enabled = false;
        demoFireboltParticle.Stop();

        isAttacking = false;
    }

}