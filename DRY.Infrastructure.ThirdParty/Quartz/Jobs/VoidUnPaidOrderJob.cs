using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY.Infrastructure.ThirdParty.Quartz.Jobs
{
    public class VoidUnPaidOrderJob : IJob
    {

        public static IJobDetail GetJobDetail()
        {
            //创建一个作业
            JobBuilder jobBuilder = JobBuilder.Create<VoidUnPaidOrderJob>();
            //jobBuilder.WithIdentity("作业名称", "作业组");
            //jobBuilder.UsingJobData("jobSays", "Hello World!");//作业数据传递
            IJobDetail jobDetail = jobBuilder.Build();

            return jobDetail;
        }

        public static ITrigger GetTrigger()
        {
            //创建一个触发器
            TriggerBuilder triggerBuilder = TriggerBuilder.Create();
            triggerBuilder.StartNow();//现在开始    
            //triggerBuilder.WithCronSchedule("/5 * * ? * *");//时间表达式
            triggerBuilder.WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever());//触发时间，5秒一次。
            ITrigger jobTrigger = triggerBuilder.Build();

            return jobTrigger;
        }

        public void Execute(IJobExecutionContext context)
        {
            JobDataMap dataMap = context.JobDetail.JobDataMap;
            string content = dataMap.GetString("jobSays");
            Console.WriteLine("作业执行，jobSays:" + content + "  " + DateTime.Now.ToString());
        }

    }
}
