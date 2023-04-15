using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.CodeDom.Compiler;

namespace QuestWebApp
{
    /// <summary>
    /// Summary description for QuestWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QuestWebService : System.Web.Services.WebService
    {

        SqlConnection myCon = new SqlConnection();


            [WebMethod]
        public void AddQuest(string Title, string Description, int Tokens, int Badges, int CreatorId)
        {
           
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\School Books\\An III Semestru II\\Industrial Informatics\\Lab\\ProjectAccesa\\QuestWebApp\\QuestWebApp\\App_Data\\QuestBringer.mdf\";Integrated Security=True";
            var procedure = string.Format("Insert Into Quests Values( {0},{1} ,{2} ,{3} ,{4} )", Title,Description,Tokens,Badges,CreatorId);

            using (SqlCommand command = new SqlCommand(procedure, myCon))
            {
                try
                {
                    myCon.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Added Quest!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            myCon.Close();
        }

        [WebMethod]
        public void AddUser(string Username,string Password, int Tokens, int Badges )
        {
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\School Books\\An III Semestru II\\Industrial Informatics\\Lab\\ProjectAccesa\\QuestWebApp\\QuestWebApp\\App_Data\\QuestBringer.mdf\";Integrated Security=True";
            var procedure = string.Format("Insert Into Users Values( {0},{1} ,{2} ,{3})", Username, Password, Tokens, Badges);
            using (SqlCommand command = new SqlCommand(procedure, myCon))
            {
                try
                {
                    myCon.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Added Quest!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                myCon.Close();
            }
        }


        [WebMethod]
        public string[] ShowQuest(int id)
        {
   
            string[] quest;//title,desc,tokens,badges, creator
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\School Books\\An III Semestru II\\Industrial Informatics\\Lab\\ProjectAccesa\\QuestWebApp\\QuestWebApp\\App_Data\\QuestBringer.mdf\";Integrated Security=True";
            var procedure = string.Format("Select Quests.Id, Title,Description,Quests.Tokens,Quests.Badges, Username  From Quests Join Users ON Quests.CreatorId = Users.Id WHERE  Quests.Id = {0}", id);
            DataSet ds = new DataSet();
            myCon.Open();
            using (myCon)
            {
                SqlDataAdapter da = new SqlDataAdapter(procedure, myCon);
              //  da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int, 100).Value = id;
                da.Fill(ds, "Quests"+"Users");
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
               quest= new string[row.ItemArray.Length];
                for (int i= 0; i < row.ItemArray.Length-1; i++)
                {
                    quest[i] = row[i].ToString();
                    Console.Write(quest[i] = row[i].ToString());
                }
               
            }
            myCon.Close();
            return quest;
        }

        [WebMethod]
        public string[] ShowUser(int id)
        {

            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\School Books\\An III Semestru II\\Industrial Informatics\\Lab\\ProjectAccesa\\QuestWebApp\\QuestWebApp\\App_Data\\QuestBringer.mdf\";Integrated Security=True";
            string[] user;//username,tokens,badges
            bool find=true; //change find after successful select
            var procedure = string.Format("Select *,RANK() over (ORDER BY {Badges * 20 + Tokens } From Users Where Id  = {0}", id);
            DataSet ds = new DataSet();
            myCon.Open();
            using (myCon)
            {
                SqlDataAdapter da = new SqlDataAdapter(procedure, myCon);
                da.Fill(ds, "Users");
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                 user = new string[row.ItemArray.Length];
                for (int i = 0; i < row.ItemArray.Length - 1; i++)
                {
                  user[i] = row[i].ToString();
                }

            }
            myCon.Close();
            if (find) {
                return user;
            }
            else return null;

        }

        [WebMethod]
        public string[] ShowLeaderboard()
        {
   
            string[] rankings;
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\School Books\\An III Semestru II\\Industrial Informatics\\Lab\\ProjectAccesa\\QuestWebApp\\QuestWebApp\\App_Data\\QuestBringer.mdf\";Integrated Security=True";
            var procedure = string.Format("Select Username, Badges, Tokens, RANK() OVER(ORDER BY Badges * 20 + Tokens )  from Users  ");
            DataSet ds = new DataSet();
            myCon.Open();
            using (myCon)
            {
                SqlDataAdapter da = new SqlDataAdapter(procedure, myCon);
                da.Fill(ds, "Users");
                DataTable dt = ds.Tables[0];

                rankings = new string[dt.Rows.Count]; int i = 0;
                string[] temp = new string[dt.Rows[0].ItemArray.Length];
                foreach (DataRow row in dt.Rows)
                {

                    for (int j = 0; j < row.ItemArray.Length - 1; j++)
                    {
                        temp[j] = row[j].ToString();

                    }
                    rankings[i] = string.Join(" ,", temp);
                    i++;
                }
            }
            return rankings ;
        }

        [WebMethod]
        public string[] ShowQuestBoard()
        {
            string[] quests ;
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\School Books\\An III Semestru II\\Industrial Informatics\\Lab\\ProjectAccesa\\QuestWebApp\\QuestWebApp\\App_Data\\QuestBringer.mdf\";Integrated Security=True";
            var procedure = string.Format("Select * From Quests");
            DataSet ds = new DataSet();
            // string questList = "";
            myCon.Open();
            using (myCon)
            {
                SqlDataAdapter da = new SqlDataAdapter(procedure, myCon);
                da.Fill(ds, "Quests");
                DataTable dt = ds.Tables[0];
               
                quests = new string[dt.Rows.Count]; int i=0;
                string[] temp =new string[dt.Rows[0].ItemArray.Length];
                foreach (DataRow row in dt.Rows)
                {
                   
                    for (int j = 0; j < row.ItemArray.Length - 1; j++)
                    {
                        temp[j] = row[j].ToString();

                    }
                    quests[i] = string.Join(" ,", temp);
                    ///questList = string.Concat(questList, quest[i], "; ");
                    i++;
                }
                
            }
            return quests;
        }

        [WebMethod]
        public void AcceptQuest(int id)
        {
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\School Books\\An III Semestru II\\Industrial Informatics\\Lab\\ProjectAccesa\\QuestWebApp\\QuestWebApp\\App_Data\\QuestBringer.mdf\";Integrated Security=True";
            var procedure = string.Format("DELETE FROM QUESTS WHERE Quests.Id = {0}",id);
            myCon.Open();
            using (SqlCommand command = new SqlCommand(procedure, myCon))
            {
                try
                {
                    myCon.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        [WebMethod]  //Both AcceptQuest and Reward are called one after the other
        public void Reward(int id, int tokens,int badges)
        {
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\School Books\\An III Semestru II\\Industrial Informatics\\Lab\\ProjectAccesa\\QuestWebApp\\QuestWebApp\\App_Data\\QuestBringer.mdf\";Integrated Security=True";
            var procedure = string.Format("Update Tokens,Badges FROM Users WHERE Quests.Id = {0}", id);
            myCon.Open();
            using (SqlCommand command = new SqlCommand(procedure, myCon))
            {
                try
                {
                    myCon.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


    }
}
