using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                var users = new List<User>();

                users.Add(new User() { UserName = "Alex", PinCode = "1231", Balance = 35 });
                users.Add(new User() { UserName = "Florin", PinCode = "1232", Balance = 230 });
                users.Add(new User() { UserName = "Andreea", PinCode = "1233", Balance = 131 });
                users.Add(new User() { UserName = "Oana", PinCode = "1234", Balance = 930 });
                users.Add(new User() { UserName = "Sorin", PinCode = "1235", Balance = 19 });
                users.Add(new User() { UserName = "Mihaela", PinCode = "1236", Balance = 1000 });
                users.Add(new User() { UserName = "Mihai", PinCode = "1237", Balance = 420 });
                users.Add(new User() { UserName = "Dana", PinCode = "1238", Balance = 135 });
                users.Add(new User() { UserName = "Alina", PinCode = "1239", Balance = 735 });
                users.Add(new User() { UserName = "Alexa", PinCode = "1230", Balance = 16 });

                var min = users[0].Balance;//store initially the first balance from the list
                var max = users[0].Balance;//store initially the first balance from the list
                var userWithMinValue = users[0].UserName;//store initially the first username from the list 
                var userWithMaxValue = users[0].UserName;//store initially the first username from the list
                var totalAmount = 0;//variable used in order to store the total balance
                var numberOfUsers = 0;//variable used in order to count the number of users
                var arithmeticMean = 0m; //we add the value m after 0 as a suffix so that the compiler knows that this variable is of type decimal

                foreach (var user in users)
                {
                    //determine the min section
                    if (min > user.Balance)
                    {
                        //in case the current balance value is lesser then the min value then we change the min value to point to the balance of the current user
                        //also we update the username of the user with the min balance
                        userWithMinValue = user.UserName;
                        min = user.Balance;
                    }

                    //determine the max section
                    if (max < user.Balance)
                    {
                        //in case the current balance value is greather then the max value then we change the max value to point to the balance of the current user
                        //also we update the username of the user with the max balance
                        userWithMaxValue = user.UserName;
                        max = user.Balance;
                    }
                //store the total amount
                totalAmount += user.Balance;
                    //increment the number of users
                    numberOfUsers++;
                    Console.WriteLine($"User with the name {user.UserName} and pincode {user.PinCode} has the amount equal to {user.Balance}");
                }

                //arithmeticMean = totalAmount / numberOfUsers; - since both total amount and number of users are of type int the result of their divide will also be an int value; 
                //for example instead of 254.3 the arithmeticMean value will be set to 254

                //arithmeticMean = (decimal)totalAmount / numberOfUsers; 
                //by forcing the first value to be converted as a decimal we will ensure that the result of the divide will be decimal

                arithmeticMean = decimal.Divide(totalAmount, numberOfUsers);
                //the decimal type has a built in method which takes as arguments two int values and returns the result of their divide as decimal

                Console.WriteLine($"The max amount is {max} belonging to the user {userWithMaxValue} and the min amount is {min} belonging to the user {userWithMinValue}");
                Console.WriteLine($"The total amount is {totalAmount}");
                Console.WriteLine($"The number of users is equal to {numberOfUsers}");
                Console.WriteLine($"The arithmetic mean value is equal to {arithmeticMean}");
                Console.ReadLine();
                return;
            
        }
    }
    
}
