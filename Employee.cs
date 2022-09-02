groovyc –cp “spock-core-2.2-M3-groovy-4.0.jar” ReverseStringSpec.groovy

groovy –cp “spock-core-2.2-M3-groovy-4.0.jar” ReverseStringSpec

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirstProject.Models
{
    public class Employee
    {
        public int EmployeeId{ get;set; }
        public string EmployeeNumber{ get;set; }
        public string EmployeeLocation{ get;set; }
        public string EmployeeName{ get;set; }
    }
}
