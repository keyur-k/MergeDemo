
using System;

namespace TestAppl.BL
{
    public class EmployeeBL
    {
        /// <summary>
        /// Returns the employee name based on employee id
        /// </summary>
        /// <param name="employeeId">The employee id</param>
        /// <returns>The employee name</returns>
        public string GetEmployee(int employeeId)
        {
            string retVal = String.Empty;

            switch (employeeId)
            {
                case 1:
                    retVal = "Smith";
                    break;

                case 2:
                    retVal = "Jacques";
                    break;

                case 3:
                    retVal = "Dale";
                    break;
            }

            return retVal;
        }

        /// <summary>
        /// Returns the date of birth for the prvided employee id
        /// </summary>
        /// <param name="employeeId">The employee id</param>
        /// <returns>The date of birth</returns>
        public DateTime? GetDOB(int employeeId)
        {
            DateTime? retVal = null;

            switch (employeeId)
            {
                case 1:
                    retVal = new DateTime(1980, 01, 01);
                    break;

                case 2:
                    retVal = new DateTime(1980, 02, 02);
                    break;

                case 3:
                    retVal = new DateTime(1980, 02, 02);
                    break;
            }

            return retVal;
        }
    }
}
