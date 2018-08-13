using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SlimApi2.Models;
using System.Data;
namespace SlimApi2.Controllers
{
    public class LoginController : ApiController
    {
        //slims1Entities1 context = new slims1Entities1();
        // GET api/login
//        public IEnumerable<Users> Get(string UserLoginId, string Password)
//        {
//            List<Users> list = new List<Users>();
//            try
//            {
//                string OldKey = new GetUpdateFile().getkey();
//                List<UserLogin> Userlist = new List<UserLogin>();
//                //Userlist = context.AppLogin(UserLoginId, Password, OldKey).Select
//                //(w => new UserLogin
//                //{

//                //}).ToList();
//                //if (Userlist.Count>0)
//                //{ 
//                //update DeviceId,DeviceType


//                string UserRole = "";
//                string UserTypeId = "";
//                DataTable dtrole = new Login().GetRole(UserLoginId, Password);
//                if (dtrole.Rows.Count > 0)
//                {
//                    UserRole = Convert.ToString(dtrole.Rows[0]["Role"]);

//                }
//                string GeneralFeedback = "False";
//                string UserFeedback = "False";
//                string FormDateId = "";
//                string DateAction = "";
//                //SendFeedBack
//                DataTable feedbackdt = new Login().SendFeedBack(UserLoginId, Password, OldKey);
//                if (feedbackdt.Rows.Count > 0)
//                {
//                    FormDateId = Convert.ToString(feedbackdt.Rows[0]["FormDateId"]);
//                    DateAction = Convert.ToString(feedbackdt.Rows[0]["DateAction"]);
//                    GeneralFeedback = Convert.ToString(feedbackdt.Rows[0]["GeneralFeedback"]);
//                    if (feedbackdt.Rows.Count >= 2)
//                    {
//                        GeneralFeedback = Convert.ToString(feedbackdt.Rows[1]["GeneralFeedback"]);
//                    }
//                    if (!string.IsNullOrWhiteSpace(Convert.ToString(feedbackdt.Rows[0]["UserFeedback"])))
//                    {
//                        UserFeedback = Convert.ToString(feedbackdt.Rows[0]["UserFeedback"]);
//                    }
//                    else
//                    {
//                        UserFeedback = "False";
//                    }

//                }
//                List<ReadingTest> ListReadingTest = new List<ReadingTest>();
//                //list = context.AppLogin(UserLoginId, Password, OldKey)
//                list = AppLogin(UserLoginId, Password, OldKey)
//                           .Select
//                           (
//                           w => new Users
//                           {
//                               Name = w.Name,
//                               FatherName = w.FatherName,
//                               RollNo = w.RollNo,
//                               Role = UserRole,
//                               Token = w.Token,
//                               message = "Valid",
//                               resultmsg = "True",
//                               ImageUrl = w.ImageUrl,
//                               EmailId = w.EmailId,
//                               DateofBirth = w.DateofBirth,
//                               MobileNo = w.MobileNo,
//                               UserLoginId = w.UserLoginId,
//                               UserId = w.UserId,
//                               TimeDuration = w.TimeDuration,
//                               UserTypeId = w.UserTypeId,
//                               FormDateId = FormDateId,
//                               ActionDate = DateAction,
//                               GeneralFeedback = GeneralFeedback,
//                               UserFeedback = UserFeedback,
//                               ChangePasswordOnLogin = w.ChangePasswordOnLogin,
//                               feedbackquestion = FeedbackQuestion(),
//                               IsTESOLMaintenanceAndroid = w.IsTESOLMaintenanceAndroid
//                               //Name = w.u.FirstName + " " + (w.u.MiddleName ?? "") + " " + (w.u.LastName ?? ""),
//                               //FatherName = w.u.FatherName,
//                               //RollNo = w.u.RollNo,
//                               //Token = (Guid)w.u.Token,
//                               //message = "Valid",
//                               //resultmsg = "True",
//                               //ImageUrl = "http://203.193.166.113/slims/upload/" + w.u.imagepath,
//                               //EmailId = w.u.EmailId1,
//                               //DateofBirth = w.u.DateofBirth,
//                               //MobileNo = w.u.PrimaryMobile,
//                               //UserLoginId = Userlist[0].UserLoginId,
//                               //UserId = w.u.HrUserId,
//                               //TimeDuration = 11

//                               ,
//                               UserCourse = GetCourse(w.UserId.ToString())
//                                //UserCourse = (from UserClass in context.Trn_Hrm_UserClass
//                                //              join Class in context.Mst_Hrm_Class
//                                //              on UserClass.ClassId equals Class.ClassId
//                                //              join ModuleLevelCentre in context.Trn_Hrm_ModuleLevelCentre
//                                //              on Class.ModuleLevelCentreId equals ModuleLevelCentre.ModuleLevelCentreId
//                                //              join ModuleLevel in context.Mst_Hrm_ModuleLevel
//                                //              on ModuleLevelCentre.ModuleLevelId equals ModuleLevel.ModuleLevelId
//                                //              join Mastercourse in context.Mst_Aca_MasterCourse
//                                //              on ModuleLevel.MasterCourseId equals Mastercourse.MasterCourseId
//                                //              join Centre in context.Mst_Hrm_Centre
//                                //              on ModuleLevelCentre.CentreId equals Centre.CentreId
//                                //              join CentreHead in context.Mst_Hrm_CentreHead
//                                //              on Centre.CentreHeadId equals CentreHead.CentreHeadId
//                                //              where UserClass.UserId == w.UserId && UserClass.UserClassId == (from newclass in context.Trn_Hrm_UserClass
//                                //                                                                                  where newclass.UserId == UserClass.UserId
//                                //                                                                                  select newclass.UserClassId).Max()
//                                //              select new Course
//                                //              {
//                                //                  CourseId = Mastercourse.MasterCourseId,
//                                //                  CourseDesc = Mastercourse.Description,
//                                //                  Centre = CentreHead.Description,
//                                //                  Campus = Centre.Description,
//                                //                  ModuleLevel = ModuleLevel.Description,
//                                //                  Class = Class.Description
//                                //              ,
//                                //                  UserTestType = (from UserTestType in context.Mst_Aca_TestType
//                                //                                  join UserCourseTestType in context.Trn_Aca_CourseTestType
//                                //                                  on UserTestType.TestTypeId equals UserCourseTestType.TestTypeId
//                                //                                  where UserCourseTestType.MasterCourseId == Mastercourse.MasterCourseId
//                                //                                  select new TestType
//                                //                                  {
//                                //                                      TestTypeId = UserTestType.TestTypeId,
//                                //                                      TestTypeDesc = UserTestType.Description,

//                                //                                      UserReadingTest = GetReadingTest("1", DateTime.Now.ToString("yyyy/MM/dd"), Convert.ToString(w.UserId), "1")
//                                //                                      .Select(r => new ReadingTest()
//                                //                                      {
//                                //                                          ReadingTestId = r.ReadingTestId,
//                                //                                          ReadingTestdesc = r.ReadingTestdesc
//                                //                                      }),
//                                //                                      //UserReadingTest = (from CourseCalender in context.Mst_Aca_CourseCalender
//                                //                                      //                   join TestSet in context.Mst_Aca_TestSet
//                                //                                      //                   on CourseCalender.CycleId equals TestSet.TestSetId
//                                //                                      //                   join Test in context.Mst_Aca_Test
//                                //                                      //                   on TestSet.ReadingTestId equals Test.TestId
//                                //                                      //                   where Test.TestTypeId == UserTestType.TestTypeId & TestSet.MasterCourseId == Mastercourse.MasterCourseId & CourseCalender.CycleDate == System.Data.Objects.EntityFunctions.AddHours(DateTime.Today, (Int32?) -14)   & TestSet.TestCategoryId==1 & CourseCalender.ClassId==UserClass.ClassId
//                                //                                      //                   select new ReadingTest
//                                //                                      //                   {
//                                //                                      //                       ReadingTestId = Test.TestId,
//                                //                                      //                       ReadingTestdesc = Test.Description
//                                //                                      //                   }),
//                                //                                      UserWritingTest = (from CourseCalender in context.Mst_Aca_CourseCalender
//                                //                                                         join TestSet in context.Mst_Aca_TestSet
//                                //                                                         on CourseCalender.CycleId equals TestSet.TestSetId
//                                //                                                         join Test in context.Mst_Aca_Test
//                                //                                                         on TestSet.WritingTestId equals Test.TestId
//                                //                                                         where Test.TestTypeId == UserTestType.TestTypeId & TestSet.MasterCourseId == Mastercourse.MasterCourseId  & TestSet.TestCategoryId == 1 & CourseCalender.ClassId == UserClass.ClassId
//                                //                                                         // & CourseCalender.CycleDate <=DateTime.Today
//                                //                                                             & CourseCalender.CycleDate ==
//                                //                                                           (from newcycle in context.Mst_Aca_CourseCalender
//                                //                                                            join newTestSet in context.Mst_Aca_TestSet
//                                //                                                         on newcycle.CycleId equals newTestSet.TestSetId
//                                //                                                            where CourseCalender.ClassId == newcycle.ClassId
//                                //                                                            & newcycle.CycleDate <= DateTime.Today
//                                //                                                            & newcycle.CycleId != 0
//                                //                                                            & newTestSet.WritingTestId != 0
//                                //                                                          & newTestSet.TestCategoryId == 1
//                                //                                                            select newcycle.CycleDate).Max()
//                                //                                                         select new WritingTest
//                                //                                                         {
//                                //                                                             WritingTestId = Test.TestId,
//                                //                                                             WritingTestdesc = Test.Description
//                                //                                                         }),
//                                //                                      UserSpeakingTest = (from CourseCalender in context.Mst_Aca_CourseCalender
//                                //                                                          join TestSet in context.Mst_Aca_TestSet
//                                //                                                          on CourseCalender.CycleId equals TestSet.TestSetId
//                                //                                                          join Test in context.Mst_Aca_Test
//                                //                                                          on TestSet.SpeakingTestId equals Test.TestId
//                                //                                                          where Test.TestTypeId == UserTestType.TestTypeId & TestSet.MasterCourseId == Mastercourse.MasterCourseId & TestSet.TestCategoryId == 1 & CourseCalender.ClassId == UserClass.ClassId
//                                //                                                            & CourseCalender.CycleDate ==
//                                //                                                           (from newcycle in context.Mst_Aca_CourseCalender
//                                //                                                            join newTestSet in context.Mst_Aca_TestSet
//                                //                                                         on newcycle.CycleId equals newTestSet.TestSetId
//                                //                                                            where CourseCalender.ClassId == newcycle.ClassId
//                                //                                                            & newcycle.CycleDate <= DateTime.Today
//                                //                                                            & newcycle.CycleId != 0
//                                //                                                            & newTestSet.SpeakingTestId != 0
//                                //                                                          & newTestSet.TestCategoryId == 1
//                                //                                                            select newcycle.CycleDate).Max()
//                                //                                                          select new SpeakingTest
//                                //                                                          {
//                                //                                                              SpeakingTestId = Test.TestId,
//                                //                                                              SpeakingTestdesc = Test.Description
//                                //                                                          }),
//                                //                                      UserListeningTest = (from CourseCalender in context.Mst_Aca_CourseCalender
//                                //                                                           join TestSet in context.Mst_Aca_TestSet
//                                //                                                           on CourseCalender.CycleId equals TestSet.TestSetId
//                                //                                                           join Test in context.Mst_Aca_Test
//                                //                                                           on TestSet.ListeningTestId equals Test.TestId
//                                //                                                           where Test.TestTypeId == UserTestType.TestTypeId & TestSet.MasterCourseId == Mastercourse.MasterCourseId & TestSet.TestCategoryId == 1 & CourseCalender.ClassId == UserClass.ClassId
//                                //                                                           & CourseCalender.CycleDate ==
//                                //                                                           (from newcycle in context.Mst_Aca_CourseCalender
//                                //                                                            join newTestSet in context.Mst_Aca_TestSet
//                                //                                                         on newcycle.CycleId equals newTestSet.TestSetId
//                                //                                                            where CourseCalender.ClassId == newcycle.ClassId
//                                //                                                            & newcycle.CycleDate <= DateTime.Today
//                                //                                                            & newcycle.CycleId != 0
//                                //                                                            & newTestSet.ListeningTestId != 0
//                                //                                                          & newTestSet.TestCategoryId == 1
//                                //                                                            select newcycle.CycleDate).Max()
//                                //                                                           select new ListeningTest
//                                //                                                           {
//                                //                                                               ListeningTestId = Test.TestId,
//                                //                                                               ListeningTestdesc = Test.Description
//                                //                                                           })
//                                //                                  })
//                                //              })


//                            }
//                           ).ToList();


//                //update DeviceId and DeviceType



//                if (!list.Any())
//                {
//                    list.Add(new Users { message = "Invalid User Id and Password. Please contact admin", Token = "", resultmsg = "false" });
//                }
//            }

//            catch { }
//            finally { }

//            return list;
//        }
//        //GetCourse
//        public IEnumerable<Course> GetCourse(string UserId)
//        {
//            List<Course> ListCourse = new List<Course>();
//            string query = " select UserClass.UserId,Mastercourse.MasterCourseId,Mastercourse.Description as Mastercourse,CentreHead.Description as CentreHead,Centre.Description as Centre,ModuleLevel.Description as ModuleLevel,Class.Description as class "
//+ " ,TestType.TestTypeId,TestType.Description as TestType from  Trn_Hrm_UserClass UserClass "
//+ " inner  join  Mst_Hrm_Class Class on UserClass.ClassId = Class.ClassId "
// + " inner join Trn_Hrm_ModuleLevelCentre ModuleLevelCentre on Class.ModuleLevelCentreId = ModuleLevelCentre.ModuleLevelCentreId "
//+ " inner join Mst_Hrm_ModuleLevel ModuleLevel on ModuleLevelCentre.ModuleLevelId = ModuleLevel.ModuleLevelId "
//+ " inner join Mst_Aca_MasterCourse Mastercourse on ModuleLevel.MasterCourseId = Mastercourse.MasterCourseId "
//+ " inner join Mst_Hrm_Centre Centre on ModuleLevelCentre.CentreId = Centre.CentreId "
//+ " inner join Mst_Hrm_CentreHead CentreHead on Centre.CentreHeadId = CentreHead.CentreHeadId "
//+ " left join Trn_Aca_CourseTestType CourseTestType on Mastercourse.MasterCourseId=CourseTestType.MasterCourseId "
//+ " left join Mst_Aca_TestType TestType on CourseTestType.TestTypeId=TestType.TestTypeId  "
//+ " where UserClass.UserId =   " + UserId
//+ " and UserClass.UserClassId = (select Top 1 UserClassId from Trn_Hrm_UserClass newclass "
//+ " where newclass.UserId = UserClass.UserId order by EndDate desc,date desc)";
//            DataTable dt2 = new Login().gettable(query);
//            try
//            {

//                if (dt2.Rows.Count > 0)
//                {
//                    foreach (System.Data.DataRow dr in dt2.Rows)
//                    {
//                        ListCourse.Add(new Course()
//                        {
//                            CourseId = Convert.ToInt32(dr["MasterCourseId"]),
//                            CourseDesc = Convert.ToString(dr["MasterCourse"]),
//                            Centre = Convert.ToString(dr["CentreHead"]),
//                            Campus = Convert.ToString(dr["Centre"]),
//                            ModuleLevel = Convert.ToString(dr["Modulelevel"]),
//                            Class = Convert.ToString(dr["Class"]),
//                            UserTestType = GetTestType(ref dt2)

//                        });
//                        break;
//                    }
//                }



//            }
//            catch { }
//            finally { }
//            return ListCourse;
//        }

//        //ReadingTest
//        public IEnumerable<TestType> GetTestType(ref DataTable dt2)
//        {
//            List<TestType> ListTestType = new List<TestType>();

//            try
//            {
//                if (dt2.Rows.Count > 0)
//                {
//                    foreach (System.Data.DataRow dr in dt2.Rows)
//                    {
//                        ListTestType.Add(new TestType()
//                        {
//                            TestTypeId = Convert.ToInt32(dr["TestTypeId"]),
//                            TestTypeDesc = Convert.ToString(dr["TestType"]),
//                            UserReadingTest = GetReadingTest(Convert.ToString(dr["TestTypeId"]), new timezone().getcurrentdate().ToString("yyyy/MM/dd"), Convert.ToString(dr["UserId"]), "1")
//                            ,
//                            UserWritingTest = GetWritingTest(Convert.ToString(dr["TestTypeId"]), new timezone().getcurrentdate().ToString("yyyy/MM/dd"), Convert.ToString(dr["UserId"]), "1")
//                           ,
//                            UserSpeakingTest = GetSpeakingTest(Convert.ToString(dr["TestTypeId"]), new timezone().getcurrentdate().ToString("yyyy/MM/dd"), Convert.ToString(dr["UserId"]), "1")
//                           ,
//                            UserListeningTest = GetListeningTest(Convert.ToString(dr["TestTypeId"]), new timezone().getcurrentdate().ToString("yyyy/MM/dd"), Convert.ToString(dr["UserId"]), "1")

//                        });
//                    }
//                }

//            }
//            catch { }
//            finally { }
//            return ListTestType;
//        }

//        //ReadingTest
//        public IEnumerable<ReadingTest> GetReadingTest(string TestTypeId, string Date, string UserId, string TestCategoryId)
//        {
//            List<ReadingTest> ListReadingTest = new List<ReadingTest>();
//            if (TestTypeId == "1")
//            {
//                DataTable dt2 = new Login().GetReadingTest(TestTypeId, Date, UserId, TestCategoryId);
//                try
//                {
//                    if (dt2.Rows.Count > 0)
//                    {
//                        foreach (System.Data.DataRow dr in dt2.Rows)
//                        {
//                            ListReadingTest.Add(new ReadingTest()
//                            {
//                                ReadingTestId = Convert.ToInt32(dr["TestId"]),
//                                ReadingTestdesc = dr["Description"].ToString()

//                            });
//                        }
//                    }



//                }
//                catch { }
//                finally { }
//            }
//            return ListReadingTest;
//        }

//        //WritingTest
//        public IEnumerable<WritingTest> GetWritingTest(string TestTypeId, string Date, string UserId, string TestCategoryId)
//        {
//            List<WritingTest> ListWritingTest = new List<WritingTest>();

//            if (TestTypeId == "2")
//            {
//                DataTable dt2 = new Login().GetReadingTest(TestTypeId, Date, UserId, TestCategoryId);
//                try
//                {
//                    if (dt2.Rows.Count > 0)
//                    {
//                        foreach (System.Data.DataRow dr in dt2.Rows)
//                        {
//                            ListWritingTest.Add(new WritingTest()
//                            {
//                                WritingTestId = Convert.ToInt32(dr["TestId"]),
//                                WritingTestdesc = dr["Description"].ToString()

//                            });
//                        }
//                    }



//                }
//                catch { }
//                finally { }
//            }
//            return ListWritingTest;
//        }

//        //SpeakingTest
//        public IEnumerable<SpeakingTest> GetSpeakingTest(string TestTypeId, string Date, string UserId, string TestCategoryId)
//        {
//            List<SpeakingTest> ListSpeakingTest = new List<SpeakingTest>();

//            if (TestTypeId == "3")
//            {
//                DataTable dt2 = new Login().GetReadingTest(TestTypeId, Date, UserId, TestCategoryId);
//                try
//                {
//                    if (dt2.Rows.Count > 0)
//                    {
//                        foreach (System.Data.DataRow dr in dt2.Rows)
//                        {
//                            ListSpeakingTest.Add(new SpeakingTest()
//                            {
//                                SpeakingTestId = Convert.ToInt32(dr["TestId"]),
//                                SpeakingTestdesc = dr["Description"].ToString()

//                            });
//                        }
//                    }



//                }
//                catch { }
//                finally { }
//            }
//            return ListSpeakingTest;
//        }

//        //Listening
//        public IEnumerable<ListeningTest> GetListeningTest(string TestTypeId, string Date, string UserId, string TestCategoryId)
//        {
//            List<ListeningTest> ListListeningTest = new List<ListeningTest>();

//            if (TestTypeId == "4")
//            {
//                DataTable dt2 = new Login().GetReadingTest(TestTypeId, Date, UserId, TestCategoryId);
//                try
//                {
//                    if (dt2.Rows.Count > 0)
//                    {
//                        foreach (System.Data.DataRow dr in dt2.Rows)
//                        {
//                            ListListeningTest.Add(new ListeningTest()
//                            {
//                                ListeningTestId = Convert.ToInt32(dr["TestId"]),
//                                ListeningTestdesc = dr["Description"].ToString()

//                            });
//                        }
//                    }



//                }
//                catch { }
//                finally { }
//            }
//            return ListListeningTest;
//        }
//        //Feedback
//        public IEnumerable<FeedbackQuestion> FeedbackQuestion()
//        {
//            List<FeedbackQuestion> feedbackquestion = new List<FeedbackQuestion>();
//            try
//            {
//                DataTable dt3 = GetFeedbackQuestions();

//                if (dt3.Rows.Count > 0)
//                {
//                    foreach (System.Data.DataRow dr in dt3.Rows)
//                    {
//                        feedbackquestion.Add(new FeedbackQuestion()
//                        {
//                            QuestionId = Convert.ToString(dr["QuestionId"]),
//                            QuestionDescription = dr["Description"].ToString(),
//                            feedbackoption = GetFeedbackOption()
//                        });
//                    }
//                }


//            }
//            catch { }
//            finally { }
//            return feedbackquestion;
//        }
//        public IEnumerable<Feedbackoption> GetFeedbackOption()
//        {
//            List<Feedbackoption> feedbackoption = new List<Feedbackoption>();
//            DataTable dt2 = GetFeedbackOptions();
//            try
//            {
//                if (dt2.Rows.Count > 0)
//                {
//                    foreach (System.Data.DataRow dr in dt2.Rows)
//                    {
//                        feedbackoption.Add(new Feedbackoption()
//                        {
//                            OptionId = Convert.ToString(dr["OptionId"]),
//                            OptionDescription = dr["Description"].ToString()

//                        });
//                    }
//                }



//            }
//            catch { }
//            finally { }
//            return feedbackoption;
//        }
//        private DataTable GetFeedbackOptions()
//        {
//            string query = " select * from Mst_Fbk_Feedbackoptions where Active=1  ";
//            DataTable dt = new DataTable();
//            dt = new Login().gettable(query);

//            return dt;
//        }


//        private DataTable GetFeedbackQuestions()
//        {
//            string query = " select * from Mst_Fbk_Question where Active=1  ";
//            DataTable dt = new DataTable();
//            dt = new Login().gettable(query);
//            return dt;
//        }



//        public IEnumerable<Users> AppLogin(string UserLoginId, string Password, string key)
//        {
//            List<Users> list = new List<Users>();

//            System.Data.DataTable dt = new Login().AppLogin(UserLoginId, Password, key);
//            if (dt.Rows.Count > 0)
//            {
//                foreach (System.Data.DataRow dr in dt.Rows)
//                {
//                    list.Add(new Users()
//                    {
//                        Name = dr["Name"].ToString(),
//                        FatherName = dr["FatherName"].ToString(),
//                        RollNo = dr["RollNo"].ToString(),
//                        //Role = dr["Role"].ToString(),
//                        Token = dr["Token"].ToString(),
//                        message = "Valid",
//                        resultmsg = "True",
//                        ImageUrl = dr["imagepath"].ToString(),
//                        EmailId = dr["EmailId1"].ToString(),
//                        DateofBirth = dr["DateofBirth"].ToString(),
//                        MobileNo = dr["PrimaryMobile"].ToString(),
//                        UserLoginId = dr["UserLoginId"].ToString(),
//                        UserId = Convert.ToInt32(dr["HrUserId"].ToString()),
//                        TimeDuration = dr["TimeDuration"].ToString(),
//                        UserTypeId = dr["UserTypeId"].ToString(),
//                        ChangePasswordOnLogin = dr["ChangePasswordOnLogin"].ToString(),
//                        IsTESOLMaintenanceAndroid = Convert.ToBoolean(dr["IsTESOLMaintenanceAndroid"])
//                    });
//                }
//            }
//            return list.ToList();
//        }


//        public string GetAddDevice(string UserLoginId, string Password, string DeviceId, string DevicePlatform)
//        {
//            string msg = "";
//            if (!string.IsNullOrWhiteSpace(UserLoginId) & !string.IsNullOrWhiteSpace(DeviceId) & !string.IsNullOrWhiteSpace(DevicePlatform))
//            {
//                msg = new Login().UpdateDevice(UserLoginId, Password, DeviceId, DevicePlatform);
//            }
//            return msg;
//        }
        // GET api/login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/login
        public void Post([FromBody]string value)
        {
        }

        // PUT api/login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/login/5
        public void Delete(int id)
        {
        }
    }
}
