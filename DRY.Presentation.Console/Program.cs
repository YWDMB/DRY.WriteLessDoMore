using DRY.Core.DataModel.DataBaseEntity;
using DRY.Infrastructure.ThirdParty.Quartz;
using DRY.Infrastructure.ThirdParty.Quartz.Jobs;
using DRY.Infrastructure.ThirdParty.SMS;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DRY.Presentation.Consoles
{
    class Program
    {
        static void Main(string[] args)
        {

            //QuartzService.Start();
            //string str =SMSService.SendSMS("18570142913");
            using (YYCFDataModel cxt = new YYCFDataModel())
            {
                cxt.Database.CreateIfNotExists();
                cxt.TAdmin.Add(new TAdmin
                {
                    Account = "root",
                    Password = "root",
                    CreateTime = DateTime.Now
                });
                cxt.SaveChanges();
            }
            Console.ReadLine();
        }
    }

  



}
