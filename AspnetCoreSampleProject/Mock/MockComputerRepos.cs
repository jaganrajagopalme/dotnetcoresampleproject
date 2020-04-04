using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCoreSampleProject.Interface;
using AspnetCoreSampleProject.Models;

namespace AspnetCoreSampleProject.Mock
{
    public class MockComputerRepos : IComputerRepo
    {
      
        public List<Computers> ListComputers()
        {
           return new List<Computers> { new Computers {serialNo=123,CategoryType="General",InstanceType="micro",OsName="Windows" },
                                  new Computers {serialNo=345,CategoryType="Computing",InstanceType="small",OsName="Windows" },
                                  new Computers {serialNo=567,CategoryType="Memory",InstanceType="Large",OsName="Windows" },
                                  new Computers {serialNo=789,CategoryType="Bigdata",InstanceType="High Large",OsName="Windows" }
            };
        }

       


    }
}
