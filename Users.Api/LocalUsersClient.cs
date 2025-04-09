namespace Users.Api;

public class LocalUsersClient : IUsersClient
{
    private UsersService _service = new UsersService();
    
    public string GetUser()
    {
        return _service.GetUser();
    }

}