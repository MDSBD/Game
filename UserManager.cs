using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class UserManager
    {
        List<User> users = new List<User>();
        public void addUser(User user)
        {

            users.Add(user);
        }

       
        public void addUser(int id, string nom, string pass , string role)
        {
            User u=new User();
            u.Id = id;  
            u.Name = nom;
            u.Password = pass;   
            u.Role = role;
            users.Add(u);
        }
        public List<User> getUsers()
        {
            return users;
        }

        public User? getUserById(int id)
        {
            User? u = users.Find(u => u.Id == id);
            return u;
        }

        public User? auth(string n, string p)
        {
            //User? u = users.Find(x => x.Name == n && x.Password == p);
            User uu = null;
            if(n=="admin" && p=="admin")
            {
                Console.WriteLine("Authentification réussie en tant qu'administrateur.");
                 uu = new User();

                uu.Id = 0;
                uu.Name = "admin";
                uu.Password = "admin";
                uu.Role = "admin";  
                return uu;
            }
            else if (n == "user" && p == "user")
            {
                Console.WriteLine("Authentification réussie.");
                 uu = new User();

                uu.Id = 0;
                uu.Name = "user";
                uu.Password = "user";
                uu.Role = "user";
                return uu;
            }
            else
            {
                Console.WriteLine("Échec de l'authentification.");
            }
           return uu;
        }



    }
}
