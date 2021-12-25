using System;

namespace User_API.Exceptions
{
    public class UserNotRegisteredException : Exception
    {
        public UserNotRegisteredException() : base("User not registered!") { }
    }
}
