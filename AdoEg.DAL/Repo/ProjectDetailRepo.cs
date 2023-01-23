using AdoEg.DAL.Entities;
using AdoEg.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoEg.DAL.Repo
{
    public class ProjectDetailRepo : IProjectRepo
    {
        public static SqlConnection connection; 


        public List<ProjectDetail> GetALlProjectDetails()
        {
            connection = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=ProjectDB;Integrated Security=True");
            connection.Open(); 
            SqlCommand cmd = new SqlCommand("select * from ProjectDetails" , connection);
            List<ProjectDetail> projectDetails = new List<ProjectDetail>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                projectDetails.Add(new ProjectDetail
                {
                    ProjectId = Convert.ToInt32(reader[0]),
                    ProjectName = reader[1].ToString(),
                    Description = reader[2].ToString(),
                    ClientName = reader[3].ToString(),
                    StartDate = Convert.ToDateTime(reader[4]),  
                    EndDate = Convert.ToDateTime(reader[5])
                    
                }); 
            }
            reader.Close();
            connection.Close();
            return projectDetails;
          
        }
        public void AddProject(ProjectDetail projectDetail)
        {
            connection = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=ProjectDB;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand(@"insert into ProjectDetails values (@ProjectName,@Description,
                @ClientName,@StartDate,@EndDate)", connection);
            cmd.Parameters.AddWithValue("@ProjectName", projectDetail.ProjectName);
            cmd.Parameters.AddWithValue("@Description", projectDetail.Description);
            cmd.Parameters.AddWithValue("@ClientName", projectDetail.ClientName);
            cmd.Parameters.AddWithValue("@StartDate", projectDetail.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", projectDetail.EndDate);
            cmd.ExecuteNonQuery();
            connection.Close();




        }
    }
}
