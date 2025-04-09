using Users;
using Users.Api;

namespace Pets;

public class PetsService
{

    private PetsRepository _repository = new PetsRepository();
    private LocalUsersClient _localUsersClient = new LocalUsersClient();

    public string FindPet()
    {
        _localUsersClient.GetUser();
        
        return _repository.FindPet();
    }
}