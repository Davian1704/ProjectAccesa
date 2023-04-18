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
           
            myCon.ConnectionString = "Data Source=DESKTOP-C5G2Q55;Initial Catalog=\"D:\\SCHOOL BOOKS\\AN III SEMESTRU II\\INDUSTRIAL INFORMATICS\\LAB\\PROJECTACCESA\\QUESTWEBAPP\\QUESTWEBAPP\\APP_DATA\\QUESTBRINGER.MDF\";Integrated Security=True";
            var procedure = string.Format("Insert Into Quests Values( '{0}','{1}' ,{2} ,{3} ,{4} )", Title,Description,Tokens,Badges,CreatorId);

            using (myCon)
            {
                try
                {
                    SqlCommand command = new SqlCommand(procedure, myCon);
                    command.Connection.Open();
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
            myCon.ConnectionString = "Data Source=DESKTOP-C5G2Q55;Initial Catalog=\"D:\\SCHOOL BOOKS\\AN III SEMESTRU II\\INDUSTRIAL INFORMATICS\\LAB\\PROJECTACCESA\\QUESTWEBAPP\\QUESTWEBAPP\\APP_DATA\\QUESTBRINGER.MDF\";Integrated Security=True";
            var procedure = string.Format("Insert Into Users Values( '{0}','{1}' ,{2} ,{3})", Username, Password, Tokens, Badges);
            using (myCon)
            {
                try
                {
                    SqlCommand command = new SqlCommand(procedure, myCon);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Added User!");
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
            myCon.ConnectionString = "Data Source=DESKTOP-C5G2Q55;Initial Catalog=\"D:\\SCHOOL BOOKS\\AN III SEMESTRU II\\INDUSTRIAL INFORMATICS\\LAB\\PROJECTACCESA\\QUESTWEBAPP\\QUESTWEBAPP\\APP_DATA\\QUESTBRINGER.MDF\";Integrated Security=True";
            var procedure = string.Format("Select Quests.Id, Title,Description,Quests.Tokens,Quests.Badges, Users.Username From Quests Join Users ON Quests.CreatorId = Users.Id WHERE  Quests.Id = {0}", id);
            DataSet ds = new DataSet();
            myCon.Open();
            using (myCon)
            {
                SqlDataAdapter da = new SqlDataAdapter(procedure, myCon);
                da.Fill(ds,"Quests");
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
               quest= new string[row.ItemArray.Length];
                for (int i= 0; i < row.ItemArray.Length; i++)
                {
                    quest[i] = row[i].ToString();
                    Console.Write(quest[i] = row[i].ToString());
                }
               
            }
            myCon.Close();
            return quest;
        }

        [WebMethod]
        public int CheckUser(string username, string password)
        {
            myCon.ConnectionString = "Data Source=DESKTOP-C5G2Q55;Initial Catalog=\"D:\\SCHOOL BOOKS\\AN III SEMESTRU II\\INDUSTRIAL INFORMATICS\\LAB\\PROJECTACCESA\\QUESTWEBAPP\\QUESTWEBAPP\\APP_DATA\\QUESTBRINGER.MDF\";Integrated Security=True";
            int userId;//username,tokens,badges
            var procedure = string.Format("Select * From Users Where Username = '{0}' And Password ='{1}'", username,password);
            DataSet ds = new DataSet();
            myCon.Open();
            using (myCon)
            {
                SqlDataAdapter da = new SqlDataAdapter(procedure, myCon);
                da.Fill(ds, "Users");

                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    userId = int.Parse(row[0].ToString());
                    myCon.Close();
                    return userId;
                }
                else
                    return 0;
            }
        }

        [WebMethod]
        public string[] ShowUser(int id)
        {
            myCon.ConnectionString = "Data Source=DESKTOP-C5G2Q55;Initial Catalog=\"D:\\SCHOOL BOOKS\\AN III SEMESTRU II\\INDUSTRIAL INFORMATICS\\LAB\\PROJECTACCESA\\QUESTWEBAPP\\QUESTWEBAPP\\APP_DATA\\QUESTBRINGER.MDF\";Integrated Security=True";
            string[] user;//username,tokens,badges
            bool find = true; //change find after successful select
            var procedure = string.Format("Select *,RANK() OVER(ORDER BY Badges * 20 + Tokens  DESC) 'Player_Rank ' From Users Where Id  = {0}", id);
            DataSet ds = new DataSet();
            myCon.Open();
            using (myCon)
            {
                SqlDataAdapter da = new SqlDataAdapter(procedure, myCon);
                da.Fill(ds, "Users");
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                user = new string[row.ItemArray.Length];
                for (int i = 0; i < row.ItemArray.Length ; i++)
                {
                    user[i] = row[i].ToString();
                }

            }
            myCon.Close();
            if (find)
            {
                return user;
            }
            else return null;

        }

        [WebMethod]
        public string[] ShowLeaderboard()
        {
   
            string[] rankings;
            myCon.ConnectionString = "Data Source=DESKTOP-C5G2Q55;Initial Catalog=\"D:\\SCHOOL BOOKS\\AN III SEMESTRU II\\INDUSTRIAL INFORMATICS\\LAB\\PROJECTACCESA\\QUESTWEBAPP\\QUESTWEBAPP\\APP_DATA\\QUESTBRINGER.MDF\";Integrated Security=True";
            var procedure = string.Format("Select Username, Badges, Tokens, RANK() OVER(ORDER BY Badges * 20 + Tokens  DESC) 'Player_Rank ' from Users   ");
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

                    for (int j = 0; j < row.ItemArray.Length ; j++)
                    {
                        temp[j] = row[j].ToString();

                    }
                    rankings[i] = string.Join(" ;", temp);
                    i++;
                }
            }
            return rankings ;
        }

        [WebMethod]
        public string[] ShowQuestBoard()
        {
            string[] quests ;
            myCon.ConnectionString = "Data Source=DESKTOP-C5G2Q55;Initial Catalog=\"D:\\SCHOOL BOOKS\\AN III SEMESTRU II\\INDUSTRIAL INFORMATICS\\LAB\\PROJECTACCESA\\QUESTWEBAPP\\QUESTWEBAPP\\APP_DATA\\QUESTBRINGER.MDF\";Integrated Security=True";
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
                    quests[i] = string.Join(" ;", temp);
                    i++;
                }
                
            }
            return quests;
        }

        [WebMethod]
        public void AcceptQuest(int id)
        {
            myCon.ConnectionString = "Data Source=DESKTOP-C5G2Q55;Initial Catalog=\"D:\\SCHOOL BOOKS\\AN III SEMESTRU II\\INDUSTRIAL INFORMATICS\\LAB\\PROJECTACCESA\\QUESTWEBAPP\\QUESTWEBAPP\\APP_DATA\\QUESTBRINGER.MDF\";Integrated Security=True";
            var procedure = string.Format("DELETE FROM QUESTS WHERE Id = {0}",id);

            using (myCon)
            {
                try
                {
                    SqlCommand command = new SqlCommand(procedure, myCon);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            myCon.Close();
        }


        [WebMethod]  //Both AcceptQuest and Reward are called one after the other
        public void Reward(int id, int tokens,int badges)
        {
            myCon.ConnectionString = "Data Source=DESKTOP-C5G2Q55;Initial Catalog=\"D:\\SCHOOL BOOKS\\AN III SEMESTRU II\\INDUSTRIAL INFORMATICS\\LAB\\PROJECTACCESA\\QUESTWEBAPP\\QUESTWEBAPP\\APP_DATA\\QUESTBRINGER.MDF\";Integrated Security=True";
            var procedure = string.Format("Update  Users SET Tokens=(Tokens+{1}), Badges=(Badges+{2})  WHERE Id = {0}", id,tokens,badges);

            using (myCon)
            {
                try
                {
                    SqlCommand command = new SqlCommand(procedure, myCon);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            myCon.Close();
        }


    }
}
