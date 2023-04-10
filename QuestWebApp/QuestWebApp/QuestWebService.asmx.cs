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
        myCon.ConnectionString= @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =D:\SCHOOL BOOKS\AN III SEMESTRU II\INDUSTRIAL INFORMATICS\LAB\PROJECTACCESSA\QUESTWEBAPP\QUESTWEBAPP\APP_DATA\QUESTBRINGER.MDF; Integrated Security = True";
     //   myCon.Open(); 
        [WebMethod]
        public void AddQuest(string Title, string Description, int Tokens, int Badges, int CreatorId)
        {
            // Insert Into Quests Values( , , , , );
        }

        [WebMethod]
        public void AddUser(string Username,string Password, int Tokens, int Badges )
        {
           // Insert Into Users Values( , , , );
        }


        [WebMethod]
        public string[] ShowQuest(int id)
        {
            
            string[] quest= { "", "","","","" };//title,desc,tokens,badges, creator
              //Select Quests.Id, Title,Description,Quests.Tokens,Quests.Badges, Username  From Quests Join Users ON Quests.CreatorId = Users.Id WHERE  Quests.Id = id
            new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            return quest;
        }

        [WebMethod]
        public string[] ShowUser(int id)
        {
            string[] user = { "", "", ""};//username,tokens,badges
            bool find=false; //change find after successful select

            // Select Username From Users Where Id = (Select CreatorId From Quest Where Id = 1) //verified
            if (find)
            {
                return user;
            }
            else return null;
            
        }

        [WebMethod]
        public string[] ShowLeaderboard()
        {
        
            string[] rankings= { };
            //Select Username,Badges,Tokens, RANK() OVER(      ORDER BY Badges * 20 + Tokens DESC ) Rank from Users
            return rankings ;
        }

        [WebMethod]
        public string[] ShowQuestBoard()
        {
            //Select * from Quests
            string[] quests= { };
            return quests;
        }

        [WebMethod]
        public void AcceptQuest(int id)
        {
            //DELETE FROM QUESTS WHERE Quests.Id = id;
        }
    }
}
