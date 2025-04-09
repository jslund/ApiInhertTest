namespace Pets.Api;

public class PetsClient
{
    private PetsService _service = new PetsService();

    public string FindPet()
    {
        return _service.FindPet();
    }
}