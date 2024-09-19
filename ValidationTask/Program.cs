namespace ValidationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, username, password, emailAddress;
            int age;

            // get the user inputs until all are valid.
            // The username should only be output once
            Console.WriteLine("Enter first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            lastName = Console.ReadLine();
            while (Convert.ToBoolean(ValidName(firstName, lastName)) == false)
            {
                Console.WriteLine("Enter first name: ");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter last name: ");
                lastName = Console.ReadLine();
            }
            Console.WriteLine("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            while (Convert.ToBoolean(ValidAge(age)) == false)
            {
                Console.WriteLine("Enter age: ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Password: ");
            password = Console.ReadLine();
            while(Convert.ToBoolean(ValidPassword(password)) == false)
            {
                Console.WriteLine("Enter Password: ");
                password = Console.ReadLine();
            }
            Console.Write("Enter email address: ");
            emailAddress = Console.ReadLine();


            //username = createUserName(firstName, lastName, age);
            //Console.WriteLine($"Username is {username}, you have successfully registered please remember your password");

            //  Test your program with a range of tests to show all validation works
            // Show your evidence in the Readme

        }
        static bool ValidName(string firstName, string lastName)
        {
            int firstLength = firstName.Length;
            int lastLength = lastName.Length;
            if (firstLength >= 2 && lastLength >= 2)
            {
                for (int i = 0; i < firstLength; i++)
                {
                    if (char.IsLetter(firstName[i]))
                    {
                    }
                    else
                    {
                        return false;
                    }
                }
                for (int i = 0; i < lastLength; i++)
                {
                    if (char.IsLetter(lastName[i]))
                    {
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        static bool ValidAge(int age)
        {
            if (age >= 11 && age <= 18)
            {
                return true;
            }
            return false;
        }


        static bool ValidPassword(string password)
        {
            // Check password is at least 8 characters in length


            // Check password contains a mix of lower case, upper case and non letter characters
            // QWErty%^& = valid
            // QWERTYUi = not valid
            // ab£$%^&* = not valid
            // QWERTYu! = valid


            // Check password contains no runs of more than 2 consecutive or repeating letters or numbers
            // AAbbdd!2 = valid (only 2 consecutive letters A and B and only 2 repeating of each)
            // abC461*+ = not valid (abC are 3 consecutive letters)
            // 987poiq! = not valid (987 are consecutive)
            if (password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsLower(password[i]))
                    {
                        for (int j = 0; j < password.Length; j++)
                        {
                            if (char.IsDigit(password[j]))
                            {
                                for (int k = 0; k < password.Length; k++)
                                {
                                    if (char.IsUpper(password[k]))
                                    {
                                        for (int l = 0; l < password.Length; l++)
                                        {
                                            if (char.IsSymbol(password[l]))
                                            {
                                                for (int m = 0; m < password.Length - 2; m++)
                                                {
                                                    password = password.ToLower();
                                                    if ( ((Convert.ToInt32((password[m])) + 2) == (Convert.ToInt32(password[m + 1])) + 1) )
                                                    {
                                                        if (((Convert.ToInt32(password[m]) + 2) == (Convert.ToInt32(password[m + 2]))))
                                                        {
                                                            return false;
                                                        }
                                                    }
                                                    if ( (Convert.ToInt32(password[m]) - 2) == (Convert.ToInt32(password[m + 1]) - 1) )
                                                    {
                                                        if ( (Convert.ToInt32(password[m]) - 2) == Convert.ToInt32(password[m + 2]) )
                                                        {
                                                            return false;
                                                        }
                                                    }
                                                    if ( Convert.ToInt32(password[m]) == Convert.ToInt32(password[m + 1]) )
                                                    {
                                                        if ( Convert.ToInt32(password[m])  == Convert.ToInt32(password[m + 2]) ) 
                                                        {
                                                            return false;
                                                        }
                                                    }
                                                }
                                                return true;
                                            }
                                        }
                                        return false;
                                    }
                                }
                                return false;
                            }
                        }
                        return false;
                    }
                }
                return false;
            }
            return false;

        }
        //static bool validEmail(string email)
        //{
        //    // a valid email address
        //    // has at least 2 characters followed by an @ symbol
        //    // has at least 2 characters followed by a .
        //    // has at least 2 characters after the .
        //    // contains only one @ and any number of .
        //    // does not contain any other non letter or number characters

        //}
        //static string createUserName(string firstName, string lastName, int age)
        //{
        //    // username is made up from:
        //    // first two characters of first name
        //    // last two characters of last name
        //    // age
        //    //e.g. Bob Smith aged 34 would have the username Both34



        //}

    }
}
