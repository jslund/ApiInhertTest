namespace Users;

public class UsersService
{
    private UsersRepository _repository = new UsersRepository();
    
    public string GetUser()
    {
        return _repository.FindUser();
    }
}