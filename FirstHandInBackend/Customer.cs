using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHandInBackend
{
    class Customer
    {
        public string Name;
        public int Age;
        public int Zipcode;
        public string Password;

        public Customer(){

            this.Name = "Poul Hansen";
            this.Age = 40;
            this.Zipcode = 2770;
            this.Password = "thistechnicallyfulfillstherequirements";

            }
        public Customer(string Name, int Age, int Zipcode, string Password)
        {

            this.Name = Name;
            this.Age = Age;
            this.Zipcode = Zipcode;
            this.Password = Password;
        }

        public Customer(Customer guytoclone)
        {
            this.Name = guytoclone.Name;
            this.Age = guytoclone.Age;
            this.Zipcode = guytoclone.Zipcode;
            this.Password = guytoclone.Password;

        }
        public string CompareAges(Customer firstguy, Customer secondguy)
        {
            if(firstguy.Age > secondguy.Age)
            {
                return firstguy.Name + " is oldest";
            }
            else if (firstguy.Age == secondguy.Age) { return firstguy.Name + " and " + secondguy.Name + " are the same ages"; }
                else
                {
                    return secondguy.Name + " is oldste";
                }
            
            
        }

        public override string ToString()
        {
            string outputtet = "This customers name is " + this.Name + ", he is " + this.Age + " years old and his postal code is " + this.Zipcode + ". And his password are " + this.Password;
            return outputtet;
        }
    }
}
