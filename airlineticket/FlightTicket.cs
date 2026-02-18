using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airlineticket
{
    internal class FlightTicket
    {
        public string NamePasenger;
        public int age;
        public string ClassType;
        public FlightTicket(string namePasenger, int age, string classType)
        {
            NamePasenger = namePasenger;
            this.age = age;
            ClassType = classType;
        }
        public double ClclateFinalPrice()
        {
            int price = 500;
            double finalprice;
            if(ClassType == "Business")
            {
                finalprice = price + 300;

            }
            else
            {
                finalprice = price;
            }
            if(age<=12)
            {
                finalprice *= 0.5;
                
            }
            if(age >= 65)
            {
                finalprice *= 0.7;
                
            }
            return finalprice;
        }
    }
}
