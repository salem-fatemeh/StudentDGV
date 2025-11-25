using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentDGV
{
    public class Person
    {
        
        public OperationResult Validation()
        {
            
            var valid = new OperationResult();
            var v1 = string.IsNullOrEmpty(FirstName);
            var v2 = string.IsNullOrEmpty(LastName);
            var v3 = string.IsNullOrEmpty(Gender);
            var v4 = string.IsNullOrEmpty(NationalCode);
            if (v1 || v2 || v3 || v4)
            {
                return OperationResult.Failed("لطفا تمامی اطلاعات را وارد کنید");
            }
            else
                valid.IsSuccess = true;
            return valid;
            
        }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Gender {  get; set; }
    }
}
