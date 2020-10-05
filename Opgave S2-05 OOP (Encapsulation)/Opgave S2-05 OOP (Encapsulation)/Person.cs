using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_S2_05_OOP__Encapsulation_ {
    public class Person {
        private string name;
        private string cpr;
        private DateTime bDay;
        private bool isWoman;

        /// <summary>
        /// Gets are sets the name
        /// </summary>
        public string Name {
            // Return the name via 'get'
            get {
                return name;
            }
            // Set the name via 'set'
            set {
                // If the name is valid (checked via ValidateName)
                (bool isValid, string errMsg) = ValidateName(value);
                if (isValid) {
                    name = value;
                }
                // Else show an error
                else {
                    throw new ArgumentException(errMsg, nameof(Name));
                }
            }
        }

        /// <summary>
        /// Gets or sets the CPR
        /// </summary>
        public string CPR {
            get {
                return cpr;
            }
            set {
                (bool isValid, string errMsg) = ValidateCPR(value);
                if (isValid) {
                    cpr = value;
                }
                else {
                    throw new ArgumentException(errMsg, nameof(CPR));
                }
            }
        }

        /// <returns>Birthdate to a string</returns>
        public DateTime BDay {
            get {
                return bDay;
            }
        }

        /// <summary>
        /// Checks CPR number to check if they're a man or woman
        /// </summary>
        public bool IsWoman {
            get {
                // If the last digit (digit 10) of CPR is even, then they're a woman
                if (int.Parse(cpr.Substring(9)) % 2 == 0) {
                return isWoman;
                }
                // If the last digit of CPR is uneven, they're a man
                else {
                    return !isWoman;
                }
            }
        }

        /// <summary>
        /// Checks if the name is properly formatted.
        /// </summary>
        /// <returns>True if the name is properly formatted, else it returns false.</returns>
        public static (bool isValid, string errMsg) ValidateName(string name) {
            // If the name is null
            if (name is null) {
                return (false, "Name is null");
            }

            // Removes whitespaces at the start and end of the string
            name = name.Trim();

            // Has already been checked if it was null, so checks if the string is only whitespaces
            if (string.IsNullOrWhiteSpace(name)) {
                return (false, "Name only contains white spaces");
            }

            // Checks the string length
            if (name.Length < 2) {
                return (false, "Name must be longer than one character");
            }

            // Makes sure there is a space (to check for a first and last name)
            if (name.Contains(' ')) {
                return (true, "");
            }
            else {
                return (false, "Please write both your first and last name");
            }
        }

        public static (bool isValid, string errMsg) ValidateCPR(string cpr) {
            // If CPR is null
            if (cpr is null) {
                return (false, "CPR is null");
            }

            // Removes whitespaces at the start and end of the string
            cpr = cpr.Trim();

            // Has already been checked if it was null, so checks if the string is only whitespaces
            if (string.IsNullOrWhiteSpace(cpr)) {
                return (false, "CPR only contains white spaces");
            }

            // Checks if it can be made into an int, which makes sure it's only numbers
            // If it can be turned into an int then isNumbers returns true, else false
            bool isNumbers = int.TryParse(cpr, out _);

            // If the input is only numbers as it should be
            if (isNumbers) {
                // Checks the string length
                if (cpr.Length == 10) {
                    // Digit 1-2 of CPR
                    string day = cpr.Substring(0, 2);
                    // Digit 3-4 of CPR
                    string month = cpr.Substring(2, 2);
                    // Digit 5-6 of CPR
                    string year = cpr.Substring(4, 2);
                    // Adds '19' to the input year to get 4 digits, year is irrelevant - it's only to  check if it's valid
                    string dummyYear = "19" + cpr.Substring(4, 2);

                    string dateInput = $"{day}/{month}/{dummyYear}";
                    DateTime date = DateTime.Parse(dateInput);
                    DateTime today = DateTime.Now;

                    if (date < today) {
                    return (true, "");
                    }
                    // Error if the date is from the future
                    else {
                        return (false, "The birthdate format is incorrect");
                    }
                }
                // Error if the length isn't 10
                else {
                    return (false, "CPR must be 10 digits long");
                }
            }
            // Error if it has anything other than numbers
            else {
                return (false, "CPR only accepts numbers");
            }
        }


    }
}