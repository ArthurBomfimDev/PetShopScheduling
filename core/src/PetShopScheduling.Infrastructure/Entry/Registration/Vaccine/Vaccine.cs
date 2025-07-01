namespace PetShopScheduling.Infrastructure.Entry.Registration.Vaccine;

public class Vaccine
{
    public string Name { get; private set; }
    public string Type { get; private set; }
    public int Stock { get; private set; }
    public string Batch { get; private set; }
    public DateTime Validity { get; private set; }
    public int Status { get; private set; } -> ENum
}