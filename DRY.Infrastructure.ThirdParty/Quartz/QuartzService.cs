using DRY.Infrastructure.ThirdParty.Quartz.Jobs;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY.Infrastructure.ThirdParty.Quartz
{
    
    public class QuartzService
    {
        public static void Start()
        {
            //从工厂中获取一个调度器实例化
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

            scheduler.Start();//开启调度器 //scheduler.Shutdown();//关闭调度器。

            scheduler.ScheduleJob(VoidUnPaidOrderJob.GetJobDetail(), VoidUnPaidOrderJob.GetTrigger());//把作业，触发器加入调度器。


        }
    }
}
