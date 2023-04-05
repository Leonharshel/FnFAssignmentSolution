using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountCreation
{
    public class BankAccountDetails
    {
        public string Name { get; set; }
        public string Panno { get; set; }
        public string AdharNo { get; set; }
        
        public byte[] Photo{ get; set; }
        public string Email { get;set; }
        public long Phone { get; set; }
        public class Builder
        {
            private BankAccountDetails _personldetails=new BankAccountDetails();

           
            public Builder EssentialFiels(string name,string panno,string adhar, byte[] photo)
            { 
                _personldetails.Name = name;
                _personldetails.Panno = panno;
                _personldetails.AdharNo = adhar;
                _personldetails.Photo = photo;
                return this;
            }
           
            public Builder WithEmail(string email)
            { 
                _personldetails.Email = email;  
                return this;
            }
            public Builder WithPhone(long phone)
            {
                _personldetails.Phone = phone;
                return this;
            }
          
            public BankAccountDetails Build()
            {
                return _personldetails;
            }

        }
        public static Builder CreateBuilder()
        {
            return new Builder();

        }
    }
    internal class BankAccount
    {
        static void Main(string[] args)
        {
            byte[] newbytearr = { 0x20,0x15,0x63,0xa };
            Console.WriteLine("hi");
            var person = BankAccountDetails.CreateBuilder()
                  .EssentialFiels("testname","teststring","anotherteststring",newbytearr)//required fields
                  .WithPhone(64565146546)//optional field phonno
                  .WithEmail("abc@bcd")//optional field email
                  .Build();
            Console.WriteLine("account person name "+person.Name);
            Console.WriteLine("account person adar no " + person.AdharNo);
            Console.WriteLine("account person pan no  " + person.Panno);
            Console.WriteLine("account person photo " + person.Photo.ToString());
            Console.WriteLine(person.Phone);

        }
    }
}
