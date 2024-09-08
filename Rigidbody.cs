public Rigidbody rb;

void Start()
{
    rb = GetComponent<Rigidbody>();

}

void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        rb.AddForce(Vector3.Up * 10, ForceMode.Impulse); // Apply force for jumping
    }
}