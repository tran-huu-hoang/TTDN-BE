namespace Lab04.Models
{
    public class DataLocal
    {
        public static List<People> peoples = new List<People>()
        {
            new People()
            {
                Id = 1,
                Name = "Zhongli",
                Email = "zhongli@gmail.com",
                Phone = "0123456789",
                Address = "Liyue",
                Avatar = "images/anh1.png",
                Birthday = Convert.ToDateTime("2003/07/14"),
                Bio = "DevMaster",
                Gender = 0,
            },
            new People()
            {
                Id = 2,
                Name = "Ganyu",
                Email = "ganyu@gmail.com",
                Phone = "0123456789",
                Address = "Liyue",
                Avatar = "images/anh2.png",
                Birthday = Convert.ToDateTime("2003/07/14"),
                Bio = "DevMaster",
                Gender = 1,
            },
            new People()
            {
                Id = 3,
                Name = "Lisa",
                Email = "lisa@gmail.com",
                Phone = "0123456789",
                Address = "Mondstadt",
                Avatar = "images/anh3.png",
                Birthday = Convert.ToDateTime("2003/07/14"),
                Bio = "DevMaster",
                Gender = 1,
            },
            new People()
            {
                Id = 4,
                Name = "Jean",
                Email = "jean@gmail.com",
                Phone = "0123456789",
                Address = "Mondstadt",
                Avatar = "images/anh4.png",
                Birthday = Convert.ToDateTime("2003/07/14"),
                Bio = "DevMaster",
                Gender = 1,
            },
            new People()
            {
                Id = 5,
                Name = "Ninguang",
                Email = "ninguang@gmail.com",
                Phone = "0123456789",
                Address = "Liyue",
                Avatar = "images/anh5.png",
                Birthday = Convert.ToDateTime("2003/07/14"),
                Bio = "DevMaster",
                Gender = 1,
            },
            new People()
            {
                Id = 6,
                Name = "Xiao",
                Email = "xiao@gmail.com",
                Phone = "0123456789",
                Address = "Liyue",
                Avatar = "images/anh6.png",
                Birthday = Convert.ToDateTime("2003/07/14"),
                Bio = "DevMaster",
                Gender = 0,
            },
        };

        public static List<People> GetPeoples()
        {
            return peoples;
        }

        public static People GetPeoplesById(int id)
        {
            return peoples.FirstOrDefault(x => x.Id == id);
        }
    }
}
