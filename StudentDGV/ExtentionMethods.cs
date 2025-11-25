using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDGV
{
    internal static class ExtentionMethods
    {
        public static OperationResult NCodeValidation(this string nationalCode)
        {
            var valid = new OperationResult();
            if(nationalCode.Length != 10)
            {
                valid.IsSuccess = false;
                valid.Message = "کدملی نامعتبر است";

            }
            switch (nationalCode)
            {
                case "0000000000":
                case "1111111111":
                case "2222222222":
                case "3333333333":
                case "4444444444":
                    valid.IsSuccess = true;
                    break;
                default:
                        valid.Message = "کدملی نامعتبر است";
                    break;
            }
            return valid;
            
        }
        
    }
}
