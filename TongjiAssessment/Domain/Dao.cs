using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Domain
{
    public static class Dao
    {
        private static string connectionString = "User Id=c##tongji;Password=123456;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl)))";
       
        //获取课程信息
        public static List<Course> getCourseList()
        {
            List<Course> list = new List<Course>();
            OracleConnection conn = new OracleConnection(connectionString);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from course";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Course
                    {
                        //Course_id = reader.GetString(0),
                        //Title = reader.GetString(1),
                        //Dept_name = reader.GetString(2),
                        //Credits = Convert.ToString(reader.GetDouble(3)),
                        //Category = reader.GetString(4)
                    });

                }

            }
            catch(Exception e)
            {
                Console.Write("eeeeeeee" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            
            
            return list;
        }

        //获取课程详细信息
        public static CourseDetail getCourseDetail(string course_id, string inst_id)
        {
            CourseDetail course = new CourseDetail();
            OracleConnection conn = new OracleConnection(connectionString);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from instructor";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                }

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return course;

        }
        //获取老师信息
        public static List<Instructor> getInstructorList()
        {
            List<Instructor> list = new List<Instructor>();
            OracleConnection conn = new OracleConnection(connectionString);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from instructor";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Instructor
                    {
                        //Id = reader.GetString(0),
                        //Name = reader.GetString(1),
                        //Dept_name = reader.GetString(2),
                        //Email = reader.GetString(3),
                        //Introduction = reader.GetString(4),
                        //Homepage = reader.GetString(5),
                        //Image = reader.GetString(6),
                    });

                }

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                conn.Close();
            }
            
            return list;

        }
        //获取评论记录信息
        public static List<Comment> getCommentRecordList()
        {
            List<Comment> list = new List<Comment>();
            OracleConnection conn = new OracleConnection(connectionString);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select MY_USER.USER_ID, MY_USER.NAME, COURSE.TITLE, MY_COMMENT.CONTENT, INSTRUCTOR.NAME, MY_DATE, MY_USER.IMAGE, RATE from SECTION NATURAL join TEACH NATURAL join INSTRUCTOR NATURAL JOIN MY_COMMENT NATURAL join course , MY_USER WHERE MY_USER.USER_ID = MY_COMMENT.USER_ID";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Comment
                    {
                       
                    });
                    
                }

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return list;

        }
        //获取老师信息
        public static List<Post> getPostList()
        {
            List<Post> list = new List<Post>();
            OracleConnection conn = new OracleConnection(connectionString);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select POST.USER_ID, MY_USER.name, POST.TITLE, POST.CONTENT, POST.TYPE, POST.MY_DATE, MY_USER.image , count(*) as sopport " +
                                   "from POST, MY_USER, POST_SUPPORT "+
                                    "WHERE POST.POST_ID = POST_SUPPORT.POST_Id and POST.USER_ID = MY_USER.USER_ID "+
                                    "GROUP BY (POST.USER_ID, POST.POST_ID, name, TITLE, CONTENT, TYPE,POST.MY_DATE, MY_user.image) ";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Post
                    {
                        
                    });

                }

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return list;

        }
        public static List<string> getCategoryList()
        {
            List<string> categories = new List<string>();
            OracleConnection conn = new OracleConnection(connectionString);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select dept_name from department";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(reader.GetString(0));

                }

            }
            catch (Exception e)
            {
                Console.Write("eeeeeeee" + e.Message);
            }
            finally
            {
                conn.Close();
            }


            return categories;
        }
        //获取楼层信息
        public static List<Floor> getFloorList()
        {
            List<Floor> list = new List<Floor>();
            OracleConnection conn = new OracleConnection(connectionString);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from course";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Floor
                    {
                        
                    });

                }

            }
            catch (Exception e)
            {
                Console.Write("eeeeeeee" + e.Message);
            }
            finally
            {
                conn.Close();
            }


            return list;
        }

        //添加用户
        public static void addTongjiUser(Tongji_user tongji_user)
        {

        }
        //添加评论
        public static void addComment(Comment comment)
        {

        }
        //添加post
        public static void addPost(Post post)
        {

        }
        //添加floor
        public static void addFloor(Floor floor)
        {

        }
        //点赞/踩课程
        public static void addSupportCourse(string username, string course_id, string ins_id, bool rec_course) 
        {

        }
        //点赞帖子
        public static void addSupportPost(string username, string post_id)
        {

        }
        //取消点赞
        public static void deleteSupportPost(string username, string post_id)
        {

        }
        //关注课程
        public static void addFollowCourse(string username, string course_id, string ins_id)
        {

        }
        //关注用户
        public static void addFollowTongjiUser(string username, string follow_user)
        {

        }
        //取消关注课程
        public static void deleteFollowCourse(string username, string course_id, string ins_id)
        {

        }
        //取消关注用户
        public static void deleteFollowTongjiUser(string username, string follow_user)
        {

        }

    }
}