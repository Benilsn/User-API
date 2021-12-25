using System;

namespace User_API.Exceptions
{
    public class UserAlreadyRegisteredException : Exception
    {

        public UserAlreadyRegisteredException() : base("User already registeres on database!") { }
    }
}
