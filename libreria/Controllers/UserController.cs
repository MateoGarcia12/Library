using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms.VisualStyles;
using libreria.Context;
using libreria.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace libreria.Controllers
{
    internal class UserController
    {
        public static bool authenticateUser(string username, string password)
        {
			try
			{
                var context = new AppDbContext();
                var user = context.Users.Single(u => u.UserName == username);
                if (user != null)
                {
                   
                    bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, user.Password);

                    Program.logged = user;
                    return isPasswordValid;
                   
                }

                return false;
            }
			catch (Exception e)
			{

               throw new Exception("An error ocurred during log in: " + e.Message);
               
			}
        }


        public static List<Models.User> getAll()
        {
             var context = new AppDbContext();
            var users = context.Users.ToList();
            

            return users;
        }

        public static bool createUser(Models.User user) 
        
        {
            try
            {
                var context = new AppDbContext();
                string password = user.Password;
                password = BCrypt.Net.BCrypt.HashPassword(password);
                user.Password = password;
                context.Users.Add(user);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                throw new Exception ("Something went wrong while creating a user: " + e.Message);
            }
           
           
        }

        public static bool deleteUser(int id)
        {
            try
            {
                var context = new AppDbContext();
                var user = getById(id);
                context.Remove(user);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                throw new Exception("Something went wrong while deleting an user: " + e.Message); ;
            }
           
        }

        public static Models.User getById(int id)
        {
            try
            {
                var context = new AppDbContext();
                var user = context.Users.Single(u => u.UserId == id);
                return user;
            }
            catch (Exception e)
            {

                throw new Exception ("Something went wrong while searching by id: " + e.Message);
            }
        }

        public static bool editUser(Models.User editedUser)
        {

             try
    {
                var context = new AppDbContext();
        {
            // Retrieve the user from the database using the getById method
            var existingUser = getById(editedUser.UserId);

            // Check if the user with the given ID exists
            if (existingUser == null)
            {
                // Handle the situation where the user does not exist (e.g., throw an exception or return false)
                throw new Exception("User not found for editing.");
                    }
                    if (editedUser.Password != existingUser.Password)
                    {
                        // Hash the new password
                       existingUser.Password = BCrypt.Net.BCrypt.HashPassword(editedUser.Password);
                        
                    }

                    existingUser.Name = editedUser.Name;
            existingUser.LastName = editedUser.LastName;
            existingUser.IsAdmin = editedUser.IsAdmin;

                    // Save the changes to the database
            context.Users.Update(existingUser);
            context.SaveChanges();

            return true; // Editing successful
        }
    }
    catch (Exception e)
    {
        // Handle exceptions (log, rethrow, etc.)
        throw new Exception("Something went wrong while editing the user: " + e.Message);
    }

        }

        
    }

  

}
