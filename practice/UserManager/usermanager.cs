using System;
using System.Collections.Generic;

namespace US
{
    public class User
    {
        public string Name;
        public string Email;
        public string Role;
    }

    public class UserManager
    {
        public List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void RemoveUser(string email)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Email == email)
                {
                    users.RemoveAt(i);
                    break; 
                }
            }
        }

        public void UpdateUser(string email, string newName, string newRole)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Email == email)
                {
                    users[i].Name = newName;
                    users[i].Role = newRole;
                    break;
                }
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            UserManager um = new UserManager();

            User u1 = new User { Name = "Alice", Email = "alice@mail.com", Role = "Admin" };
            User u2 = new User { Name = "Bob", Email = "bob@mail.com", Role = "User" };

            um.AddUser(u1);
            um.AddUser(u2);

            um.UpdateUser("bob@mail.com", "Bobby", "Moderator");
            um.RemoveUser("alice@mail.com");

            // вывод результата
            for (int i = 0; i < um.users.Count; i++)
            {
                Console.WriteLine(um.users[i].Name + " " + um.users[i].Email + " " + um.users[i].Role);
            }
        }
    }
}
