using NinePoint.Entities;
using NinePoint.Hubs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NinePoint.Repositories
{
    public class JobInfoRepository : GenericRepository<JobInfo>, IJobInfoRepository
    {
        public JobInfoRepository(ManageApartmentDbContext context) : base(context)
        {
        }

        public IEnumerable<JobInfo> GetData()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ManageApartmentDbContext"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"SELECT [JobID],[Name],[LastExcutionDate],[Status]
               FROM [dbo].[JobInfo]", connection))
                {
                    // Make sure the command object does not already have
                    // a notification object associated with it.
                    command.Notification = null;

                    SqlDependency dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (var reader = command.ExecuteReader())
                        return reader.Cast<IDataRecord>()
                            .Select(x => new JobInfo()
                            {
                                JobID = x.GetInt32(0),
                                Name = x.GetString(1),
                                LastExcutionDate = x.GetDateTime(2),
                                Status = x.GetString(3)
                            }).ToList();



                }
            }
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            JobHub.Show();
        }
    }
}